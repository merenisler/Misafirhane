namespace KGM_Misafirhane
{
    partial class Odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odalar));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnCikis = new Button();
            ımageList2 = new ImageList(components);
            btnImg = new Button();
            ımageList1 = new ImageList(components);
            btnOdalar = new Button();
            btnRaporlar = new Button();
            btnRezervasyonlar = new Button();
            btnTumOdalar = new Button();
            lstViewOdalar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnSureyiUzalt = new Button();
            cmbxSüreyiAzalt = new ComboBox();
            cmbxSüreyiUzat = new ComboBox();
            btnSureyiAzalt = new Button();
            btnOde = new Button();
            cmbBxOde = new ComboBox();
            btnIptalEt = new Button();
            cmbBxIptaEt = new ComboBox();
            btnMusteriBilgileri = new Button();
            cmbBxMusteriBilgileri = new ComboBox();
            btnDoluOdalar = new Button();
            btnBosOdalar = new Button();
            lstViewMusteriBilgileri = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            Timer1 = new System.Windows.Forms.Timer(components);
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
            btnOdalar.BackColor = Color.DarkOrange;
            btnOdalar.FlatAppearance.BorderSize = 0;
            btnOdalar.FlatStyle = FlatStyle.Popup;
            btnOdalar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdalar.Location = new Point(453, 13);
            btnOdalar.Name = "btnOdalar";
            btnOdalar.Size = new Size(220, 45);
            btnOdalar.TabIndex = 10;
            btnOdalar.Text = "Odalar";
            btnOdalar.UseVisualStyleBackColor = false;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Yellow;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaporlar.Location = new Point(679, 12);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(220, 45);
            btnRaporlar.TabIndex = 9;
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
            btnRezervasyonlar.Location = new Point(227, 12);
            btnRezervasyonlar.Name = "btnRezervasyonlar";
            btnRezervasyonlar.Size = new Size(220, 45);
            btnRezervasyonlar.TabIndex = 8;
            btnRezervasyonlar.Text = "Rezervasyonlar";
            btnRezervasyonlar.UseVisualStyleBackColor = false;
            btnRezervasyonlar.Click += btnRezervasyonlar_Click;
            // 
            // btnTumOdalar
            // 
            btnTumOdalar.BackColor = Color.Chartreuse;
            btnTumOdalar.FlatAppearance.BorderSize = 0;
            btnTumOdalar.FlatStyle = FlatStyle.Flat;
            btnTumOdalar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTumOdalar.Location = new Point(12, 156);
            btnTumOdalar.Name = "btnTumOdalar";
            btnTumOdalar.Size = new Size(257, 40);
            btnTumOdalar.TabIndex = 15;
            btnTumOdalar.Text = "Tüm Odaları Görüntüle";
            btnTumOdalar.UseVisualStyleBackColor = false;
            btnTumOdalar.Click += btnTumOdalar_Click;
            // 
            // lstViewOdalar
            // 
            lstViewOdalar.BorderStyle = BorderStyle.None;
            lstViewOdalar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstViewOdalar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewOdalar.FullRowSelect = true;
            lstViewOdalar.Location = new Point(12, 202);
            lstViewOdalar.Name = "lstViewOdalar";
            lstViewOdalar.Size = new Size(301, 436);
            lstViewOdalar.TabIndex = 16;
            lstViewOdalar.UseCompatibleStateImageBehavior = false;
            lstViewOdalar.View = View.Details;
            lstViewOdalar.SelectedIndexChanged += lstViewOdalar_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kat";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Oda No";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Oda Durumu";
            columnHeader3.Width = 137;
            // 
            // btnSureyiUzalt
            // 
            btnSureyiUzalt.BackColor = Color.Aquamarine;
            btnSureyiUzalt.FlatAppearance.BorderSize = 0;
            btnSureyiUzalt.FlatStyle = FlatStyle.Flat;
            btnSureyiUzalt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSureyiUzalt.Location = new Point(1054, 258);
            btnSureyiUzalt.Name = "btnSureyiUzalt";
            btnSureyiUzalt.Size = new Size(160, 33);
            btnSureyiUzalt.TabIndex = 21;
            btnSureyiUzalt.Text = "Süreyi Uzat";
            btnSureyiUzalt.UseVisualStyleBackColor = false;
            btnSureyiUzalt.Click += btnSureyiUzalt_Click;
            // 
            // cmbxSüreyiAzalt
            // 
            cmbxSüreyiAzalt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbxSüreyiAzalt.FormattingEnabled = true;
            cmbxSüreyiAzalt.Items.AddRange(new object[] { "1 Gün", "2 Gün", "3 Gün", "4 Gün", "5 Gün", "6 Gün", "1 Hafta", "2 Hafta", "3 Hafta", "1 Ay", "2 Ay", "3 Ay" });
            cmbxSüreyiAzalt.Location = new Point(856, 330);
            cmbxSüreyiAzalt.Name = "cmbxSüreyiAzalt";
            cmbxSüreyiAzalt.Size = new Size(168, 33);
            cmbxSüreyiAzalt.TabIndex = 18;
            cmbxSüreyiAzalt.KeyPress += cmbxSüreyiAzalt_KeyPress;
            // 
            // cmbxSüreyiUzat
            // 
            cmbxSüreyiUzat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbxSüreyiUzat.FormattingEnabled = true;
            cmbxSüreyiUzat.Items.AddRange(new object[] { "1 Gün", "2 Gün", "3 Gün", "4 Gün", "5 Gün", "6 Gün", "1 Hafta", "2 Hafta", "3 Hafta", "1 Ay", "2 Ay", "3 Ay" });
            cmbxSüreyiUzat.Location = new Point(856, 258);
            cmbxSüreyiUzat.Name = "cmbxSüreyiUzat";
            cmbxSüreyiUzat.Size = new Size(168, 33);
            cmbxSüreyiUzat.TabIndex = 17;
            cmbxSüreyiUzat.KeyPress += cmbxSüreyiUzat_KeyPress;
            // 
            // btnSureyiAzalt
            // 
            btnSureyiAzalt.BackColor = Color.Aquamarine;
            btnSureyiAzalt.FlatAppearance.BorderSize = 0;
            btnSureyiAzalt.FlatStyle = FlatStyle.Flat;
            btnSureyiAzalt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSureyiAzalt.Location = new Point(1054, 330);
            btnSureyiAzalt.Name = "btnSureyiAzalt";
            btnSureyiAzalt.Size = new Size(160, 33);
            btnSureyiAzalt.TabIndex = 22;
            btnSureyiAzalt.Text = "Süreyi Azalt";
            btnSureyiAzalt.UseVisualStyleBackColor = false;
            btnSureyiAzalt.Click += btnSureyiAzalt_Click;
            // 
            // btnOde
            // 
            btnOde.BackColor = Color.Aquamarine;
            btnOde.FlatAppearance.BorderSize = 0;
            btnOde.FlatStyle = FlatStyle.Flat;
            btnOde.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOde.Location = new Point(1054, 404);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(160, 33);
            btnOde.TabIndex = 24;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = false;
            btnOde.Click += btnOde_Click;
            // 
            // cmbBxOde
            // 
            cmbBxOde.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxOde.FormattingEnabled = true;
            cmbBxOde.Location = new Point(856, 404);
            cmbBxOde.Name = "cmbBxOde";
            cmbBxOde.Size = new Size(168, 33);
            cmbBxOde.TabIndex = 23;
            cmbBxOde.KeyPress += cmbBxOde_KeyPress;
            // 
            // btnIptalEt
            // 
            btnIptalEt.BackColor = Color.Aquamarine;
            btnIptalEt.FlatAppearance.BorderSize = 0;
            btnIptalEt.FlatStyle = FlatStyle.Flat;
            btnIptalEt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptalEt.Location = new Point(1054, 476);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(160, 33);
            btnIptalEt.TabIndex = 26;
            btnIptalEt.Text = "İptal Et";
            btnIptalEt.UseVisualStyleBackColor = false;
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // cmbBxIptaEt
            // 
            cmbBxIptaEt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxIptaEt.FormattingEnabled = true;
            cmbBxIptaEt.Location = new Point(856, 476);
            cmbBxIptaEt.Name = "cmbBxIptaEt";
            cmbBxIptaEt.Size = new Size(168, 33);
            cmbBxIptaEt.TabIndex = 25;
            cmbBxIptaEt.KeyPress += cmbBxIptaEt_KeyPress;
            // 
            // btnMusteriBilgileri
            // 
            btnMusteriBilgileri.BackColor = Color.Aquamarine;
            btnMusteriBilgileri.FlatAppearance.BorderSize = 0;
            btnMusteriBilgileri.FlatStyle = FlatStyle.Flat;
            btnMusteriBilgileri.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriBilgileri.Location = new Point(1054, 550);
            btnMusteriBilgileri.Name = "btnMusteriBilgileri";
            btnMusteriBilgileri.Size = new Size(160, 57);
            btnMusteriBilgileri.TabIndex = 28;
            btnMusteriBilgileri.Text = "Müşteri Bilgilerini Güncelle";
            btnMusteriBilgileri.UseVisualStyleBackColor = false;
            btnMusteriBilgileri.Click += btnMusteriBilgileri_Click;
            // 
            // cmbBxMusteriBilgileri
            // 
            cmbBxMusteriBilgileri.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxMusteriBilgileri.FormattingEnabled = true;
            cmbBxMusteriBilgileri.Location = new Point(856, 550);
            cmbBxMusteriBilgileri.Name = "cmbBxMusteriBilgileri";
            cmbBxMusteriBilgileri.Size = new Size(168, 33);
            cmbBxMusteriBilgileri.TabIndex = 27;
            cmbBxMusteriBilgileri.KeyPress += cmbBxMusteriBilgileri_KeyPress;
            // 
            // btnDoluOdalar
            // 
            btnDoluOdalar.BackColor = Color.Chartreuse;
            btnDoluOdalar.FlatAppearance.BorderSize = 0;
            btnDoluOdalar.FlatStyle = FlatStyle.Flat;
            btnDoluOdalar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoluOdalar.Location = new Point(557, 156);
            btnDoluOdalar.Name = "btnDoluOdalar";
            btnDoluOdalar.Size = new Size(257, 40);
            btnDoluOdalar.TabIndex = 29;
            btnDoluOdalar.Text = "Dolu Odaları Görüntüle";
            btnDoluOdalar.UseVisualStyleBackColor = false;
            btnDoluOdalar.Click += btnDoluOdalar_Click;
            // 
            // btnBosOdalar
            // 
            btnBosOdalar.BackColor = Color.Chartreuse;
            btnBosOdalar.FlatAppearance.BorderSize = 0;
            btnBosOdalar.FlatStyle = FlatStyle.Flat;
            btnBosOdalar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBosOdalar.Location = new Point(284, 156);
            btnBosOdalar.Name = "btnBosOdalar";
            btnBosOdalar.Size = new Size(257, 40);
            btnBosOdalar.TabIndex = 30;
            btnBosOdalar.Text = "Boş Odaları Görüntüle";
            btnBosOdalar.UseVisualStyleBackColor = false;
            btnBosOdalar.Click += btnBosOdalar_Click;
            // 
            // lstViewMusteriBilgileri
            // 
            lstViewMusteriBilgileri.BorderStyle = BorderStyle.None;
            lstViewMusteriBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            lstViewMusteriBilgileri.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewMusteriBilgileri.FullRowSelect = true;
            lstViewMusteriBilgileri.Location = new Point(319, 202);
            lstViewMusteriBilgileri.Name = "lstViewMusteriBilgileri";
            lstViewMusteriBilgileri.Size = new Size(495, 436);
            lstViewMusteriBilgileri.TabIndex = 31;
            lstViewMusteriBilgileri.UseCompatibleStateImageBehavior = false;
            lstViewMusteriBilgileri.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = " ";
            columnHeader4.Width = 225;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Müşteri Bilgileri";
            columnHeader5.Width = 250;
            // 
            // Timer1
            // 
            Timer1.Interval = 1000;
            // 
            // btnKayitliMusteriler
            // 
            btnKayitliMusteriler.BackColor = Color.Yellow;
            btnKayitliMusteriler.FlatAppearance.BorderSize = 0;
            btnKayitliMusteriler.FlatStyle = FlatStyle.Flat;
            btnKayitliMusteriler.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitliMusteriler.Location = new Point(905, 14);
            btnKayitliMusteriler.Name = "btnKayitliMusteriler";
            btnKayitliMusteriler.Size = new Size(220, 45);
            btnKayitliMusteriler.TabIndex = 32;
            btnKayitliMusteriler.Text = "Kayıtlı Müşteriler";
            btnKayitliMusteriler.UseVisualStyleBackColor = false;
            btnKayitliMusteriler.Click += btnKayitliMusteriler_Click;
            // 
            // Odalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1300, 650);
            Controls.Add(btnKayitliMusteriler);
            Controls.Add(lstViewMusteriBilgileri);
            Controls.Add(btnBosOdalar);
            Controls.Add(btnDoluOdalar);
            Controls.Add(btnMusteriBilgileri);
            Controls.Add(cmbBxMusteriBilgileri);
            Controls.Add(btnIptalEt);
            Controls.Add(cmbBxIptaEt);
            Controls.Add(btnOde);
            Controls.Add(cmbBxOde);
            Controls.Add(btnSureyiAzalt);
            Controls.Add(btnSureyiUzalt);
            Controls.Add(cmbxSüreyiAzalt);
            Controls.Add(cmbxSüreyiUzat);
            Controls.Add(lstViewOdalar);
            Controls.Add(btnTumOdalar);
            Controls.Add(btnOdalar);
            Controls.Add(btnRaporlar);
            Controls.Add(btnRezervasyonlar);
            Controls.Add(btnCikis);
            Controls.Add(btnImg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Odalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odalar";
            Load += Odalar_Load_1;
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
        private Button btnTumOdalar;
        private Button btnSureyiAzalt;
        private Button btnSureyiUzalt;
        private ComboBox cmbxSüreyiAzalt;
        private ComboBox cmbxSüreyiUzat;
        private ListView lstViewOdalar;
        private Button btnOde;
        private ComboBox cmbBxOde;
        private Button btnIptalEt;
        private ComboBox cmbBxIptaEt;
        private Button btnMusteriBilgileri;
        private ComboBox cmbBxMusteriBilgileri;
        private Button btnBosOdalar;
        private Button btnDoluOdalar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        public ListView lstViewMusteriBilgileri;
        private System.Windows.Forms.Timer Timer1;
        private Button btnKayitliMusteriler;
    }
}