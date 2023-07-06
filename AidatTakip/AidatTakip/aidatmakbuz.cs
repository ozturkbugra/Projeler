using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidatTakip
{
    public partial class aidatmakbuz : Form
    {
        Bitmap memoryImage;
        aidatodeme a = new aidatodeme();
        public aidatmakbuz()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void aidatmakbuz_Load(object sender, EventArgs e)
        {
            if (lblTarih.Text == "")
            {
                lblTarih.Text = DateTime.Now.ToString("d");
            }

            if (lblBorc.Text == "0")
            {
                lblNot.Text = "Aidatınızı zamanında ödediğiniz için teşekkür ederiz.";
            }/*else
            {
                lblNot.Text = "Lütfen borcunuzu zamanında ödeyiniz";
            }*/
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
