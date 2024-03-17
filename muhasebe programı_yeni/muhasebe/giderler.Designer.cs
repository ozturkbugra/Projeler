namespace muhasebe
{
    partial class giderler
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
            Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giderler));
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtAciklama = new RichTextBox();
            txtOdemeTuru = new ComboBox();
            label1 = new Label();
            button7 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            label7 = new Label();
            button6 = new Button();
            label6 = new Label();
            button5 = new Button();
            sektör2 = new ComboBox();
            button4 = new Button();
            txtAra = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            txtTarih = new DateTimePicker();
            label4 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            txtSektör = new ComboBox();
            dgvGider = new DataGridView();
            txtKisi = new ComboBox();
            label8 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1010, 535);
            button3.Name = "button3";
            button3.Size = new Size(89, 33);
            button3.TabIndex = 8;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 45);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 18;
            label2.Text = "ARA";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtKisi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtOdemeTuru);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(sektör2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtAra);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSektör);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gider Ekleme";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(798, 57);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(301, 81);
            txtAciklama.TabIndex = 1;
            txtAciklama.Text = "";
            // 
            // txtOdemeTuru
            // 
            txtOdemeTuru.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtOdemeTuru.FormattingEnabled = true;
            txtOdemeTuru.Location = new Point(798, 400);
            txtOdemeTuru.Name = "txtOdemeTuru";
            txtOdemeTuru.Size = new Size(301, 32);
            txtOdemeTuru.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(798, 370);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 46;
            label1.Text = "Ödeme Türü";
            // 
            // button7
            // 
            button7.BackColor = Color.MediumSeaGreen;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(255, 596);
            button7.Name = "button7";
            button7.Size = new Size(251, 30);
            button7.TabIndex = 14;
            button7.Text = "Tarih Aralığını Listele";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dtSon
            // 
            dtSon.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtSon.Location = new Point(388, 559);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(285, 31);
            dtSon.TabIndex = 13;
            // 
            // dtBas
            // 
            dtBas.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtBas.Location = new Point(77, 559);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(285, 31);
            dtBas.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(796, 27);
            label7.Name = "label7";
            label7.Size = new Size(98, 27);
            label7.TabIndex = 41;
            label7.Text = "Açıklama";
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(856, 584);
            button6.Name = "button6";
            button6.Size = new Size(208, 35);
            button6.TabIndex = 39;
            button6.Text = "ÇIKIŞ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 27);
            label6.Name = "label6";
            label6.Size = new Size(44, 24);
            label6.TabIndex = 38;
            label6.Text = "ARA";
            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(543, 512);
            button5.Name = "button5";
            button5.Size = new Size(185, 30);
            button5.TabIndex = 11;
            button5.Text = "Tümünü listele";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // sektör2
            // 
            sektör2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sektör2.FormattingEnabled = true;
            sektör2.ItemHeight = 24;
            sektör2.Location = new Point(31, 510);
            sektör2.Name = "sektör2";
            sektör2.Size = new Size(287, 32);
            sektör2.TabIndex = 36;
            sektör2.KeyPress += sektör2_KeyPress_1;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(324, 512);
            button4.Name = "button4";
            button4.Size = new Size(213, 30);
            button4.TabIndex = 10;
            button4.Text = "Sektöre göre listele";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.Location = new Point(81, 27);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(647, 31);
            txtAra.TabIndex = 34;
            txtAra.TextChanged += txtAra_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(886, 535);
            button2.Name = "button2";
            button2.Size = new Size(115, 33);
            button2.TabIndex = 7;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(798, 535);
            button1.Name = "button1";
            button1.Size = new Size(80, 33);
            button1.TabIndex = 6;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(796, 293);
            label5.Name = "label5";
            label5.Size = new Size(61, 27);
            label5.TabIndex = 30;
            label5.Text = "Tarih";
            // 
            // txtTarih
            // 
            txtTarih.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTarih.Location = new Point(798, 322);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(301, 31);
            txtTarih.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(797, 223);
            label4.Name = "label4";
            label4.Size = new Size(59, 27);
            label4.TabIndex = 28;
            label4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtFiyat.Location = new Point(798, 251);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(301, 31);
            txtFiyat.TabIndex = 3;
            txtFiyat.KeyPress += txtFiyat_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(798, 153);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 26;
            label3.Text = "Sektör";
            // 
            // txtSektör
            // 
            txtSektör.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSektör.FormattingEnabled = true;
            txtSektör.Location = new Point(798, 180);
            txtSektör.Name = "txtSektör";
            txtSektör.Size = new Size(301, 32);
            txtSektör.TabIndex = 2;
            txtSektör.KeyPress += txtSektör_KeyPress_1;
            // 
            // dgvGider
            // 
            dgvGider.AllowUserToAddRows = false;
            dgvGider.AllowUserToDeleteRows = false;
            dgvGider.AllowUserToOrderColumns = true;
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(33, 64);
            dgvGider.Name = "dgvGider";
            dgvGider.ReadOnly = true;
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(695, 440);
            dgvGider.TabIndex = 22;
            dgvGider.CellClick += dgvGider_CellClick_1;
            // 
            // txtKisi
            // 
            txtKisi.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKisi.FormattingEnabled = true;
            txtKisi.Location = new Point(798, 472);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(301, 32);
            txtKisi.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(798, 442);
            label8.Name = "label8";
            label8.Size = new Size(46, 27);
            label8.TabIndex = 48;
            label8.Text = "Kişi";
            // 
            // giderler
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "giderler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giderler";
            Load += giderler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private Button button5;
        private ComboBox sektör2;
        private Button button4;
        private TextBox txtAra;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private DateTimePicker txtTarih;
        private Label label4;
        private TextBox txtFiyat;
        private Label label3;
        private ComboBox txtSektör;
        private DataGridView dgvGider;
        private Label label6;
        private Button button6;
        private Label label7;
        private Button button7;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private ComboBox txtOdemeTuru;
        private Label label1;
        private RichTextBox txtAciklama;
        private ComboBox txtKisi;
        private Label label8;
    }
}