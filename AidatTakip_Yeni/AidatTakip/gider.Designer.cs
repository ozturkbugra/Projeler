namespace AidatTakip
{
    partial class gider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gider));
            groupBox1 = new GroupBox();
            txtTur = new ComboBox();
            label3 = new Label();
            rb6 = new RadioButton();
            txtTutar6 = new TextBox();
            txtAciklama6 = new TextBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            txtTutar5 = new TextBox();
            txtAciklama5 = new TextBox();
            txtTutar4 = new TextBox();
            txtAciklama4 = new TextBox();
            rb7 = new RadioButton();
            txtTutar7 = new TextBox();
            txtAciklama7 = new TextBox();
            rb3 = new RadioButton();
            txtTutar3 = new TextBox();
            txtAciklama3 = new TextBox();
            button4 = new Button();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            txtTutar2 = new TextBox();
            txtAciklama2 = new TextBox();
            txtTutar1 = new TextBox();
            txtAciklama1 = new TextBox();
            button1 = new Button();
            txtTutar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAciklama = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTur);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rb6);
            groupBox1.Controls.Add(txtTutar6);
            groupBox1.Controls.Add(txtAciklama6);
            groupBox1.Controls.Add(rb5);
            groupBox1.Controls.Add(rb4);
            groupBox1.Controls.Add(txtTutar5);
            groupBox1.Controls.Add(txtAciklama5);
            groupBox1.Controls.Add(txtTutar4);
            groupBox1.Controls.Add(txtAciklama4);
            groupBox1.Controls.Add(rb7);
            groupBox1.Controls.Add(txtTutar7);
            groupBox1.Controls.Add(txtAciklama7);
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(txtTutar3);
            groupBox1.Controls.Add(txtAciklama3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtTutar2);
            groupBox1.Controls.Add(txtAciklama2);
            groupBox1.Controls.Add(txtTutar1);
            groupBox1.Controls.Add(txtAciklama1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 476);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gider Makbuzu Oluşturmak";
            // 
            // txtTur
            // 
            txtTur.FormattingEnabled = true;
            txtTur.Items.AddRange(new object[] { "ELEKTRİK", "SU", "YÖNETİM", "TEMİZLİK", "BAKIM ONARIM", "DEMİRBAŞ", "MAAŞ", "SSK", "DİĞER" });
            txtTur.Location = new Point(258, 130);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(285, 27);
            txtTur.TabIndex = 1;
            txtTur.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 91);
            label3.Name = "label3";
            label3.Size = new Size(164, 36);
            label3.TabIndex = 30;
            label3.Text = "GİDER TÜRÜ";
            label3.Click += label3_Click;
            // 
            // rb6
            // 
            rb6.AutoSize = true;
            rb6.Location = new Point(400, 367);
            rb6.Name = "rb6";
            rb6.Size = new Size(14, 13);
            rb6.TabIndex = 29;
            rb6.TabStop = true;
            rb6.UseVisualStyleBackColor = true;
            // 
            // txtTutar6
            // 
            txtTutar6.Enabled = false;
            txtTutar6.Location = new Point(711, 361);
            txtTutar6.Name = "txtTutar6";
            txtTutar6.Size = new Size(51, 27);
            txtTutar6.TabIndex = 28;
            txtTutar6.KeyPress += txtTutar6_KeyPress;
            // 
            // txtAciklama6
            // 
            txtAciklama6.Enabled = false;
            txtAciklama6.Location = new Point(420, 361);
            txtAciklama6.MaxLength = 50;
            txtAciklama6.Name = "txtAciklama6";
            txtAciklama6.Size = new Size(285, 27);
            txtAciklama6.TabIndex = 27;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(400, 334);
            rb5.Name = "rb5";
            rb5.Size = new Size(14, 13);
            rb5.TabIndex = 26;
            rb5.TabStop = true;
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(401, 301);
            rb4.Name = "rb4";
            rb4.Size = new Size(14, 13);
            rb4.TabIndex = 25;
            rb4.TabStop = true;
            rb4.UseVisualStyleBackColor = true;
            // 
            // txtTutar5
            // 
            txtTutar5.Enabled = false;
            txtTutar5.Location = new Point(711, 328);
            txtTutar5.Name = "txtTutar5";
            txtTutar5.Size = new Size(51, 27);
            txtTutar5.TabIndex = 24;
            txtTutar5.TextChanged += txtTutar5_TextChanged;
            txtTutar5.KeyPress += txtTutar5_KeyPress;
            // 
            // txtAciklama5
            // 
            txtAciklama5.Enabled = false;
            txtAciklama5.Location = new Point(420, 328);
            txtAciklama5.MaxLength = 50;
            txtAciklama5.Name = "txtAciklama5";
            txtAciklama5.Size = new Size(285, 27);
            txtAciklama5.TabIndex = 23;
            // 
            // txtTutar4
            // 
            txtTutar4.Enabled = false;
            txtTutar4.Location = new Point(711, 295);
            txtTutar4.Name = "txtTutar4";
            txtTutar4.Size = new Size(51, 27);
            txtTutar4.TabIndex = 22;
            txtTutar4.KeyPress += txtTutar4_KeyPress;
            // 
            // txtAciklama4
            // 
            txtAciklama4.Enabled = false;
            txtAciklama4.Location = new Point(421, 295);
            txtAciklama4.MaxLength = 50;
            txtAciklama4.Name = "txtAciklama4";
            txtAciklama4.Size = new Size(285, 27);
            txtAciklama4.TabIndex = 21;
            // 
            // rb7
            // 
            rb7.AutoSize = true;
            rb7.Location = new Point(238, 400);
            rb7.Name = "rb7";
            rb7.Size = new Size(14, 13);
            rb7.TabIndex = 20;
            rb7.TabStop = true;
            rb7.UseVisualStyleBackColor = true;
            // 
            // txtTutar7
            // 
            txtTutar7.Enabled = false;
            txtTutar7.Location = new Point(549, 394);
            txtTutar7.Name = "txtTutar7";
            txtTutar7.Size = new Size(51, 27);
            txtTutar7.TabIndex = 19;
            txtTutar7.KeyPress += txtTutar7_KeyPress;
            // 
            // txtAciklama7
            // 
            txtAciklama7.Enabled = false;
            txtAciklama7.Location = new Point(258, 394);
            txtAciklama7.MaxLength = 50;
            txtAciklama7.Name = "txtAciklama7";
            txtAciklama7.Size = new Size(285, 27);
            txtAciklama7.TabIndex = 18;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(23, 367);
            rb3.Name = "rb3";
            rb3.Size = new Size(14, 13);
            rb3.TabIndex = 17;
            rb3.TabStop = true;
            rb3.UseVisualStyleBackColor = true;
            // 
            // txtTutar3
            // 
            txtTutar3.Enabled = false;
            txtTutar3.Location = new Point(334, 361);
            txtTutar3.Name = "txtTutar3";
            txtTutar3.Size = new Size(51, 27);
            txtTutar3.TabIndex = 16;
            txtTutar3.KeyPress += txtTutar3_KeyPress;
            // 
            // txtAciklama3
            // 
            txtAciklama3.Enabled = false;
            txtAciklama3.Location = new Point(43, 361);
            txtAciklama3.MaxLength = 50;
            txtAciklama3.Name = "txtAciklama3";
            txtAciklama3.Size = new Size(285, 27);
            txtAciklama3.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(345, 437);
            button4.Name = "button4";
            button4.Size = new Size(96, 31);
            button4.TabIndex = 14;
            button4.Text = "Kaydet";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(23, 334);
            rb2.Name = "rb2";
            rb2.Size = new Size(14, 13);
            rb2.TabIndex = 13;
            rb2.TabStop = true;
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(24, 301);
            rb1.Name = "rb1";
            rb1.Size = new Size(14, 13);
            rb1.TabIndex = 12;
            rb1.TabStop = true;
            rb1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(458, 437);
            button3.Name = "button3";
            button3.Size = new Size(153, 31);
            button3.TabIndex = 11;
            button3.Text = "Makbuza Aktar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(225, 437);
            button2.Name = "button2";
            button2.Size = new Size(100, 31);
            button2.TabIndex = 10;
            button2.Text = "Düzenle";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtTutar2
            // 
            txtTutar2.Enabled = false;
            txtTutar2.Location = new Point(334, 328);
            txtTutar2.Name = "txtTutar2";
            txtTutar2.Size = new Size(51, 27);
            txtTutar2.TabIndex = 9;
            txtTutar2.KeyPress += txtTutar2_KeyPress;
            // 
            // txtAciklama2
            // 
            txtAciklama2.Enabled = false;
            txtAciklama2.Location = new Point(43, 328);
            txtAciklama2.MaxLength = 50;
            txtAciklama2.Name = "txtAciklama2";
            txtAciklama2.Size = new Size(285, 27);
            txtAciklama2.TabIndex = 8;
            // 
            // txtTutar1
            // 
            txtTutar1.Enabled = false;
            txtTutar1.Location = new Point(334, 295);
            txtTutar1.Name = "txtTutar1";
            txtTutar1.Size = new Size(51, 27);
            txtTutar1.TabIndex = 7;
            txtTutar1.KeyPress += txtTutar1_KeyPress;
            // 
            // txtAciklama1
            // 
            txtAciklama1.Enabled = false;
            txtAciklama1.Location = new Point(44, 295);
            txtAciklama1.MaxLength = 50;
            txtAciklama1.Name = "txtAciklama1";
            txtAciklama1.Size = new Size(285, 27);
            txtAciklama1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(341, 241);
            button1.Name = "button1";
            button1.Size = new Size(110, 45);
            button1.TabIndex = 3;
            button1.Text = "OLUŞTUR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(330, 205);
            txtTutar.MaxLength = 35;
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(138, 27);
            txtTutar.TabIndex = 2;
            txtTutar.TextAlign = HorizontalAlignment.Center;
            txtTutar.KeyPress += txtTutar_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(247, 167);
            label2.Name = "label2";
            label2.Size = new Size(309, 36);
            label2.TabIndex = 2;
            label2.Text = "GİDER MAKBUZU TUTAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(214, 16);
            label1.Name = "label1";
            label1.Size = new Size(360, 36);
            label1.TabIndex = 1;
            label1.Text = "GİDER MAKBUZU AÇIKLAMA";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(139, 55);
            txtAciklama.MaxLength = 35;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(530, 27);
            txtAciklama.TabIndex = 0;
            txtAciklama.TextAlign = HorizontalAlignment.Center;
            // 
            // gider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 500);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(831, 539);
            MinimizeBox = false;
            MinimumSize = new Size(831, 539);
            Name = "gider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gider Makbuzu Oluşturma";
            Load += gider_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtTutar;
        private Label label2;
        private Label label1;
        private TextBox txtAciklama;
        private RadioButton rb2;
        private RadioButton rb1;
        private Button button3;
        private Button button2;
        private TextBox txtTutar2;
        private TextBox txtAciklama2;
        private TextBox txtTutar1;
        private TextBox txtAciklama1;
        private Button button4;
        private RadioButton rb6;
        private TextBox txtTutar6;
        private TextBox txtAciklama6;
        private RadioButton rb5;
        private RadioButton rb4;
        private TextBox txtTutar5;
        private TextBox txtAciklama5;
        private TextBox txtTutar4;
        private TextBox txtAciklama4;
        private RadioButton rb7;
        private TextBox txtTutar7;
        private TextBox txtAciklama7;
        private RadioButton rb3;
        private TextBox txtTutar3;
        private TextBox txtAciklama3;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox txtTur;
    }
}