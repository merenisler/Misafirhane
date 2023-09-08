namespace KGM_Misafirhane
{
    partial class IptalNedeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IptalNedeni));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList2 = new ImageList(components);
            btnCikis = new Button();
            label3 = new Label();
            label1 = new Label();
            txtBxMusteriEpostası = new TextBox();
            txtBxIptalNedeni = new TextBox();
            label2 = new Label();
            btnGonder = new Button();
            btnIptalEt = new Button();
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
            btnCikis.Location = new Point(558, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(51, 51);
            btnCikis.TabIndex = 20;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 80);
            label3.Name = "label3";
            label3.Size = new Size(205, 35);
            label3.TabIndex = 21;
            label3.Text = "Müşteri Epostası:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 118);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 22;
            label1.Text = "İptal Nedeni:";
            // 
            // txtBxMusteriEpostası
            // 
            txtBxMusteriEpostası.BorderStyle = BorderStyle.None;
            txtBxMusteriEpostası.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMusteriEpostası.Location = new Point(249, 83);
            txtBxMusteriEpostası.Multiline = true;
            txtBxMusteriEpostası.Name = "txtBxMusteriEpostası";
            txtBxMusteriEpostası.Size = new Size(261, 30);
            txtBxMusteriEpostası.TabIndex = 29;
            txtBxMusteriEpostası.KeyPress += txtBxMusteriEpostası_KeyPress;
            // 
            // txtBxIptalNedeni
            // 
            txtBxIptalNedeni.BorderStyle = BorderStyle.None;
            txtBxIptalNedeni.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxIptalNedeni.Location = new Point(249, 121);
            txtBxIptalNedeni.Multiline = true;
            txtBxIptalNedeni.Name = "txtBxIptalNedeni";
            txtBxIptalNedeni.Size = new Size(261, 92);
            txtBxIptalNedeni.TabIndex = 30;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 12);
            label2.Name = "label2";
            label2.Size = new Size(552, 54);
            label2.TabIndex = 31;
            label2.Text = "Rezervasyon İptal";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.RoyalBlue;
            btnGonder.FlatAppearance.BorderSize = 0;
            btnGonder.FlatStyle = FlatStyle.Flat;
            btnGonder.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGonder.ForeColor = SystemColors.ControlLightLight;
            btnGonder.Location = new Point(249, 219);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(261, 39);
            btnGonder.TabIndex = 32;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // btnIptalEt
            // 
            btnIptalEt.BackColor = Color.RoyalBlue;
            btnIptalEt.FlatAppearance.BorderSize = 0;
            btnIptalEt.FlatStyle = FlatStyle.Flat;
            btnIptalEt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptalEt.ForeColor = SystemColors.ControlLightLight;
            btnIptalEt.Location = new Point(249, 263);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(261, 31);
            btnIptalEt.TabIndex = 33;
            btnIptalEt.Text = "Mail Göndermeden İptal Et";
            btnIptalEt.TextAlign = ContentAlignment.TopCenter;
            btnIptalEt.UseVisualStyleBackColor = false;
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // IptalNedeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(621, 304);
            Controls.Add(btnIptalEt);
            Controls.Add(btnGonder);
            Controls.Add(label2);
            Controls.Add(txtBxIptalNedeni);
            Controls.Add(txtBxMusteriEpostası);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IptalNedeni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IptalNedeni";
            Load += IptalNedeni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button btnCikis;
        private ImageList ımageList2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtBxIptalNedeni;
        private TextBox txtBxMusteriEpostası;
        private Button btnGonder;
        private Button btnIptalEt;
    }
}