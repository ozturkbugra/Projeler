namespace muhasebe
{
    partial class SektorTanimla
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
            Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SektorTanimla));
            txtAd = new TextBox();
            dgvSektor = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            btnEkle = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSektor).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(260, 170);
            button3.Name = "button3";
            button3.Size = new Size(89, 33);
            button3.TabIndex = 27;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(86, 136);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(187, 23);
            txtAd.TabIndex = 0;
            // 
            // dgvSektor
            // 
            dgvSektor.AllowUserToAddRows = false;
            dgvSektor.AllowUserToDeleteRows = false;
            dgvSektor.AllowUserToOrderColumns = true;
            dgvSektor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSektor.BackgroundColor = SystemColors.ActiveCaption;
            dgvSektor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSektor.Location = new Point(8, 7);
            dgvSektor.Name = "dgvSektor";
            dgvSektor.ReadOnly = true;
            dgvSektor.RowTemplate.Height = 25;
            dgvSektor.Size = new Size(342, 109);
            dgvSektor.TabIndex = 23;
            dgvSektor.CellClick += dgvSektor_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 119);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 24;
            label1.Text = "Sektör Adı";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(121, 169);
            button2.Name = "button2";
            button2.Size = new Size(115, 33);
            button2.TabIndex = 26;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Green;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(12, 169);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(80, 33);
            btnEkle.TabIndex = 25;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // SektorTanimla
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 210);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(dgvSektor);
            Controls.Add(txtAd);
            Font = new Font("Source Sans Pro Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(378, 249);
            MinimumSize = new Size(378, 249);
            Name = "SektorTanimla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sektörler";
            Load += SektorTanimla_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSektor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private DataGridView dgvSektor;
        private Label label1;
        private Button button2;
        private Button btnEkle;
    }
}