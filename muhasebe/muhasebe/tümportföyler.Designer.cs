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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoviz = new System.Windows.Forms.DataGridView();
            this.dgvHisse = new System.Windows.Forms.DataGridView();
            this.dgvEmtia = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dtSon = new System.Windows.Forms.DateTimePicker();
            this.dtBas = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmtia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "DÖVİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "HİSSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "EMTİA";
            // 
            // dgvDoviz
            // 
            this.dgvDoviz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoviz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoviz.Location = new System.Drawing.Point(856, 66);
            this.dgvDoviz.Name = "dgvDoviz";
            this.dgvDoviz.RowTemplate.Height = 25;
            this.dgvDoviz.Size = new System.Drawing.Size(368, 338);
            this.dgvDoviz.TabIndex = 8;
            // 
            // dgvHisse
            // 
            this.dgvHisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHisse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisse.Location = new System.Drawing.Point(437, 66);
            this.dgvHisse.Name = "dgvHisse";
            this.dgvHisse.RowTemplate.Height = 25;
            this.dgvHisse.Size = new System.Drawing.Size(349, 338);
            this.dgvHisse.TabIndex = 7;
            // 
            // dgvEmtia
            // 
            this.dgvEmtia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmtia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmtia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmtia.Location = new System.Drawing.Point(19, 66);
            this.dgvEmtia.Name = "dgvEmtia";
            this.dgvEmtia.RowTemplate.Height = 25;
            this.dgvEmtia.Size = new System.Drawing.Size(338, 338);
            this.dgvEmtia.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(534, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtSon
            // 
            this.dtSon.Location = new System.Drawing.Point(640, 436);
            this.dtSon.Name = "dtSon";
            this.dtSon.Size = new System.Drawing.Size(318, 31);
            this.dtSon.TabIndex = 16;
            // 
            // dtBas
            // 
            this.dtBas.Location = new System.Drawing.Point(293, 436);
            this.dtBas.Name = "dtBas";
            this.dtBas.Size = new System.Drawing.Size(287, 31);
            this.dtBas.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.dtBas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtSon);
            this.groupBox1.Controls.Add(this.dgvDoviz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvHisse);
            this.groupBox1.Controls.Add(this.dgvEmtia);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 637);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Portföyler";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(534, 552);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 31);
            this.button7.TabIndex = 52;
            this.button7.Text = "ÇIKIŞ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tümportföyler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "tümportföyler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Portföyler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmtia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDoviz;
        private DataGridView dgvHisse;
        private DataGridView dgvEmtia;
        private Button button2;
        private DateTimePicker dtSon;
        private DateTimePicker dtBas;
        private GroupBox groupBox1;
        private Button button7;
    }
}