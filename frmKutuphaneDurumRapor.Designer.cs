namespace Kütüphane_Otomasyonu1
{
    partial class frmKutuphaneDurumRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.dataG_Emanet = new System.Windows.Forms.DataGridView();
            this.dataG_Tum = new System.Windows.Forms.DataGridView();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Emanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Tum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVeri
            // 
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(248, 118);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.Size = new System.Drawing.Size(240, 150);
            this.dataGVeri.TabIndex = 1;
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick_1);
            // 
            // dataG_Emanet
            // 
            this.dataG_Emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_Emanet.Location = new System.Drawing.Point(218, 222);
            this.dataG_Emanet.Name = "dataG_Emanet";
            this.dataG_Emanet.Size = new System.Drawing.Size(240, 150);
            this.dataG_Emanet.TabIndex = 2;
            this.dataG_Emanet.Visible = false;
            // 
            // dataG_Tum
            // 
            this.dataG_Tum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_Tum.Location = new System.Drawing.Point(382, 105);
            this.dataG_Tum.Name = "dataG_Tum";
            this.dataG_Tum.Size = new System.Drawing.Size(223, 149);
            this.dataG_Tum.TabIndex = 3;
            this.dataG_Tum.Visible = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(47, 35);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(648, 401);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // frmKutuphaneDurumRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 448);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dataG_Tum);
            this.Controls.Add(this.dataG_Emanet);
            this.Controls.Add(this.dataGVeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmKutuphaneDurumRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutuphane Durum Rapor";
            this.Load += new System.EventHandler(this.frmKutuphaneDurumRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Emanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Tum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.DataGridView dataG_Emanet;
        private System.Windows.Forms.DataGridView dataG_Tum;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}