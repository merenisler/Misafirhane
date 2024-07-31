namespace KGM_Misafirhane
{
    partial class Giris
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList1 = new ImageList(components);
            btnImg = new Button();
            btnCikis = new Button();
            ımageList2 = new ImageList(components);
            txtBxKullaniciAdi = new TextBox();
            txtBxSifre = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "kgm_logo.png");
            ımageList1.Images.SetKeyName(1, "KGM_logo.svg.png");
            // 
            // btnImg
            // 
            btnImg.FlatAppearance.BorderSize = 0;
            btnImg.FlatStyle = FlatStyle.Flat;
            btnImg.ImageIndex = 1;
            btnImg.ImageList = ımageList1;
            btnImg.Location = new Point(2, 2);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(135, 131);
            btnImg.TabIndex = 1;
            btnImg.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList2;
            btnCikis.Location = new Point(1221, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(67, 58);
            btnCikis.TabIndex = 2;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "pngwing.com (9).png");
            // 
            // txtBxKullaniciAdi
            // 
            txtBxKullaniciAdi.BorderStyle = BorderStyle.None;
            txtBxKullaniciAdi.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxKullaniciAdi.Location = new Point(475, 283);
            txtBxKullaniciAdi.Multiline = true;
            txtBxKullaniciAdi.Name = "txtBxKullaniciAdi";
            txtBxKullaniciAdi.Size = new Size(260, 40);
            txtBxKullaniciAdi.TabIndex = 3;
            txtBxKullaniciAdi.TextAlign = HorizontalAlignment.Center;
            txtBxKullaniciAdi.KeyPress += txtBxKullaniciAdi_KeyPress;
            // 
            // txtBxSifre
            // 
            txtBxSifre.BorderStyle = BorderStyle.None;
            txtBxSifre.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxSifre.Location = new Point(475, 327);
            txtBxSifre.Multiline = true;
            txtBxSifre.Name = "txtBxSifre";
            txtBxSifre.PasswordChar = '*';
            txtBxSifre.Size = new Size(260, 40);
            txtBxSifre.TabIndex = 4;
            txtBxSifre.TextAlign = HorizontalAlignment.Center;
            txtBxSifre.KeyPress += txtBxSifre_KeyPress;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Lime;
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(741, 297);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(132, 55);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1300, 650);
            Controls.Add(btnGirisYap);
            Controls.Add(txtBxSifre);
            Controls.Add(txtBxKullaniciAdi);
            Controls.Add(btnCikis);
            Controls.Add(btnImg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += Giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ImageList ımageList1;
        private Button btnImg;
        private Button btnCikis;
        private ImageList ımageList2;
        private Button btnGirisYap;
        private TextBox txtBxSifre;
        private TextBox txtBxKullaniciAdi;
    }
}