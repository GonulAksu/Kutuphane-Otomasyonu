namespace Kütüphane_Otomasyonu1
{
    partial class frmAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMANETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetÖgrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üYEİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakültelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapStokDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMANETToolStripMenuItem,
            this.kİTAPToolStripMenuItem,
            this.üYEİŞLEMLERİToolStripMenuItem,
            this.rAPORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMANETToolStripMenuItem
            // 
            this.eMANETToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emanetVerToolStripMenuItem,
            this.emanetÖgrenciToolStripMenuItem});
            this.eMANETToolStripMenuItem.Name = "eMANETToolStripMenuItem";
            this.eMANETToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.eMANETToolStripMenuItem.Text = "EMANET";
            this.eMANETToolStripMenuItem.Click += new System.EventHandler(this.adToolStripMenuItem_Click);
            // 
            // emanetVerToolStripMenuItem
            // 
            this.emanetVerToolStripMenuItem.Name = "emanetVerToolStripMenuItem";
            this.emanetVerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.emanetVerToolStripMenuItem.Text = "Emanet Ver";
            this.emanetVerToolStripMenuItem.Click += new System.EventHandler(this.emanetVerToolStripMenuItem_Click);
            // 
            // emanetÖgrenciToolStripMenuItem
            // 
            this.emanetÖgrenciToolStripMenuItem.Name = "emanetÖgrenciToolStripMenuItem";
            this.emanetÖgrenciToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.emanetÖgrenciToolStripMenuItem.Text = "Emanet-Ögrenci";
            this.emanetÖgrenciToolStripMenuItem.Click += new System.EventHandler(this.emanetogrenciToolStripMenuItem_Click);
            // 
            // kİTAPToolStripMenuItem
            // 
            this.kİTAPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem});
            this.kİTAPToolStripMenuItem.Name = "kİTAPToolStripMenuItem";
            this.kİTAPToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.kİTAPToolStripMenuItem.Text = "KİTAP";
            this.kİTAPToolStripMenuItem.Click += new System.EventHandler(this.KİTAPToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // üYEİŞLEMLERİToolStripMenuItem
            // 
            this.üYEİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ögrenciToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.fakültelerToolStripMenuItem});
            this.üYEİŞLEMLERİToolStripMenuItem.Name = "üYEİŞLEMLERİToolStripMenuItem";
            this.üYEİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.üYEİŞLEMLERİToolStripMenuItem.Text = "ÜYE İŞLEMLERİ";
            this.üYEİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.kullaniciToolStripMenuItem_Click);
            // 
            // ögrenciToolStripMenuItem
            // 
            this.ögrenciToolStripMenuItem.Name = "ögrenciToolStripMenuItem";
            this.ögrenciToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ögrenciToolStripMenuItem.Text = "Ögrenci";
            this.ögrenciToolStripMenuItem.Click += new System.EventHandler(this.ogrenciToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            this.bölümlerToolStripMenuItem.Click += new System.EventHandler(this.bolumlerToolStripMenuItem_Click);
            // 
            // fakültelerToolStripMenuItem
            // 
            this.fakültelerToolStripMenuItem.Name = "fakültelerToolStripMenuItem";
            this.fakültelerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fakültelerToolStripMenuItem.Text = "Fakülteler";
            this.fakültelerToolStripMenuItem.Click += new System.EventHandler(this.fakulltelerToolStripMenuItem_Click);
            // 
            // rAPORToolStripMenuItem
            // 
            this.rAPORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapStokDurumuToolStripMenuItem});
            this.rAPORToolStripMenuItem.Name = "rAPORToolStripMenuItem";
            this.rAPORToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rAPORToolStripMenuItem.Text = "RAPOR";
            this.rAPORToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // kitapStokDurumuToolStripMenuItem
            // 
            this.kitapStokDurumuToolStripMenuItem.Name = "kitapStokDurumuToolStripMenuItem";
            this.kitapStokDurumuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kitapStokDurumuToolStripMenuItem.Text = "Kitap Stok Durumu";
            this.kitapStokDurumuToolStripMenuItem.Click += new System.EventHandler(this.kitapStokDurumuToolStripMenuItem_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 433);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(91, 15);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 455);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAna";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMANETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetÖgrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üYEİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakültelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapStokDurumuToolStripMenuItem;
        private System.Windows.Forms.Label lblKullaniciAdi;
    }
}