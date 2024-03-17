namespace AidatTakip
{
    partial class makbuzara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makbuzara));
            groupBox1 = new GroupBox();
            rdTahsilat = new RadioButton();
            rdGider = new RadioButton();
            button1 = new Button();
            txtAra = new TextBox();
            rbDaireNo = new RadioButton();
            rdMakNo = new RadioButton();
            dgvMakbuz = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMakbuz).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdTahsilat);
            groupBox1.Controls.Add(rdGider);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtAra);
            groupBox1.Controls.Add(rbDaireNo);
            groupBox1.Controls.Add(rdMakNo);
            groupBox1.Controls.Add(dgvMakbuz);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 476);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Makbuz Arama";
            // 
            // rdTahsilat
            // 
            rdTahsilat.AutoSize = true;
            rdTahsilat.Location = new Point(363, 66);
            rdTahsilat.Name = "rdTahsilat";
            rdTahsilat.Size = new Size(195, 23);
            rdTahsilat.TabIndex = 19;
            rdTahsilat.TabStop = true;
            rdTahsilat.Text = "Tahsilat Numarasına Göre";
            rdTahsilat.UseVisualStyleBackColor = true;
            // 
            // rdGider
            // 
            rdGider.AutoSize = true;
            rdGider.Location = new Point(363, 46);
            rdGider.Name = "rdGider";
            rdGider.Size = new Size(179, 23);
            rdGider.TabIndex = 18;
            rdGider.TabStop = true;
            rdGider.Text = "Gider Numarasına Göre";
            rdGider.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(618, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 17;
            button1.Text = "ARA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(83, 98);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(516, 27);
            txtAra.TabIndex = 16;
            // 
            // rbDaireNo
            // 
            rbDaireNo.AutoSize = true;
            rbDaireNo.Location = new Point(159, 64);
            rbDaireNo.Name = "rbDaireNo";
            rbDaireNo.Size = new Size(179, 23);
            rbDaireNo.TabIndex = 15;
            rbDaireNo.TabStop = true;
            rbDaireNo.Text = "Daire Numarasına Göre";
            rbDaireNo.UseVisualStyleBackColor = true;
            // 
            // rdMakNo
            // 
            rdMakNo.AutoSize = true;
            rdMakNo.Location = new Point(159, 43);
            rdMakNo.Name = "rdMakNo";
            rdMakNo.Size = new Size(194, 23);
            rdMakNo.TabIndex = 14;
            rdMakNo.TabStop = true;
            rdMakNo.Text = "Makbuz Numarasına Göre";
            rdMakNo.UseVisualStyleBackColor = true;
            // 
            // dgvMakbuz
            // 
            dgvMakbuz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMakbuz.BackgroundColor = SystemColors.ActiveCaption;
            dgvMakbuz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakbuz.Location = new Point(24, 140);
            dgvMakbuz.Name = "dgvMakbuz";
            dgvMakbuz.RowTemplate.Height = 25;
            dgvMakbuz.Size = new Size(725, 320);
            dgvMakbuz.TabIndex = 13;
            dgvMakbuz.CellClick += dgvMakbuz_CellClick;
            dgvMakbuz.CellContentClick += dgvMakbuz_CellContentClick;
            // 
            // makbuzara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 500);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(831, 539);
            MinimizeBox = false;
            MinimumSize = new Size(831, 539);
            Name = "makbuzara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Makbuz Arama";
            Load += makbuzara_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMakbuz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtAra;
        private RadioButton rbDaireNo;
        private RadioButton rdMakNo;
        private DataGridView dgvMakbuz;
        private RadioButton rdTahsilat;
        private RadioButton rdGider;
    }
}