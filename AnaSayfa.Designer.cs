namespace KGM_Misafirhane
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            button1 = new Button();
            ımageList2 = new ImageList(components);
            button2 = new Button();
            ımageList1 = new ImageList(components);
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageIndex = 0;
            button1.ImageList = ımageList2;
            button1.Location = new Point(1221, 12);
            button1.Name = "button1";
            button1.Size = new Size(67, 58);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "pngwing.com (9).png");
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageIndex = 1;
            button2.ImageList = ımageList1;
            button2.Location = new Point(1, 1);
            button2.Name = "button2";
            button2.Size = new Size(135, 131);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "kgm_logo.png");
            ımageList1.Images.SetKeyName(1, "KGM_logo.svg.png");
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(230, 12);
            button3.Name = "button3";
            button3.Size = new Size(290, 45);
            button3.TabIndex = 5;
            button3.Text = "Rezervasyonlar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(818, 12);
            button4.Name = "button4";
            button4.Size = new Size(290, 45);
            button4.TabIndex = 6;
            button4.Text = "Raporlar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(524, 12);
            button5.Name = "button5";
            button5.Size = new Size(290, 45);
            button5.TabIndex = 7;
            button5.Text = "Odalar";
            button5.UseVisualStyleBackColor = false;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1300, 650);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button button1;
        private ImageList ımageList2;
        private Button button2;
        private ImageList ımageList1;
        private Button button5;
        private Button button4;
        private Button button3;
    }
}