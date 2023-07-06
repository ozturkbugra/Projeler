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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEk = new System.Windows.Forms.DataGridView();
            this.dgvAidat = new System.Windows.Forms.DataGridView();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBorc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEk = new System.Windows.Forms.RadioButton();
            this.rbAidat = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.dgvMakbuz = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakbuz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvEk);
            this.groupBox1.Controls.Add(this.dgvAidat);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblBorc);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDaireNo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aidat Ödeme Ekranı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(520, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ek Makbuzu Oluştur";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(592, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "EK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(157, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "AİDAT";
            // 
            // dgvEk
            // 
            this.dgvEk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEk.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEk.Location = new System.Drawing.Point(426, 215);
            this.dgvEk.Name = "dgvEk";
            this.dgvEk.RowTemplate.Height = 25;
            this.dgvEk.Size = new System.Drawing.Size(362, 285);
            this.dgvEk.TabIndex = 13;
            // 
            // dgvAidat
            // 
            this.dgvAidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAidat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAidat.Location = new System.Drawing.Point(48, 215);
            this.dgvAidat.Name = "dgvAidat";
            this.dgvAidat.RowTemplate.Height = 25;
            this.dgvAidat.Size = new System.Drawing.Size(351, 285);
            this.dgvAidat.TabIndex = 12;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(301, 111);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(14, 19);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durum:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(131, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aidat Makbuzu Oluştur";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Location = new System.Drawing.Point(299, 140);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(14, 19);
            this.lblBorc.TabIndex = 8;
            this.lblBorc.Text = "-";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(300, 80);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(14, 19);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "-";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(300, 52);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(14, 19);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Borç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(102, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listele";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daire No";
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(120, 77);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(60, 27);
            this.txtDaireNo.TabIndex = 0;
            this.txtDaireNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaireNo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEk);
            this.groupBox2.Controls.Add(this.rbAidat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Controls.Add(this.dgvMakbuz);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(870, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 585);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dairenin Makbuz Bilgileri";
            // 
            // rbEk
            // 
            this.rbEk.AutoSize = true;
            this.rbEk.Location = new System.Drawing.Point(205, 26);
            this.rbEk.Name = "rbEk";
            this.rbEk.Size = new System.Drawing.Size(68, 23);
            this.rbEk.TabIndex = 4;
            this.rbEk.TabStop = true;
            this.rbEk.Text = "Ek Ara";
            this.rbEk.UseVisualStyleBackColor = true;
            // 
            // rbAidat
            // 
            this.rbAidat.AutoSize = true;
            this.rbAidat.Location = new System.Drawing.Point(112, 26);
            this.rbAidat.Name = "rbAidat";
            this.rbAidat.Size = new System.Drawing.Size(87, 23);
            this.rbAidat.TabIndex = 3;
            this.rbAidat.TabStop = true;
            this.rbAidat.Text = "Aidat Ara";
            this.rbAidat.UseVisualStyleBackColor = true;
            this.rbAidat.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Aidat / Ek Dönemi:";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cb1.Location = new System.Drawing.Point(169, 61);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(177, 27);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvMakbuz
            // 
            this.dgvMakbuz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMakbuz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMakbuz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMakbuz.Location = new System.Drawing.Point(31, 96);
            this.dgvMakbuz.Name = "dgvMakbuz";
            this.dgvMakbuz.RowTemplate.Height = 25;
            this.dgvMakbuz.Size = new System.Drawing.Size(370, 468);
            this.dgvMakbuz.TabIndex = 0;
            this.dgvMakbuz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMakbuz_CellEndEdit);
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // aidatodeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1386, 650);
            this.MinimumSize = new System.Drawing.Size(1358, 650);
            this.Name = "aidatodeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aidat Ödeme";
            this.Load += new System.EventHandler(this.aidatodeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakbuz)).EndInit();
            this.ResumeLayout(false);

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
    }
}