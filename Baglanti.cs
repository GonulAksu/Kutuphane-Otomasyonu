using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu1
{
    class Baglanti
    {

        public OleDbConnection baglan()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = database.mdb");
            baglanti.Open();
            return baglanti;
        }

        public int idu(string sqlcumle)
        {

            OleDbConnection baglan = this.baglan();
            OleDbCommand sorgu = new OleDbCommand(sqlcumle, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return (sonuc);
        }

        public DataTable DataTableGetir(string sql)
        {
            OleDbConnection baglan = this.baglan();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (OleDbException ex)
            {

                throw new Exception(ex.Message);
            }
            adapter.Dispose();
            baglan.Close();
            baglan.Dispose();
            return dt;

        }

    }
}
