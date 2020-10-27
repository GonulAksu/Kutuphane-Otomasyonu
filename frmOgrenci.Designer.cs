namespace Kütüphane_Otomasyonu1
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.btnBolumSec = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lbsSecim = new System.Windows.Forms.Label();
            this.lblNumaBaslik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBolumSec
            // 
            this.btnBolumSec.BackColor = System.Drawing.Color.Tomato;
            this.btnBolumSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolumSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBolumSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBolumSec.ImageKey = "school-3158985_960_720.png";
            this.btnBolumSec.ImageList = this.ımageList1;
            this.btnBolumSec.Location = new System.Drawing.Point(36, 19);
            this.btnBolumSec.Name = "btnBolumSec";
            this.btnBolumSec.Size = new System.Drawing.Size(153, 53);
            this.btnBolumSec.TabIndex = 0;
            this.btnBolumSec.Text = "Bölüm Seç";
            this.btnBolumSec.UseVisualStyleBackColor = false;
            this.btnBolumSec.Click += new System.EventHandler(this.btnBolumSec_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "school-3158985_960_720.png");
            this.ımageList1.Images.SetKeyName(1, "CheckMark.png");
            this.ımageList1.Images.SetKeyName(2, "bölümler_temizle.jpg");
            this.ımageList1.Images.SetKeyName(3, "magnifying-glass-1083378_960_720.png");
            this.ımageList1.Images.SetKeyName(4, "icon-3695104_960_720.png");
            this.ımageList1.Images.SetKeyName(5, "kisspng-orange-rectangle-eraser-5ab0b5707ac4d7.6334954715215302245029.jpg");
            this.ımageList1.Images.SetKeyName(6, "");
            this.ımageList1.Images.SetKeyName(7, "silgi.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.lbsSecim);
            this.groupBox1.Controls.Add(this.lblNumaBaslik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCinsiyet);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.btnBolumSec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(94, 248);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(0, 13);
            this.lblNumara.TabIndex = 11;
            this.lblNumara.Click += new System.EventHandler(this.lblNumara_Click);
            // 
            // lbsSecim
            // 
            this.lbsSecim.AutoSize = true;
            this.lbsSecim.Location = new System.Drawing.Point(33, 85);
            this.lbsSecim.Name = "lbsSecim";
            this.lbsSecim.Size = new System.Drawing.Size(0, 13);
            this.lbsSecim.TabIndex = 10;
            this.lbsSecim.Click += new System.EventHandler(this.lbsSecim_Click);
            // 
            // lblNumaBaslik
            // 
            this.lblNumaBaslik.AutoSize = true;
            this.lblNumaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblNumaBaslik.Location = new System.Drawing.Point(14, 248);
            this.lblNumaBaslik.Name = "lblNumaBaslik";
            this.lblNumaBaslik.Size = new System.Drawing.Size(54, 13);
            this.lblNumaBaslik.TabIndex = 9;
            this.lblNumaBaslik.Text = "Numara:";
            this.lblNumaBaslik.Click += new System.EventHandler(this.lblNumaBaslik_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cinsiyet:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tc:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Location = new System.Drawing.Point(97, 220);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(136, 21);
            this.cbCinsiyet.TabIndex = 4;
            this.cbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cbCinsiyet_SelectedIndexChanged);
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTc.Location = new System.Drawing.Point(97, 191);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(136, 26);
            this.txtTc.TabIndex = 3;
            this.txtTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTc_MaskInputRejected);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSoyad.Location = new System.Drawing.Point(97, 152);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(136, 30);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged_1);
            this.txtSoyad.Validated += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAd.Location = new System.Drawing.Point(97, 111);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(136, 35);
            this.txtAd.TabIndex = 1;
            this.txtAd.UseSystemPasswordChar = true;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.Tan;
            this.btnEkleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEkleGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkleGuncelle.ImageKey = "CheckMark.png";
            this.btnEkleGuncelle.ImageList = this.ımageList1;
            this.btnEkleGuncelle.Location = new System.Drawing.Point(276, 31);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(153, 53);
            this.btnEkleGuncelle.TabIndex = 10;
            this.btnEkleGuncelle.Text = "Kaydet";
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Tan;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "silgi.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(276, 97);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 50);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Location = new System.Drawing.Point(276, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 114);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numara veya Ad Soyad";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Tan;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "magnifying-glass-1083378_960_720.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(17, 50);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(147, 46);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAra.Location = new System.Drawing.Point(17, 24);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dataGVeri
            // 
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(0, 297);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.Size = new System.Drawing.Size(371, 150);
            this.dataGVeri.TabIndex = 13;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tan;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "icon-3695104_960_720.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(392, 297);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(61, 150);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(604, 456);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ögrenci";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnBolumSec;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label lblNumaBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Label lbsSecim;
        public System.Windows.Forms.Label lblNumara;
    }
}