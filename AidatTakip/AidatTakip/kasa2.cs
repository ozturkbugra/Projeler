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
    public partial class kasa2 : Form
    {
        
        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public kasa2()
        {
            InitializeComponent();
        }

        private void kasa2_Load(object sender, EventArgs e)
        {
            dtBas.Format = DateTimePickerFormat.Custom;
            dtBas.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtSon.Format = DateTimePickerFormat.Custom;
            dtSon.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            if (txtTahsilat.Text == "")
            {
                txtTahsilat.Text = "0";
            }
            if (txtGider.Text == "")
            {
                txtGider.Text = "0";
            }
            if (txtAidat.Text == "")
            {
                txtAidat.Text = "0";
            }
            if (txtEk.Text == "")
            {
                txtEk.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            DataTable dt = new DataTable();
            string sql = "Select [Daire No],[Aidat Ayı],[Aidat Tutarı],[Makbuz Tarihi] from VwMakbuz WHERE [Makbuz Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@dtBas", dtBas.Value);
            da.SelectCommand.Parameters.AddWithValue("@dtSon", dtSon.Value);
            da.Fill(dt);
            dgvAidat.DataSource = dt;
            conn.Close();

            conn.Open();
            DataTable dt2 = new DataTable();
            string sql2 = "Select [Daire No],[Ek Ayı],[Ek Tutarı],[Makbuz Tarihi] from VwMakbuz WHERE [Makbuz Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.SelectCommand.Parameters.AddWithValue("@dtBas", dtBas.Value );
            da2.SelectCommand.Parameters.AddWithValue("@dtSon", dtSon.Value);
            da2.Fill(dt2);
            dgvEk.DataSource = dt2;
            conn.Close();

            conn.Open();
            DataTable dt3 = new DataTable();
            string sql3 = "Select * from VwTahsilat WHERE [Tahsilat Tarih] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            da3.SelectCommand.Parameters.AddWithValue("@dtBas", dtBas.Value);
            da3.SelectCommand.Parameters.AddWithValue("@dtSon", dtSon.Value);
            da3.Fill(dt3);
            dgvTahsilat.DataSource = dt3;
            conn.Close();

            conn.Open();
            DataTable dt4 = new DataTable();
            string sql4 = "Select * from VwGiderler WHERE [Gider Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
            da4.SelectCommand.Parameters.AddWithValue("@dtBas", dtBas.Value);
            da4.SelectCommand.Parameters.AddWithValue("@dtSon", dtSon.Value);
            da4.Fill(dt4);
            dgvGider.DataSource = dt4;
            conn.Close();

            conn.Open();
            string sql5 = "Select Sum([Aidat Tutarı]) from VwMakbuz WHERE [Makbuz Tarihi] BETWEEN @dtBas and @dtSon";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            cmd5.Parameters.AddWithValue("@dtBas", dtBas.Value);
            cmd5.Parameters.AddWithValue("@dtSon", dtSon.Value);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                txtAidat.Text = dr5[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql6 = "Select Sum([Gider Tutarı]) from VwGiderler WHERE [Gider Tarihi] BETWEEN @dtBas and @dtSon";
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            cmd6.Parameters.AddWithValue("@dtBas", dtBas.Value);
            cmd6.Parameters.AddWithValue("@dtSon", dtSon.Value);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                txtGider.Text = dr6[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql7 = "Select Sum([Ek Tutarı]) from VwMakbuz WHERE [Makbuz Tarihi] BETWEEN @dtBas and @dtSon";
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            cmd7.Parameters.AddWithValue("@dtBas", dtBas.Value);
            cmd7.Parameters.AddWithValue("@dtSon", dtSon.Value);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                txtEk.Text = dr7[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql8 = "Select Sum([Tahsilat Tutar]) from VwTahsilat WHERE [Tahsilat Tarih] BETWEEN @dtBas and @dtSon";
            SqlCommand cmd8 = new SqlCommand(sql8, conn);
            cmd8.Parameters.AddWithValue("@dtBas", dtBas.Value);
            cmd8.Parameters.AddWithValue("@dtSon", dtSon.Value);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                txtTahsilat.Text = dr8[0].ToString();
            }
            
            conn.Close();

            if (txtTahsilat.Text == "")
            {
                txtTahsilat.Text = "0";
            }
            if (txtGider.Text == "")
            {
                txtGider.Text = "0";
            }
            if (txtAidat.Text == "")
            {
                txtAidat.Text = "0";
            }
            if (txtEk.Text == "")
            {
                txtEk.Text = "0";
            }

            int gider = Convert.ToInt32(txtGider.Text);
            int aidat = Convert.ToInt32(txtAidat.Text);
            int tahsilat = Convert.ToInt32(txtTahsilat.Text);
            int ek = Convert.ToInt32(txtEk.Text);
            int toplamgelir = aidat + tahsilat + ek;
            txtGelir.Text = toplamgelir.ToString();
            int gelir = Convert.ToInt32(txtGelir.Text);



            int toplam = gelir - gider;

            txtKasa.Text = toplam.ToString();
        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void dgvAidat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTahsilat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tahsilatmakbuz a = new tahsilatmakbuz();
            a.lblTahsilatNo.Text = dgvTahsilat.CurrentRow.Cells[0].Value.ToString();
            a.lblTahsilatAciklama.Text = dgvTahsilat.CurrentRow.Cells[1].Value.ToString();
            a.lblToplam.Text = dgvTahsilat.CurrentRow.Cells[2].Value.ToString();
            a.lblTutar.Text = dgvTahsilat.CurrentRow.Cells[2].Value.ToString();
            a.lblTarih.Text = dgvTahsilat.CurrentRow.Cells[3].Value.ToString();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
