namespace KGM_Misafirhane
{
    partial class MailGönder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailGönder));
            s = new Bunifu.Framework.UI.BunifuElipse(components);
            ımageList2 = new ImageList(components);
            btnCikis = new Button();
            ımageList1 = new ImageList(components);
            lstBxKayitliMusteriler = new CheckedListBox();
            btnTumunuSec = new Button();
            txtBxMailMetni = new TextBox();
            btnGonder = new Button();
            label4 = new Label();
            btnSecimleriKaldir = new Button();
            SuspendLayout();
            // 
            // s
            // 
            s.ElipseRadius = 5;
            s.TargetControl = this;
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
            btnCikis.Location = new Point(853, 12);
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
            // lstBxKayitliMusteriler
            // 
            lstBxKayitliMusteriler.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstBxKayitliMusteriler.FormattingEnabled = true;
            lstBxKayitliMusteriler.Location = new Point(12, 78);
            lstBxKayitliMusteriler.Name = "lstBxKayitliMusteriler";
            lstBxKayitliMusteriler.Size = new Size(338, 433);
            lstBxKayitliMusteriler.TabIndex = 7;
            // 
            // btnTumunuSec
            // 
            btnTumunuSec.BackColor = Color.OliveDrab;
            btnTumunuSec.FlatAppearance.BorderSize = 0;
            btnTumunuSec.FlatStyle = FlatStyle.Flat;
            btnTumunuSec.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTumunuSec.ForeColor = Color.White;
            btnTumunuSec.Location = new Point(183, 35);
            btnTumunuSec.Name = "btnTumunuSec";
            btnTumunuSec.Size = new Size(166, 37);
            btnTumunuSec.TabIndex = 57;
            btnTumunuSec.Text = "Tümünü Seç";
            btnTumunuSec.UseVisualStyleBackColor = false;
            btnTumunuSec.Click += btnTumunuSec_Click;
            // 
            // txtBxMailMetni
            // 
            txtBxMailMetni.BorderStyle = BorderStyle.None;
            txtBxMailMetni.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMailMetni.Location = new Point(479, 214);
            txtBxMailMetni.Multiline = true;
            txtBxMailMetni.Name = "txtBxMailMetni";
            txtBxMailMetni.Size = new Size(322, 144);
            txtBxMailMetni.TabIndex = 58;
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.Lime;
            btnGonder.FlatAppearance.BorderSize = 0;
            btnGonder.FlatStyle = FlatStyle.Flat;
            btnGonder.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGonder.Location = new Point(500, 367);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(280, 38);
            btnGonder.TabIndex = 59;
            btnGonder.Text = "Gönder";
            btnGonder.TextAlign = ContentAlignment.TopCenter;
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(472, 174);
            label4.Name = "label4";
            label4.Size = new Size(151, 35);
            label4.TabIndex = 60;
            label4.Text = "Mail Metni:";
            // 
            // btnSecimleriKaldir
            // 
            btnSecimleriKaldir.BackColor = Color.OliveDrab;
            btnSecimleriKaldir.FlatAppearance.BorderSize = 0;
            btnSecimleriKaldir.FlatStyle = FlatStyle.Flat;
            btnSecimleriKaldir.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSecimleriKaldir.ForeColor = Color.White;
            btnSecimleriKaldir.Location = new Point(12, 35);
            btnSecimleriKaldir.Name = "btnSecimleriKaldir";
            btnSecimleriKaldir.Size = new Size(165, 37);
            btnSecimleriKaldir.TabIndex = 61;
            btnSecimleriKaldir.Text = "Seçimleri Kaldır";
            btnSecimleriKaldir.UseVisualStyleBackColor = false;
            btnSecimleriKaldir.Click += btnSecimleriKaldir_Click;
            // 
            // MailGönder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(932, 534);
            Controls.Add(btnSecimleriKaldir);
            Controls.Add(btnGonder);
            Controls.Add(label4);
            Controls.Add(txtBxMailMetni);
            Controls.Add(btnTumunuSec);
            Controls.Add(lstBxKayitliMusteriler);
            Controls.Add(btnCikis);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MailGönder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailGönder";
            Load += MailGönder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse s;
        private Button btnCikis;
        private ImageList ımageList2;
        private ImageList ımageList1;
        private CheckedListBox lstBxKayitliMusteriler;
        private Button btnTumunuSec;
        private TextBox txtBxMailMetni;
        private Button btnGonder;
        private Label label4;
        private Button btnSecimleriKaldir;
    }
}