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

namespace SirketProje
{
    public partial class Sirket : Form
    {
        public static string c = baglan.conStr;

        SqlConnection conn = new SqlConnection(c);
        AnaSayfa a = new AnaSayfa();
        int id;
        public string kadi;
        baglan b = new baglan();
        public Sirket()
        {
            InitializeComponent();
        }


        private void Sirket_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select ID from tblKullanicilar where KullaniciAdi= '" + kadi + " '";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            conn.Close();

            dgvSirket.DataSource = b.veriAl("Select ID,Ad From SirketlerView where KullaniciID=' "+ id +" '");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into tblSirket (Ad,KullaniciID) values (@p1,@p2) ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(txtAd.Text + " Şirketi oluşturuldu");
            dgvSirket.DataSource = b.veriAl("Select ID,Ad From SirketlerView where KullaniciID=' " + id + " '");
        }

        private void dgvSirket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSirket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvSirket.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update tblSirket set Ad=@p1 where ID=@p2 ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", dgvSirket.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(txtAd.Text + " Şirketi Güncellendi");
            dgvSirket.DataSource = b.veriAl("Select ID,Ad From SirketlerView where KullaniciID=' " + id + " '");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblSirket where ID=@p1 ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", dgvSirket.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(txtAd.Text + " Şirketi Silindi");
            dgvSirket.DataSource = b.veriAl("Select ID,Ad From SirketlerView where KullaniciID=' " + id + " '");
        }
    }
}
