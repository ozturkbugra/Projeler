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
    public partial class TureGoreGiderler : Form
    {
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        listele b = new listele();
        public TureGoreGiderler()
        {
            InitializeComponent();
        }

        private void TureGoreGiderler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bas = dtBas.Value.Date;  // Sadece tarih kısmını al
            DateTime son = dtSon.Value.Date.AddDays(1).AddTicks(-1);  // Günün sonu (23:59:59) olarak ayarla



            conn.Open();
            DataTable dt = new DataTable();
            string sql = "Select * from tblGiderler where tur=@p1 and Tarih between @p2 and @p3 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@p1", txtTur.Text);
            da.SelectCommand.Parameters.AddWithValue("@p2", bas);
            da.SelectCommand.Parameters.AddWithValue("@p3", son);
            da.Fill(dt);
            dgvGider.DataSource = dt;
            conn.Close();
            dgvGider.Columns[4].Visible = false;
            dgvGider.Columns[5].Visible = false;
            dgvGider.Columns[6].Visible = false;

            conn.Open();
            string sql2 = "select sum(tutar) from tblGiderler where tur=@p1 and Tarih between @p2 and @p3";
            SqlCommand cmd = new SqlCommand(sql2, conn);
            cmd.Parameters.AddWithValue("@p1", txtTur.Text);
            cmd.Parameters.AddWithValue("@p2", bas);
            cmd.Parameters.AddWithValue("@p3", son);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblFiyat.Text = dr[0].ToString() + " ₺";
            }
            conn.Close();

            conn.Open();
            string sql1 = "select CEILING (avg(tutar)) from tblGiderler where tur=@p1 and Tarih between @p2 and @p3";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@p1", txtTur.Text);
            cmd1.Parameters.AddWithValue("@p2", bas);
            cmd1.Parameters.AddWithValue("@p3", son);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                lblortalama.Text = dr1[0].ToString() + " ₺";
            }
            conn.Close();


        }
    }
}
