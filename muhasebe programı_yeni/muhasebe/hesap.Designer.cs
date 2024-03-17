namespace muhasebe
{
    partial class hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesap));
            groupBox1 = new GroupBox();
            button1 = new Button();
            button7 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtParola = new TextBox();
            txtAd = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtParola);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Font = new Font("Source Sans Pro Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 285);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 183);
            button1.Name = "button1";
            button1.Size = new Size(166, 38);
            button1.TabIndex = 53;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(189, 239);
            button7.Name = "button7";
            button7.Size = new Size(166, 38);
            button7.TabIndex = 52;
            button7.Text = "ÇIKIŞ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 39);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(182, 131);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(184, 31);
            txtParola.TabIndex = 2;
            txtParola.UseSystemPasswordChar = true;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(182, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(184, 31);
            txtAd.TabIndex = 1;
            // 
            // hesap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 300);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(547, 339);
            MinimizeBox = false;
            MinimumSize = new Size(547, 339);
            Name = "hesap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Bilgileri";
            Load += hesap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button7;
        private Label label2;
        private Label label1;
        private TextBox txtParola;
        private TextBox txtAd;
    }
}