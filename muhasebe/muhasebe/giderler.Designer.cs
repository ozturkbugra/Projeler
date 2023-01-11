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
            System.Windows.Forms.Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giderler));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dtSon = new System.Windows.Forms.DateTimePicker();
            this.dtBas = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.sektör2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSektör = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiderAdi = new System.Windows.Forms.TextBox();
            this.dgvGider = new System.Windows.Forms.DataGridView();
            button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.DarkRed;
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(1011, 420);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(89, 33);
            button3.TabIndex = 33;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "ARA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.dtSon);
            this.groupBox1.Controls.Add(this.dtBas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.sektör2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSektör);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiderAdi);
            this.groupBox1.Controls.Add(this.dgvGider);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 637);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gider Ekleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(255, 596);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(251, 30);
            this.button7.TabIndex = 44;
            this.button7.Text = "Tarih Aralığını Listele";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtSon
            // 
            this.dtSon.Location = new System.Drawing.Point(388, 559);
            this.dtSon.Name = "dtSon";
            this.dtSon.Size = new System.Drawing.Size(285, 31);
            this.dtSon.TabIndex = 43;
            // 
            // dtBas
            // 
            this.dtBas.Location = new System.Drawing.Point(77, 559);
            this.dtBas.Name = "dtBas";
            this.dtBas.Size = new System.Drawing.Size(285, 31);
            this.dtBas.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(799, 369);
            this.txtAciklama.MaxLength = 100;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(301, 31);
            this.txtAciklama.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(857, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 35);
            this.button6.TabIndex = 39;
            this.button6.Text = "ÇIKIŞ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 38;
            this.label6.Text = "ARA";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aquamarine;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(543, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 30);
            this.button5.TabIndex = 37;
            this.button5.Text = "Tümünü listele";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // sektör2
            // 
            this.sektör2.FormattingEnabled = true;
            this.sektör2.Items.AddRange(new object[] {
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
            this.sektör2.Location = new System.Drawing.Point(31, 510);
            this.sektör2.Name = "sektör2";
            this.sektör2.Size = new System.Drawing.Size(287, 32);
            this.sektör2.TabIndex = 36;
            this.sektör2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sektör2_KeyPress_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(324, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 30);
            this.button4.TabIndex = 35;
            this.button4.Text = "Sektöre göre listele";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(99, 27);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(626, 31);
            this.txtAra.TabIndex = 34;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(887, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(799, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(799, 297);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(301, 31);
            this.txtTarih.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(799, 226);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(301, 31);
            this.txtFiyat.TabIndex = 27;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sektör";
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
            this.txtSektör.Location = new System.Drawing.Point(799, 155);
            this.txtSektör.Name = "txtSektör";
            this.txtSektör.Size = new System.Drawing.Size(301, 32);
            this.txtSektör.TabIndex = 25;
            this.txtSektör.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSektör_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gider Adı";
            // 
            // txtGiderAdi
            // 
            this.txtGiderAdi.Location = new System.Drawing.Point(799, 92);
            this.txtGiderAdi.MaxLength = 50;
            this.txtGiderAdi.Name = "txtGiderAdi";
            this.txtGiderAdi.Size = new System.Drawing.Size(301, 31);
            this.txtGiderAdi.TabIndex = 23;
            // 
            // dgvGider
            // 
            this.dgvGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGider.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGider.Location = new System.Drawing.Point(33, 64);
            this.dgvGider.Name = "dgvGider";
            this.dgvGider.RowTemplate.Height = 25;
            this.dgvGider.Size = new System.Drawing.Size(695, 440);
            this.dgvGider.TabIndex = 22;
            this.dgvGider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGider_CellClick_1);
            // 
            // giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "giderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.giderler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label1;
        private TextBox txtGiderAdi;
        private DataGridView dgvGider;
        private Label label6;
        private Button button6;
        private Label label7;
        private TextBox txtAciklama;
        private Button button7;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
    }
}