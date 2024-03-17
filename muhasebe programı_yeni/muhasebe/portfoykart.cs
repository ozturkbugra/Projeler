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
    public partial class portfoykart : Form
    {
        int o;
        int a;

        public static string c = baglan.conStr;

        SqlConnection conn = new SqlConnection(c);

        baglan b = new baglan();
        public portfoykart()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            conn.Open();
            string sorgu = "Select count(*) from tblPortfoyKart where PAd=@p1";
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
                string sql = "Insert Into tblPortfoyKart (PAd,PTur) values (@p1,@p2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtTur.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvSektor.DataSource = b.veriAl("Select * from tblPortfoyKart");
            }
            else
            {
                MessageBox.Show("Bu Portföy Sisteme kayıtlı");
            }
        }

        private void portfoykart_Load(object sender, EventArgs e)
        {
            dgvSektor.DataSource = b.veriAl("Select * from tblPortfoyKart");
            dgvSektor.Columns[0].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Güncellemek İstiyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                conn.Open();
                string sql = "Update tblPortfoyKart set PAd=@p1,PTur=@p2 where Id=@p3";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtTur.Text);
                cmd.Parameters.AddWithValue("@p3", dgvSektor.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvSektor.DataSource = b.veriAl("Select * from tblPortfoyKart");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                conn.Open();
                string sql = "Select count(*) from tblPortfoy where PAd=@p2";
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
                    string sql2 = "Delete from tblPortfoyKart where Id=@p2";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@p2", dgvSektor.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    dgvSektor.DataSource = b.veriAl("Select * from tblPortfoyKart");
                }
                else
                {
                    MessageBox.Show("Bu Portföy ile işlem yaptığınız için silinemiyor");
                    conn.Close();
                }
            }
        }

        private void dgvSektor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvSektor.CurrentRow.Cells[1].Value.ToString();
            txtTur.Text = dgvSektor.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
