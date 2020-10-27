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
    public partial class frmFakulteSec : Form
    {
        public frmFakulteSec()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();

        public void VeriYenile()
        {
            dataGVeri.DataSource = baglan.DataTableGetir("select * from fakulte");

            dataGVeri.Columns[0].Visible = false;
            dataGVeri.Columns[1].HeaderText = "Fakülte Adı";
            dataGVeri.Columns[1].Width = 330;
            dataGVeri.AllowUserToAddRows = false;

        }
        private void frmFakulteSec_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmBolumler.fakulteID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                frmBolumler.fakulteAd = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                frmBolumler.fakulteSecim = true;

                frmBolumler frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmBolumler")
                    {
                        frm = (frmBolumler)f;
                    }
                }

                frm.btnFakulteSec.BackColor = Color.FromArgb(119, 221, 119);
                frm.lbsSecim.Text = frmBolumler.fakulteAd.ToString();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }
    }
}
