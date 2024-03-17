using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidatTakip
{
    public partial class giris : Form
    {
        int aidat;
        string ay = DateTime.Now.ToString("MMMM").ToUpper();
        string yıl = DateTime.Now.ToString("yyyy");
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        listele b = new listele();
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

            //aidat güncellemesi yapmadıysa uyaran kod
            conn.Open();
            SqlCommand cmd10 = new SqlCommand("Select * from tblAidat Where aidatAdi= '" + ay + "' and aidatYili= '" + yıl + "' ", conn);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                aidat = 1;
            }
            else
            {
                aidat = 0;
            }

            conn.Close();
            if (aidat == 0)
            {
                MessageBox.Show("Bu ayın aidatını eklemediniz güncelleme gerekli");
                donemekle a = new donemekle();
                a.ShowDialog();

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

        private void gELİRGİDERTABLOSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rprgelirgider a = new rprgelirgider();
            a.ShowDialog();
            a.Dispose();
        }

        private void aİDATGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borcartis a = new borcartis();
            a.ShowDialog();
            a.Dispose();
        }

        private void OpenWebPage(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Varsayılan tarayıcıyı başlatma hatası olursa, alternatif bir yöntem kullanabilirsiniz.
                // Örneğin, varsayılan web tarayıcısını başlatmak için bu fonksiyonu kullanabilirsiniz:
                System.Diagnostics.Process.Start("cmd", $"/c start {url}");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Internet sitesinin URL'sini belirleyin
            string url = "https://bugrasoft.com";

            // URL'yi açmak için fonksiyonu çağırın
            OpenWebPage(url);
        }

        private void gİRİŞBİLGİLERİDEĞİŞTİRMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tÜREGÖREGİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TureGoreGiderler a = new TureGoreGiderler();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
