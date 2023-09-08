namespace KGM_Misafirhane
{
    partial class MusteriBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBilgileri));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList2 = new ImageList(components);
            btnCikis = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGuncelle = new Button();
            txtBxTelefon = new TextBox();
            txtBxEmail = new TextBox();
            txtBxSoyad = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbBxOdaNo = new ComboBox();
            cmbBxKat = new ComboBox();
            label1 = new Label();
            cmbBxOdaTuru = new ComboBox();
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
            btnCikis.Location = new Point(569, 2);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(51, 51);
            btnCikis.TabIndex = 19;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 34);
            label4.Name = "label4";
            label4.Size = new Size(132, 35);
            label4.TabIndex = 21;
            label4.Text = "Ad Soyad:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 75);
            label5.Name = "label5";
            label5.Size = new Size(116, 35);
            label5.TabIndex = 22;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 115);
            label6.Name = "label6";
            label6.Size = new Size(225, 35);
            label6.TabIndex = 23;
            label6.Text = "Telefon Numarası:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Lime;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(207, 290);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(213, 39);
            btnGuncelle.TabIndex = 24;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtBxTelefon
            // 
            txtBxTelefon.BorderStyle = BorderStyle.None;
            txtBxTelefon.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTelefon.Location = new Point(275, 116);
            txtBxTelefon.Multiline = true;
            txtBxTelefon.Name = "txtBxTelefon";
            txtBxTelefon.Size = new Size(228, 29);
            txtBxTelefon.TabIndex = 25;
            txtBxTelefon.KeyPress += txtBxTelefon_KeyPress;
            // 
            // txtBxEmail
            // 
            txtBxEmail.BorderStyle = BorderStyle.None;
            txtBxEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxEmail.Location = new Point(275, 75);
            txtBxEmail.Multiline = true;
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(228, 29);
            txtBxEmail.TabIndex = 26;
            // 
            // txtBxSoyad
            // 
            txtBxSoyad.BorderStyle = BorderStyle.None;
            txtBxSoyad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxSoyad.Location = new Point(275, 34);
            txtBxSoyad.Multiline = true;
            txtBxSoyad.Name = "txtBxSoyad";
            txtBxSoyad.Size = new Size(228, 29);
            txtBxSoyad.TabIndex = 27;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 239);
            label7.Name = "label7";
            label7.Size = new Size(121, 34);
            label7.TabIndex = 44;
            label7.Text = "Oda No:";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 200);
            label8.Name = "label8";
            label8.Size = new Size(65, 35);
            label8.TabIndex = 43;
            label8.Text = "Kat:";
            // 
            // cmbBxOdaNo
            // 
            cmbBxOdaNo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxOdaNo.FormattingEnabled = true;
            cmbBxOdaNo.Location = new Point(275, 239);
            cmbBxOdaNo.Name = "cmbBxOdaNo";
            cmbBxOdaNo.Size = new Size(228, 33);
            cmbBxOdaNo.TabIndex = 42;
            // 
            // cmbBxKat
            // 
            cmbBxKat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxKat.FormattingEnabled = true;
            cmbBxKat.Location = new Point(275, 198);
            cmbBxKat.Name = "cmbBxKat";
            cmbBxKat.Size = new Size(228, 33);
            cmbBxKat.TabIndex = 41;
            cmbBxKat.SelectedIndexChanged += cmbBxKat_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 156);
            label1.Name = "label1";
            label1.Size = new Size(141, 35);
            label1.TabIndex = 46;
            label1.Text = "Oda Türü:";
            // 
            // cmbBxOdaTuru
            // 
            cmbBxOdaTuru.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxOdaTuru.FormattingEnabled = true;
            cmbBxOdaTuru.Location = new Point(275, 156);
            cmbBxOdaTuru.Name = "cmbBxOdaTuru";
            cmbBxOdaTuru.Size = new Size(228, 33);
            cmbBxOdaTuru.TabIndex = 45;
            cmbBxOdaTuru.SelectedIndexChanged += cmbBxOdaTuru_SelectedIndexChanged;
            // 
            // MusteriBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(624, 346);
            Controls.Add(label1);
            Controls.Add(cmbBxOdaTuru);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(cmbBxOdaNo);
            Controls.Add(cmbBxKat);
            Controls.Add(txtBxSoyad);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxTelefon);
            Controls.Add(btnGuncelle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusteriBilgileri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriBilgileri";
            Load += MusteriBilgileri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnGuncelle;
        private TextBox txtBxSoyad;
        private TextBox txtBxEmail;
        private TextBox txtBxTelefon;
        private Label label7;
        private Label label8;
        private ComboBox cmbBxOdaNo;
        private ComboBox cmbBxKat;
        private Label label1;
        private ComboBox cmbBxOdaTuru;
    }
}