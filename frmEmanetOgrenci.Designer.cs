namespace Kütüphane_Otomasyonu1
{
    partial class frmEmanetOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmanetOgrenci));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRaporGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKitapSecim = new System.Windows.Forms.Label();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.btnKitapSec = new System.Windows.Forms.Button();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.btnOgrneciSec = new System.Windows.Forms.Button();
            this.btn_iadeAl = new System.Windows.Forms.Button();
            this.lblOgrenciSecim = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "emanetver1.jpg");
            this.ımageList1.Images.SetKeyName(1, "kisspng-computer-icons-east-tennessee-state-university-stu-graduate-male-icon-5ab" +
        "09611d89da2.1071787515215221938873.jpg");
            this.ımageList1.Images.SetKeyName(2, "icono_2_entronizado.png");
            this.ımageList1.Images.SetKeyName(3, "emanetver3.jpg");
            this.ımageList1.Images.SetKeyName(4, "icone-école-png-4.png");
            // 
            // btnRaporGetir
            // 
            this.btnRaporGetir.BackColor = System.Drawing.Color.Crimson;
            this.btnRaporGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnRaporGetir.Location = new System.Drawing.Point(12, 112);
            this.btnRaporGetir.Name = "btnRaporGetir";
            this.btnRaporGetir.Size = new System.Drawing.Size(161, 36);
            this.btnRaporGetir.TabIndex = 1;
            this.btnRaporGetir.Text = "Rapor Getir";
            this.btnRaporGetir.UseVisualStyleBackColor = false;
            this.btnRaporGetir.Click += new System.EventHandler(this.btnRaporGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKitapSecim);
            this.groupBox1.Controls.Add(this.btnEmanetVer);
            this.groupBox1.Controls.Add(this.btnKitapSec);
            this.groupBox1.Location = new System.Drawing.Point(211, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Verme İslemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblKitapSecim
            // 
            this.lblKitapSecim.AutoSize = true;
            this.lblKitapSecim.Location = new System.Drawing.Point(6, 68);
            this.lblKitapSecim.Name = "lblKitapSecim";
            this.lblKitapSecim.Size = new System.Drawing.Size(35, 13);
            this.lblKitapSecim.TabIndex = 4;
            this.lblKitapSecim.Text = "label1";
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.Thistle;
            this.btnEmanetVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageKey = "emanetver3.jpg";
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(0, 84);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(161, 36);
            this.btnEmanetVer.TabIndex = 1;
            this.btnEmanetVer.Text = "Emanet Ver";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // btnKitapSec
            // 
            this.btnKitapSec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKitapSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnKitapSec.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnKitapSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapSec.ImageKey = "icono_2_entronizado.png";
            this.btnKitapSec.ImageList = this.ımageList1;
            this.btnKitapSec.Location = new System.Drawing.Point(6, 19);
            this.btnKitapSec.Name = "btnKitapSec";
            this.btnKitapSec.Size = new System.Drawing.Size(161, 36);
            this.btnKitapSec.TabIndex = 0;
            this.btnKitapSec.Text = "Kitap Seç";
            this.btnKitapSec.UseVisualStyleBackColor = false;
            this.btnKitapSec.Click += new System.EventHandler(this.btnKitapSec_Click);
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(12, 175);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(391, 150);
            this.dataGVeri.TabIndex = 2;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            // 
            // btnOgrneciSec
            // 
            this.btnOgrneciSec.BackColor = System.Drawing.Color.Plum;
            this.btnOgrneciSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOgrneciSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrneciSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOgrneciSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrneciSec.ImageKey = "kisspng-computer-icons-east-tennessee-state-university-stu-graduate-male-icon-5ab" +
    "09611d89da2.1071787515215221938873.jpg";
            this.btnOgrneciSec.ImageList = this.ımageList1;
            this.btnOgrneciSec.Location = new System.Drawing.Point(12, 47);
            this.btnOgrneciSec.Name = "btnOgrneciSec";
            this.btnOgrneciSec.Size = new System.Drawing.Size(161, 36);
            this.btnOgrneciSec.TabIndex = 0;
            this.btnOgrneciSec.Text = "Ögrenci Seç";
            this.btnOgrneciSec.UseVisualStyleBackColor = false;
            this.btnOgrneciSec.Click += new System.EventHandler(this.btnOgrneciSec_Click);
            // 
            // btn_iadeAl
            // 
            this.btn_iadeAl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_iadeAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iadeAl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btn_iadeAl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_iadeAl.ImageKey = "icone-école-png-4.png";
            this.btn_iadeAl.ImageList = this.ımageList1;
            this.btn_iadeAl.Location = new System.Drawing.Point(409, 175);
            this.btn_iadeAl.Name = "btn_iadeAl";
            this.btn_iadeAl.Size = new System.Drawing.Size(49, 150);
            this.btn_iadeAl.TabIndex = 3;
            this.btn_iadeAl.Text = "İ ADE";
            this.btn_iadeAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_iadeAl.UseVisualStyleBackColor = false;
            this.btn_iadeAl.Click += new System.EventHandler(this.btn_iadeAl_Click);
            // 
            // lblOgrenciSecim
            // 
            this.lblOgrenciSecim.AutoSize = true;
            this.lblOgrenciSecim.Location = new System.Drawing.Point(12, 87);
            this.lblOgrenciSecim.Name = "lblOgrenciSecim";
            this.lblOgrenciSecim.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciSecim.TabIndex = 5;
            // 
            // frmEmanetOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 337);
            this.Controls.Add(this.lblOgrenciSecim);
            this.Controls.Add(this.btn_iadeAl);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRaporGetir);
            this.Controls.Add(this.btnOgrneciSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmEmanetOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Ogrenci";
            this.Load += new System.EventHandler(this.frmEmanetOgrenci_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOgrneciSec;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Button btnRaporGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnKitapSec;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.DataGridView dataGVeri;
        public System.Windows.Forms.Button btn_iadeAl;
        public System.Windows.Forms.Label lblOgrenciSecim;
        public System.Windows.Forms.Label lblKitapSecim;
    }
}