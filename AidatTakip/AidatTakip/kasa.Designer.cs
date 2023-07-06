namespace AidatTakip
{
    partial class kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGider = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAidat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGider = new System.Windows.Forms.TextBox();
            this.txtGelir = new System.Windows.Forms.TextBox();
            this.txtKasa = new System.Windows.Forms.TextBox();
            this.txt2022 = new System.Windows.Forms.TextBox();
            this.txtAlacak = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGider);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // dgvGider
            // 
            this.dgvGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGider.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGider.Location = new System.Drawing.Point(15, 38);
            this.dgvGider.Name = "dgvGider";
            this.dgvGider.RowTemplate.Height = 25;
            this.dgvGider.Size = new System.Drawing.Size(607, 460);
            this.dgvGider.TabIndex = 12;
            this.dgvGider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGider_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAidat);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(686, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 515);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelirler";
            // 
            // dgvAidat
            // 
            this.dgvAidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAidat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAidat.Location = new System.Drawing.Point(14, 38);
            this.dgvAidat.Name = "dgvAidat";
            this.dgvAidat.RowTemplate.Height = 25;
            this.dgvAidat.Size = new System.Drawing.Size(650, 460);
            this.dgvAidat.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giderler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gelirler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(573, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "KASA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1137, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "2022 YILINDAN KALAN BAKİYE";
            // 
            // txtGider
            // 
            this.txtGider.Enabled = false;
            this.txtGider.Location = new System.Drawing.Point(102, 17);
            this.txtGider.Name = "txtGider";
            this.txtGider.Size = new System.Drawing.Size(160, 23);
            this.txtGider.TabIndex = 24;
            this.txtGider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGelir
            // 
            this.txtGelir.Enabled = false;
            this.txtGelir.Location = new System.Drawing.Point(102, 50);
            this.txtGelir.Name = "txtGelir";
            this.txtGelir.Size = new System.Drawing.Size(160, 23);
            this.txtGelir.TabIndex = 25;
            this.txtGelir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKasa
            // 
            this.txtKasa.Enabled = false;
            this.txtKasa.Location = new System.Drawing.Point(668, 13);
            this.txtKasa.Name = "txtKasa";
            this.txtKasa.Size = new System.Drawing.Size(133, 23);
            this.txtKasa.TabIndex = 26;
            this.txtKasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2022
            // 
            this.txt2022.Enabled = false;
            this.txt2022.Location = new System.Drawing.Point(1161, 47);
            this.txt2022.Name = "txt2022";
            this.txt2022.Size = new System.Drawing.Size(133, 23);
            this.txt2022.TabIndex = 27;
            this.txt2022.Text = "45996";
            this.txt2022.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlacak
            // 
            this.txtAlacak.Enabled = false;
            this.txtAlacak.ForeColor = System.Drawing.Color.Black;
            this.txtAlacak.Location = new System.Drawing.Point(668, 49);
            this.txtAlacak.Name = "txtAlacak";
            this.txtAlacak.Size = new System.Drawing.Size(133, 23);
            this.txtAlacak.TabIndex = 29;
            this.txtAlacak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(569, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "ALACAK:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Red;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(256, 31);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(256, 31);
            this.dataGridView2.TabIndex = 31;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(556, 45);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(256, 31);
            this.dataGridView3.TabIndex = 32;
            // 
            // kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 611);
            this.Controls.Add(this.txtAlacak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt2022);
            this.Controls.Add(this.txtKasa);
            this.Controls.Add(this.txtGelir);
            this.Controls.Add(this.txtGider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1386, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1358, 650);
            this.Name = "kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.kasa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvGider;
        private GroupBox groupBox2;
        private DataGridView dgvAidat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtGider;
        private TextBox txtGelir;
        private TextBox txtKasa;
        private TextBox txt2022;
        private TextBox txtAlacak;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}