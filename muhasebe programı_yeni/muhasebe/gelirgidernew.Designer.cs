namespace muhasebe
{
    partial class gelirgidernew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gelirgidernew));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            txtAktif = new CheckBox();
            button5 = new Button();
            label7 = new Label();
            button4 = new Button();
            txtKisi = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button7 = new Button();
            lblKasa = new Label();
            label4 = new Label();
            lblGider = new Label();
            label3 = new Label();
            lblGelir = new Label();
            label1 = new Label();
            button1 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            dgvGider = new DataGridView();
            dgvGelir = new DataGridView();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            txtYil = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            txtAy = new ComboBox();
            label2 = new Label();
            txtKisi2 = new ComboBox();
            button11 = new Button();
            lblKasa2 = new Label();
            label6 = new Label();
            lblGider2 = new Label();
            label9 = new Label();
            lblGelir2 = new Label();
            label11 = new Label();
            button12 = new Button();
            dgvGider2 = new DataGridView();
            dgvGelir2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelir).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelir2).BeginInit();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printDocument2
            // 
            printDocument2.BeginPrint += printDocument2_BeginPrint;
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 13);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1268, 644);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1260, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tarihler Arası Toplam Kasa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAktif);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtKisi);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(lblKasa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblGider);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblGelir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Controls.Add(dgvGelir);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1250, 612);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelir Gider Hesaplama";
            // 
            // txtAktif
            // 
            txtAktif.AutoSize = true;
            txtAktif.Location = new Point(457, 422);
            txtAktif.Name = "txtAktif";
            txtAktif.Size = new Size(15, 14);
            txtAktif.TabIndex = 38;
            txtAktif.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Firebrick;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(836, 556);
            button5.Name = "button5";
            button5.Size = new Size(192, 32);
            button5.TabIndex = 54;
            button5.Text = "PDF İNDİR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(478, 386);
            label7.Name = "label7";
            label7.Size = new Size(238, 24);
            label7.TabIndex = 37;
            label7.Text = "Kişi Seçiniz (Zorunlu Değil)";
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(216, 553);
            button4.Name = "button4";
            button4.Size = new Size(192, 32);
            button4.TabIndex = 53;
            button4.Text = "PDF İNDİR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // txtKisi
            // 
            txtKisi.FormattingEnabled = true;
            txtKisi.Location = new Point(478, 413);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(308, 32);
            txtKisi.TabIndex = 36;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1048, 556);
            button3.Name = "button3";
            button3.Size = new Size(192, 32);
            button3.TabIndex = 53;
            button3.Text = "GİDERLERİ YAZDIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(6, 553);
            button2.Name = "button2";
            button2.Size = new Size(192, 32);
            button2.TabIndex = 52;
            button2.Text = "GELİRLERİ YAZDIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(534, 554);
            button7.Name = "button7";
            button7.Size = new Size(166, 38);
            button7.TabIndex = 51;
            button7.Text = "ÇIKIŞ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblKasa.ForeColor = Color.Black;
            lblKasa.Location = new Point(642, 497);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(39, 41);
            lblKasa.TabIndex = 10;
            lblKasa.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(547, 497);
            label4.Name = "label4";
            label4.Size = new Size(102, 41);
            label4.TabIndex = 9;
            label4.Text = "Kasa:";
            // 
            // lblGider
            // 
            lblGider.AutoSize = true;
            lblGider.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGider.ForeColor = Color.FromArgb(192, 0, 0);
            lblGider.Location = new Point(858, 451);
            lblGider.Name = "lblGider";
            lblGider.Size = new Size(0, 41);
            lblGider.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(858, 410);
            label3.Name = "label3";
            label3.Size = new Size(96, 41);
            label3.TabIndex = 7;
            label3.Text = "Gider";
            // 
            // lblGelir
            // 
            lblGelir.AutoSize = true;
            lblGelir.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGelir.ForeColor = Color.FromArgb(0, 192, 0);
            lblGelir.Location = new Point(243, 451);
            lblGelir.Name = "lblGelir";
            lblGelir.Size = new Size(0, 41);
            lblGelir.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(234, 410);
            label1.Name = "label1";
            label1.Size = new Size(85, 41);
            label1.TabIndex = 5;
            label1.Text = "Gelir";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(562, 451);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 4;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(615, 337);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(301, 31);
            dtSon.TabIndex = 3;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(292, 337);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(301, 31);
            dtBas.TabIndex = 2;
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(615, 30);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(629, 301);
            dgvGider.TabIndex = 1;
            // 
            // dgvGelir
            // 
            dgvGelir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelir.BackgroundColor = SystemColors.ActiveCaption;
            dgvGelir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelir.Location = new Point(6, 30);
            dgvGelir.Name = "dgvGelir";
            dgvGelir.RowTemplate.Height = 25;
            dgvGelir.Size = new Size(587, 301);
            dgvGelir.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1260, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ay Ay Kasa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtYil);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAy);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtKisi2);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(lblKasa2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblGider2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblGelir2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(dgvGider2);
            groupBox2.Controls.Add(dgvGelir2);
            groupBox2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(5, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1250, 612);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ay Ay Kasa";
            // 
            // txtYil
            // 
            txtYil.FormattingEnabled = true;
            txtYil.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            txtYil.Location = new Point(633, 361);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(134, 32);
            txtYil.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(653, 334);
            label8.Name = "label8";
            label8.Size = new Size(94, 24);
            label8.TabIndex = 57;
            label8.Text = "Yıl Seçiniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 335);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 56;
            label5.Text = "Ay Seçiniz";
            // 
            // txtAy
            // 
            txtAy.FormattingEnabled = true;
            txtAy.Location = new Point(459, 362);
            txtAy.Name = "txtAy";
            txtAy.Size = new Size(168, 32);
            txtAy.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 403);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 37;
            label2.Text = "Kişi Seçiniz";
            // 
            // txtKisi2
            // 
            txtKisi2.FormattingEnabled = true;
            txtKisi2.Location = new Point(459, 430);
            txtKisi2.Name = "txtKisi2";
            txtKisi2.Size = new Size(308, 32);
            txtKisi2.TabIndex = 36;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(192, 0, 0);
            button11.Cursor = Cursors.Hand;
            button11.FlatStyle = FlatStyle.Popup;
            button11.ForeColor = Color.White;
            button11.Location = new Point(534, 554);
            button11.Name = "button11";
            button11.Size = new Size(166, 38);
            button11.TabIndex = 51;
            button11.Text = "ÇIKIŞ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // lblKasa2
            // 
            lblKasa2.AutoSize = true;
            lblKasa2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblKasa2.ForeColor = Color.Black;
            lblKasa2.Location = new Point(642, 504);
            lblKasa2.Name = "lblKasa2";
            lblKasa2.Size = new Size(39, 41);
            lblKasa2.TabIndex = 10;
            lblKasa2.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(547, 504);
            label6.Name = "label6";
            label6.Size = new Size(102, 41);
            label6.TabIndex = 9;
            label6.Text = "Kasa:";
            // 
            // lblGider2
            // 
            lblGider2.AutoSize = true;
            lblGider2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGider2.ForeColor = Color.FromArgb(192, 0, 0);
            lblGider2.Location = new Point(858, 451);
            lblGider2.Name = "lblGider2";
            lblGider2.Size = new Size(0, 41);
            lblGider2.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(858, 410);
            label9.Name = "label9";
            label9.Size = new Size(96, 41);
            label9.TabIndex = 7;
            label9.Text = "Gider";
            // 
            // lblGelir2
            // 
            lblGelir2.AutoSize = true;
            lblGelir2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGelir2.ForeColor = Color.FromArgb(0, 192, 0);
            lblGelir2.Location = new Point(243, 451);
            lblGelir2.Name = "lblGelir2";
            lblGelir2.Size = new Size(0, 41);
            lblGelir2.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 192, 0);
            label11.Location = new Point(234, 410);
            label11.Name = "label11";
            label11.Size = new Size(85, 41);
            label11.TabIndex = 5;
            label11.Text = "Gelir";
            // 
            // button12
            // 
            button12.BackColor = Color.Cyan;
            button12.Cursor = Cursors.Hand;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Location = new Point(553, 468);
            button12.Name = "button12";
            button12.Size = new Size(109, 32);
            button12.TabIndex = 4;
            button12.Text = "HESAPLA";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // dgvGider2
            // 
            dgvGider2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider2.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider2.Location = new Point(615, 30);
            dgvGider2.Name = "dgvGider2";
            dgvGider2.RowTemplate.Height = 25;
            dgvGider2.Size = new Size(629, 301);
            dgvGider2.TabIndex = 1;
            // 
            // dgvGelir2
            // 
            dgvGelir2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelir2.BackgroundColor = SystemColors.ActiveCaption;
            dgvGelir2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelir2.Location = new Point(6, 30);
            dgvGelir2.Name = "dgvGelir2";
            dgvGelir2.RowTemplate.Height = 25;
            dgvGelir2.Size = new Size(587, 301);
            dgvGelir2.TabIndex = 0;
            // 
            // gelirgidernew
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(tabControl1);
            Font = new Font("Source Sans Pro Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "gelirgidernew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Gider Raporu";
            Load += gelirgidernew_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelir).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGelir2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private Label lblKasa;
        private Label label4;
        private Label lblGider;
        private Label label3;
        private Label lblGelir;
        private Label label1;
        private Button button1;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private DataGridView dgvGider;
        private DataGridView dgvGelir;
        private CheckBox txtAktif;
        private Label label7;
        private ComboBox txtKisi;
        private GroupBox groupBox2;
        private ComboBox txtKisi2;
        private Button button11;
        private Label lblKasa2;
        private Label label6;
        private Label lblGider2;
        private Label label9;
        private Label lblGelir2;
        private Label label11;
        private Button button12;
        private DataGridView dgvGider2;
        private DataGridView dgvGelir2;
        private Label label5;
        private ComboBox txtAy;
        private Label label2;
        private ComboBox txtYil;
        private Label label8;
    }
}