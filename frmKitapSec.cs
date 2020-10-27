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
    public partial class frmKitapSec : Form
    {
        public frmKitapSec()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();



        public void VeriYenile()
        {
            bool ekle = true;
            dataGridView1.DataSource = baglan.DataTableGetir("select * FROM kitaplar");
            dataGridView2.DataSource = baglan.DataTableGetir("select  emanetKitapID from emanet where emanetDurum=0");

            DataTable dt = new DataTable();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
                {

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView2.Rows[j].Cells[0].Value.ToString())
                    {
                        ekle = false;

                    }

                }
                if (ekle)
                {
                    dt.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString());

                }
                else
                {
                    ekle = true;
                }

            }




            dataGVeri.DataSource = dt;

            dataGVeri.Columns[0].HeaderText = "Barkod No";
            dataGVeri.Columns[1].HeaderText = "Kitap Adı";
            dataGVeri.Columns[2].HeaderText = "Yayın Tarihi";
            dataGVeri.Columns[3].HeaderText = "Yayın Evi";
            dataGVeri.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGVeri.Columns[5].HeaderText = "Kategori";
            dataGVeri.Columns[6].HeaderText = "Yazar";


        }



        private void frmKitapSec_Leave(object sender, EventArgs e)
        {
            frmEmanetVer.emanetVer = false;
            frmEmanetOgrenci.emanetOgrenci = false;
        }

        private void frmKitapSec_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (frmEmanetVer.emanetVer)
                {
                    frmEmanetVer.kitapBorkodNo = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                    frmEmanetVer.kitapAd = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                    frmEmanetVer.kitapSecim = true;

                    frmEmanetVer frm = null;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmEmanetVer")
                        {
                            frm = (frmEmanetVer)f;
                        }
                    }

                    frm.btnKitapSec.BackColor = Color.FromArgb(119, 221, 119);
                    frm.lblKitapSecim.Text = frmEmanetVer.kitapAd.ToString();
                    frmEmanetVer.emanetVer = false;
                    this.Close();

                }
                else if (frmEmanetOgrenci.emanetOgrenci)
                {
                    frmEmanetOgrenci.kitapBorkodNo = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                    frmEmanetOgrenci.kitapAd = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                    frmEmanetOgrenci.kitapSecim = true;

                    frmEmanetOgrenci frm = null;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmEmanetOgrenci")
                        {
                            frm = (frmEmanetOgrenci)f;
                        }
                    }

                    frm.btnKitapSec.BackColor = Color.FromArgb(119, 221, 119);
                    frm.lblKitapSecim.Text = frmEmanetOgrenci.kitapAd.ToString();
                    frmEmanetOgrenci.emanetOgrenci = false;
                    this.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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
            dataGVeri.DataSource = dt;


            dataGVeri.AllowUserToAddRows = false;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
                VeriYenile();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnlAra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
