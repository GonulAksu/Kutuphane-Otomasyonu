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
    public partial class frmEmanetVer : Form
    {
        public frmEmanetVer()
        {
            InitializeComponent();
        }
        public static string ogrenciAd;
        public static int ogrenciNo;
        public static bool ogrenciSecim = false;

        public static bool emanetVer = false;

        public static string kitapAd;
        public static int kitapBorkodNo;
        public static bool kitapSecim = false;
        Baglanti baglan = new Baglanti();

        public void temizle()
        {
            kitapSecim = false;
            ogrenciSecim = false;
            btnKitapSec.BackColor = Color.FromArgb(255, 77, 77);
            btnOgrneciSec.BackColor = Color.FromArgb(255, 77, 77);
            lblKitapSecim.Text = "";
            lblOgrenciSecim.Text = "";

        }



        private void frmEmanetVer_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrneciSec_Click(object sender, EventArgs e)
        {
            emanetVer = true;
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

        private void btnKitapSec_Click(object sender, EventArgs e)
        {
            emanetVer = true;
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

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            if (kitapSecim && ogrenciSecim)
            {

                baglan.idu("insert into emanet(emanetOgrenciNo,emanetKitapID) values ('" + ogrenciNo + "','" + kitapBorkodNo + "')");
                temizle();
                MessageBox.Show("Emanet Verildi...");


            }
            else
            {

                MessageBox.Show("Kitap ve Ögrenci Secimi Zorunludur");
            }
        }
    }
}
