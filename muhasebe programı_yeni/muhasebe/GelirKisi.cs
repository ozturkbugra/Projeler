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
    public partial class GelirKisi : Form
    {
        int o;
        int a;
        public static string c = baglan.conStr;

        SqlConnection conn = new SqlConnection(c);

        baglan b = new baglan();
        public GelirKisi()
        {
            InitializeComponent();
        }

        private void GelirKisi_Load(object sender, EventArgs e)
        {
            dgvSektor.DataSource = b.veriAl("Select * from tblKisi");
            dgvSektor.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            conn.Open();
            string sorgu = "Select count(*) from tblKisi where AdSoyad=@p1";
            SqlCommand cmd1 = new SqlCommand(sorgu, conn);
            cmd1.Parameters.AddWithValue("@p1", txtAd.Text);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                a = Convert.ToInt32(dr2[0]);
            }
            else
            {
                a = 0;
            }
            conn.Close();
            if (a == 0)
            {
                conn.Open();
                string sql = "Insert Into tblKisi (AdSoyad) values (@p1)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvSektor.DataSource = b.veriAl("Select * from tblKisi");
            }
            else
            {
                MessageBox.Show("Bu kişiyi zaten eklediniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Güncellemek İstiyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                conn.Open();
                string sql = "Update tblKisi set AdSoyad=@p1 where KisiId=@p2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", dgvSektor.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvSektor.DataSource = b.veriAl("Select * from tblKisi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                conn.Open();
                string sql = "Select count(*) from tblGelirler where KisiId=@p2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p2", dgvSektor.CurrentRow.Cells[0].Value.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    o = Convert.ToInt32(dr[0]);
                }
                else
                {
                    o = 0;
                }
                conn.Close();
                if (o == 0)
                {
                    conn.Open();
                    string sql2 = "Delete from tblKisi where KisiId=@p2";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@p2", dgvSektor.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    dgvSektor.DataSource = b.veriAl("Select * from tblKisi");
                }
                else
                {
                    MessageBox.Show("Bu kişinin geliri olduğu için silinemez");
                    conn.Close();
                }


            }
        }

        private void dgvSektor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvSektor.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
