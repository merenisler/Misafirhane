namespace KGM_Misafirhane
{
    partial class KayitliMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitliMusteriler));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList2 = new ImageList(components);
            btnCikis = new Button();
            ımageList1 = new ImageList(components);
            btnImg = new Button();
            btnKayitliMusteriler = new Button();
            btnOdalar = new Button();
            btnRaporlar = new Button();
            btnRezervasyonlar = new Button();
            lstViewAd = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtBxAdSoyad = new TextBox();
            txtBxEmail = new TextBox();
            txtBxTelefon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            cmbBxMusteriTipi = new ComboBox();
            btnGuncelle = new Button();
            btnYeniRezervasyon = new Button();
            label2 = new Label();
            btnMailGonder = new Button();
            lstViewMusteriBilgileri = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "pngwing.com (9).png");
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
            btnCikis.TabIndex = 5;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
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
            btnImg.Location = new Point(-4, -4);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(135, 131);
            btnImg.TabIndex = 6;
            btnImg.UseVisualStyleBackColor = true;
            // 
            // btnKayitliMusteriler
            // 
            btnKayitliMusteriler.BackColor = Color.DarkOrange;
            btnKayitliMusteriler.FlatStyle = FlatStyle.Popup;
            btnKayitliMusteriler.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitliMusteriler.Location = new Point(896, 12);
            btnKayitliMusteriler.Name = "btnKayitliMusteriler";
            btnKayitliMusteriler.Size = new Size(220, 45);
            btnKayitliMusteriler.TabIndex = 26;
            btnKayitliMusteriler.Text = "Kayıtlı Müşteriler";
            btnKayitliMusteriler.UseVisualStyleBackColor = false;
            // 
            // btnOdalar
            // 
            btnOdalar.BackColor = Color.Yellow;
            btnOdalar.FlatAppearance.BorderSize = 0;
            btnOdalar.FlatStyle = FlatStyle.Flat;
            btnOdalar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdalar.Location = new Point(444, 12);
            btnOdalar.Name = "btnOdalar";
            btnOdalar.Size = new Size(220, 45);
            btnOdalar.TabIndex = 25;
            btnOdalar.Text = "Odalar";
            btnOdalar.UseVisualStyleBackColor = false;
            btnOdalar.Click += btnOdalar_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Yellow;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaporlar.Location = new Point(670, 12);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(220, 45);
            btnRaporlar.TabIndex = 24;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnRezervasyonlar
            // 
            btnRezervasyonlar.BackColor = Color.Yellow;
            btnRezervasyonlar.FlatAppearance.BorderSize = 0;
            btnRezervasyonlar.FlatStyle = FlatStyle.Flat;
            btnRezervasyonlar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRezervasyonlar.Location = new Point(218, 12);
            btnRezervasyonlar.Name = "btnRezervasyonlar";
            btnRezervasyonlar.Size = new Size(220, 45);
            btnRezervasyonlar.TabIndex = 23;
            btnRezervasyonlar.Text = "Rezervasyonlar";
            btnRezervasyonlar.UseVisualStyleBackColor = false;
            btnRezervasyonlar.Click += btnRezervasyonlar_Click;
            // 
            // lstViewAd
            // 
            lstViewAd.BorderStyle = BorderStyle.None;
            lstViewAd.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewAd.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewAd.FullRowSelect = true;
            lstViewAd.Location = new Point(12, 133);
            lstViewAd.Name = "lstViewAd";
            lstViewAd.RightToLeft = RightToLeft.No;
            lstViewAd.Size = new Size(340, 505);
            lstViewAd.TabIndex = 27;
            lstViewAd.UseCompatibleStateImageBehavior = false;
            lstViewAd.View = View.Details;
            lstViewAd.SelectedIndexChanged += lstViewOdalar_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad Soyad";
            columnHeader1.Width = 305;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "id";
            columnHeader2.Width = 1;
            // 
            // txtBxAdSoyad
            // 
            txtBxAdSoyad.BorderStyle = BorderStyle.None;
            txtBxAdSoyad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdSoyad.Location = new Point(607, 273);
            txtBxAdSoyad.Multiline = true;
            txtBxAdSoyad.Name = "txtBxAdSoyad";
            txtBxAdSoyad.Size = new Size(247, 29);
            txtBxAdSoyad.TabIndex = 33;
            // 
            // txtBxEmail
            // 
            txtBxEmail.BorderStyle = BorderStyle.None;
            txtBxEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxEmail.Location = new Point(607, 314);
            txtBxEmail.Multiline = true;
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(247, 29);
            txtBxEmail.TabIndex = 32;
            // 
            // txtBxTelefon
            // 
            txtBxTelefon.BorderStyle = BorderStyle.None;
            txtBxTelefon.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon.Location = new Point(607, 355);
            txtBxTelefon.Multiline = true;
            txtBxTelefon.Name = "txtBxTelefon";
            txtBxTelefon.Size = new Size(247, 29);
            txtBxTelefon.TabIndex = 31;
            txtBxTelefon.KeyPress += txtBxTelefon_KeyPress;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(366, 354);
            label6.Name = "label6";
            label6.Size = new Size(225, 35);
            label6.TabIndex = 30;
            label6.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(366, 314);
            label5.Name = "label5";
            label5.Size = new Size(116, 35);
            label5.TabIndex = 29;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(366, 273);
            label4.Name = "label4";
            label4.Size = new Size(132, 35);
            label4.TabIndex = 28;
            label4.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 396);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 48;
            label1.Text = "Müşteri Tipi:";
            // 
            // cmbBxMusteriTipi
            // 
            cmbBxMusteriTipi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMusteriTipi.FormattingEnabled = true;
            cmbBxMusteriTipi.Location = new Point(607, 397);
            cmbBxMusteriTipi.Name = "cmbBxMusteriTipi";
            cmbBxMusteriTipi.Size = new Size(247, 33);
            cmbBxMusteriTipi.TabIndex = 47;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Lime;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(607, 436);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(247, 39);
            btnGuncelle.TabIndex = 49;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnYeniRezervasyon
            // 
            btnYeniRezervasyon.BackColor = SystemColors.Highlight;
            btnYeniRezervasyon.FlatAppearance.BorderSize = 0;
            btnYeniRezervasyon.FlatStyle = FlatStyle.Flat;
            btnYeniRezervasyon.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniRezervasyon.ForeColor = Color.White;
            btnYeniRezervasyon.Location = new Point(607, 481);
            btnYeniRezervasyon.Name = "btnYeniRezervasyon";
            btnYeniRezervasyon.Size = new Size(247, 37);
            btnYeniRezervasyon.TabIndex = 50;
            btnYeniRezervasyon.Text = "Yeni Rezervasyon Oluştur";
            btnYeniRezervasyon.UseVisualStyleBackColor = false;
            btnYeniRezervasyon.Click += btnYeniRezervasyon_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(896, 92);
            label2.Name = "label2";
            label2.Size = new Size(392, 35);
            label2.TabIndex = 51;
            label2.Text = "En Son Rezervasyon Bilgileri:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMailGonder
            // 
            btnMailGonder.BackColor = Color.OliveDrab;
            btnMailGonder.FlatAppearance.BorderSize = 0;
            btnMailGonder.FlatStyle = FlatStyle.Flat;
            btnMailGonder.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMailGonder.ForeColor = Color.White;
            btnMailGonder.Location = new Point(178, 90);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(174, 37);
            btnMailGonder.TabIndex = 56;
            btnMailGonder.Text = "Mail Gönder";
            btnMailGonder.UseVisualStyleBackColor = false;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // lstViewMusteriBilgileri
            // 
            lstViewMusteriBilgileri.BorderStyle = BorderStyle.None;
            lstViewMusteriBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lstViewMusteriBilgileri.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewMusteriBilgileri.FullRowSelect = true;
            lstViewMusteriBilgileri.Location = new Point(896, 133);
            lstViewMusteriBilgileri.Name = "lstViewMusteriBilgileri";
            lstViewMusteriBilgileri.Size = new Size(392, 505);
            lstViewMusteriBilgileri.TabIndex = 57;
            lstViewMusteriBilgileri.UseCompatibleStateImageBehavior = false;
            lstViewMusteriBilgileri.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = " ";
            columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Rezervasyon Bilgileri";
            columnHeader5.Width = 195;
            // 
            // KayitliMusteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1300, 650);
            Controls.Add(lstViewMusteriBilgileri);
            Controls.Add(btnMailGonder);
            Controls.Add(label2);
            Controls.Add(btnYeniRezervasyon);
            Controls.Add(btnGuncelle);
            Controls.Add(label1);
            Controls.Add(cmbBxMusteriTipi);
            Controls.Add(txtBxAdSoyad);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxTelefon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstViewAd);
            Controls.Add(btnKayitliMusteriler);
            Controls.Add(btnOdalar);
            Controls.Add(btnRaporlar);
            Controls.Add(btnRezervasyonlar);
            Controls.Add(btnImg);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "KayitliMusteriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayitliMusteriler";
            Load += KayitliMusteriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList2;
        private Button btnImg;
        private ImageList ımageList1;
        private Button btnKayitliMusteriler;
        private Button btnOdalar;
        private Button btnRaporlar;
        private Button btnRezervasyonlar;
        private ListView lstViewAd;
        private ColumnHeader columnHeader1;
        private TextBox txtBxAdSoyad;
        private TextBox txtBxEmail;
        private TextBox txtBxTelefon;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private ComboBox cmbBxMusteriTipi;
        private Button btnGuncelle;
        private Button btnYeniRezervasyon;
        private Label label2;
        private Button btnMailGonder;
        public ListView lstViewMusteriBilgileri;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
    }
}