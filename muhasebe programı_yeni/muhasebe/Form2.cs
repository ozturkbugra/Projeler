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
    public partial class Form2 : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        decimal gider;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query2 = "SELECT OdemeId,OdemeAd FROM tblOdemeTuru order by OdemeAd asc";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            txtOdemeTuru.DisplayMember = "OdemeAd"; // ComboBox'ta gösterilecek sütun adı
            txtOdemeTuru.ValueMember = "OdemeId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtOdemeTuru.DataSource = table2;
            txtOdemeTuru.SelectedIndex = 0; // İlk veriyi seçili getir



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bas = dtBas.Value.Date;
            DateTime son = dtSon.Value.Date.AddDays(1).AddSeconds(-1);

            string sql2 = "Select [Açıklama],[Sektör Adı],[Tutar],[Tarih],[Kişi],[Ödeme Şekli] from ViewGiderler Where [Tarih] BETWEEN @dtBas and @dtSon and [Ödeme Şekli]='" + txtOdemeTuru.Text + "'";
            string sql3 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih BETWEEN @dtBas and @dtSon and [Ödeme Şekli]='" + txtOdemeTuru.Text + "'";

            conn.Open();
            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.SelectCommand.Parameters.AddWithValue("dtBas", bas);
            da2.SelectCommand.Parameters.AddWithValue("dtSon", son);
            da2.Fill(dt2);
            dgvGider.DataSource = dt2;


            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.AddWithValue("@dtBas", bas);
            cmd.Parameters.AddWithValue("@dtSon", son);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gider = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }

            conn.Close();

            lblGider.Text = gider.ToString() + " TL";

            if (lblGider.Text == " TL")
            {
                lblGider.Text = "0 TL";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
