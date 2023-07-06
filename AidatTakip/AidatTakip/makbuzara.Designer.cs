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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTahsilat = new System.Windows.Forms.RadioButton();
            this.rdGider = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rbDaireNo = new System.Windows.Forms.RadioButton();
            this.rdMakNo = new System.Windows.Forms.RadioButton();
            this.dgvMakbuz = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakbuz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTahsilat);
            this.groupBox1.Controls.Add(this.rdGider);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.rbDaireNo);
            this.groupBox1.Controls.Add(this.rdMakNo);
            this.groupBox1.Controls.Add(this.dgvMakbuz);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 476);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Makbuz Arama";
            // 
            // rdTahsilat
            // 
            this.rdTahsilat.AutoSize = true;
            this.rdTahsilat.Location = new System.Drawing.Point(363, 66);
            this.rdTahsilat.Name = "rdTahsilat";
            this.rdTahsilat.Size = new System.Drawing.Size(195, 23);
            this.rdTahsilat.TabIndex = 19;
            this.rdTahsilat.TabStop = true;
            this.rdTahsilat.Text = "Tahsilat Numarasına Göre";
            this.rdTahsilat.UseVisualStyleBackColor = true;
            // 
            // rdGider
            // 
            this.rdGider.AutoSize = true;
            this.rdGider.Location = new System.Drawing.Point(363, 46);
            this.rdGider.Name = "rdGider";
            this.rdGider.Size = new System.Drawing.Size(179, 23);
            this.rdGider.TabIndex = 18;
            this.rdGider.TabStop = true;
            this.rdGider.Text = "Gider Numarasına Göre";
            this.rdGider.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(618, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "ARA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(83, 98);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(516, 27);
            this.txtAra.TabIndex = 16;
            // 
            // rbDaireNo
            // 
            this.rbDaireNo.AutoSize = true;
            this.rbDaireNo.Location = new System.Drawing.Point(159, 64);
            this.rbDaireNo.Name = "rbDaireNo";
            this.rbDaireNo.Size = new System.Drawing.Size(179, 23);
            this.rbDaireNo.TabIndex = 15;
            this.rbDaireNo.TabStop = true;
            this.rbDaireNo.Text = "Daire Numarasına Göre";
            this.rbDaireNo.UseVisualStyleBackColor = true;
            // 
            // rdMakNo
            // 
            this.rdMakNo.AutoSize = true;
            this.rdMakNo.Location = new System.Drawing.Point(159, 43);
            this.rdMakNo.Name = "rdMakNo";
            this.rdMakNo.Size = new System.Drawing.Size(194, 23);
            this.rdMakNo.TabIndex = 14;
            this.rdMakNo.TabStop = true;
            this.rdMakNo.Text = "Makbuz Numarasına Göre";
            this.rdMakNo.UseVisualStyleBackColor = true;
            // 
            // dgvMakbuz
            // 
            this.dgvMakbuz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMakbuz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMakbuz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMakbuz.Location = new System.Drawing.Point(24, 140);
            this.dgvMakbuz.Name = "dgvMakbuz";
            this.dgvMakbuz.RowTemplate.Height = 25;
            this.dgvMakbuz.Size = new System.Drawing.Size(725, 320);
            this.dgvMakbuz.TabIndex = 13;
            this.dgvMakbuz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMakbuz_CellContentClick);
            // 
            // makbuzara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(831, 539);
            this.Name = "makbuzara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makbuz Arama";
            this.Load += new System.EventHandler(this.makbuzara_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMakbuz)).EndInit();
            this.ResumeLayout(false);

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