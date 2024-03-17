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

namespace muhasebe
{
    public partial class giris : Form
    {
        string ay = DateTime.Now.ToString("MM");
        string yil = DateTime.Now.ToString("yyyy");
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        int d, f, g;

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
            conn.Open();
            string sql = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Elektrik'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblElektrik.ForeColor = Color.Green;
                lblElektrik.Text = "Ödenmiştir";
                pbelektrik.Value = 100;

            }
            else
            {
                lblElektrik.ForeColor = Color.Red;
                lblElektrik.Text = "Ödenmemiştir";
                pbelektrik.Value = 2;

            }
            conn.Close();

            conn.Open();
            string sql1 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Su'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                lblSu.ForeColor = Color.Green;
                lblSu.Text = "Ödenmiştir";
                pbSu.Value = 100;

            }
            else
            {
                lblSu.ForeColor = Color.Red;
                lblSu.Text = "Ödenmemiştir";
                pbSu.Value = 2;

            }
            conn.Close();

            conn.Open();
            string sql2 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='İnternet'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblInternet.ForeColor = Color.Green;
                lblInternet.Text = "Ödenmiştir";
                pbInternet.Value = 100;

            }
            else
            {
                lblInternet.ForeColor = Color.Red;
                lblInternet.Text = "Ödenmemiştir";
                pbInternet.Value = 2;

            }
            conn.Close();

            conn.Open();
            string sql3 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Doğalgaz'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                lblDogalgaz.ForeColor = Color.Green;
                lblDogalgaz.Text = "Ödenmiştir";
                pbDogalgaz.Value = 100;

            }
            else
            {
                lblDogalgaz.ForeColor = Color.Red;
                lblDogalgaz.Text = "Ödenmemiştir";
                pbDogalgaz.Value = 2;

            }
            conn.Close();

            conn.Open();

            string sql4 = "Select count(*) from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Telefon'";
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                d = Convert.ToInt32(dr4[0]);

            }

            if (d == 0)
            {
                lblTelefon.Text = "Ödenmemiştir";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 3;

            }
            else if (d == 1)
            {
                lblTelefon.Text = "1 Ödeme";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 33;

            }
            else if (d == 2)
            {
                lblTelefon.Text = "2 Ödeme";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 66;

            }
            else if (d >= 3)
            {
                lblTelefon.Text = "Ödenmiştir";
                lblTelefon.ForeColor = Color.Green;
                pbTelefon.Value = 100;
            }

            conn.Close();


            conn.Open();

            string sql5 = "Select count(*) from ViewGiderler where Yil = '" + yil + "' and [Sektör Adı]='Belediye Vergi'";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                f = Convert.ToInt32(dr5[0]);

            }

            if (f == 0)
            {
                lblBelediye.Text = "Ödenmemiştir";
                lblBelediye.ForeColor = Color.Red;
                pbBelediye.Value = 3;

            }
            else if (f == 1)
            {
                lblBelediye.Text = "1 Ödeme";
                lblBelediye.ForeColor = Color.Red;
                pbBelediye.Value = 50;

            }
            else if (f >= 2)
            {
                lblBelediye.Text = "Ödenmiştir";
                lblBelediye.ForeColor = Color.Green;
                pbBelediye.Value = 100;

            }


            conn.Close();

            conn.Open();
            string sql6 = "Select count(*) from ViewGiderler where Yil = '" + yil + "' and [Sektör Adı]='Araba Vergi'";
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                g = Convert.ToInt32(dr6[0]);

            }

            if (g == 0)
            {
                lblAraba.Text = "Ödenmemiştir";
                lblAraba.ForeColor = Color.Red;
                pbAraba.Value = 3;

            }
            else if (g == 1)
            {
                lblAraba.Text = "1 Ödeme";
                lblAraba.ForeColor = Color.Red;
                pbAraba.Value = 50;

            }
            else if (g >= 2)
            {
                lblAraba.Text = "Ödenmiştir";
                lblAraba.ForeColor = Color.Green;
                pbAraba.Value = 100;

            }


            conn.Close();

            conn.Open();
            string sql7 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Twitter'";
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                lblTwitter.ForeColor = Color.Green;
                lblTwitter.Text = "Ödenmiştir";
                pbTwitter.Value = 100;

            }
            else
            {
                lblTwitter.ForeColor = Color.Red;
                lblTwitter.Text = "Ödenmemiştir";
                pbTwitter.Value = 2;

            }
            conn.Close();

            conn.Open();
            string sql8 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Youtube'";
            SqlCommand cmd8 = new SqlCommand(sql8, conn);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                lblYoutube.ForeColor = Color.Green;
                lblYoutube.Text = "Ödenmiştir";
                pbYoutube.Value = 100;

            }
            else
            {
                lblYoutube.ForeColor = Color.Red;
                lblYoutube.Text = "Ödenmemiştir";
                pbYoutube.Value = 2;

            }
            conn.Close();
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
            borclar a = new borclar();
            a.ShowDialog();
            a.Dispose();
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

            conn.Open();
            string sql = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Elektrik'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblElektrik.ForeColor = Color.Green;
                lblElektrik.Text = "Ödenmiştir";
                pbelektrik.Value = 100;

            }
            else
            {
                lblElektrik.ForeColor = Color.Red;
                lblElektrik.Text = "Ödenmemiştir";
                pbelektrik.Value = 2;

            }
            conn.Close();


            conn.Open();
            string sql1 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Su'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                lblSu.ForeColor = Color.Green;
                lblSu.Text = "Ödenmiştir";
                pbSu.Value = 100;

            }
            else
            {
                lblSu.ForeColor = Color.Red;
                lblSu.Text = "Ödenmemiştir";
                pbSu.Value = 2;

            }
            conn.Close();


            conn.Open();
            string sql2 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='İnternet'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblInternet.ForeColor = Color.Green;
                lblInternet.Text = "Ödenmiştir";
                pbInternet.Value = 100;

            }
            else
            {
                lblInternet.ForeColor = Color.Red;
                lblInternet.Text = "Ödenmemiştir";
                pbInternet.Value = 2;

            }
            conn.Close();

            conn.Open();
            string sql3 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Doğalgaz'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                lblDogalgaz.ForeColor = Color.Green;
                lblDogalgaz.Text = "Ödenmiştir";
                pbDogalgaz.Value = 100;

            }
            else
            {
                lblDogalgaz.ForeColor = Color.Red;
                lblDogalgaz.Text = "Ödenmemiştir";
                pbDogalgaz.Value = 2;

            }
            conn.Close();

            conn.Open();

            string sql4 = "Select count(*) from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Telefon'";
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                d = Convert.ToInt32(dr4[0]);

            }

            if (d == 0)
            {
                lblTelefon.Text = "Ödenmemiştir";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 3;

            }
            else if (d == 1)
            {
                lblTelefon.Text = "1 Ödeme";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 33;

            }
            else if (d == 2)
            {
                lblTelefon.Text = "2 Ödeme";
                lblTelefon.ForeColor = Color.Red;
                pbTelefon.Value = 66;

            }
            else if (d >= 3)
            {
                lblTelefon.Text = "Ödenmiştir";
                lblTelefon.ForeColor = Color.Green;
                pbTelefon.Value = 100;
            }

            conn.Close();

            conn.Open();

            string sql5 = "Select count(*) from ViewGiderler where Yil = '" + yil + "' and [Sektör Adı]='Belediye Vergi'";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                f = Convert.ToInt32(dr5[0]);

            }

            if (f == 0)
            {
                lblBelediye.Text = "Ödenmemiştir";
                lblBelediye.ForeColor = Color.Red;
                pbBelediye.Value = 3;

            }
            else if (f == 1)
            {
                lblBelediye.Text = "1 Ödeme";
                lblBelediye.ForeColor = Color.Red;
                pbBelediye.Value = 50;

            }
            else if (f >= 2)
            {
                lblBelediye.Text = "Ödenmiştir";
                lblBelediye.ForeColor = Color.Green;
                pbBelediye.Value = 100;

            }


            conn.Close();

            conn.Open();
            string sql6 = "Select count(*) from ViewGiderler where Yil = '" + yil + "' and [Sektör Adı]='Araba Vergi'";
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                g = Convert.ToInt32(dr6[0]);

            }

            if (g == 0)
            {
                lblAraba.Text = "Ödenmemiştir";
                lblAraba.ForeColor = Color.Red;
                pbAraba.Value = 3;

            }
            else if (g == 1)
            {
                lblAraba.Text = "1 Ödeme";
                lblAraba.ForeColor = Color.Red;
                pbAraba.Value = 50;

            }
            else if (g >= 2)
            {
                lblAraba.Text = "Ödenmiştir";
                lblAraba.ForeColor = Color.Green;
                pbAraba.Value = 100;

            }


            conn.Close();

            conn.Open();
            string sql7 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Twitter'";
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                lblTwitter.ForeColor = Color.Green;
                lblTwitter.Text = "Ödenmiştir";
                pbTwitter.Value = 100;

            }
            else
            {
                lblTwitter.ForeColor = Color.Red;
                lblTwitter.Text = "Ödenmemiştir";
                pbTwitter.Value = 2;

            }
            conn.Close();
            conn.Open();
            string sql8 = "Select * from ViewGiderler where Ay ='" + ay + "' and Yil = '" + yil + "' and [Sektör Adı]='Youtube'";
            SqlCommand cmd8 = new SqlCommand(sql8, conn);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                lblYoutube.ForeColor = Color.Green;
                lblYoutube.Text = "Ödenmiştir";
                pbYoutube.Value = 100;

            }
            else
            {
                lblYoutube.ForeColor = Color.Red;
                lblYoutube.Text = "Ödenmemiştir";
                pbYoutube.Value = 2;

            }
            conn.Close();

        }

        private void aLINANBORÇToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vERİLENBORÇToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void gİDERTÜRÜTANIMLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SektorTanimla a = new SektorTanimla();
            a.ShowDialog();
            a.Dispose();
        }

        private void öDEMEYÖNTEMİTANIMLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeTuru a = new OdemeTuru();
            a.ShowDialog();
            a.Dispose();
        }

        private void cARİTANIMLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cariler a = new Cariler();
            a.ShowDialog();
            a.Dispose();
        }

        private void gELİRKİŞİSİTANIMLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirKisi a = new GelirKisi();
            a.ShowDialog();
            a.Dispose();
        }

        private void pORTFÖYTANIMLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portfoykart a = new portfoykart();
            a.ShowDialog();
            a.Dispose();
        }

        private void dETAYLIGİDERRAPORUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
            a.Dispose();
        }

        private void bORÇLULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumBorclar a = new TumBorclar();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
