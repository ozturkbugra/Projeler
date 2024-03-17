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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SirketProje
{
    public partial class Form1 : Form
    {
        public static string c = baglan.conStr;

        SqlConnection conn = new SqlConnection(c);

        baglan b = new baglan();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool KullaniciVarmi(string a)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT COUNT(*) FROM tblKullanicilar WHERE KullaniciAdi = @kullaniciAdi";
                cmd.Parameters.AddWithValue("@kullaniciAdi", a);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }

        }


        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            if (KullaniciVarmi(txtGirisKadi.Text))
            {
                if (txtKayitSifre1.Text == TxtKayitSifre2.Text)
                {
                    string sql = "Insert Into tblKullanicilar (KullaniciAdi,AdSoyad,Parola) values (@p1,@p2,@p3) ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", txtKayitKadi.Text);
                    cmd.Parameters.AddWithValue("@p2", txtKayitAd.Text);
                    cmd.Parameters.AddWithValue("@p3", txtKayitSifre1.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(txtKayitKadi.Text + " Kullanıcısı oluşturuldu");
                }
                else
                {
                    MessageBox.Show("Şifreleriniz Uyuşmuyor");
                }
            }else
            {
                MessageBox.Show("Bu kullanıcı adı sisteme kayıtlı");
            }
            
           
            
            

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtGirisKadi.Text;

            string parola = txtGirisSifre.Text;

            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tblKullanicilar where KullaniciAdi='" + kullanici + "'And Parola='" + parola + "'";
            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            if (dr.Read())

            {

                AnaSayfa a = new AnaSayfa();
                a.lblKullaniciAdi.Text = kullanici;
                a.Show();

                this.Hide();

            }

            else

            {

                MessageBox.Show("Hatalı giriş");

            }

            conn.Close();
        }
    }
}
