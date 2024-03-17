using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void şirketlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sirket a = new Sirket();
            a.kadi = lblKullaniciAdi.Text;
            a.ShowDialog();
            a.Dispose();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giderler a = new Giderler();
            a.kadi = lblKullaniciAdi.Text;
            a.ShowDialog();
            a.Dispose();
        }

        private void gelirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelirler a = new Gelirler();
            a.kadi = lblKullaniciAdi.Text;
            a.ShowDialog();
            a.Dispose();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasa a = new Kasa();
            a.kadi = lblKullaniciAdi.Text;
            a.ShowDialog();
            a.Dispose();
        }

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çalışanlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisanlar a = new Calisanlar();
            a.kadi = lblKullaniciAdi.Text;
            a.ShowDialog();
            a.Dispose();
        }
    }
}
