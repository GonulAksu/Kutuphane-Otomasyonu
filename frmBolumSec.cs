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
    public partial class frmBolumSec : Form
    {
        public frmBolumSec()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
      
        public void VeriYenile()
        {

            dataGVeri.DataSource = baglan.DataTableGetir("SELECT  bolumler.bolumKodu,bolumler.bolumAd,fakulte.fakulteAd FROM bolumler INNER JOIN fakulte ON  bolumler.bolumFakulteID = fakulte.fakulteID ");
            dataGVeri.Columns[0].Visible = true;
            dataGVeri.Columns[1].HeaderText = "Bolum Adı";
            dataGVeri.Columns[1].Width = 220;
            dataGVeri.Columns[2].HeaderText = "Fakülte Adı";
            dataGVeri.Columns[2].Width = 220;

            dataGVeri.AllowUserToAddRows = false;


        }
        private void frmBolumSec_Load(object sender, EventArgs e)
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
                frmOgrenci.bolumKodu = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                frmOgrenci.bolumAd = dataGVeri.CurrentRow.Cells[1].Value.ToString();
                frmOgrenci.bolumSecim = true;

                frmOgrenci frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmOgrenci")
                    {
                        frm = (frmOgrenci)f;
                    }
                }

                frm.btnBolumSec.BackColor = Color.FromArgb(119, 221, 119);
                frm.lbsSecim.Text = frmOgrenci.bolumAd.ToString();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }
    }
}
