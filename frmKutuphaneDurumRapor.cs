using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Kütüphane_Otomasyonu1
{
    public partial class frmKutuphaneDurumRapor : Form
    {
        public frmKutuphaneDurumRapor()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        public void VeriYenile()
        {
            bool ekle = true;
            dataG_Tum.DataSource = baglan.DataTableGetir("select * FROM kitaplar");
            dataG_Emanet.DataSource = baglan.DataTableGetir("select  emanetKitapID from emanet where emanetDurum=0");

            DataTable dt = new DataTable();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();

            for (int i = 0; i < dataG_Tum.Rows.Count - 1; i++)
            {

                for (int j = 0; j < dataG_Emanet.Rows.Count - 1; j++)
                {

                    if (dataG_Tum.Rows[i].Cells[0].Value.ToString() == dataG_Emanet.Rows[j].Cells[0].Value.ToString())
                    {
                        ekle = false;

                    }

                }
                if (ekle)
                {
                    dt.Rows.Add(dataG_Tum.Rows[i].Cells[0].Value.ToString(), dataG_Tum.Rows[i].Cells[1].Value.ToString(), dataG_Tum.Rows[i].Cells[2].Value.ToString(), dataG_Tum.Rows[i].Cells[3].Value.ToString(), dataG_Tum.Rows[i].Cells[4].Value.ToString(), dataG_Tum.Rows[i].Cells[5].Value.ToString(), dataG_Tum.Rows[i].Cells[6].Value.ToString());

                }
                else
                {
                    ekle = true;
                }

            }

            dataGVeri.DataSource = dt;

        }

        private void frmKutuphaneDurumRapor_Load(object sender, EventArgs e)
        {
            VeriYenile();
            GraphPane myPane = zedGraphControl1.GraphPane;
            string[] labels = { "Emanette", "Verilmeye Hazır", "Tüm Kitaplar" };
            double[] y = { dataG_Emanet.Rows.Count - 1, dataGVeri.Rows.Count - 1, dataG_Tum.Rows.Count - 1 };
            myPane.AddPieSlices(y, new[] { "Emanette", "Verilmeye Hazır", null });
            myPane.Legend.IsVisible = true;
            LineItem myLine = myPane.AddCurve(null, null, y, Color.Red);
            myLine.Line.Fill = new Fill(Color.Red, Color.White, Color.Blue);

            myPane.XAxis.Scale.TextLabels = labels;
            myPane.XAxis.Type = AxisType.Text;

            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void dataGVeri_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
