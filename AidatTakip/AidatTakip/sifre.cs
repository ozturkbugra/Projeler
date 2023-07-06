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
    public partial class sifre : Form
    {
        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public sifre()
        {
            InitializeComponent();
        }

        private void sifre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtKullanici.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Kullanıcı adı ve Şifreyi değiştirmek istiyor musunuz?", "Değiştirme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "Update tblAdmin set kullaniciAdi=@kullaniciAdi, parola=@parola";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", txtKullanici.Text);
                    cmd.Parameters.AddWithValue("@parola", txtParola.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kullanıcı adı ve şifre başarıyla değiştirildi", "İşlem Başarılı");
                }


            }

        }
    }
}
