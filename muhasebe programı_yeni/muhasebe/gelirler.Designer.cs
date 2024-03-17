namespace muhasebe
{
    partial class gelirler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gelirler));
            label2 = new Label();
            txtAra = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            txtTarih = new DateTimePicker();
            label4 = new Label();
            txtFiyat = new TextBox();
            dgvGelir = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtKisi = new ComboBox();
            txtAciklama = new RichTextBox();
            button7 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            label3 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGelir).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(64, 34);
            label2.TabIndex = 33;
            label2.Text = "ARA";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(92, 36);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(603, 31);
            txtAra.TabIndex = 32;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1023, 516);
            button3.Name = "button3";
            button3.Size = new Size(91, 37);
            button3.TabIndex = 7;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(880, 516);
            button2.Name = "button2";
            button2.Size = new Size(128, 37);
            button2.TabIndex = 6;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(768, 516);
            button1.Name = "button1";
            button1.Size = new Size(97, 37);
            button1.TabIndex = 5;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 288);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 28;
            label5.Text = "Tarih";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(768, 314);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(346, 31);
            txtTarih.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 203);
            label4.Name = "label4";
            label4.Size = new Size(53, 24);
            label4.TabIndex = 26;
            label4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(768, 233);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(346, 31);
            txtFiyat.TabIndex = 2;
            txtFiyat.KeyPress += txtFiyat_KeyPress;
            // 
            // dgvGelir
            // 
            dgvGelir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelir.BackgroundColor = SystemColors.ActiveCaption;
            dgvGelir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelir.Location = new Point(31, 73);
            dgvGelir.Name = "dgvGelir";
            dgvGelir.RowTemplate.Height = 25;
            dgvGelir.Size = new Size(664, 443);
            dgvGelir.TabIndex = 20;
            dgvGelir.CellClick += dgvGelir_CellClick;
            dgvGelir.CellContentClick += dgvGelir_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtKisi);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAra);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(dgvGelir);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelir Ekleme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(765, 378);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 50;
            label1.Text = "Gelir Kişi";
            // 
            // txtKisi
            // 
            txtKisi.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKisi.FormattingEnabled = true;
            txtKisi.Location = new Point(765, 405);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(349, 32);
            txtKisi.TabIndex = 4;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(765, 96);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(349, 96);
            txtAciklama.TabIndex = 1;
            txtAciklama.Text = "";
            // 
            // button7
            // 
            button7.BackColor = Color.MediumSeaGreen;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(244, 575);
            button7.Name = "button7";
            button7.Size = new Size(251, 30);
            button7.TabIndex = 10;
            button7.Text = "Tarih Aralığını Listele";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(377, 538);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(285, 31);
            dtSon.TabIndex = 9;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(66, 538);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(285, 31);
            dtBas.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(765, 69);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 36;
            label3.Text = "Açıklama";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Location = new Point(857, 575);
            button4.Name = "button4";
            button4.Size = new Size(190, 37);
            button4.TabIndex = 11;
            button4.Text = "ÇIKIŞ YAP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // gelirler
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "gelirler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelirler";
            Load += gelirler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGelir).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtAra;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private DateTimePicker txtTarih;
        private Label label4;
        private TextBox txtFiyat;
        private DataGridView dgvGelir;
        private GroupBox groupBox1;
        private Button button4;
        private Button button7;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private RichTextBox txtAciklama;
        private Label label3;
        private Label label1;
        private ComboBox txtKisi;
    }
}