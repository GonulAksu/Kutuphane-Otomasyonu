using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu1
{
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }
        bool secim;
        int secimID;
        Baglanti baglan = new Baglanti();


        public static int fakulteID;
        public static string fakulteAd;
        public static bool fakulteSecim = false;


        public void temizle()
        {
            txtBolumAd.Text = "";
            lbsSecim.Text = "";
            secim = false;
            dataGVeri.ClearSelection();
            btnEkleGuncelle.Text = "Ekle";
            btnFakulteSec.BackColor = Color.FromArgb(255, 77, 77);
            btnSil.BackColor = Color.FromArgb(255, 77, 77);
            dataGVeri.ClearSelection();
        }
        public void VeriYenile()
        {

            dataGVeri.DataSource = baglan.DataTableGetir("SELECT  bolumler.bolumKodu,bolumler.bolumAd,fakulte.fakulteAd,bolumler.bolumFakulteID FROM bolumler INNER JOIN fakulte ON  bolumler.bolumFakulteID = fakulte.fakulteID ");
            dataGVeri.Columns[0].Visible = false;
            dataGVeri.Columns[1].HeaderText = "Bolum Adı";
            dataGVeri.Columns[1].Width = 220;
            dataGVeri.Columns[2].HeaderText = "Fakülte Adı";
            dataGVeri.Columns[2].Width = 220;
            dataGVeri.Columns[3].Visible = false;
            dataGVeri.AllowUserToAddRows = false;

            temizle();
        }

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFakulteSec_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {

            if (!secim)
            {
                baglan.idu("insert into bolumler(bolumAd,bolumFakulteID) values ('" + txtBolumAd.Text + "','" + fakulteID + "')");
                VeriYenile();
                btnFakulteSec.BackColor = Color.FromArgb(119, 221, 119);
            }
            else
            {

                baglan.idu("update bolumler set bolumAd = '" + txtBolumAd.Text + "',bolumFakulteID='" + fakulteID + "' where bolumKodu = " + secimID + "");
                VeriYenile();
                btnFakulteSec.BackColor = Color.FromArgb(119, 221, 119);

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void txtBolumAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                secimID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);
                txtBolumAd.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                btnEkleGuncelle.Text = "Güncelle";
                secim = true;
                btnFakulteSec.BackColor = Color.FromArgb(119, 221, 119);
                fakulteAd = dataGVeri.CurrentRow.Cells[2].Value.ToString();
                fakulteID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[3].Value);
                lbsSecim.Text = fakulteAd;
                btnSil.BackColor = Color.FromArgb(119, 221, 119);
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz..");
            }
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.idu("delete from bolumler where bolumkodu = " + secimID + "");
                VeriYenile();
            }
            catch (Exception)
            {

                MessageBox.Show("Önce Seçim Yapmalısınız");
            }

        }
    }
}
