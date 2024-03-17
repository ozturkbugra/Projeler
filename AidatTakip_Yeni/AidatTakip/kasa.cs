using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidatTakip
{
    public partial class kasa : Form
    {
        int aidatay;
        int ekay;
        int tahsilatay;
        int gideray;
        string aidat1;
        string ek1;
        string tahsilat1;
        string ay = DateTime.Now.ToString("MMMM");
        string yıl = DateTime.Now.ToString("yyyy");

        listele b = new listele();
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        public kasa()
        {
            InitializeComponent();
        }

        private void kasa_Load(object sender, EventArgs e)
        {
            lblAy.Text = DateTime.Now.ToString("MMMM");

            dgvGider.DataSource = b.veriAl("set dateformat dmy Select * from VwGiderler Where ay = '" + ay + "' and yıl ='" + yıl + "' order by [Gider No] desc ");
            dgvAidat.DataSource = b.veriAl("Select [Makbuz No],[Daire No], ad + ' ' + soyad AS 'Adı Soyadı', [Aidat Ayı] , [Aidat Tutarı], [Ek Ayı] , [Ek Tutarı],[Makbuz Tarihi], ay, yıl  from VwMakbuz Where Ay = '" + ay + "' and yıl ='" + yıl + "' order by [Makbuz No] desc");
            dgvAidat.Columns[9].Visible = false;
            dgvAidat.Columns[8].Visible = false;
            dgvGider.Columns[4].Visible = false;
            dgvGider.Columns[5].Visible = false;

            conn.Open();
            string sql100 = "Select Sum([Aidat Tutarı]) from VwMakbuz  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd100 = new SqlCommand(sql100, conn);
            cmd100.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
            cmd100.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
            SqlDataReader dr100 = cmd100.ExecuteReader();
            if (dr100.Read())
            {
                if (dr100[0] != DBNull.Value && dr100[0] != null)
                {
                    aidatay = Convert.ToInt32(dr100[0]);
                }
                else
                {
                    aidatay = 0; // Set to 0 if the value is null
                }
            }

            conn.Close();

            conn.Open();
            string sql101 = "Select Sum([Gider Tutarı]) from VwGiderler  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd101 = new SqlCommand(sql101, conn);
            cmd101.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
            cmd101.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
            SqlDataReader dr101 = cmd101.ExecuteReader();
            if (dr101.Read())
            {
                if (dr101[0] != DBNull.Value && dr101[0] != null)
                {
                    gideray = Convert.ToInt32(dr101[0]);
                }
                else
                {
                    gideray = 0; // Set to 0 if the value is null
                }
            }

            conn.Close();

            conn.Open();
            string sql102 = "Select Sum([Ek Tutarı]) from VwMakbuz  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd102 = new SqlCommand(sql102, conn);
            cmd102.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
            cmd102.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
            SqlDataReader dr102 = cmd102.ExecuteReader();
            if (dr102.Read())
            {


                if (dr102[0] != DBNull.Value && dr102[0] != null)
                {
                    ekay = Convert.ToInt32(dr102[0]);
                }
                else
                {
                    ekay = 0; // Set to 0 if the value is null
                }


            }

            conn.Close();

            conn.Open();
            string sql103 = "Select Sum([Tahsilat Tutar]) from VwTahsilat  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd103 = new SqlCommand(sql103, conn);
            cmd103.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
            cmd103.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
            SqlDataReader dr103 = cmd103.ExecuteReader();
            if (dr103.Read())
            {
                if (dr103[0] != DBNull.Value && dr103[0] != null)
                {
                    tahsilatay = Convert.ToInt32(dr103[0]);
                }
                else
                {
                    tahsilatay = 0; // Set to 0 if the value is null
                }
            }

            conn.Close();


            int toplam8 = aidatay + ekay + tahsilatay;

            txtGelir2.Text = toplam8.ToString();
            txtGider2.Text = gideray.ToString();

            // alacak kısmının hesaplanması
            conn.Open();
            string sql55 = "Select Sum(borc) from tblSakinler Where borc>0";
            SqlCommand cmd55 = new SqlCommand(sql55, conn);
            SqlDataReader dr55 = cmd55.ExecuteReader();
            if (dr55.Read())
            {
                txtAlacak.Text = dr55[0].ToString();
            }
            conn.Close();

            //alınan aidatların hesaplanması griedviewe aktarma
            conn.Open();
            string sql3 = "Select Sum(tutar) from tblAidat WHERE bitti=1";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                aidat1 = dr[0].ToString();
            }
            conn.Close();

            //alınan eklerin hesaplanması ve griedviewe aktarma
            conn.Open();
            string sql4 = "Select Sum(tutar) from tblEk WHERE bitti=1";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                ek1 = dr2[0].ToString();

            }
            conn.Close();

            //alınan tahsilatların hesaplanması ve griedviewe aktarma
            conn.Open();
            string sql5 = "Select Sum(tutar) from tblTahsilat";
            SqlCommand cmd2 = new SqlCommand(sql5, conn);
            SqlDataReader dr3 = cmd2.ExecuteReader();
            if (dr3.Read())
            {
                tahsilat1 = dr3[0].ToString();

            }
            conn.Close();

            //verilen giderlerin hesaplanması ve griedviewe aktarılması
            conn.Open();
            string sql6 = "Select Sum(tutar) from tblGiderler";
            SqlCommand cmd3 = new SqlCommand(sql6, conn);
            SqlDataReader dr4 = cmd3.ExecuteReader();
            if (dr4.Read())
            {
                txtGider.Text = dr4[0].ToString();

            }
            conn.Close();


            //değerler boşsa 0 yapıyoruz
            if (txtGider.Text == "")
            {
                txtGider.Text = "0";
            }
            if (aidat1 == "")
            {
                aidat1 = "0";
            }
            if (ek1 == "")
            {
                ek1 = "0";
            }
            if (tahsilat1 == "")
            {
                tahsilat1 = "0";
            }

            //tür dönüşümleri ve kasa hesaplama
            int gider = Convert.ToInt32(txtGider.Text);
            int aidat = Convert.ToInt32(aidat1);
            int tahsilat = Convert.ToInt32(tahsilat1);
            int ek = Convert.ToInt32(ek1);
            int eski = 45996;
            int toplamgelir = aidat + tahsilat + ek;
            txtGelir.Text = toplamgelir.ToString();
            int gelir = Convert.ToInt32(txtGelir.Text);



            int toplam = (gelir + eski) - gider;

            txtKasa.Text = toplam.ToString();
        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //giderlerin üzerine basınca ekstra makbuz çıkartma
            gidermakbuz a = new gidermakbuz();
            a.lblTarih.Text = dgvGider.CurrentRow.Cells[3].Value.ToString();
            a.lblGiderAciklama.Text = dgvGider.CurrentRow.Cells[1].Value.ToString();
            a.lblToplam.Text = dgvGider.CurrentRow.Cells[2].Value.ToString();
            a.lblTutar.Text = dgvGider.CurrentRow.Cells[2].Value.ToString();
            a.lblTutar2.Text = "# " + dgvGider.CurrentRow.Cells[2].Value.ToString() + " #";
            a.lblMakNo.Text = dgvGider.CurrentRow.Cells[0].Value.ToString();
            a.ShowDialog();
            a.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTahsilat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGelir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtGider_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
