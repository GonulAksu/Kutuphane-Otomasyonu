namespace Kütüphane_Otomasyonu1
{
    partial class frmEmanetVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmanetVer));
            this.btnOgrneciSec = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKitapSec = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.lblOgrenciSecim = new System.Windows.Forms.Label();
            this.lblKitapSecim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrneciSec
            // 
            this.btnOgrneciSec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOgrneciSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrneciSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOgrneciSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrneciSec.ImageKey = "emanetver1.jpg";
            this.btnOgrneciSec.ImageList = this.ımageList1;
            this.btnOgrneciSec.Location = new System.Drawing.Point(40, 30);
            this.btnOgrneciSec.Name = "btnOgrneciSec";
            this.btnOgrneciSec.Size = new System.Drawing.Size(172, 44);
            this.btnOgrneciSec.TabIndex = 0;
            this.btnOgrneciSec.Text = "Ögrenci Seç";
            this.btnOgrneciSec.UseVisualStyleBackColor = false;
            this.btnOgrneciSec.Click += new System.EventHandler(this.btnOgrneciSec_Click);
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
            // 
            // btnKitapSec
            // 
            this.btnKitapSec.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKitapSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnKitapSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapSec.ImageKey = "icono_2_entronizado.png";
            this.btnKitapSec.ImageList = this.ımageList1;
            this.btnKitapSec.Location = new System.Drawing.Point(40, 97);
            this.btnKitapSec.Name = "btnKitapSec";
            this.btnKitapSec.Size = new System.Drawing.Size(172, 44);
            this.btnKitapSec.TabIndex = 1;
            this.btnKitapSec.Text = "Kitap Seç";
            this.btnKitapSec.UseVisualStyleBackColor = false;
            this.btnKitapSec.Click += new System.EventHandler(this.btnKitapSec_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.Brown;
            this.btnEmanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageKey = "emanetver3.jpg";
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(40, 165);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(172, 45);
            this.btnEmanetVer.TabIndex = 2;
            this.btnEmanetVer.Text = "Emanet Ver";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // lblOgrenciSecim
            // 
            this.lblOgrenciSecim.AutoSize = true;
            this.lblOgrenciSecim.Location = new System.Drawing.Point(48, 81);
            this.lblOgrenciSecim.Name = "lblOgrenciSecim";
            this.lblOgrenciSecim.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciSecim.TabIndex = 3;
            // 
            // lblKitapSecim
            // 
            this.lblKitapSecim.AutoSize = true;
            this.lblKitapSecim.Location = new System.Drawing.Point(48, 149);
            this.lblKitapSecim.Name = "lblKitapSecim";
            this.lblKitapSecim.Size = new System.Drawing.Size(0, 13);
            this.lblKitapSecim.TabIndex = 4;
            // 
            // frmEmanetVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblKitapSecim);
            this.Controls.Add(this.lblOgrenciSecim);
            this.Controls.Add(this.btnEmanetVer);
            this.Controls.Add(this.btnKitapSec);
            this.Controls.Add(this.btnOgrneciSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmEmanetVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Ver";
            this.Load += new System.EventHandler(this.frmEmanetVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOgrneciSec;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Button btnKitapSec;
        private System.Windows.Forms.Button btnEmanetVer;
        public System.Windows.Forms.Label lblOgrenciSecim;
        public System.Windows.Forms.Label lblKitapSecim;
    }
}