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
    public partial class borcartis : Form
    {
        string o;
        int toplam;
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        listele b = new listele();
        int aidat;
        int zam;
        string ay = DateTime.Now.Date.ToString("MMMM");
        public borcartis()
        {
            InitializeComponent();
        }

        private void borcartis_Load(object sender, EventArgs e)
        {


            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd1.Parameters.AddWithValue("@veri2", 10);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                zam = Convert.ToInt32(dr[2]);
            }
            conn.Close();


            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd2.Parameters.AddWithValue("@veri2", 8);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                aidat = Convert.ToInt32(dr2[2]);
            }
            conn.Close();

            dgvAidat.DataSource = b.veriAl("Select * from VwAidat where Bitti=0 and [Aidat Tutarı] =" + aidat + " ");
            dgvAidat.Columns[0].Visible = false;
            dgvAidat.Columns[5].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {






        }

        private void dgvAidat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aidattutar = Convert.ToInt32(dgvAidat.CurrentRow.Cells["Aidat Tutarı"].Value.ToString());
            int daire = Convert.ToInt32(dgvAidat.CurrentRow.Cells["Daire No"].Value.ToString());


            try
            {
                if (aidattutar >= zam + aidat)
                {
                    MessageBox.Show("Bu aidata zaten gecikme zammı eklenmiştir");
                }
                else
                {
                    conn.Open();
                    string sql = "Update tblAidat set tutar=@p1 where ID=@p2";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", aidat + zam);
                    cmd.Parameters.AddWithValue("@p2", dgvAidat.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Open();
                    string sql1 = "Select sum(tutar) from tblAidat  Where daireNo = '" + daire + "' and bitti=0";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        toplam = Convert.ToInt32(dr[0]);
                    }
                    conn.Close();
                    conn.Open();
                    string sql2 = "Update tblSakinler set borc = @p1 Where No = '" + daire + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@p1", toplam);
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("İşlem Başarılı Olmuştur");

                    dgvAidat.DataSource = b.veriAl("Select * from VwAidat where Bitti=0 and [Aidat Tutarı] =" + aidat + " ");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }








        }
    }
}
