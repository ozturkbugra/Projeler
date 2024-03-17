namespace AidatTakip
{
    partial class rprGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rprGider));
            groupBox2 = new GroupBox();
            button1 = new Button();
            label8 = new Label();
            button2 = new Button();
            dgvGider = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label9 = new Label();
            label6 = new Label();
            txtAy = new ComboBox();
            txtYıl = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAy);
            groupBox2.Controls.Add(txtYıl);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dgvGider);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 587);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giderler";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(707, 518);
            button1.Name = "button1";
            button1.Size = new Size(197, 42);
            button1.TabIndex = 44;
            button1.Text = "Tarihleri Arasını Yazdır";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(523, 563);
            label8.Name = "label8";
            label8.Size = new Size(308, 19);
            label8.TabIndex = 43;
            label8.Text = "Seçeceğiniz ilk tarihin saati 00:00:00 olmalıdır.";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(476, 518);
            button2.Name = "button2";
            button2.Size = new Size(200, 42);
            button2.TabIndex = 28;
            button2.Text = "Tarihleri Arasını Göster";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgvGider
            // 
            dgvGider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGider.BackgroundColor = SystemColors.ActiveCaption;
            dgvGider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGider.Location = new Point(290, 44);
            dgvGider.Name = "dgvGider";
            dgvGider.RowTemplate.Height = 25;
            dgvGider.Size = new Size(790, 428);
            dgvGider.TabIndex = 12;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(715, 482);
            label9.Name = "label9";
            label9.Size = new Size(28, 19);
            label9.TabIndex = 56;
            label9.Text = "AY:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 482);
            label6.Name = "label6";
            label6.Size = new Size(32, 19);
            label6.TabIndex = 55;
            label6.Text = "YIL:";
            // 
            // txtAy
            // 
            txtAy.FormattingEnabled = true;
            txtAy.Location = new Point(748, 478);
            txtAy.Name = "txtAy";
            txtAy.Size = new Size(144, 27);
            txtAy.TabIndex = 54;
            // 
            // txtYıl
            // 
            txtYıl.FormattingEnabled = true;
            txtYıl.Location = new Point(560, 478);
            txtYıl.Name = "txtYıl";
            txtYıl.Size = new Size(144, 27);
            txtYıl.TabIndex = 53;
            // 
            // rprGider
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
            Name = "rprGider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gider Raporu";
            Load += rprGider_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button2;
        private DataGridView dgvGider;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label8;
        private Button button1;
        private Label label9;
        private Label label6;
        public ComboBox txtAy;
        public ComboBox txtYıl;
    }
}