namespace KGM_Misafirhane
{
    partial class YeniRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniRezervasyon));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList2 = new ImageList(components);
            btnCikis = new Button();
            txtBxAdSoyad = new TextBox();
            txtBxEmail = new TextBox();
            txtBxTelefon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbBxOdaNo = new ComboBox();
            cmbBxKat = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            dateTimeGiris = new DateTimePicker();
            dateTimeCikis = new DateTimePicker();
            txtBxUcret = new TextBox();
            label9 = new Label();
            btnHesapla = new Button();
            btnOnayla = new Button();
            label3 = new Label();
            cmbBxOdaTuru = new ComboBox();
            label10 = new Label();
            cmbBxYetiskinSayisi = new ComboBox();
            label11 = new Label();
            cmbBxCocukSayisi = new ComboBox();
            label12 = new Label();
            cmbBxMusteriTipi = new ComboBox();
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
            btnCikis.Location = new Point(740, 8);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(51, 51);
            btnCikis.TabIndex = 20;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // txtBxAdSoyad
            // 
            txtBxAdSoyad.BorderStyle = BorderStyle.None;
            txtBxAdSoyad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxAdSoyad.Location = new Point(253, 21);
            txtBxAdSoyad.Multiline = true;
            txtBxAdSoyad.Name = "txtBxAdSoyad";
            txtBxAdSoyad.Size = new Size(228, 29);
            txtBxAdSoyad.TabIndex = 1;
            // 
            // txtBxEmail
            // 
            txtBxEmail.BorderStyle = BorderStyle.None;
            txtBxEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxEmail.Location = new Point(253, 62);
            txtBxEmail.Multiline = true;
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(228, 29);
            txtBxEmail.TabIndex = 2;
            // 
            // txtBxTelefon
            // 
            txtBxTelefon.BorderStyle = BorderStyle.None;
            txtBxTelefon.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon.Location = new Point(253, 105);
            txtBxTelefon.Multiline = true;
            txtBxTelefon.Name = "txtBxTelefon";
            txtBxTelefon.Size = new Size(228, 29);
            txtBxTelefon.TabIndex = 3;
            txtBxTelefon.KeyPress += txtBxTelefon_KeyPress;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 104);
            label6.Name = "label6";
            label6.Size = new Size(225, 35);
            label6.TabIndex = 32;
            label6.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(116, 35);
            label5.TabIndex = 31;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(132, 35);
            label4.TabIndex = 30;
            label4.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 228);
            label2.Name = "label2";
            label2.Size = new Size(194, 34);
            label2.TabIndex = 40;
            label2.Text = "Çıkış Tarihi";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 187);
            label1.Name = "label1";
            label1.Size = new Size(195, 35);
            label1.TabIndex = 39;
            label1.Text = "Giriş Tarihi";
            // 
            // cmbBxOdaNo
            // 
            cmbBxOdaNo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxOdaNo.FormattingEnabled = true;
            cmbBxOdaNo.Location = new Point(253, 303);
            cmbBxOdaNo.Name = "cmbBxOdaNo";
            cmbBxOdaNo.Size = new Size(228, 33);
            cmbBxOdaNo.TabIndex = 11;
            cmbBxOdaNo.KeyPress += cmbBxOdaNo_KeyPress;
            // 
            // cmbBxKat
            // 
            cmbBxKat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxKat.FormattingEnabled = true;
            cmbBxKat.ItemHeight = 25;
            cmbBxKat.Location = new Point(253, 262);
            cmbBxKat.Name = "cmbBxKat";
            cmbBxKat.Size = new Size(228, 33);
            cmbBxKat.TabIndex = 10;
            cmbBxKat.SelectedIndexChanged += cmbBxKat_SelectedIndexChanged;
            cmbBxKat.KeyPress += cmbBxKat_KeyPress;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 267);
            label7.Name = "label7";
            label7.Size = new Size(154, 34);
            label7.TabIndex = 41;
            label7.Text = "Kat No:";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 306);
            label8.Name = "label8";
            label8.Size = new Size(143, 34);
            label8.TabIndex = 42;
            label8.Text = "Oda No:";
            // 
            // dateTimeGiris
            // 
            dateTimeGiris.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeGiris.Format = DateTimePickerFormat.Short;
            dateTimeGiris.Location = new Point(253, 189);
            dateTimeGiris.Name = "dateTimeGiris";
            dateTimeGiris.Size = new Size(228, 26);
            dateTimeGiris.TabIndex = 8;
            dateTimeGiris.ValueChanged += dateTimeGiris_ValueChanged;
            // 
            // dateTimeCikis
            // 
            dateTimeCikis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeCikis.Format = DateTimePickerFormat.Short;
            dateTimeCikis.Location = new Point(253, 225);
            dateTimeCikis.Name = "dateTimeCikis";
            dateTimeCikis.Size = new Size(228, 26);
            dateTimeCikis.TabIndex = 9;
            dateTimeCikis.ValueChanged += dateTimeCikis_ValueChanged;
            // 
            // txtBxUcret
            // 
            txtBxUcret.BorderStyle = BorderStyle.None;
            txtBxUcret.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUcret.Location = new Point(638, 303);
            txtBxUcret.Multiline = true;
            txtBxUcret.Name = "txtBxUcret";
            txtBxUcret.Size = new Size(124, 29);
            txtBxUcret.TabIndex = 46;
            txtBxUcret.TextAlign = HorizontalAlignment.Center;
            txtBxUcret.KeyPress += txtBxUcret_KeyPress;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(655, 265);
            label9.Name = "label9";
            label9.Size = new Size(86, 35);
            label9.TabIndex = 45;
            label9.Text = "Ücret:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Yellow;
            btnHesapla.FlatAppearance.BorderSize = 0;
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHesapla.Location = new Point(487, 285);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(135, 34);
            btnHesapla.TabIndex = 12;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Lime;
            btnOnayla.FlatAppearance.BorderSize = 0;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.Location = new Point(298, 350);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(135, 34);
            btnOnayla.TabIndex = 13;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(130, 35);
            label3.TabIndex = 50;
            label3.Text = "Oda Türü:";
            // 
            // cmbBxOdaTuru
            // 
            cmbBxOdaTuru.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxOdaTuru.FormattingEnabled = true;
            cmbBxOdaTuru.Location = new Point(253, 145);
            cmbBxOdaTuru.Name = "cmbBxOdaTuru";
            cmbBxOdaTuru.Size = new Size(228, 33);
            cmbBxOdaTuru.TabIndex = 4;
            cmbBxOdaTuru.SelectedIndexChanged += cmbBxOdaTuru_SelectedIndexChanged;
            cmbBxOdaTuru.KeyPress += cmbBxOdaTuru_KeyPress;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(488, 122);
            label10.Name = "label10";
            label10.Size = new Size(178, 35);
            label10.TabIndex = 54;
            label10.Text = "Yetişkin Sayısı:";
            // 
            // cmbBxYetiskinSayisi
            // 
            cmbBxYetiskinSayisi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxYetiskinSayisi.FormattingEnabled = true;
            cmbBxYetiskinSayisi.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbBxYetiskinSayisi.Location = new Point(663, 122);
            cmbBxYetiskinSayisi.Name = "cmbBxYetiskinSayisi";
            cmbBxYetiskinSayisi.Size = new Size(128, 33);
            cmbBxYetiskinSayisi.TabIndex = 5;
            cmbBxYetiskinSayisi.KeyPress += cmbBxYetiskinSayisi_KeyPress;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(487, 164);
            label11.Name = "label11";
            label11.Size = new Size(168, 35);
            label11.TabIndex = 52;
            label11.Text = "Çocuk Sayısı:";
            // 
            // cmbBxCocukSayisi
            // 
            cmbBxCocukSayisi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxCocukSayisi.FormattingEnabled = true;
            cmbBxCocukSayisi.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cmbBxCocukSayisi.Location = new Point(663, 164);
            cmbBxCocukSayisi.Name = "cmbBxCocukSayisi";
            cmbBxCocukSayisi.Size = new Size(128, 33);
            cmbBxCocukSayisi.TabIndex = 6;
            cmbBxCocukSayisi.KeyPress += cmbBxCocukSayisi_KeyPress;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(487, 207);
            label12.Name = "label12";
            label12.Size = new Size(168, 35);
            label12.TabIndex = 56;
            label12.Text = "Müşteri Tipi:";
            // 
            // cmbBxMusteriTipi
            // 
            cmbBxMusteriTipi.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMusteriTipi.FormattingEnabled = true;
            cmbBxMusteriTipi.Items.AddRange(new object[] { "Memur", "Sivil" });
            cmbBxMusteriTipi.Location = new Point(663, 207);
            cmbBxMusteriTipi.Name = "cmbBxMusteriTipi";
            cmbBxMusteriTipi.Size = new Size(128, 33);
            cmbBxMusteriTipi.TabIndex = 7;
            cmbBxMusteriTipi.KeyPress += cmbBxOdaSayisi_KeyPress;
            // 
            // YeniRezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(800, 404);
            Controls.Add(label12);
            Controls.Add(cmbBxMusteriTipi);
            Controls.Add(cmbBxYetiskinSayisi);
            Controls.Add(label11);
            Controls.Add(cmbBxCocukSayisi);
            Controls.Add(label3);
            Controls.Add(cmbBxOdaTuru);
            Controls.Add(btnOnayla);
            Controls.Add(btnHesapla);
            Controls.Add(txtBxUcret);
            Controls.Add(label9);
            Controls.Add(dateTimeCikis);
            Controls.Add(dateTimeGiris);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBxOdaNo);
            Controls.Add(cmbBxKat);
            Controls.Add(txtBxAdSoyad);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxTelefon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCikis);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YeniRezervasyon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniRezervasyon";
            Load += YeniRezervasyon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList2;
        private TextBox txtBxAdSoyad;
        private TextBox txtBxEmail;
        private TextBox txtBxTelefon;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbBxOdaNo;
        private ComboBox cmbBxKat;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimeCikis;
        private DateTimePicker dateTimeGiris;
        private TextBox txtBxUcret;
        private Label label9;
        private Button btnHesapla;
        private Button btnOnayla;
        private Label label3;
        private ComboBox cmbBxOdaTuru;
        private Label label10;
        private ComboBox cmbBxYetiskinSayisi;
        private Label label11;
        private ComboBox cmbBxCocukSayisi;
        private Label label12;
        private ComboBox cmbBxMusteriTipi;
    }
}