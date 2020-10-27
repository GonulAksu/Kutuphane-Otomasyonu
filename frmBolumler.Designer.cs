namespace Kütüphane_Otomasyonu1
{
    partial class frmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolumler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsSecim = new System.Windows.Forms.Label();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.btnFakulteSec = new System.Windows.Forms.Button();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbsSecim);
            this.groupBox1.Controls.Add(this.txtBolumAd);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnEkleGuncelle);
            this.groupBox1.Controls.Add(this.btnFakulteSec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bölüm Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbsSecim
            // 
            this.lbsSecim.AutoSize = true;
            this.lbsSecim.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsSecim.Location = new System.Drawing.Point(16, 119);
            this.lbsSecim.Name = "lbsSecim";
            this.lbsSecim.Size = new System.Drawing.Size(0, 16);
            this.lbsSecim.TabIndex = 4;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtBolumAd.Location = new System.Drawing.Point(72, 170);
            this.txtBolumAd.Multiline = true;
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(185, 32);
            this.txtBolumAd.TabIndex = 3;
            this.txtBolumAd.TextChanged += new System.EventHandler(this.txtBolumAd_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Tan;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btnTemizle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "Martz90-Circle-Addon1-Memory-cleaner.ico";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(387, 119);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(233, 58);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "fakültesec.jpg");
            this.ımageList1.Images.SetKeyName(1, "bolümler_ekle.jpg");
            this.ımageList1.Images.SetKeyName(2, "CheckMark.png");
            this.ımageList1.Images.SetKeyName(3, "pngtree-Eraser-png-clipart_286626.jpg");
            this.ımageList1.Images.SetKeyName(4, "kisspng-eraser-icon-eraser-5a70fbe990f8a5.3435048415173539615938.jpg");
            this.ımageList1.Images.SetKeyName(5, "kisspng-computer-icons-icon-design-drawing-5af6178f159e44.5691577415260773270886." +
        "jpg");
            this.ımageList1.Images.SetKeyName(6, "0434a39cba78c71acc15db922453d352_icon.png");
            this.ımageList1.Images.SetKeyName(7, "Martz90-Circle-Addon1-Memory-cleaner.ico");
            this.ımageList1.Images.SetKeyName(8, "kisspng-computer-icons-school-student-holy-family-catholic-5b3fd2cb87fb16.2886386" +
        "61530909387557.jpg");
            this.ımageList1.Images.SetKeyName(9, "indir (3).jpeg");
            this.ımageList1.Images.SetKeyName(10, "kisspng-computer-icons-computer-monitors-computer-software-icon-free-png-school-5" +
        "ab0e067c90f64.0044882815215412238236.jpg");
            this.ımageList1.Images.SetKeyName(11, "kisspng-computer-icons-icon-design-delete-button-5abcecfee7b8e6.55429258152233087" +
        "89491.jpg");
            this.ımageList1.Images.SetKeyName(12, "recycle-bin-png-5a364a0d6000f9.1021710915135073413932.jpg");
            this.ımageList1.Images.SetKeyName(13, "kisspng-recycling-bin-ico-icon-trash-can-5aa0f60f86b7e2.8112438015204981915518.jp" +
        "g");
            this.ımageList1.Images.SetKeyName(14, "kisspng-macbook-pro-computer-icons-trash-recycle-bin-5ac1164b98da49.3956202715226" +
        "035956261.jpg");
            this.ımageList1.Images.SetKeyName(15, "kisspng-recycling-waste-container-icon-recycle-bin-material-5a72229f7f17e6.855900" +
        "9715174294075206.jpg");
            this.ımageList1.Images.SetKeyName(16, "kisspng-rubbish-bins-waste-paper-baskets-computer-icons-symbol-icon-trash-can-5ab" +
        "15f6eec6e29.9819341915215737429684.jpg");
            this.ımageList1.Images.SetKeyName(17, "kisspng-logo-recycling-symbol-paper-vector-tri-color-recycling-trash-can-5a6e7739" +
        "cda604.9712082315171889218424.jpg");
            this.ımageList1.Images.SetKeyName(18, "kisspng-recycling-symbol-waste-recycling-bin-a-trash-can-5a9959cc6e3993.177372521" +
        "5199994364515.jpg");
            this.ımageList1.Images.SetKeyName(19, "school-3158985_960_720.png");
            this.ımageList1.Images.SetKeyName(20, "HP-Recycle-Empty-icon.png");
            this.ımageList1.Images.SetKeyName(21, "öğrenci.png");
            this.ımageList1.Images.SetKeyName(22, "icon-3695104_960_720.png");
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.Tan;
            this.btnEkleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btnEkleGuncelle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEkleGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkleGuncelle.ImageKey = "CheckMark.png";
            this.btnEkleGuncelle.ImageList = this.ımageList1;
            this.btnEkleGuncelle.Location = new System.Drawing.Point(387, 40);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(233, 58);
            this.btnEkleGuncelle.TabIndex = 1;
            this.btnEkleGuncelle.Text = "Ekle";
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // btnFakulteSec
            // 
            this.btnFakulteSec.BackColor = System.Drawing.Color.Tan;
            this.btnFakulteSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFakulteSec.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btnFakulteSec.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFakulteSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFakulteSec.ImageKey = "school-3158985_960_720.png";
            this.btnFakulteSec.ImageList = this.ımageList1;
            this.btnFakulteSec.Location = new System.Drawing.Point(6, 19);
            this.btnFakulteSec.Name = "btnFakulteSec";
            this.btnFakulteSec.Size = new System.Drawing.Size(251, 56);
            this.btnFakulteSec.TabIndex = 0;
            this.btnFakulteSec.Text = "Fakülte Seç";
            this.btnFakulteSec.UseVisualStyleBackColor = false;
            this.btnFakulteSec.Click += new System.EventHandler(this.btnFakulteSec_Click);
            // 
            // dataGVeri
            // 
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(12, 242);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(569, 198);
            this.dataGVeri.TabIndex = 6;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tan;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "icon-3695104_960_720.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(602, 242);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 198);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(706, 452);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBolumler";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnFakulteSec;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbsSecim;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Button btnSil;
    }
}