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
    public partial class frmEmanetOgrenci : Form
    {
        public frmEmanetOgrenci()
        {
            InitializeComponent();
        }


        public static bool emanetOgrenci = false;


        public static string ogrenciAd;
        public static int ogrenciNo;
        public static bool ogrenciSecim = false;



        public static string kitapAd;
        public static int kitapBorkodNo;
        public static bool kitapSecim = false;

        int kitapID;
        public void veriYenile()
        {

            btn_iadeAl.BackColor = Color.FromArgb(255, 77, 77);
            dataGVeri.DataSource = baglan.DataTableGetir("SELECT kitaplar.kitapID,kitaplar.kitapAdi,kitaplar.kitapYayinTarihi,kitaplar.kitapYayinEvi,kitaplar.kitapSayfaSayisi,kitaplar.kitapKategori,kitaplar.kitapYazari,emanet.emanetDurum,emanet.emanetTarih,emanet.emanetiadeTarih, emanet.ceza  FROM kitaplar,emanet where kitaplar.kitapID = emanet.emanetKitapID and emanet.emanetOgrenciNo=" + ogrenciNo + "");
            dataGVeri.Columns[0].HeaderText = "Barkod No";
            dataGVeri.Columns[1].HeaderText = "Kitap Adı";
            dataGVeri.Columns[2].HeaderText = "Yayın Tarihi";
            dataGVeri.Columns[3].HeaderText = "Yayın Evi";
            dataGVeri.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGVeri.Columns[5].HeaderText = "Kategori";
            dataGVeri.Columns[6].HeaderText = "Yazar";
            dataGVeri.Columns[7].Visible = false;
            dataGVeri.Columns[8].HeaderText = "Alış Tarihi";
            dataGVeri.Columns[9].HeaderText = "İade Tarihi";
            dataGVeri.AllowUserToAddRows = false;

            //bool cezadurum = false;
            //DataGridViewTextBoxColumn ceza = new DataGridViewTextBoxColumn();
            for (int i = 0; i < dataGVeri.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGVeri.Rows[i].Cells[7].Value.ToString()) == 1)
                {

                    dataGVeri.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                }
                else if ((int)((DateTime.Now - (Convert.ToDateTime(dataGVeri.Rows[i].Cells[8].Value.ToString()).AddDays(14))).TotalDays) <= 2 && (int)((DateTime.Now - (Convert.ToDateTime(dataGVeri.Rows[i].Cells[8].Value.ToString()).AddDays(14))).TotalDays) >= 0)
                {

                    dataGVeri.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }



                else if ((Convert.ToDateTime(dataGVeri.Rows[i].Cells[8].Value.ToString()).AddDays(14)) < DateTime.Now)
                {
                    dataGVeri.Rows[i].DefaultCellStyle.BackColor = Color.Red;


                    dataGVeri.Rows[i].Cells[10].Value = (int)((DateTime.Now - (Convert.ToDateTime(dataGVeri.Rows[i].Cells[8].Value.ToString()).AddDays(14))).TotalDays);



                }
            }

        }
        public void temizle()
        {
            kitapSecim = false;
            ogrenciSecim = false;
            btnKitapSec.BackColor = Color.FromArgb(255, 77, 77);
            btnOgrneciSec.BackColor = Color.FromArgb(255, 77, 77);
            btn_iadeAl.BackColor = Color.FromArgb(255, 77, 77);
            lblKitapSecim.Text = "";
            lblOgrenciSecim.Text = "";

        }

        private void frmEmanetOgrenci_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrneciSec_Click(object sender, EventArgs e)
        {
            emanetOgrenci = true;
            frmAna frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmAna")
                {
                    frm = (frmAna)f;
                }
            }
            frmOgrenciSec frm2 = new frmOgrenciSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {

            veriYenile();
        }

        private void btnKitapSec_Click(object sender, EventArgs e)
        {
            emanetOgrenci = true;
            frmAna frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmAna")
                {
                    frm = (frmAna)f;
                }
            }
            frmKitapSec frm2 = new frmKitapSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }
        Baglanti baglan = new Baglanti();
        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            if (kitapSecim && ogrenciSecim)
            {

                baglan.idu("insert into emanet(emanetOgrenciNo,emanetKitapID) values ('" + ogrenciNo + "','" + kitapBorkodNo + "')");

                veriYenile();
                kitapSecim = false;

                btnKitapSec.BackColor = Color.FromArgb(255, 77, 77); ;

                lblKitapSecim.Text = "";

            }
            else
            {

                MessageBox.Show("Kitap ve Ögrenci Secimi Zorunludur");
            }

        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_iadeAl_Click(object sender, EventArgs e)
        {

            try
            {


                baglan.idu("update emanet set emanetDurum = '" + "1" + "',emanetiadeTarih='" + DateTime.Now.ToShortDateString() + "' where emanetKitapID = " + kitapID + "");

                veriYenile();

            }

            catch (Exception)
            {

                MessageBox.Show("Önce Ögrenci Sonra Asagıdaki Listeden Kitap Secmelisiniz");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
