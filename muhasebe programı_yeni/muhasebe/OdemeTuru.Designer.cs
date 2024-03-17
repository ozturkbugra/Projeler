namespace muhasebe
{
    partial class OdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeTuru));
            button2 = new Button();
            btnEkle = new Button();
            label1 = new Label();
            dgvSektor = new DataGridView();
            txtAd = new TextBox();
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
            button3.Location = new Point(264, 175);
            button3.Name = "button3";
            button3.Size = new Size(89, 33);
            button3.TabIndex = 33;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(125, 174);
            button2.Name = "button2";
            button2.Size = new Size(115, 33);
            button2.TabIndex = 32;
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
            btnEkle.Location = new Point(16, 174);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(80, 33);
            btnEkle.TabIndex = 31;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 124);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 30;
            label1.Text = "Ödeme Türü Adı";
            // 
            // dgvSektor
            // 
            dgvSektor.AllowUserToAddRows = false;
            dgvSektor.AllowUserToDeleteRows = false;
            dgvSektor.AllowUserToOrderColumns = true;
            dgvSektor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSektor.BackgroundColor = SystemColors.ActiveCaption;
            dgvSektor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSektor.Location = new Point(12, 12);
            dgvSektor.Name = "dgvSektor";
            dgvSektor.ReadOnly = true;
            dgvSektor.RowTemplate.Height = 25;
            dgvSektor.Size = new Size(342, 109);
            dgvSektor.TabIndex = 29;
            dgvSektor.CellClick += dgvSektor_CellClick;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(90, 141);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(187, 23);
            txtAd.TabIndex = 28;
            // 
            // OdemeTuru
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 217);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(dgvSektor);
            Controls.Add(txtAd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(384, 256);
            MinimumSize = new Size(384, 256);
            Name = "OdemeTuru";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme Türleri";
            Load += OdemeTuru_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSektor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnEkle;
        private Label label1;
        private DataGridView dgvSektor;
        private TextBox txtAd;
    }
}