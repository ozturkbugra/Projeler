namespace muhasebe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button4 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            lblGider = new Label();
            label4 = new Label();
            txtOdemeTuru = new ComboBox();
            button3 = new Button();
            dgvGider = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 192);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Location = new Point(944, 495);
            button4.Name = "button4";
            button4.Size = new Size(266, 37);
            button4.TabIndex = 32;
            button4.Text = "PDF OLARAK İNDİR";
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblGider);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOdemeTuru);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Türüne Göre Hesaplama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Righteous", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(944, 387);
            label3.Name = "label3";
            label3.Size = new Size(105, 34);
            label3.TabIndex = 35;
            label3.Text = "GİDER:";
            // 
            // lblGider
            // 
            lblGider.AutoSize = true;
            lblGider.Font = new Font("Righteous", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGider.Location = new Point(1047, 387);
            lblGider.Name = "lblGider";
            lblGider.Size = new Size(33, 34);
            lblGider.TabIndex = 36;
            lblGider.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(920, 44);
            label4.Name = "label4";
            label4.Size = new Size(200, 24);
            label4.TabIndex = 34;
            label4.Text = "Ödeme Türünü Seçiniz";
            label4.Click += label4_Click;
            // 
            // txtOdemeTuru
            // 
            txtOdemeTuru.FormattingEnabled = true;
            txtOdemeTuru.Items.AddRange(new object[] { "Ulaşım", "Lokanta", "Market", "Ekmek", "Giyim", "Sağlık", "Eğitim", "Elektrik", "Su", "İnternet", "DoğalGaz", "Telefon", "Araba", "Berber", "Altın", "Döviz", "Hisse", "Diğer" });
            txtOdemeTuru.Location = new Point(919, 73);
            txtOdemeTuru.Name = "txtOdemeTuru";
            txtOdemeTuru.Size = new Size(308, 32);
            txtOdemeTuru.TabIndex = 33;
            txtOdemeTuru.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1017, 559);
            button3.Name = "button3";
            button3.Size = new Size(138, 39);
            button3.TabIndex = 31;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(919, 120);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 23;
            label2.Text = "Tarih aralığını seçiniz";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(944, 275);
            button1.Name = "button1";
            button1.Size = new Size(266, 48);
            button1.TabIndex = 13;
            button1.Text = "SEKTÖRE GÖRE HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(919, 212);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(308, 31);
            dtSon.TabIndex = 12;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(920, 153);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(307, 31);
            dtBas.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme Türüne Göre Giderler";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox txtOdemeTuru;
        private Button button3;
        private DataGridView dgvGider;
        private Label label2;
        private Button button1;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private Label label3;
        private Label lblGider;
    }
}