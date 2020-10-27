namespace Kütüphane_Otomasyonu1
{
    partial class frmKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitaplar));
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.dpkitapYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtKitapYayinEvi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtKitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKitapGecmis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKitapAdi.Location = new System.Drawing.Point(177, 34);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 30);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // dpkitapYayinTarihi
            // 
            this.dpkitapYayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dpkitapYayinTarihi.Location = new System.Drawing.Point(177, 70);
            this.dpkitapYayinTarihi.Name = "dpkitapYayinTarihi";
            this.dpkitapYayinTarihi.Size = new System.Drawing.Size(200, 23);
            this.dpkitapYayinTarihi.TabIndex = 1;
            // 
            // txtKitapYayinEvi
            // 
            this.txtKitapYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKitapYayinEvi.Location = new System.Drawing.Point(177, 113);
            this.txtKitapYayinEvi.Multiline = true;
            this.txtKitapYayinEvi.Name = "txtKitapYayinEvi";
            this.txtKitapYayinEvi.Size = new System.Drawing.Size(200, 35);
            this.txtKitapYayinEvi.TabIndex = 2;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKitapYazari.Location = new System.Drawing.Point(177, 154);
            this.txtKitapYazari.Multiline = true;
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(200, 34);
            this.txtKitapYazari.TabIndex = 3;
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKategori.Location = new System.Drawing.Point(177, 194);
            this.txtKategori.Multiline = true;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(200, 29);
            this.txtKategori.TabIndex = 4;
            // 
            // txtKitapSayfaSayisi
            // 
            this.txtKitapSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtKitapSayfaSayisi.Location = new System.Drawing.Point(177, 238);
            this.txtKitapSayfaSayisi.Multiline = true;
            this.txtKitapSayfaSayisi.Name = "txtKitapSayfaSayisi";
            this.txtKitapSayfaSayisi.Size = new System.Drawing.Size(100, 28);
            this.txtKitapSayfaSayisi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(93, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yayın Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(93, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yayın Evi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(93, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategori:";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblNumara.Location = new System.Drawing.Point(163, 120);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(0, 13);
            this.lblNumara.TabIndex = 10;
            this.lblNumara.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(91, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(91, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Yazar Adı:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kitapkaydet.png");
            this.ımageList1.Images.SetKeyName(1, "silgi.png");
            this.ımageList1.Images.SetKeyName(2, "023_broom_clear_clean_tool-512.png");
            this.ımageList1.Images.SetKeyName(3, "magnifying-glass-1083378_960_720.png");
            this.ımageList1.Images.SetKeyName(4, "kitapsil.png");
            this.ımageList1.Images.SetKeyName(5, "kitapgeçmişi.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Location = new System.Drawing.Point(426, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Adı veya Barkod No";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.MistyRose;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAra.ImageKey = "magnifying-glass-1083378_960_720.png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(191, 16);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(57, 45);
            this.btnAra.TabIndex = 1;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtAra.Location = new System.Drawing.Point(37, 28);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(135, 33);
            this.txtAra.TabIndex = 0;
            this.txtAra.Tag = "asdsad";
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dataGVeri
            // 
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(94, 286);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(283, 128);
            this.dataGVeri.TabIndex = 2;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Crimson;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "silgi.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(442, 90);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 44);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEkleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEkleGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkleGuncelle.ImageKey = "kitapkaydet.png";
            this.btnEkleGuncelle.ImageList = this.ımageList1;
            this.btnEkleGuncelle.Location = new System.Drawing.Point(442, 34);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(140, 46);
            this.btnEkleGuncelle.TabIndex = 13;
            this.btnEkleGuncelle.Text = "Kaydet";
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "kitapsil.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(426, 286);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 83);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKitapGecmis
            // 
            this.btnKitapGecmis.BackColor = System.Drawing.Color.Aquamarine;
            this.btnKitapGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGecmis.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btnKitapGecmis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapGecmis.ImageKey = "kitapgeçmişi.png";
            this.btnKitapGecmis.ImageList = this.ımageList1;
            this.btnKitapGecmis.Location = new System.Drawing.Point(539, 286);
            this.btnKitapGecmis.Name = "btnKitapGecmis";
            this.btnKitapGecmis.Size = new System.Drawing.Size(75, 83);
            this.btnKitapGecmis.TabIndex = 17;
            this.btnKitapGecmis.Text = "Kitap Geçmişi";
            this.btnKitapGecmis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapGecmis.UseVisualStyleBackColor = false;
            this.btnKitapGecmis.Click += new System.EventHandler(this.btnKitapGecmis_Click);
            // 
            // frmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 424);
            this.Controls.Add(this.btnKitapGecmis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapSayfaSayisi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.txtKitapYayinEvi);
            this.Controls.Add(this.dpkitapYayinTarihi);
            this.Controls.Add(this.txtKitapAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Kitaplar";
            this.Load += new System.EventHandler(this.frmKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.DateTimePicker dpkitapYayinTarihi;
        private System.Windows.Forms.TextBox txtKitapYayinEvi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtKitapSayfaSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKitapGecmis;
    }
}