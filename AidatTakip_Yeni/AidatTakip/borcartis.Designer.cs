namespace AidatTakip
{
    partial class borcartis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borcartis));
            dgvAidat = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAidat).BeginInit();
            SuspendLayout();
            // 
            // dgvAidat
            // 
            dgvAidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAidat.BackgroundColor = SystemColors.ActiveCaption;
            dgvAidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAidat.Location = new Point(73, 30);
            dgvAidat.Name = "dgvAidat";
            dgvAidat.RowTemplate.Height = 25;
            dgvAidat.Size = new Size(571, 287);
            dgvAidat.TabIndex = 13;
            dgvAidat.CellClick += dgvAidat_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(281, 343);
            button2.Name = "button2";
            button2.Size = new Size(182, 36);
            button2.TabIndex = 26;
            button2.Text = "Borcu ve Aidatı Güncelle";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // borcartis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 409);
            Controls.Add(button2);
            Controls.Add(dgvAidat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "borcartis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aidat Güncelle";
            Load += borcartis_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAidat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvAidat;
        private Button button2;
    }
}