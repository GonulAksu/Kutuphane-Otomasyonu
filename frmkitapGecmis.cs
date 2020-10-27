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
    public partial class frmkitapGecmis : Form
    {
        public frmkitapGecmis()
        {
            InitializeComponent();
        }

        Baglanti baglan = new Baglanti();
        public void VeriYenile()
        {


            dataGVeri.DataSource = baglan.DataTableGetir("SELECT ogrenciler.ogrenciNo, ogrenciler.ogrenciAd, ogrenciler.ogrenciSoyad, ogrenciler.ogrenciTc ,emanet.emanetDurum, emanet.emanetTarih, emanet.emanetiadeTarih  FROM emanet,ogrenciler where emanet.emanetOgrenciNo = ogrenciler.ogrenciNo and emanet.emanetKitapID= " + frmKitaplar.secimID + "");


            dataGVeri.AllowUserToAddRows = false;

        }

        private void kitapGecmis_Load(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
