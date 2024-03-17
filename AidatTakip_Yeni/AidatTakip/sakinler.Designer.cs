namespace AidatTakip
{
    partial class sakinler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sakinler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSakin1 = new System.Windows.Forms.DataGridView();
            this.txtDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdAd = new System.Windows.Forms.RadioButton();
            this.rdDaireNo = new System.Windows.Forms.RadioButton();
            this.dgvSakin2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakin1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakin2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvSakin1);
            this.groupBox1.Controls.Add(this.txtDurum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 545);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sakin Ekleme";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(260, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "DÜZENLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(127, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "*başında 0 olmadan girin";
            // 
            // dgvSakin1
            // 
            this.dgvSakin1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSakin1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSakin1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSakin1.Location = new System.Drawing.Point(35, 38);
            this.dgvSakin1.Name = "dgvSakin1";
            this.dgvSakin1.RowTemplate.Height = 25;
            this.dgvSakin1.Size = new System.Drawing.Size(551, 290);
            this.dgvSakin1.TabIndex = 8;
            this.dgvSakin1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSakin1_CellClick);
            // 
            // txtDurum
            // 
            this.txtDurum.FormattingEnabled = true;
            this.txtDurum.Items.AddRange(new object[] {
            "EV SAHİBİ",
            "KİRACI"});
            this.txtDurum.Location = new System.Drawing.Point(394, 428);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 27);
            this.txtDurum.TabIndex = 7;
            this.txtDurum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDurum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "DURUM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEL NO:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(194, 425);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 27);
            this.txtTelNo.TabIndex = 4;
            this.txtTelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelNo_KeyDown);
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(321, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(396, 377);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(194, 376);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 27);
            this.txtAd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.rdAd);
            this.groupBox2.Controls.Add(this.rdDaireNo);
            this.groupBox2.Controls.Add(this.dgvSakin2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(650, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 545);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sakin Arama";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(247, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "ARAMA YAP";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(53, 67);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(504, 27);
            this.txtAra.TabIndex = 11;
            // 
            // rdAd
            // 
            this.rdAd.AutoSize = true;
            this.rdAd.Location = new System.Drawing.Point(350, 38);
            this.rdAd.Name = "rdAd";
            this.rdAd.Size = new System.Drawing.Size(113, 23);
            this.rdAd.TabIndex = 10;
            this.rdAd.TabStop = true;
            this.rdAd.Text = "Ada Göre Ara";
            this.rdAd.UseVisualStyleBackColor = true;
            // 
            // rdDaireNo
            // 
            this.rdDaireNo.AutoSize = true;
            this.rdDaireNo.Location = new System.Drawing.Point(114, 38);
            this.rdDaireNo.Name = "rdDaireNo";
            this.rdDaireNo.Size = new System.Drawing.Size(205, 23);
            this.rdDaireNo.TabIndex = 9;
            this.rdDaireNo.TabStop = true;
            this.rdDaireNo.Text = "Daire Numarasına Göre Ara";
            this.rdDaireNo.UseVisualStyleBackColor = true;
            // 
            // dgvSakin2
            // 
            this.dgvSakin2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSakin2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSakin2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSakin2.Location = new System.Drawing.Point(29, 152);
            this.dgvSakin2.Name = "dgvSakin2";
            this.dgvSakin2.RowTemplate.Height = 25;
            this.dgvSakin2.Size = new System.Drawing.Size(551, 373);
            this.dgvSakin2.TabIndex = 8;
            // 
            // sakinler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1386, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1358, 650);
            this.Name = "sakinler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sakinler";
            this.Load += new System.EventHandler(this.sakinler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakin1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakin2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txtDurum;
        private Label label4;
        private Label label3;
        private TextBox txtTelNo;
        private Label label2;
        private TextBox txtSoyad;
        private Label label1;
        private TextBox txtAd;
        private Button button2;
        private Label label5;
        private DataGridView dgvSakin1;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox txtAra;
        private RadioButton rdAd;
        private RadioButton rdDaireNo;
        private DataGridView dgvSakin2;
    }
}