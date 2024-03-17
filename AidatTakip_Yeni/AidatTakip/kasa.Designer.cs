namespace AidatTakip
{
    partial class kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasa));
            groupBox1 = new GroupBox();
            dgvGider = new DataGridView();
            groupBox2 = new GroupBox();
            dgvAidat = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGider = new TextBox();
            txtGelir = new TextBox();
            txtKasa = new TextBox();
            txtAlacak = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            txtGelir2 = new TextBox();
            txtGider2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            lblAy = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 515);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giderler";
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(15, 38);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(607, 460);
            dgvGider.TabIndex = 12;
            dgvGider.CellContentClick += dgvGider_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAidat);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(686, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(672, 515);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gelirler";
            // 
            // dgvAidat
            // 
            dgvAidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAidat.BackgroundColor = SystemColors.ActiveCaption;
            dgvAidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAidat.Location = new Point(14, 38);
            dgvAidat.Name = "dgvAidat";
            dgvAidat.RowTemplate.Height = 25;
            dgvAidat.Size = new Size(650, 460);
            dgvAidat.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 3;
            label1.Text = "Giderler";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 24);
            label2.TabIndex = 14;
            label2.Text = "Gelirler";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(573, 7);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 16;
            label3.Text = "KASA:";
            // 
            // txtGider
            // 
            txtGider.Enabled = false;
            txtGider.Location = new Point(102, 17);
            txtGider.Name = "txtGider";
            txtGider.Size = new Size(160, 23);
            txtGider.TabIndex = 24;
            txtGider.TextAlign = HorizontalAlignment.Center;
            txtGider.TextChanged += txtGider_TextChanged;
            // 
            // txtGelir
            // 
            txtGelir.Enabled = false;
            txtGelir.Location = new Point(102, 50);
            txtGelir.Name = "txtGelir";
            txtGelir.Size = new Size(160, 23);
            txtGelir.TabIndex = 25;
            txtGelir.TextAlign = HorizontalAlignment.Center;
            txtGelir.TextChanged += txtGelir_TextChanged;
            // 
            // txtKasa
            // 
            txtKasa.Enabled = false;
            txtKasa.Location = new Point(668, 13);
            txtKasa.Name = "txtKasa";
            txtKasa.Size = new Size(133, 23);
            txtKasa.TabIndex = 26;
            txtKasa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAlacak
            // 
            txtAlacak.Enabled = false;
            txtAlacak.ForeColor = Color.Black;
            txtAlacak.Location = new Point(668, 49);
            txtAlacak.Name = "txtAlacak";
            txtAlacak.Size = new Size(133, 23);
            txtAlacak.TabIndex = 29;
            txtAlacak.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Maroon;
            label8.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(569, 47);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 28;
            label8.Text = "ALACAK:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Red;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(256, 31);
            dataGridView1.TabIndex = 30;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(0, 192, 0);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(256, 31);
            dataGridView2.TabIndex = 31;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Maroon;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(556, 45);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(256, 31);
            dataGridView3.TabIndex = 32;
            // 
            // txtGelir2
            // 
            txtGelir2.Enabled = false;
            txtGelir2.Location = new Point(1180, 50);
            txtGelir2.Name = "txtGelir2";
            txtGelir2.Size = new Size(160, 23);
            txtGelir2.TabIndex = 36;
            txtGelir2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGider2
            // 
            txtGider2.Enabled = false;
            txtGider2.Location = new Point(1180, 17);
            txtGider2.Name = "txtGider2";
            txtGider2.Size = new Size(160, 23);
            txtGider2.TabIndex = 35;
            txtGider2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1096, 17);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 33;
            label4.Text = "Giderler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1096, 49);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 34;
            label5.Text = "Gelirler";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.Red;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(1090, 13);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(256, 31);
            dataGridView4.TabIndex = 37;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = Color.FromArgb(0, 192, 0);
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(1090, 46);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(256, 31);
            dataGridView5.TabIndex = 38;
            // 
            // lblAy
            // 
            lblAy.AutoSize = true;
            lblAy.Location = new Point(1020, 20);
            lblAy.Name = "lblAy";
            lblAy.Size = new Size(21, 15);
            lblAy.TabIndex = 39;
            lblAy.Text = "AY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1000, 45);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 40;
            label6.Text = "AYI TOPLAM ";
            // 
            // kasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(label6);
            Controls.Add(lblAy);
            Controls.Add(txtGelir2);
            Controls.Add(txtGider2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView5);
            Controls.Add(txtAlacak);
            Controls.Add(label8);
            Controls.Add(txtKasa);
            Controls.Add(txtGelir);
            Controls.Add(txtGider);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1386, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1358, 650);
            Name = "kasa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasa";
            Load += kasa_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAidat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvGider;
        private GroupBox groupBox2;
        private DataGridView dgvAidat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGider;
        private TextBox txtGelir;
        private TextBox txtAlacak;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private TextBox txtGelir2;
        private TextBox txtGider2;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Label lblAy;
        private Label label6;
        public TextBox txtKasa;
    }
}