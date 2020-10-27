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
    public partial class frmKitaplar : Form
    {
        public frmKitaplar()
        {
            InitializeComponent();
        }

        bool secim = false;


        public void temizle()
        {

            secim = false;
            btnEkleGuncelle.Text = "Ekle";




            txtKitapAdi.Text = "";

            dpkitapYayinTarihi.Value = DateTime.Now;

            txtKitapYayinEvi.Text = "";

            txtKitapSayfaSayisi.Text = "";

            txtKategori.Text = "";

            txtKitapYazari.Text = "";


            btnKitapGecmis.BackColor = Color.FromArgb(255, 77, 77);
            btnSil.BackColor = Color.FromArgb(255, 77, 77);

        }
        public void VeriYenile()
        {


            dataGVeri.DataSource = baglan.DataTableGetir("select * from kitaplar");

            dataGVeri.Columns[0].HeaderText = "Barkod No";
            dataGVeri.Columns[1].HeaderText = "Kitap Adı";
            dataGVeri.Columns[2].HeaderText = "Yayın Tarihi";
            dataGVeri.Columns[3].HeaderText = "Yayın Evi";
            dataGVeri.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGVeri.Columns[5].HeaderText = "Kategori";
            dataGVeri.Columns[6].HeaderText = "Yazar";

            dataGVeri.AllowUserToAddRows = false;
            temizle();
        }


        public static int secimID;

        Baglanti baglan = new Baglanti();







        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
                VeriYenile();
        }
        DataTable dt = new DataTable();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Kitap Adı");
            dt.Columns.Add("Yayın Tarihi");
            dt.Columns.Add("Yayın Evi");
            dt.Columns.Add("Sayfa Sayısı");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Yazar");
            for (int i = 0; i < dataGVeri.RowCount; i++)
            {

                if (txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[0].Value.ToString().ToUpper() || txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    dt.Rows.Add(dataGVeri.Rows[i].Cells[0].Value.ToString(), dataGVeri.Rows[i].Cells[1].Value.ToString(), dataGVeri.Rows[i].Cells[2].Value.ToString(), dataGVeri.Rows[i].Cells[3].Value.ToString(),
                        dataGVeri.Rows[i].Cells[4].Value.ToString(), dataGVeri.Rows[i].Cells[5].Value.ToString(), dataGVeri.Rows[i].Cells[6].Value.ToString());
                }

            }

            dataGVeri.Columns.Clear();
            dataGVeri.DataSource = dt;

            dataGVeri.Columns[6].Visible = false;
            dataGVeri.AllowUserToAddRows = false;
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secimID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);
                txtKitapAdi.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                dpkitapYayinTarihi.Value = Convert.ToDateTime(dataGVeri.CurrentRow.Cells[2].Value);
                txtKitapYayinEvi.Text = dataGVeri.CurrentRow.Cells[3].Value.ToString();
                txtKitapSayfaSayisi.Text = dataGVeri.CurrentRow.Cells[4].Value.ToString();
                txtKategori.Text = dataGVeri.CurrentRow.Cells[5].Value.ToString();
                txtKitapYazari.Text = dataGVeri.CurrentRow.Cells[6].Value.ToString();

                btnEkleGuncelle.Text = "Güncelle";
                secim = true;
                btnKitapGecmis.BackColor = Color.FromArgb(119, 221, 119);
                btnSil.BackColor = Color.FromArgb(119, 221, 119);
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (secim)
                {
                    baglan.idu("delete from kitaplar where kitapID = " + secimID + "");
                    VeriYenile();
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnKitapGecmis_Click(object sender, EventArgs e)
        {
            if (secim)
            {

                frmAna frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmAna")
                    {
                        frm = (frmAna)f;
                    }
                }

                frmkitapGecmis frm2 = new frmkitapGecmis();
                frm2.MdiParent = frm;
                frm2.Show();
            }

            else
            {
                MessageBox.Show("Önce Kitap Secmelisiniz...");
            }
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
