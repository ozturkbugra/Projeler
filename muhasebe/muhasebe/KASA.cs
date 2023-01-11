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
    public partial class KASA : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public KASA()
        {
            InitializeComponent();
        }

        private void KASA_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select [Gelir Adı],[Gelir Tutarı],[Gelir Tarihi],[Gelir Açıklama] from VwGelirler";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(dt);
            dgvGelir.DataSource = dt;

            DataTable dt2 = new DataTable();
            string sql2 = "Select [Gider Adı],[Gider Sektörü],[Gider Tutarı],[Gider Tarihi],[Gider Açıklama] from VwGiderler ";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.Fill(dt2);
            dgvGider.DataSource = dt2;


            string sql3 = "Select Sum(fiyat) from tblGelirler";
            SqlCommand cmd = new SqlCommand(sql3, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblGelir.Text = dr[0].ToString();
            }

            conn.Close();

            conn.Open();

            string sql4 = "Select Sum(fiyat) from tblGiderler";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);
          
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                lblGider.Text = dr2[0].ToString();

            }
            conn.Close();

            if (lblGelir.Text == "")
            {
                lblGelir.Text = "0";
            }

            if (lblGider.Text == "")
            {
                lblGider.Text = "0";
            }

            double toplam = 0;
            toplam = Double.Parse(lblGelir.Text) - Double.Parse(lblGider.Text);
            lblKasa.Text = toplam.ToString("0.##");


            if (Double.Parse(lblKasa.Text) > 0.0)
            {
                lblKasa.ForeColor = Color.Green;
                



            }

            else if (Double.Parse(lblKasa.Text) < 0.0)
            {
                lblKasa.ForeColor = Color.Red;
               

            }


            else if (Double.Parse(lblKasa.Text) == 0.0)
            {
                lblKasa.ForeColor = Color.Black;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
