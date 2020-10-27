using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu1
{
    public partial class FrmKullanıcı : Form
    {
        public FrmKullanıcı()
        {
            InitializeComponent();
        }
        Kullanıcı kullanici = new Kullanıcı();
        Baglanti baglan = new Baglanti();
        private void FrmKullanıcı_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("Select * from admin", baglan.baglan());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbKullanici.Items.Add(dr["adminAdi"]);
            }

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (kullanici.giris(cbKullanici.Text, txtSifre.Text))
            {
                frmAna frm = new frmAna();
                frm.ShowDialog();
                this.Close();


            }
            else
            {


                MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz...");
            }
        }
    }
}
