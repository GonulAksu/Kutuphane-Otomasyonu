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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        public static int bolumKodu;
        public static string bolumAd;
        public static bool bolumSecim = false;
        Baglanti baglan = new Baglanti();

        bool secim = false;
        int secimID;
        public void temizle()
        {
            txtAra.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            lblNumara.Text = "";
            lblNumaBaslik.Visible = false;
            lbsSecim.Text = "";
            txtTc.Text = "";
            cbCinsiyet.SelectedItem = "Erkek";
            secim = false;
            dataGVeri.ClearSelection();
            btnEkleGuncelle.Text = "Ekle";
            btnBolumSec.BackColor = Color.FromArgb(255, 77, 77);
            btnSil.BackColor = Color.FromArgb(255, 77, 77);

            dataGVeri.ClearSelection();
        }
        public void VeriYenile()
        {


            dataGVeri.DataSource = baglan.DataTableGetir("select ogrenciler.ogrenciNo, ogrenciler.ogrenciAd, ogrenciler.ogrenciSoyad, ogrenciler.ogrenciTc, ogrenciler.ogrenciCinsiyet, bolumler.bolumAd, bolumler.bolumKodu  FROM ogrenciler INNER JOIN bolumler ON ogrenciler.ogrenciBolumKodu = bolumler.bolumKodu");

            dataGVeri.Columns[6].Visible = false;
            dataGVeri.Columns[0].HeaderText = "Numara";
            dataGVeri.Columns[1].HeaderText = "Adı";
            dataGVeri.Columns[2].HeaderText = "Soyadı";
            dataGVeri.Columns[3].HeaderText = "Tc";
            dataGVeri.Columns[4].HeaderText = "Cinsiyet";
            dataGVeri.Columns[5].HeaderText = "Bolum Adı";


            dataGVeri.AllowUserToAddRows = false;
            temizle();

        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNumaBaslik_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!secim && txtAd.Text != "")
                {

                    baglan.idu("insert into ogrenciler(ogrenciBolumKodu,ogrenciTc,ogrenciAd,ogrenciSoyad,ogrenciCinsiyet) values ('" + bolumKodu + "','" + txtTc.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + cbCinsiyet.SelectedItem.ToString() + "')");
                    VeriYenile();

                }
                else if (txtAd.Text != "")
                {

                    baglan.idu("update ogrenciler set ogrenciBolumKodu = '" + bolumKodu + "',ogrenciTc='" + txtTc.Text + "',ogrenciAd='" + txtAd.Text + "',ogrenciSoyad='" + txtSoyad.Text + "',ogrenciCinsiyet='" + cbCinsiyet.SelectedItem.ToString() + "' where ogrenciNo = " + secimID + "");
                    VeriYenile();

                }
                else
                {
                    MessageBox.Show("Alanları Eksiksiz Doldurunuz...");
                }


            }
            catch (Exception)
            {


            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
                VeriYenile();
        }

        DataTable dt = new DataTable();
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {

                dt.Columns.Clear();
                dt.Columns.Add("Numara");
                dt.Columns.Add("Adı");
                dt.Columns.Add("Soyadı");
                dt.Columns.Add("Tc");
                dt.Columns.Add("Cinsiyet");
                dt.Columns.Add("Bolum Adı");
                dt.Columns.Add();
                for (int i = 0; i < dataGVeri.RowCount; i++)
                {
                    if (txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[0].Value.ToString().ToUpper() || txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[1].Value.ToString().ToUpper() + " " + dataGVeri.Rows[i].Cells[2].Value.ToString().ToUpper())
                    {
                        dt.Rows.Add(dataGVeri.Rows[i].Cells[0].Value.ToString(), dataGVeri.Rows[i].Cells[1].Value.ToString(), dataGVeri.Rows[i].Cells[2].Value.ToString(), dataGVeri.Rows[i].Cells[3].Value.ToString(),
                            dataGVeri.Rows[i].Cells[4].Value.ToString(), dataGVeri.Rows[i].Cells[5].Value.ToString(), dataGVeri.Rows[i].Cells[6].Value.ToString());
                    }

                }
                dataGVeri.DataSource = dt;

                dataGVeri.Columns[6].Visible = false;
                dataGVeri.AllowUserToAddRows = false;
            }
            catch (Exception)
            {

            }

        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.idu("delete from ogrenciler where ogrenciNo = " + secimID + "");
            VeriYenile();
        }

        private void btnBolumSec_Click(object sender, EventArgs e)
        {
            frmAna frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmAna")
                {
                    frm = (frmAna)f;
                }
            }
            frmBolumSec frm2 = new frmBolumSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secimID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);
                lblNumara.Text = dataGVeri.CurrentRow.Cells[0].Value.ToString();
                lblNumaBaslik.Visible = true;
                txtAd.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGVeri.CurrentRow.Cells[2].Value.ToString();
                txtTc.Text = dataGVeri.CurrentRow.Cells[3].Value.ToString();
                cbCinsiyet.SelectedItem = dataGVeri.CurrentRow.Cells[4].Value.ToString();
                btnEkleGuncelle.Text = "Güncelle";
                secim = true;
                btnBolumSec.BackColor = Color.FromArgb(119, 221, 119);
                bolumAd = dataGVeri.CurrentRow.Cells[5].Value.ToString();
                bolumKodu = Convert.ToInt32(dataGVeri.CurrentRow.Cells[6].Value);
                lbsSecim.Text = bolumAd;
                btnSil.BackColor = Color.FromArgb(119, 221, 119);
            }
            catch (Exception)
            {
                MessageBox.Show("Dogru Alanı Seçiniz...");
            }

        }

        private void btnBolumSec_Click_1(object sender, EventArgs e)
        {

            frmAna frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmAna")
                {
                    frm = (frmAna)f;
                }
            }
            frmBolumSec frm2 = new frmBolumSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }

        private void txtSoyad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbsSecim_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblNumara_Click(object sender, EventArgs e)
        {

        }
    }
}
