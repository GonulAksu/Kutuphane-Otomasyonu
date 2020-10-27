using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu1
{
    class Kullanıcı
    {
        public static string kullaniciAdi;

        public static string KullaniciAdi
        {
            get
            {
                return kullaniciAdi;
            }

            set
            {
                kullaniciAdi = value;
            }
        }

        Baglanti baglan = new Baglanti();
        public bool giris(string kullaniciAdi, string Parola)
        {

            OleDbCommand cmd = new OleDbCommand("Select * from admin where adminAdi='" + kullaniciAdi + "'and adminSifre= '" + Parola + "'", baglan.baglan());
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                KullaniciAdi = kullaniciAdi;
                return true;
            }
            else
            {

                return false;

            }

        }
    }
}
