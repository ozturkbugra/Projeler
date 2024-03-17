namespace AidatTakip
{
    partial class borcludaireler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borcludaireler));
            groupBox1 = new GroupBox();
            button3 = new Button();
            label1 = new Label();
            txtAlacak = new TextBox();
            button2 = new Button();
            button1 = new Button();
            dgvBorc = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAlacak);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvBorc);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borçlu Daireler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(377, 369);
            button3.Name = "button3";
            button3.Size = new Size(140, 44);
            button3.TabIndex = 18;
            button3.Text = "Excel'e Aktar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 382);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 17;
            label1.Text = "Toplam Alacak";
            // 
            // txtAlacak
            // 
            txtAlacak.Enabled = false;
            txtAlacak.Location = new Point(130, 379);
            txtAlacak.Name = "txtAlacak";
            txtAlacak.Size = new Size(118, 27);
            txtAlacak.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(663, 369);
            button2.Name = "button2";
            button2.Size = new Size(91, 44);
            button2.TabIndex = 15;
            button2.Text = "Yazdır";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(531, 369);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 14;
            button1.Text = "PDF'e Aktar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvBorc
            // 
            dgvBorc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorc.BackgroundColor = SystemColors.ActiveCaption;
            dgvBorc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorc.Location = new Point(21, 26);
            dgvBorc.Name = "dgvBorc";
            dgvBorc.RowTemplate.Height = 25;
            dgvBorc.Size = new Size(733, 334);
            dgvBorc.TabIndex = 13;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // borcludaireler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "borcludaireler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borçlu Daireler";
            Load += borcludaireler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private DataGridView dgvBorc;
        private Label label1;
        private TextBox txtAlacak;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button3;
    }
}