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
    public partial class hesap : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        public hesap()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                baglan b = new baglan();
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Güncellemek İstiyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblAdmin set Ad=@kullaniciAdi, Sifre=@parola where ID=1";
                    cmd.Parameters.AddWithValue("@kullaniciAdi", txtAd.Text);
                    cmd.Parameters.AddWithValue("@parola", txtParola.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Başarıyla güncellendi", "İşlem başarılı");
                }

            }

        }

        private void hesap_Load(object sender, EventArgs e)
        {

        }
    }
}
