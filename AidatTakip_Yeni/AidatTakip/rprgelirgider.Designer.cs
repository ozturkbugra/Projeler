namespace AidatTakip
{
    partial class rprgelirgider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rprgelirgider));
            label9 = new Label();
            label6 = new Label();
            txtAy = new ComboBox();
            txtYıl = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 43);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 53;
            label9.Text = "AY:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 16);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 52;
            label6.Text = "YIL:";
            // 
            // txtAy
            // 
            txtAy.FormattingEnabled = true;
            txtAy.Location = new Point(45, 39);
            txtAy.Name = "txtAy";
            txtAy.Size = new Size(196, 23);
            txtAy.TabIndex = 51;
            // 
            // txtYıl
            // 
            txtYıl.FormattingEnabled = true;
            txtYıl.Location = new Point(45, 12);
            txtYıl.Name = "txtYıl";
            txtYıl.Size = new Size(196, 23);
            txtYıl.TabIndex = 50;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(75, 132);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 49;
            button2.Text = "LİSTELE";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Name = "label2";
            label2.Size = new Size(204, 45);
            label2.TabIndex = 56;
            label2.Text = "DOĞRU HESAPLANMASI İÇİN RAPOR\r\nALACAĞINIZ AYDAN ÖNCEKİ KASAYI\r\nDOĞRU BİR ŞEKİLDE YAZINIZ\r\n";
            // 
            // rprgelirgider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 181);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(txtAy);
            Controls.Add(txtYıl);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rprgelirgider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GELİR GİDER RAPORU";
            Load += rprgelirgider_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label6;
        public ComboBox txtAy;
        public ComboBox txtYıl;
        private Button button2;
        private Label label2;
    }
}