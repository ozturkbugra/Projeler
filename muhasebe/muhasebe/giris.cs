using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giderler a = new giderler();
            a.ShowDialog();
            a.Dispose();
        }

        private void gELİRLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gelirler a = new gelirler();
            a.ShowDialog();
            a.Dispose();

        }

        private void bORÇLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borclar a = new borclar();
            a.ShowDialog();
            a.Dispose();
        }

        private void pORTFÖYLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portföy a = new portföy();
            a.ShowDialog();
            a.Dispose();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gELİRGİDERRAPORUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gelirgidernew a = new gelirgidernew();
            a.ShowDialog();
            a.Dispose();
        }

       

        private void tÜMPORTFÖYLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tümportföyler a = new tümportföyler();
            a.ShowDialog();
            a.Dispose();
        }

        private void bORÇLARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void sEKTÖREGÖREGİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sektör a = new sektör();
            a.ShowDialog();
            a.Dispose();

        }

        private void giris_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void aLINANBORÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borclar a = new borclar();
            a.ShowDialog();
            a.Dispose();
        }

        private void vERİLENBORÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borc2 a = new borc2();
            a.ShowDialog();
            a.Dispose();
        }

        private void mEVCUTKASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KASA a = new KASA();
            a.ShowDialog();
            a.Dispose();
        }

        private void şİFREİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesap a = new hesap();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
