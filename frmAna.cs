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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            #region ismidleArkaplanDenemesi
            MdiClient ctlMDI;


            foreach (Control ctl in this.Controls)
            {

                if ((ctl) is MdiClient)
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.FromArgb(208, 240, 192);
                }

            }
            #endregion



            lblKullaniciAdi.Text = "Kullanıcı Adı:" + Kullanıcı.kullaniciAdi;

        }

        private void fakulltelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFakulte frm = new frmFakulte();
            frm.MdiParent = this;
            frm.Show();
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emanetVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmanetVer frm = new frmEmanetVer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void emanetogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEmanetOgrenci frm = new frmEmanetOgrenci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void KİTAPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmKitaplar frm = new frmKitaplar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullaniciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmOgrenci frm = new frmOgrenci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bolumlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler frm = new frmBolumler();
            frm.MdiParent = this;
            frm.Show();
        }

     

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapStokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKutuphaneDurumRapor frm = new frmKutuphaneDurumRapor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
