namespace AidatTakip
{
    partial class TureGoreGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TureGoreGiderler));
            groupBox1 = new GroupBox();
            lblortalama = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFiyat = new Label();
            button1 = new Button();
            dtSon = new DateTimePicker();
            dtBas = new DateTimePicker();
            label3 = new Label();
            txtTur = new ComboBox();
            dgvGider = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblortalama);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblFiyat);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtSon);
            groupBox1.Controls.Add(dtBas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTur);
            groupBox1.Controls.Add(dgvGider);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1035, 583);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giderler";
            // 
            // lblortalama
            // 
            lblortalama.AutoSize = true;
            lblortalama.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblortalama.Location = new Point(798, 400);
            lblortalama.Name = "lblortalama";
            lblortalama.Size = new Size(63, 36);
            lblortalama.TabIndex = 46;
            lblortalama.Text = "0 TL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(669, 400);
            label2.Name = "label2";
            label2.Size = new Size(136, 36);
            label2.TabIndex = 45;
            label2.Text = "Ortalama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(667, 327);
            label1.Name = "label1";
            label1.Size = new Size(111, 36);
            label1.TabIndex = 44;
            label1.Text = "Toplam:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.Location = new Point(776, 327);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(63, 36);
            lblFiyat.TabIndex = 43;
            lblFiyat.Text = "0 TL";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(667, 256);
            button1.Name = "button1";
            button1.Size = new Size(166, 37);
            button1.TabIndex = 42;
            button1.Text = "Tarihe göre listele";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(667, 196);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(287, 27);
            dtSon.TabIndex = 41;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(667, 148);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(287, 27);
            dtBas.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(669, 51);
            label3.Name = "label3";
            label3.Size = new Size(164, 36);
            label3.TabIndex = 31;
            label3.Text = "GİDER TÜRÜ";
            // 
            // txtTur
            // 
            txtTur.FormattingEnabled = true;
            txtTur.Items.AddRange(new object[] { "ELEKTRİK", "SU", "YÖNETİM", "TEMİZLİK", "BAKIM ONARIM", "DEMİRBAŞ", "MAAŞ", "SSK", "DİĞER" });
            txtTur.Location = new Point(669, 95);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(285, 27);
            txtTur.TabIndex = 13;
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(15, 38);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(607, 539);
            dgvGider.TabIndex = 12;
            // 
            // TureGoreGiderler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 607);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TureGoreGiderler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TÜRE GÖRE GİDERLER";
            Load += TureGoreGiderler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvGider;
        private ComboBox txtTur;
        private Label label3;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private Button button1;
        private Label lblFiyat;
        private Label lblortalama;
        private Label label2;
        private Label label1;
    }
}