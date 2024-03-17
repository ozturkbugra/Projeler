using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace AidatTakip
{
    public partial class Rapor : Form
    {

        public Rapor()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            rprgelirgider a = new rprgelirgider();

            if (lblElektrik.Text == "")
            {
                lblElektrik.Text = "0";
            }
            if (lblSu.Text == "")
            {
                lblSu.Text = "0";
            }
            if (lblYonetim.Text == "")
            {
                lblYonetim.Text = "0";
            }
            if (lblTemizlik.Text == "")
            {
                lblTemizlik.Text = "0";
            }
            if (lblBakım.Text == "")
            {
                lblBakım.Text = "0";
            }
            if (lblDemirbas.Text == "")
            {
                lblDemirbas.Text = "0";
            }
            if (lblMaas.Text == "")
            {
                lblMaas.Text = "0";
            }
            if (lblSsk.Text == "")
            {
                lblSsk.Text = "0";
            }
            if (lblDiger.Text == "")
            {
                lblDiger.Text = "0";
            }
            if (lblAidat.Text == "")
            {
                lblAidat.Text = "0";
            }
            if (lblDiger.Text == "")
            {
                lblDiger.Text = "0";
            }
            if (lblToplamGelir.Text == "")
            {
                lblToplamGelir.Text = "0";
            }
            if (lblEskiKasa.Text == "")
            {
                lblEskiKasa.Text = "0";
            }
            if (lblKasa.Text == "")
            {
                lblKasa.Text = "0";
            }
            int toplamgider = Convert.ToInt32(lblElektrik.Text) + Convert.ToInt32(lblSu.Text) + Convert.ToInt32(lblYonetim.Text) + Convert.ToInt32(lblTemizlik.Text)
                + Convert.ToInt32(lblBakım.Text) + Convert.ToInt32(lblDemirbas.Text) + Convert.ToInt32(lblMaas.Text) + Convert.ToInt32(lblSsk.Text) + Convert.ToInt32(lblDiger.Text);
            lblToplamGider.Text = toplamgider.ToString();

            int toplamgelir = Convert.ToInt32(lblAidat.Text) + Convert.ToInt32(lblDigerGelir.Text);
            lblToplamGelir.Text = toplamgelir.ToString();

            int eskikasa5 = Convert.ToInt32(lblEskiKasa.Text);

            int kasa = (toplamgelir + eskikasa5) - toplamgider;

            lblKasa.Text = kasa.ToString();

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pDFeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
                saveFileDialog.FileName ="Uzay 2 Apartmanı "+ lblAy.Text + " Gelir Gider raporu" ;
                saveFileDialog.InitialDirectory = desktopPath;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageFilePath = saveFileDialog.FileName;

                    Size formSize = this.Size;

                    using (Bitmap bitmap = new Bitmap(formSize.Width, formSize.Height))
                    {
                        this.DrawToBitmap(bitmap, new Rectangle(0, 0, formSize.Width, formSize.Height));
                        bitmap.Save(imageFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}

