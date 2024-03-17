namespace muhasebe
{
    partial class borclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borclar));
            label5 = new Label();
            txtTarih = new DateTimePicker();
            label4 = new Label();
            txtFiyat = new TextBox();
            label1 = new Label();
            dgvBorc = new DataGridView();
            button6 = new Button();
            groupBox1 = new GroupBox();
            lblAd = new Label();
            txtAciklama = new RichTextBox();
            txtCari = new ComboBox();
            button8 = new Button();
            label3 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorc).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(855, 208);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 41;
            label5.Text = "Tarih";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(855, 245);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(341, 31);
            txtTarih.TabIndex = 40;
            txtTarih.ValueChanged += txtTarih_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(855, 129);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 39;
            label4.Text = "Borç Miktarı";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(855, 159);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(341, 31);
            txtFiyat.TabIndex = 38;
            txtFiyat.KeyPress += txtFiyat_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(855, 55);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 37;
            label1.Text = "Cari";
            // 
            // dgvBorc
            // 
            dgvBorc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorc.BackgroundColor = SystemColors.ActiveCaption;
            dgvBorc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorc.Location = new Point(28, 45);
            dgvBorc.Name = "dgvBorc";
            dgvBorc.RowTemplate.Height = 25;
            dgvBorc.Size = new Size(746, 511);
            dgvBorc.TabIndex = 35;
            dgvBorc.CellClick += dgvBorc_CellClick;
            dgvBorc.CellContentClick += dgvBorc_CellContentClick;
            // 
            // button6
            // 
            button6.BackColor = Color.LimeGreen;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.White;
            button6.Location = new Point(893, 500);
            button6.Name = "button6";
            button6.Size = new Size(128, 38);
            button6.TabIndex = 49;
            button6.Text = "Borcu Arttır";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtCari);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dgvBorc);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borçlar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(28, 586);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(181, 24);
            lblAd.TabIndex = 56;
            lblAd.Text = "Cari Ad Soyad - Borç";
            lblAd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(855, 326);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(341, 156);
            txtAciklama.TabIndex = 55;
            txtAciklama.Text = "";
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCari.FormattingEnabled = true;
            txtCari.Location = new Point(855, 84);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(341, 32);
            txtCari.TabIndex = 54;
            txtCari.SelectedIndexChanged += txtCari_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.Firebrick;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = Color.White;
            button8.Location = new Point(1045, 500);
            button8.Name = "button8";
            button8.Size = new Size(133, 38);
            button8.TabIndex = 53;
            button8.Text = "Borcu Azalt";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(855, 297);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 52;
            label3.Text = "Açıklama";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(957, 558);
            button7.Name = "button7";
            button7.Size = new Size(166, 38);
            button7.TabIndex = 50;
            button7.Text = "ÇIKIŞ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // borclar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(870, 468);
            Name = "borclar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borçlar";
            Load += borclar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private DateTimePicker txtTarih;
        private Label label4;
        private TextBox txtFiyat;
        private Label label1;
        private DataGridView dgvBorc;
        private Button button6;
        private GroupBox groupBox1;
        private Button button7;
        private Button button8;
        private Label label3;
        private RichTextBox txtAciklama;
        private ComboBox txtCari;
        private Label lblAd;
    }
}