namespace KGM_Misafirhane
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnCikis = new Button();
            ımageList2 = new ImageList(components);
            btnImg = new Button();
            ımageList1 = new ImageList(components);
            btnOdalar = new Button();
            btnRaporlar = new Button();
            btnRezervasyonlar = new Button();
            dateTarih2 = new DateTimePicker();
            btnGoster = new Button();
            lstViewRezervasyonlar = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            btnYazdir1 = new Button();
            ımageList3 = new ImageList(components);
            dateTarih1 = new DateTimePicker();
            btnKayitliMusteriler = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
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
            btnCikis.TabIndex = 4;
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
            // btnImg
            // 
            btnImg.FlatAppearance.BorderSize = 0;
            btnImg.FlatStyle = FlatStyle.Flat;
            btnImg.ImageIndex = 1;
            btnImg.ImageList = ımageList1;
            btnImg.Location = new Point(-4, -4);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(135, 131);
            btnImg.TabIndex = 3;
            btnImg.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "kgm_logo.png");
            ımageList1.Images.SetKeyName(1, "KGM_logo.svg.png");
            // 
            // btnOdalar
            // 
            btnOdalar.BackColor = Color.Yellow;
            btnOdalar.FlatAppearance.BorderSize = 0;
            btnOdalar.FlatStyle = FlatStyle.Flat;
            btnOdalar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdalar.Location = new Point(453, 12);
            btnOdalar.Name = "btnOdalar";
            btnOdalar.Size = new Size(220, 45);
            btnOdalar.TabIndex = 10;
            btnOdalar.Text = "Odalar";
            btnOdalar.UseVisualStyleBackColor = false;
            btnOdalar.Click += btnOdalar_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.DarkOrange;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Popup;
            btnRaporlar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaporlar.Location = new Point(679, 12);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(220, 45);
            btnRaporlar.TabIndex = 9;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            // 
            // btnRezervasyonlar
            // 
            btnRezervasyonlar.BackColor = Color.Yellow;
            btnRezervasyonlar.FlatAppearance.BorderSize = 0;
            btnRezervasyonlar.FlatStyle = FlatStyle.Flat;
            btnRezervasyonlar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRezervasyonlar.Location = new Point(227, 12);
            btnRezervasyonlar.Name = "btnRezervasyonlar";
            btnRezervasyonlar.Size = new Size(220, 45);
            btnRezervasyonlar.TabIndex = 8;
            btnRezervasyonlar.Text = "Rezervasyonlar";
            btnRezervasyonlar.UseVisualStyleBackColor = false;
            btnRezervasyonlar.Click += btnRezervasyonlar_Click;
            // 
            // dateTarih2
            // 
            dateTarih2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTarih2.Format = DateTimePickerFormat.Custom;
            dateTarih2.Location = new Point(668, 86);
            dateTarih2.Name = "dateTarih2";
            dateTarih2.Size = new Size(218, 35);
            dateTarih2.TabIndex = 11;
            // 
            // btnGoster
            // 
            btnGoster.BackColor = Color.Chartreuse;
            btnGoster.FlatAppearance.BorderSize = 0;
            btnGoster.FlatStyle = FlatStyle.Flat;
            btnGoster.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoster.Location = new Point(560, 127);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(208, 40);
            btnGoster.TabIndex = 16;
            btnGoster.Text = "Görüntüle";
            btnGoster.UseVisualStyleBackColor = false;
            btnGoster.Click += btnGoster_Click;
            // 
            // lstViewRezervasyonlar
            // 
            lstViewRezervasyonlar.BorderStyle = BorderStyle.None;
            lstViewRezervasyonlar.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lstViewRezervasyonlar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewRezervasyonlar.Location = new Point(8, 173);
            lstViewRezervasyonlar.Name = "lstViewRezervasyonlar";
            lstViewRezervasyonlar.Size = new Size(1282, 470);
            lstViewRezervasyonlar.TabIndex = 17;
            lstViewRezervasyonlar.UseCompatibleStateImageBehavior = false;
            lstViewRezervasyonlar.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Müşteri Adı";
            columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kat";
            columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Oda No";
            columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Giriş Tarihi";
            columnHeader7.Width = 230;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Çıkış Tarihi";
            columnHeader8.Width = 230;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Rezervasyon Durumu";
            columnHeader10.Width = 280;
            // 
            // btnYazdir1
            // 
            btnYazdir1.BackColor = Color.DarkSeaGreen;
            btnYazdir1.FlatAppearance.BorderSize = 0;
            btnYazdir1.FlatStyle = FlatStyle.Flat;
            btnYazdir1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYazdir1.ImageIndex = 0;
            btnYazdir1.ImageList = ımageList3;
            btnYazdir1.Location = new Point(1215, 112);
            btnYazdir1.Name = "btnYazdir1";
            btnYazdir1.Size = new Size(75, 55);
            btnYazdir1.TabIndex = 19;
            btnYazdir1.UseVisualStyleBackColor = false;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "pngwing.com (8).png");
            // 
            // dateTarih1
            // 
            dateTarih1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTarih1.Format = DateTimePickerFormat.Custom;
            dateTarih1.Location = new Point(443, 86);
            dateTarih1.Name = "dateTarih1";
            dateTarih1.Size = new Size(218, 35);
            dateTarih1.TabIndex = 21;
            // 
            // btnKayitliMusteriler
            // 
            btnKayitliMusteriler.BackColor = Color.Yellow;
            btnKayitliMusteriler.FlatAppearance.BorderSize = 0;
            btnKayitliMusteriler.FlatStyle = FlatStyle.Flat;
            btnKayitliMusteriler.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitliMusteriler.Location = new Point(905, 13);
            btnKayitliMusteriler.Name = "btnKayitliMusteriler";
            btnKayitliMusteriler.Size = new Size(220, 45);
            btnKayitliMusteriler.TabIndex = 22;
            btnKayitliMusteriler.Text = "Kayıtlı Müşteriler";
            btnKayitliMusteriler.UseVisualStyleBackColor = false;
            btnKayitliMusteriler.Click += btnKayitliMusteriler_Click;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1300, 650);
            Controls.Add(btnKayitliMusteriler);
            Controls.Add(dateTarih1);
            Controls.Add(btnYazdir1);
            Controls.Add(lstViewRezervasyonlar);
            Controls.Add(btnGoster);
            Controls.Add(dateTarih2);
            Controls.Add(btnOdalar);
            Controls.Add(btnRaporlar);
            Controls.Add(btnRezervasyonlar);
            Controls.Add(btnCikis);
            Controls.Add(btnImg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Raporlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList2;
        private Button btnImg;
        private ImageList ımageList1;
        private Button btnOdalar;
        private Button btnRaporlar;
        private Button btnRezervasyonlar;
        private DateTimePicker dateTarih2;
        private Button btnGoster;
        private ListView lstViewRezervasyonlar;
        private ImageList ımageList3;
        private Button btnYazdir1;
        private DateTimePicker dateTarih1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button btnKayitliMusteriler;
    }
}