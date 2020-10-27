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
    public partial class frmOgrenciSec : Form
    {
        public frmOgrenciSec()
        {
            InitializeComponent();
        }

        Baglanti baglan = new Baglanti();
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


        }

        private void frmOgrenciSec_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void frmOgrenciSec_Leave(object sender, EventArgs e)
        {
            frmEmanetVer.emanetVer = false;
            frmEmanetOgrenci.emanetOgrenci = false;
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (frmEmanetVer.emanetVer)
                {
                    frmEmanetVer.ogrenciNo = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                    frmEmanetVer.ogrenciAd = dataGVeri.CurrentRow.Cells[1].Value.ToString() + " " + dataGVeri.CurrentRow.Cells[2].Value.ToString();
                    frmEmanetVer.ogrenciSecim = true;

                    frmEmanetVer frm = null;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmEmanetVer")
                        {
                            frm = (frmEmanetVer)f;
                        }
                    }

                    frm.btnOgrneciSec.BackColor = Color.FromArgb(119, 221, 119);
                    frm.lblOgrenciSecim.Text = frmEmanetVer.ogrenciAd.ToString();
                    frmEmanetVer.emanetVer = false;
                    this.Close();

                }
                else if (frmEmanetOgrenci.emanetOgrenci)
                {
                    frmEmanetOgrenci.ogrenciNo = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                    frmEmanetOgrenci.ogrenciAd = dataGVeri.CurrentRow.Cells[1].Value.ToString() + " " + dataGVeri.CurrentRow.Cells[2].Value.ToString();
                    frmEmanetOgrenci.ogrenciSecim = true;

                    frmEmanetOgrenci frm = null;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmEmanetOgrenci")
                        {
                            frm = (frmEmanetOgrenci)f;
                        }
                    }

                    frm.btnOgrneciSec.BackColor = Color.FromArgb(119, 221, 119);
                    frm.lblOgrenciSecim.Text = frmEmanetOgrenci.ogrenciAd.ToString();

                    frmEmanetOgrenci.emanetOgrenci = false;


                    this.Close();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
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
                for (int i = 0; i < dataGVeri.RowCount - 1; i++)
                {
                    if (txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[0].Value.ToString().ToUpper() || txtAra.Text.ToUpper() == dataGVeri.Rows[i].Cells[1].Value.ToString().ToUpper() + " " + dataGVeri.Rows[i].Cells[2].Value.ToString().ToUpper())
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
            catch (Exception)
            {

            }

        }
    }
}
