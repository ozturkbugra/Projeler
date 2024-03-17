namespace muhasebe
{
    partial class TumBorclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumBorclar));
            groupBox1 = new GroupBox();
            button7 = new Button();
            dgvEmtia = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmtia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(dgvEmtia);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 637);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borçlar";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(534, 561);
            button7.Name = "button7";
            button7.Size = new Size(152, 31);
            button7.TabIndex = 52;
            button7.Text = "ÇIKIŞ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 602);
            label1.Name = "label1";
            label1.Size = new Size(471, 24);
            label1.TabIndex = 53;
            label1.Text = "Tutarın başında eksi olanlar bizden alacaklı olanlardır";
            // 
            // TumBorclar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "TumBorclar";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tüm Borçlar";
            Load += TumBorclar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmtia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button7;
        private DataGridView dgvEmtia;
        private Label label1;
    }
}