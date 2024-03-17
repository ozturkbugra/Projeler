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
            dgvGider = new DataGridView();
            button1 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            lblGider = new Label();
            label3 = new Label();
            txtSektör = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblEnflasyon = new Label();
            label5 = new Label();
            txtBas = new TextBox();
            txtSon = new TextBox();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            txtAktif = new CheckBox();
            label7 = new Label();
            txtKisi = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(21, 30);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(856, 572);
            dgvGider.TabIndex = 0;
            dgvGider.CellClick += dgvGider_CellClick;
            dgvGider.CellContentClick += dgvGider_CellContentClick;
            dgvGider.CellEndEdit += dgvGider_CellEndEdit;
            dgvGider.CellMouseClick += dgvGider_CellMouseClick;
            dgvGider.MouseClick += dgvGider_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(944, 307);
            button1.Name = "button1";
            button1.Size = new Size(266, 48);
            button1.TabIndex = 13;
            button1.Text = "SEKTÖRE GÖRE HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(919, 178);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(308, 31);
            dtSon.TabIndex = 12;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(920, 131);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(307, 31);
            dtBas.TabIndex = 11;
            // 
            // lblGider
            // 
            lblGider.AutoSize = true;
            lblGider.Font = new Font("Righteous", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGider.Location = new Point(1066, 381);
            lblGider.Name = "lblGider";
            lblGider.Size = new Size(33, 34);
            lblGider.TabIndex = 10;
            lblGider.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Righteous", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(963, 381);
            label3.Name = "label3";
            label3.Size = new Size(105, 34);
            label3.TabIndex = 9;
            label3.Text = "GİDER:";
            // 
            // txtSektör
            // 
            txtSektör.FormattingEnabled = true;
            txtSektör.Location = new Point(919, 67);
            txtSektör.Name = "txtSektör";
            txtSektör.Size = new Size(308, 32);
            txtSektör.TabIndex = 21;
            txtSektör.KeyPress += txtSektör_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(920, 38);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 22;
            label1.Text = "Sektör Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(919, 105);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 23;
            label2.Text = "Tarih aralığını seçiniz";
            // 
            // lblEnflasyon
            // 
            lblEnflasyon.AutoSize = true;
            lblEnflasyon.Font = new Font("Righteous", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnflasyon.Location = new Point(1127, 606);
            lblEnflasyon.Name = "lblEnflasyon";
            lblEnflasyon.Size = new Size(23, 24);
            lblEnflasyon.TabIndex = 25;
            lblEnflasyon.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Righteous", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(994, 606);
            label5.Name = "label5";
            label5.Size = new Size(134, 24);
            label5.TabIndex = 24;
            label5.Text = "Enflasyon: %";
            label5.Click += label5_Click;
            // 
            // txtBas
            // 
            txtBas.Location = new Point(944, 502);
            txtBas.Name = "txtBas";
            txtBas.Size = new Size(124, 31);
            txtBas.TabIndex = 26;
            txtBas.KeyPress += txtBas_KeyPress;
            // 
            // txtSon
            // 
            txtSon.Location = new Point(1087, 502);
            txtSon.Name = "txtSon";
            txtSon.Size = new Size(138, 31);
            txtSon.TabIndex = 27;
            txtSon.KeyPress += txtSon_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(944, 475);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 28;
            label4.Text = "İlk Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1087, 475);
            label6.Name = "label6";
            label6.Size = new Size(90, 24);
            label6.TabIndex = 29;
            label6.Text = "Son Fiyat";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(975, 551);
            button2.Name = "button2";
            button2.Size = new Size(225, 39);
            button2.TabIndex = 30;
            button2.Text = "Enflasyon Hesapla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAktif);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtKisi);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSektör);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Controls.Add(lblGider);
            groupBox1.Controls.Add(txtSon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBas);
            groupBox1.Controls.Add(lblEnflasyon);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sektöre Göre Hesaplama";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtAktif
            // 
            txtAktif.AutoSize = true;
            txtAktif.Location = new Point(898, 263);
            txtAktif.Name = "txtAktif";
            txtAktif.Size = new Size(15, 14);
            txtAktif.TabIndex = 35;
            txtAktif.UseVisualStyleBackColor = true;
            txtAktif.CheckedChanged += txtAktif_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(919, 227);
            label7.Name = "label7";
            label7.Size = new Size(238, 24);
            label7.TabIndex = 34;
            label7.Text = "Kişi Seçiniz (Zorunlu Değil)";
            // 
            // txtKisi
            // 
            txtKisi.FormattingEnabled = true;
            txtKisi.Location = new Point(919, 254);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(308, 32);
            txtKisi.TabIndex = 33;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 192);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Location = new Point(944, 424);
            button4.Name = "button4";
            button4.Size = new Size(266, 37);
            button4.TabIndex = 32;
            button4.Text = "PDF OLARAK İNDİR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sektör
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "sektör";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sektöre Göre Listeleme";
            Load += sektör_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button button4;
        private CheckBox txtAktif;
        private Label label7;
        private ComboBox txtKisi;
    }
}