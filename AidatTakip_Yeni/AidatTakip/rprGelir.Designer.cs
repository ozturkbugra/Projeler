namespace AidatTakip
{
    partial class rprGelir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rprGelir));
            groupBox2 = new GroupBox();
            label8 = new Label();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dgvTahsilat = new DataGridView();
            label7 = new Label();
            label4 = new Label();
            dgvAidat = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument3 = new System.Drawing.Printing.PrintDocument();
            label9 = new Label();
            label6 = new Label();
            txtAy = new ComboBox();
            txtYıl = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTahsilat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAy);
            groupBox2.Controls.Add(txtYıl);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dgvTahsilat);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dgvAidat);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 587);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gelirler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(518, 565);
            label8.Name = "label8";
            label8.Size = new Size(308, 19);
            label8.TabIndex = 42;
            label8.Text = "Seçeceğiniz ilk tarihin saati 00:00:00 olmalıdır.";
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(873, 520);
            button5.Name = "button5";
            button5.Size = new Size(118, 44);
            button5.TabIndex = 32;
            button5.Text = "PDF İNDİR";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(290, 514);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 31;
            button1.Text = "PDF İNDİR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(603, 527);
            button4.Name = "button4";
            button4.Size = new Size(145, 37);
            button4.TabIndex = 30;
            button4.Text = "Tümünü Listele";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(997, 520);
            button3.Name = "button3";
            button3.Size = new Size(321, 44);
            button3.TabIndex = 29;
            button3.Text = "Tarihleri Arası Tahsilat Makbuzları Yazdır";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(21, 514);
            button2.Name = "button2";
            button2.Size = new Size(263, 44);
            button2.TabIndex = 28;
            button2.Text = "Tarihleri Arası Makbuzları Yazdır";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgvTahsilat
            // 
            dgvTahsilat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTahsilat.BackgroundColor = SystemColors.ActiveCaption;
            dgvTahsilat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTahsilat.Location = new Point(723, 61);
            dgvTahsilat.Name = "dgvTahsilat";
            dgvTahsilat.RowTemplate.Height = 25;
            dgvTahsilat.Size = new Size(595, 419);
            dgvTahsilat.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(723, 23);
            label7.Name = "label7";
            label7.Size = new Size(127, 36);
            label7.TabIndex = 22;
            label7.Text = "TAHSİLAT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 23);
            label4.Name = "label4";
            label4.Size = new Size(143, 36);
            label4.TabIndex = 18;
            label4.Text = "Makbuzlar";
            // 
            // dgvAidat
            // 
            dgvAidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAidat.BackgroundColor = SystemColors.ActiveCaption;
            dgvAidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAidat.Location = new Point(21, 61);
            dgvAidat.Name = "dgvAidat";
            dgvAidat.RowTemplate.Height = 25;
            dgvAidat.Size = new Size(679, 419);
            dgvAidat.TabIndex = 12;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDocument3
            // 
            printDocument3.BeginPrint += printDocument3_BeginPrint;
            printDocument3.PrintPage += printDocument3_PrintPage;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(690, 498);
            label9.Name = "label9";
            label9.Size = new Size(28, 19);
            label9.TabIndex = 52;
            label9.Text = "AY:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 498);
            label6.Name = "label6";
            label6.Size = new Size(32, 19);
            label6.TabIndex = 51;
            label6.Text = "YIL:";
            // 
            // txtAy
            // 
            txtAy.FormattingEnabled = true;
            txtAy.Location = new Point(723, 494);
            txtAy.Name = "txtAy";
            txtAy.Size = new Size(144, 27);
            txtAy.TabIndex = 50;
            // 
            // txtYıl
            // 
            txtYıl.FormattingEnabled = true;
            txtYıl.Location = new Point(535, 494);
            txtYıl.Name = "txtYıl";
            txtYıl.Size = new Size(144, 27);
            txtYıl.TabIndex = 49;
            // 
            // rprGelir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1386, 650);
            MinimizeBox = false;
            MinimumSize = new Size(1358, 650);
            Name = "rprGelir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Raporu";
            Load += rprGelir_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTahsilat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private DataGridView dgvAidat;
        private Button button2;
        private DataGridView dgvTahsilat;
        private Label label7;
        private Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private Button button4;
        private Button button5;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label6;
        public ComboBox txtAy;
        public ComboBox txtYıl;
    }
}