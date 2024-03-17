namespace muhasebe
{
    partial class KASA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KASA));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            lblKasa = new Label();
            label4 = new Label();
            lblGider = new Label();
            label3 = new Label();
            lblGelir = new Label();
            label1 = new Label();
            dgvGider = new DataGridView();
            dgvGelir = new DataGridView();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtKisi = new ComboBox();
            lblKasa2 = new Label();
            label5 = new Label();
            lblGider2 = new Label();
            label7 = new Label();
            lblGelir2 = new Label();
            label9 = new Label();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1260, 637);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1252, 600);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Toplam Kasa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblKasa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblGider);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblGelir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Controls.Add(dgvGelir);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1217, 565);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "MEVCUT KASA";
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblKasa.ForeColor = Color.Black;
            lblKasa.ImageAlign = ContentAlignment.MiddleLeft;
            lblKasa.Location = new Point(600, 445);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(39, 41);
            lblKasa.TabIndex = 10;
            lblKasa.Text = "0";
            lblKasa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(570, 404);
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
            lblGider.Location = new Point(938, 404);
            lblGider.Name = "lblGider";
            lblGider.Size = new Size(39, 41);
            lblGider.TabIndex = 8;
            lblGider.Text = "0";
            lblGider.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(908, 363);
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
            lblGelir.Location = new Point(277, 404);
            lblGelir.Name = "lblGelir";
            lblGelir.Size = new Size(39, 41);
            lblGelir.TabIndex = 6;
            lblGelir.Text = "0";
            lblGelir.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(254, 363);
            label1.Name = "label1";
            label1.Size = new Size(85, 41);
            label1.TabIndex = 5;
            label1.Text = "Gelir";
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(681, 30);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(517, 330);
            dgvGider.TabIndex = 1;
            // 
            // dgvGelir
            // 
            dgvGelir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelir.BackgroundColor = SystemColors.ActiveCaption;
            dgvGelir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelir.Location = new Point(47, 30);
            dgvGelir.Name = "dgvGelir";
            dgvGelir.RowTemplate.Height = 25;
            dgvGelir.Size = new Size(530, 330);
            dgvGelir.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1252, 600);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kişiye Özel Kasa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtKisi);
            groupBox2.Controls.Add(lblKasa2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblGider2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblGelir2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dgvGider2);
            groupBox2.Controls.Add(dgvGelir2);
            groupBox2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1217, 565);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "MEVCUT KASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 500);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 23;
            label2.Text = "Kişi seçiniz";
            // 
            // txtKisi
            // 
            txtKisi.FormattingEnabled = true;
            txtKisi.Items.AddRange(new object[] { "Ulaşım", "Lokanta", "Market", "Ekmek", "Giyim", "Sağlık", "Eğitim", "Elektrik", "Su", "İnternet", "DoğalGaz", "Telefon", "Araba", "Berber", "Altın", "Döviz", "Hisse", "Diğer" });
            txtKisi.Location = new Point(473, 527);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(308, 32);
            txtKisi.TabIndex = 22;
            txtKisi.SelectedIndexChanged += txtKisi_SelectedIndexChanged;
            // 
            // lblKasa2
            // 
            lblKasa2.AutoSize = true;
            lblKasa2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblKasa2.ForeColor = Color.Black;
            lblKasa2.ImageAlign = ContentAlignment.MiddleLeft;
            lblKasa2.Location = new Point(610, 445);
            lblKasa2.Name = "lblKasa2";
            lblKasa2.Size = new Size(39, 41);
            lblKasa2.TabIndex = 10;
            lblKasa2.Text = "0";
            lblKasa2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(580, 404);
            label5.Name = "label5";
            label5.Size = new Size(102, 41);
            label5.TabIndex = 9;
            label5.Text = "Kasa:";
            // 
            // lblGider2
            // 
            lblGider2.AutoSize = true;
            lblGider2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGider2.ForeColor = Color.FromArgb(192, 0, 0);
            lblGider2.Location = new Point(938, 404);
            lblGider2.Name = "lblGider2";
            lblGider2.Size = new Size(39, 41);
            lblGider2.TabIndex = 8;
            lblGider2.Text = "0";
            lblGider2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(908, 363);
            label7.Name = "label7";
            label7.Size = new Size(96, 41);
            label7.TabIndex = 7;
            label7.Text = "Gider";
            // 
            // lblGelir2
            // 
            lblGelir2.AutoSize = true;
            lblGelir2.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGelir2.ForeColor = Color.FromArgb(0, 192, 0);
            lblGelir2.Location = new Point(277, 404);
            lblGelir2.Name = "lblGelir2";
            lblGelir2.Size = new Size(39, 41);
            lblGelir2.TabIndex = 6;
            lblGelir2.Text = "0";
            lblGelir2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Righteous", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 192, 0);
            label9.Location = new Point(254, 363);
            label9.Name = "label9";
            label9.Size = new Size(85, 41);
            label9.TabIndex = 5;
            label9.Text = "Gelir";
            // 
            // dgvGider2
            // 
            dgvGider2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider2.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider2.Location = new Point(681, 30);
            dgvGider2.Name = "dgvGider2";
            dgvGider2.RowTemplate.Height = 25;
            dgvGider2.Size = new Size(517, 330);
            dgvGider2.TabIndex = 1;
            // 
            // dgvGelir2
            // 
            dgvGelir2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGelir2.BackgroundColor = SystemColors.ActiveCaption;
            dgvGelir2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGelir2.Location = new Point(47, 30);
            dgvGelir2.Name = "dgvGelir2";
            dgvGelir2.RowTemplate.Height = 25;
            dgvGelir2.Size = new Size(530, 330);
            dgvGelir2.TabIndex = 0;
            // 
            // KASA
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(tabControl1);
            Font = new Font("Righteous", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "KASA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEVCUT KASA";
            Load += KASA_Load;
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

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label lblKasa;
        private Label label4;
        private Label lblGider;
        private Label label3;
        private Label lblGelir;
        private Label label1;
        private DataGridView dgvGider;
        private DataGridView dgvGelir;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label lblKasa2;
        private Label label5;
        private Label lblGider2;
        private Label label7;
        private Label lblGelir2;
        private Label label9;
        private DataGridView dgvGider2;
        private DataGridView dgvGelir2;
        private ComboBox txtKisi;
        private Label label2;
    }
}