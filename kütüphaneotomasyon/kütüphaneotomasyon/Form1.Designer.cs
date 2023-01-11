namespace kütüphaneotomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üYELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPTAKİPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lİSTELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTABIVERENLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTABIVERMEYENLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkitapara = new System.Windows.Forms.TextBox();
            this.txtuyeara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.dgvUye = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateAlınıs = new System.Windows.Forms.DateTimePicker();
            this.dateVerilis = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbldurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem,
            this.üYELERToolStripMenuItem,
            this.kİTAPLARToolStripMenuItem,
            this.kİTAPTAKİPToolStripMenuItem,
            this.lİSTELERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // üYELERToolStripMenuItem
            // 
            this.üYELERToolStripMenuItem.Name = "üYELERToolStripMenuItem";
            this.üYELERToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.üYELERToolStripMenuItem.Text = "ÜYELER";
            this.üYELERToolStripMenuItem.Click += new System.EventHandler(this.üYELERToolStripMenuItem_Click);
            // 
            // kİTAPLARToolStripMenuItem
            // 
            this.kİTAPLARToolStripMenuItem.Name = "kİTAPLARToolStripMenuItem";
            this.kİTAPLARToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kİTAPLARToolStripMenuItem.Text = "KİTAPLAR";
            this.kİTAPLARToolStripMenuItem.Click += new System.EventHandler(this.kİTAPLARToolStripMenuItem_Click);
            // 
            // kİTAPTAKİPToolStripMenuItem
            // 
            this.kİTAPTAKİPToolStripMenuItem.Name = "kİTAPTAKİPToolStripMenuItem";
            this.kİTAPTAKİPToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kİTAPTAKİPToolStripMenuItem.Text = "KİTAP TAKİP";
            this.kİTAPTAKİPToolStripMenuItem.Click += new System.EventHandler(this.kİTAPTAKİPToolStripMenuItem_Click);
            // 
            // lİSTELERToolStripMenuItem
            // 
            this.lİSTELERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTABIVERENLERToolStripMenuItem,
            this.kİTABIVERMEYENLERToolStripMenuItem});
            this.lİSTELERToolStripMenuItem.Name = "lİSTELERToolStripMenuItem";
            this.lİSTELERToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lİSTELERToolStripMenuItem.Text = "LİSTELER";
            // 
            // kİTABIVERENLERToolStripMenuItem
            // 
            this.kİTABIVERENLERToolStripMenuItem.Name = "kİTABIVERENLERToolStripMenuItem";
            this.kİTABIVERENLERToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kİTABIVERENLERToolStripMenuItem.Text = "KİTABI VERENLER";
            this.kİTABIVERENLERToolStripMenuItem.Click += new System.EventHandler(this.kİTABIVERENLERToolStripMenuItem_Click);
            // 
            // kİTABIVERMEYENLERToolStripMenuItem
            // 
            this.kİTABIVERMEYENLERToolStripMenuItem.Name = "kİTABIVERMEYENLERToolStripMenuItem";
            this.kİTABIVERMEYENLERToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kİTABIVERMEYENLERToolStripMenuItem.Text = "KİTABI VERMEYENLER";
            this.kİTABIVERMEYENLERToolStripMenuItem.Click += new System.EventHandler(this.kİTABIVERMEYENLERToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkitapara);
            this.groupBox1.Controls.Add(this.txtuyeara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvKitap);
            this.groupBox1.Controls.Add(this.dgvUye);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateAlınıs);
            this.groupBox1.Controls.Add(this.dateVerilis);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 652);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Verme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtkitapara
            // 
            this.txtkitapara.Location = new System.Drawing.Point(837, 29);
            this.txtkitapara.Name = "txtkitapara";
            this.txtkitapara.Size = new System.Drawing.Size(446, 23);
            this.txtkitapara.TabIndex = 13;
            this.txtkitapara.TextChanged += new System.EventHandler(this.txtkitapara_TextChanged);
            // 
            // txtuyeara
            // 
            this.txtuyeara.Location = new System.Drawing.Point(131, 29);
            this.txtuyeara.Name = "txtuyeara";
            this.txtuyeara.Size = new System.Drawing.Size(446, 23);
            this.txtuyeara.TabIndex = 12;
            this.txtuyeara.TextChanged += new System.EventHandler(this.txtuyeara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(732, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "KİTAPLAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "ÜYELER";
            // 
            // dgvKitap
            // 
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Location = new System.Drawing.Point(732, 58);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.RowTemplate.Height = 25;
            this.dgvKitap.Size = new System.Drawing.Size(596, 339);
            this.dgvKitap.TabIndex = 9;
            // 
            // dgvUye
            // 
            this.dgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUye.Location = new System.Drawing.Point(46, 58);
            this.dgvUye.Name = "dgvUye";
            this.dgvUye.RowTemplate.Height = 25;
            this.dgvUye.Size = new System.Drawing.Size(572, 339);
            this.dgvUye.TabIndex = 8;
            this.dgvUye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUye_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(471, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Alınış Tarihi:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(471, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Veriliş Tarihi:";
            // 
            // dateAlınıs
            // 
            this.dateAlınıs.Location = new System.Drawing.Point(623, 467);
            this.dateAlınıs.Name = "dateAlınıs";
            this.dateAlınıs.Size = new System.Drawing.Size(200, 23);
            this.dateAlınıs.TabIndex = 5;
            // 
            // dateVerilis
            // 
            this.dateVerilis.Location = new System.Drawing.Point(623, 423);
            this.dateVerilis.Name = "dateVerilis";
            this.dateVerilis.Size = new System.Drawing.Size(200, 23);
            this.dateVerilis.TabIndex = 4;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Red;
            this.btnVer.Location = new System.Drawing.Point(623, 534);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(145, 41);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Kitabı Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbldurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Kütüphane Otomasyon";
            // 
            // lbldurum
            // 
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(130, 17);
            this.lbldurum.Text = "Kütüphane Otomasyon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem çIKIŞToolStripMenuItem;
        private ToolStripMenuItem üYELERToolStripMenuItem;
        private ToolStripMenuItem kİTAPLARToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnVer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbldurum;
        private DateTimePicker dateAlınıs;
        private DateTimePicker dateVerilis;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridView dgvKitap;
        private DataGridView dgvUye;
        private ToolStripMenuItem kİTAPTAKİPToolStripMenuItem;
        private TextBox txtkitapara;
        private TextBox txtuyeara;
        private ToolStripMenuItem lİSTELERToolStripMenuItem;
        private ToolStripMenuItem kİTABIVERENLERToolStripMenuItem;
        private ToolStripMenuItem kİTABIVERMEYENLERToolStripMenuItem;
    }
}