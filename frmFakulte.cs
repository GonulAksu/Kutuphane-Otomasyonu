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
    public partial class frmFakulte : Form
    {
        public frmFakulte()
        {
            InitializeComponent();
        }

        Baglanti baglan = new Baglanti();
        int secimID = 1;
        bool secim = false;
        public void VeriYenile()
        {
            dataGVeri.DataSource = baglan.DataTableGetir("select * from fakulte");

            dataGVeri.Columns[0].Visible = false;
            dataGVeri.Columns[1].HeaderText = "Fakülte Adı";
            dataGVeri.Columns[1].Width = 330;
            dataGVeri.AllowUserToAddRows = false;
            txtFakulteAd.Text = "";
            secim = false;
            dataGVeri.ClearSelection();
            btnEkleGuncelle.Text = "Ekle";
        }


        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {

            if (!secim)
            {
                baglan.idu("insert into fakulte(fakulteAd) values ('" + txtFakulteAd.Text + "')");
                VeriYenile();

            }
            else
            {

                baglan.idu("update fakulte set fakulteAd = '" + txtFakulteAd.Text + "' where fakulteID = " + secimID + "");
                VeriYenile();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFakulteAd.Text = "";
            secim = false;
            dataGVeri.ClearSelection();
            btnSil.BackColor = Color.FromArgb(255, 77, 77);
            btnEkleGuncelle.Text = "Ekle";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.idu("delete from fakulte where fakulteID = " + secimID + "");
            VeriYenile();

            dataGVeri.ClearSelection();
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secimID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);
                txtFakulteAd.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                btnEkleGuncelle.Text = "Güncelle";
                secim = true;
                btnSil.BackColor = Color.FromArgb(119, 221, 119);
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seçiniz...");
            }

        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbUst_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click_1(object sender, EventArgs e)
        {

        }

        private void frmFakulte_Load(object sender, EventArgs e)
        {

            VeriYenile();

        }

        private void txtFakulteAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
