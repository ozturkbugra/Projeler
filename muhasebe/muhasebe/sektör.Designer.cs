namespace muhasebe
{
    partial class sektör
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sektör));
            this.dgvGider = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtSon = new System.Windows.Forms.DateTimePicker();
            this.dtBas = new System.Windows.Forms.DateTimePicker();
            this.lblGider = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSektör = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnflasyon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBas = new System.Windows.Forms.TextBox();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGider
            // 
            this.dgvGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGider.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGider.Location = new System.Drawing.Point(21, 30);
            this.dgvGider.Name = "dgvGider";
            this.dgvGider.RowTemplate.Height = 25;
            this.dgvGider.Size = new System.Drawing.Size(856, 572);
            this.dgvGider.TabIndex = 0;
            this.dgvGider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGider_CellClick);
            this.dgvGider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGider_CellContentClick);
            this.dgvGider.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGider_CellEndEdit);
            this.dgvGider.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGider_CellMouseClick);
            this.dgvGider.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvGider_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(934, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "SEKTÖRE GÖRE HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtSon
            // 
            this.dtSon.Location = new System.Drawing.Point(919, 178);
            this.dtSon.Name = "dtSon";
            this.dtSon.Size = new System.Drawing.Size(308, 31);
            this.dtSon.TabIndex = 12;
            // 
            // dtBas
            // 
            this.dtBas.Location = new System.Drawing.Point(920, 131);
            this.dtBas.Name = "dtBas";
            this.dtBas.Size = new System.Drawing.Size(307, 31);
            this.dtBas.TabIndex = 11;
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGider.Location = new System.Drawing.Point(1051, 293);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(33, 34);
            this.lblGider.TabIndex = 10;
            this.lblGider.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(948, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "GİDER:";
            // 
            // txtSektör
            // 
            this.txtSektör.FormattingEnabled = true;
            this.txtSektör.Items.AddRange(new object[] {
            "Ulaşım",
            "Lokanta",
            "Market",
            "Ekmek",
            "Giyim",
            "Sağlık",
            "Eğitim",
            "Elektrik",
            "Su",
            "İnternet",
            "DoğalGaz",
            "Telefon",
            "Araba",
            "Berber",
            "Altın",
            "Döviz",
            "Hisse",
            "Diğer"});
            this.txtSektör.Location = new System.Drawing.Point(919, 67);
            this.txtSektör.Name = "txtSektör";
            this.txtSektör.Size = new System.Drawing.Size(308, 32);
            this.txtSektör.TabIndex = 21;
            this.txtSektör.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSektör_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(920, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sektör Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tarih aralığını seçiniz";
            // 
            // lblEnflasyon
            // 
            this.lblEnflasyon.AutoSize = true;
            this.lblEnflasyon.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnflasyon.Location = new System.Drawing.Point(1117, 524);
            this.lblEnflasyon.Name = "lblEnflasyon";
            this.lblEnflasyon.Size = new System.Drawing.Size(23, 24);
            this.lblEnflasyon.TabIndex = 25;
            this.lblEnflasyon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(984, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enflasyon: %";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBas
            // 
            this.txtBas.Location = new System.Drawing.Point(934, 420);
            this.txtBas.Name = "txtBas";
            this.txtBas.Size = new System.Drawing.Size(124, 31);
            this.txtBas.TabIndex = 26;
            this.txtBas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBas_KeyPress);
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(1077, 420);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(138, 31);
            this.txtSon.TabIndex = 27;
            this.txtSon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSon_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "İlk Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1077, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Son Fiyat";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(965, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Enflasyon Hesapla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dgvGider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSektör);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtSon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtBas);
            this.groupBox1.Controls.Add(this.lblGider);
            this.groupBox1.Controls.Add(this.txtSon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBas);
            this.groupBox1.Controls.Add(this.lblEnflasyon);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 637);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sektöre Göre Hesaplama";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(934, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 37);
            this.button4.TabIndex = 32;
            this.button4.Text = "PDF OLARAK İNDİR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1002, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 39);
            this.button3.TabIndex = 31;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sektör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "sektör";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sektöre Göre Listeleme";
            this.Load += new System.EventHandler(this.sektör_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvGider;
        private Button button1;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private Label lblGider;
        private Label label3;
        private ComboBox txtSektör;
        private Label label1;
        private Label label2;
        private Label lblEnflasyon;
        private Label label5;
        private TextBox txtBas;
        private TextBox txtSon;
        private Label label4;
        private Label label6;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
    }
}