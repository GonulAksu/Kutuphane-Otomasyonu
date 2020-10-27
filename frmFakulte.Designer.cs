namespace Kütüphane_Otomasyonu1
{
    partial class frmFakulte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFakulte));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFakulteAd = new System.Windows.Forms.TextBox();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.gbUst = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.gbUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFakulteAd
            // 
            this.txtFakulteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFakulteAd.Location = new System.Drawing.Point(9, 32);
            this.txtFakulteAd.Multiline = true;
            this.txtFakulteAd.Name = "txtFakulteAd";
            this.txtFakulteAd.Size = new System.Drawing.Size(141, 24);
            this.txtFakulteAd.TabIndex = 1;
            this.txtFakulteAd.TextChanged += new System.EventHandler(this.txtFakulteAd_TextChanged);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.Snow;
            this.btnEkleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEkleGuncelle.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEkleGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkleGuncelle.ImageKey = "CheckMark.png";
            this.btnEkleGuncelle.ImageList = this.ımageList1;
            this.btnEkleGuncelle.Location = new System.Drawing.Point(190, 19);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(181, 37);
            this.btnEkleGuncelle.TabIndex = 2;
            this.btnEkleGuncelle.Text = "Ekle";
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bolümler_ekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "bölümler_temizle.jpg");
            this.ımageList1.Images.SetKeyName(2, "bölümler_sil.jpg");
            this.ımageList1.Images.SetKeyName(3, "icon-3695104_960_720.png");
            this.ımageList1.Images.SetKeyName(4, "kisspng-computer-icons-icon-design-drawing-5af6178f159e44.5691577415260773270886." +
        "jpg");
            this.ımageList1.Images.SetKeyName(5, "kisspng-orange-rectangle-eraser-5ab0b5707ac4d7.6334954715215302245029.jpg");
            this.ımageList1.Images.SetKeyName(6, "pngtree-Eraser-png-clipart_286626.jpg");
            this.ımageList1.Images.SetKeyName(7, "silgi.png");
            this.ımageList1.Images.SetKeyName(8, "CheckMark.png");
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Snow;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.LightCoral;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "silgi.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(190, 62);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(181, 43);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Snow;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnSil.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "icon-3695104_960_720.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(340, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(67, 171);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGVeri
            // 
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(3, 139);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(316, 171);
            this.dataGVeri.TabIndex = 5;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            this.dataGVeri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellDoubleClick);
            // 
            // gbUst
            // 
            this.gbUst.Controls.Add(this.txtFakulteAd);
            this.gbUst.Controls.Add(this.label1);
            this.gbUst.Controls.Add(this.btnEkleGuncelle);
            this.gbUst.Controls.Add(this.btnTemizle);
            this.gbUst.Location = new System.Drawing.Point(3, 12);
            this.gbUst.Name = "gbUst";
            this.gbUst.Size = new System.Drawing.Size(404, 120);
            this.gbUst.TabIndex = 6;
            this.gbUst.TabStop = false;
            this.gbUst.Enter += new System.EventHandler(this.gbUst_Enter);
            // 
            // frmFakulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(451, 343);
            this.Controls.Add(this.gbUst);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFakulte";
            this.Text = "Fakülte";
            this.Load += new System.EventHandler(this.frmFakulte_Load);
            this.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.gbUst.ResumeLayout(false);
            this.gbUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFakulteAd;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.GroupBox gbUst;
    }
}