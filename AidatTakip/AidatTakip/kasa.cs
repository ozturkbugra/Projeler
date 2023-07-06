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
        string aidat1;
        string ek1;
        string tahsilat1;

        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public kasa()
        {
            InitializeComponent();
        }

        private void kasa_Load(object sender, EventArgs e)
        {
         

                dgvGider.DataSource = b.veriAl("set dateformat dmy Select * from VwGiderler order by [Gider No] desc ");
                dgvAidat.DataSource = b.veriAl("Select * from VwMakbuz order by [Makbuz No] desc");
            
            
            
           
            
            
            
            conn.Open();
            string sql55 = "Select Sum(borc) from tblSakinler Where borc>0";
            SqlCommand cmd55 = new SqlCommand(sql55, conn);
            SqlDataReader dr55 = cmd55.ExecuteReader();
            if (dr55.Read())
            {
                txtAlacak.Text = dr55[0].ToString();
            }

            conn.Close();
            conn.Open();
            string sql3 = "Select Sum(tutar) from tblAidat WHERE bitti=1";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              aidat1 = dr[0].ToString();
            }

            conn.Close();

            conn.Open();

            string sql4 = "Select Sum(tutar) from tblEk WHERE bitti=1";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                ek1 = dr2[0].ToString();

            }
            conn.Close();

            conn.Open();

            string sql5 = "Select Sum(tutar) from tblTahsilat";
            SqlCommand cmd2 = new SqlCommand(sql5, conn);
            SqlDataReader dr3 = cmd2.ExecuteReader();
            if (dr3.Read())
            {
                tahsilat1 = dr3[0].ToString();

            }
            conn.Close();

            conn.Open();

            string sql6 = "Select Sum(tutar) from tblGiderler";
            SqlCommand cmd3 = new SqlCommand(sql6, conn);
            SqlDataReader dr4 = cmd3.ExecuteReader();
            if (dr4.Read())
            {
                txtGider.Text = dr4[0].ToString() ;

            }
            conn.Close();

            
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

            int gider = Convert.ToInt32(txtGider.Text);
            int aidat = Convert.ToInt32(aidat1);
            int tahsilat = Convert.ToInt32(tahsilat1);
            int ek = Convert.ToInt32(ek1);
            int eski = Convert.ToInt32(txt2022.Text);
            int toplamgelir = aidat + tahsilat + ek;
            txtGelir.Text = toplamgelir.ToString();
            int gelir = Convert.ToInt32(txtGelir.Text);

            

            int toplam =  (gelir + eski) - gider;

            txtKasa.Text = toplam.ToString();
        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gidermakbuz a = new gidermakbuz();
            a.lblTarih.Text = dgvGider.CurrentRow.Cells[3].Value.ToString();
            a.lblGiderAciklama.Text = dgvGider.CurrentRow.Cells[1].Value.ToString();
            a.lblToplam.Text = dgvGider.CurrentRow.Cells[2].Value.ToString();
            a.lblTutar.Text = dgvGider.CurrentRow.Cells[2].Value.ToString();
            a.lblTutar2.Text ="# " + dgvGider.CurrentRow.Cells[2].Value.ToString() + " #";
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
    }
}
