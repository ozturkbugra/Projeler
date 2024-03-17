namespace AidatTakip
{
    partial class aidatodeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aidatodeme));
            groupBox1 = new GroupBox();
            txtBorc2 = new TextBox();
            cbBorcFarkli = new CheckBox();
            cbBorc0 = new CheckBox();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            dgvEk = new DataGridView();
            dgvAidat = new DataGridView();
            lblDurum = new Label();
            label5 = new Label();
            button2 = new Button();
            lblBorc = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            txtDaireNo = new TextBox();
            groupBox2 = new GroupBox();
            rbEk = new RadioButton();
            rbAidat = new RadioButton();
            label8 = new Label();
            cb1 = new ComboBox();
            dgvMakbuz = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMakbuz).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBorc2);
            groupBox1.Controls.Add(cbBorcFarkli);
            groupBox1.Controls.Add(cbBorc0);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dgvEk);
            groupBox1.Controls.Add(dgvAidat);
            groupBox1.Controls.Add(lblDurum);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(lblBorc);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDaireNo);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(812, 587);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aidat Ödeme Ekranı";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtBorc2
            // 
            txtBorc2.Location = new Point(577, 129);
            txtBorc2.Name = "txtBorc2";
            txtBorc2.Size = new Size(100, 27);
            txtBorc2.TabIndex = 19;
            // 
            // cbBorcFarkli
            // 
            cbBorcFarkli.AutoSize = true;
            cbBorcFarkli.Location = new Point(520, 62);
            cbBorcFarkli.Name = "cbBorcFarkli";
            cbBorcFarkli.Size = new Size(247, 61);
            cbBorcFarkli.TabIndex = 18;
            cbBorcFarkli.Text = "Birden fazla makbuz kesilip borcu \r\nsıfırdan farklıysa işaretleyin ve \r\naşağıya kalan borcu yazın\r\n";
            cbBorcFarkli.UseVisualStyleBackColor = true;
            cbBorcFarkli.CheckedChanged += cbBorcFarkli_CheckedChanged;
            // 
            // cbBorc0
            // 
            cbBorc0.AutoSize = true;
            cbBorc0.Location = new Point(520, 26);
            cbBorc0.Name = "cbBorc0";
            cbBorc0.Size = new Size(201, 23);
            cbBorc0.TabIndex = 17;
            cbBorc0.Text = "Borç 0 olacaksa işaretleyin";
            cbBorc0.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(520, 506);
            button3.Name = "button3";
            button3.Size = new Size(177, 36);
            button3.TabIndex = 16;
            button3.Text = "Ek Makbuzu Oluştur";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(592, 183);
            label7.Name = "label7";
            label7.Size = new Size(38, 29);
            label7.TabIndex = 15;
            label7.Text = "EK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(157, 183);
            label6.Name = "label6";
            label6.Size = new Size(73, 29);
            label6.TabIndex = 14;
            label6.Text = "AİDAT";
            // 
            // dgvEk
            // 
            dgvEk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEk.BackgroundColor = SystemColors.ActiveCaption;
            dgvEk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEk.Location = new Point(426, 215);
            dgvEk.Name = "dgvEk";
            dgvEk.RowTemplate.Height = 25;
            dgvEk.Size = new Size(362, 285);
            dgvEk.TabIndex = 13;
            // 
            // dgvAidat
            // 
            dgvAidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAidat.BackgroundColor = SystemColors.ActiveCaption;
            dgvAidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAidat.Location = new Point(48, 215);
            dgvAidat.Name = "dgvAidat";
            dgvAidat.RowTemplate.Height = 25;
            dgvAidat.Size = new Size(351, 285);
            dgvAidat.TabIndex = 12;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(301, 111);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(14, 19);
            lblDurum.TabIndex = 11;
            lblDurum.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 111);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 10;
            label5.Text = "Durum:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(131, 506);
            button2.Name = "button2";
            button2.Size = new Size(193, 36);
            button2.TabIndex = 9;
            button2.Text = "Aidat Makbuzu Oluştur";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblBorc
            // 
            lblBorc.AutoSize = true;
            lblBorc.Location = new Point(299, 140);
            lblBorc.Name = "lblBorc";
            lblBorc.Size = new Size(14, 19);
            lblBorc.TabIndex = 8;
            lblBorc.Text = "-";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(300, 80);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(14, 19);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "-";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(300, 52);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(14, 19);
            lblAd.TabIndex = 6;
            lblAd.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 140);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 5;
            label4.Text = "Borç:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 4;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 51);
            label2.Name = "label2";
            label2.Size = new Size(30, 19);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(102, 121);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 2;
            button1.Text = "Listele";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 80);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 1;
            label1.Text = "Daire No";
            // 
            // txtDaireNo
            // 
            txtDaireNo.Location = new Point(120, 77);
            txtDaireNo.Name = "txtDaireNo";
            txtDaireNo.Size = new Size(60, 27);
            txtDaireNo.TabIndex = 0;
            txtDaireNo.KeyPress += txtDaireNo_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbEk);
            groupBox2.Controls.Add(rbAidat);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cb1);
            groupBox2.Controls.Add(dgvMakbuz);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(870, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 585);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dairenin Makbuz Bilgileri";
            // 
            // rbEk
            // 
            rbEk.AutoSize = true;
            rbEk.Location = new Point(205, 26);
            rbEk.Name = "rbEk";
            rbEk.Size = new Size(68, 23);
            rbEk.TabIndex = 4;
            rbEk.TabStop = true;
            rbEk.Text = "Ek Ara";
            rbEk.UseVisualStyleBackColor = true;
            // 
            // rbAidat
            // 
            rbAidat.AutoSize = true;
            rbAidat.Location = new Point(112, 26);
            rbAidat.Name = "rbAidat";
            rbAidat.Size = new Size(87, 23);
            rbAidat.TabIndex = 3;
            rbAidat.TabStop = true;
            rbAidat.Text = "Aidat Ara";
            rbAidat.UseVisualStyleBackColor = true;
            rbAidat.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 64);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 2;
            label8.Text = "Aidat / Ek Dönemi:";
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035" });
            cb1.Location = new Point(169, 61);
            cb1.Name = "cb1";
            cb1.Size = new Size(177, 27);
            cb1.TabIndex = 1;
            cb1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvMakbuz
            // 
            dgvMakbuz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMakbuz.BackgroundColor = SystemColors.ActiveCaption;
            dgvMakbuz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakbuz.Location = new Point(31, 96);
            dgvMakbuz.Name = "dgvMakbuz";
            dgvMakbuz.RowTemplate.Height = 25;
            dgvMakbuz.Size = new Size(370, 468);
            dgvMakbuz.TabIndex = 0;
            dgvMakbuz.CellEndEdit += dgvMakbuz_CellEndEdit;
            // 
            // ID
            // 
            ID.HeaderText = "Column1";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // aidatodeme
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1386, 650);
            MinimumSize = new Size(1358, 650);
            Name = "aidatodeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aidat Ödeme";
            Load += aidatodeme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMakbuz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private DataGridView dgvEk;
        private Button button3;
        public Label lblDurum;
        public Label lblBorc;
        public Label lblSoyad;
        public Label lblAd;
        public TextBox txtDaireNo;
        public DataGridView dgvMakbuz;
        public DataGridView dgvAidat;
        private Label label8;
        private ComboBox cb1;
        private RadioButton rbAidat;
        private RadioButton rbEk;
        private DataGridViewTextBoxColumn ID;
        private TextBox txtBorc2;
        private CheckBox cbBorcFarkli;
        private CheckBox cbBorc0;
    }
}