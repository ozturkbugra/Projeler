using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidatTakip
{
    public partial class giris : Form
    {
      

        
        public giris()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aİDATÖDEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aidatodeme a = new aidatodeme();
            a.ShowDialog();
            a.Dispose();
        }

        private void sAKİNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sakinler a = new sakinler();
            a.ShowDialog();
            a.Dispose();
        }

        private void dÖNEMEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donemekle a = new donemekle();
            a.ShowDialog();
            a.Dispose();
        }

        private void tAHSİLATMAKBUZUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tahsilat a = new tahsilat();
            a.ShowDialog();
            a.Dispose();
        }

        private void gİDERMABUZUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gider a = new gider();
            a.ShowDialog();
            a.Dispose();
        }

        private void mAKBUZARAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            makbuzara a = new makbuzara();
            a.ShowDialog();
            a.Dispose();
        }

        private void kASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasa a = new kasa();
            a.ShowDialog();
            a.Dispose();

        }

        private void gELİRRAPORUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rprGelir a = new rprGelir();
            a.ShowDialog();
            a.Dispose();
        }

        private void gİDERRAPORUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rprGider a = new rprGider();
            a.ShowDialog();
            a.Dispose();
        }

        private void tAHSİLATRAPORUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void şİFREGÜNCELLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifre a = new sifre();
            a.ShowDialog();
            a.Dispose();
        }

        private void bORÇLUDAİRELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borcludaireler a = new borcludaireler();
            a.ShowDialog();
            a.Dispose();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardım a = new yardım();
            a.ShowDialog();
            a.Dispose();
        }

        private void bELİRLİTARİHARASIKASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasa2 a = new kasa2();
            a.ShowDialog();
            a.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/iUbLHwEJWCU");

        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void giris_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            if (DateTime.Now.ToString("dd") == "1" || DateTime.Now.ToString("dd") == "2" || DateTime.Now.ToString("dd") == "3")
            {
                lblAidat.Text="AİDAT BORÇLANDIRMA İŞLEMİ ZAMANINIZ GELDİ EĞER BORÇLANDIRMADIYSANIZ TIKLAYIN";
            }else
            {
                lblAidat.Text = "";
            }
           


        }

        private void yedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lblAidat_Click(object sender, EventArgs e)
        {
            donemekle a = new donemekle();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
