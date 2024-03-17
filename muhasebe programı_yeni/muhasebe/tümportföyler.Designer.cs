namespace muhasebe
{
    partial class tümportföyler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tümportföyler));
            dgvEmtia = new DataGridView();
            groupBox1 = new GroupBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmtia).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmtia
            // 
            dgvEmtia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmtia.BackgroundColor = SystemColors.ActiveCaption;
            dgvEmtia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmtia.Location = new Point(19, 43);
            dgvEmtia.Name = "dgvEmtia";
            dgvEmtia.RowTemplate.Height = 25;
            dgvEmtia.Size = new Size(1216, 512);
            dgvEmtia.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dgvEmtia);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tüm Portföyler";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(533, 582);
            button7.Name = "button7";
            button7.Size = new Size(152, 31);
            button7.TabIndex = 52;
            button7.Text = "ÇIKIŞ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // tümportföyler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1300, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1300, 700);
            Name = "tümportföyler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tüm Portföyler";
            Load += tümportföyler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmtia).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvEmtia;
        private GroupBox groupBox1;
        private Button button7;
    }
}