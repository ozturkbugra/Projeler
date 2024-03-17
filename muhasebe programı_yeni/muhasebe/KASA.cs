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
        baglan b = new baglan();
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);

        decimal gider;
        decimal gelir;
        decimal gelir2;
        decimal gider2;

        public KASA()
        {
            InitializeComponent();
        }

        private void KASA_Load(object sender, EventArgs e)
        {
            string query = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtKisi.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi.DataSource = table;
            txtKisi.SelectedIndex = 0;

            dgvGelir.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
            dgvGider.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
            DateTime tarih = DateTime.Now;
            DataTable dt = new DataTable();

            // Parametreli sorgu kullanımı
            string sql = "SELECT [Kişi], Tutar, Tarih, [Açıklama] FROM ViewGelirler WHERE Tarih <= @tarih";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            // Parametre eklemek
            da.SelectCommand.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            da.Fill(dt);
            conn.Close();

            dgvGelir.DataSource = dt;

            DataTable dt2 = new DataTable();

            // Parametreli sorgu kullanımı
            string sql2 = "SELECT [Kişi],[Sektör Adı], Tutar, Tarih, [Açıklama] FROM ViewGiderler WHERE Tarih <= @tarih";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);

            // Parametre eklemek
            da2.SelectCommand.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            da2.Fill(dt2);
            conn.Close();

            dgvGider.DataSource = dt2;

            //Toplama işlemleri 
            conn.Open();
            string sql3 = "Select Sum(Tutar) from tblGelirler WHERE Tarih <= @tarih";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gelir = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }

            conn.Close();

            conn.Open();

            string sql4 = "Select Sum(Tutar) from tblGiderler WHERE Tarih <= @tarih";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);
            cmd1.Parameters.AddWithValue("@tarih", tarih);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                gider = dr2[0] != DBNull.Value ? Convert.ToDecimal(dr2[0]) : 0;

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

            lblGelir.Text = gelir.ToString();
            lblGider.Text = gider.ToString();

            decimal toplam = 0;
            toplam = gelir - gider;
            lblKasa.Text = toplam.ToString();


            if (Convert.ToDecimal(lblKasa.Text) > 0)
            {
                lblKasa.ForeColor = Color.Green;

            }

            else if (Convert.ToDecimal(lblKasa.Text) < 0)
            {
                lblKasa.ForeColor = Color.Red;


            }


            else if (Convert.ToDecimal(lblKasa.Text) == 0)
            {
                lblKasa.ForeColor = Color.Black;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            DateTime tarih = DateTime.Now;
            DataTable dt = new DataTable();

            // Parametreli sorgu kullanımı
            string sql = "SELECT [Kişi], Tutar, Tarih, [Açıklama] FROM ViewGelirler WHERE Tarih <= @tarih and [Kişi] ='" + txtKisi.Text +"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            // Parametre eklemek
            da.SelectCommand.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            da.Fill(dt);
            conn.Close();

            dgvGelir2.DataSource = dt;

            DataTable dt2 = new DataTable();

            // Parametreli sorgu kullanımı
            string sql2 = "SELECT [Kişi],[Sektör Adı], Tutar, Tarih, [Açıklama] FROM ViewGiderler WHERE Tarih <= @tarih and [Kişi] ='" + txtKisi.Text +"'";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);

            // Parametre eklemek
            da2.SelectCommand.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            da2.Fill(dt2);
            conn.Close();

            dgvGider2.DataSource = dt2;

            //Toplama işlemleri 
            conn.Open();
            string sql3 = "Select Sum(Tutar) from ViewGelirler WHERE Tarih <= @tarih and [Kişi] = '" + txtKisi.Text + "'";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gelir2 = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
               
            }

            conn.Close();

            conn.Open();

            string sql4 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih <= @tarih and [Kişi] = '" + txtKisi.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);
            cmd1.Parameters.AddWithValue("@tarih", tarih);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
              
                gider2 = dr2[0] != DBNull.Value ? Convert.ToDecimal(dr2[0]) : 0;

            }
            conn.Close();

            if (lblGelir2.Text == "")
            {
                lblGelir2.Text = "0";
            }

            if (lblGider2.Text == "")
            {
                lblGider2.Text = "0";
            }

            lblGelir2.Text = gelir2.ToString();
            lblGider2.Text = gider2.ToString();

            decimal toplam2 = 0;
            toplam2 = gelir2 - gider2;
            lblKasa2.Text = toplam2.ToString();


            if (Convert.ToDecimal(lblKasa2.Text) > 0)
            {
                lblKasa2.ForeColor = Color.Green;

            }

            else if (Convert.ToDecimal(lblKasa2.Text) < 0)
            {
                lblKasa2.ForeColor = Color.Red;


            }


            else if (Convert.ToDecimal(lblKasa2.Text) == 0)
            {
                lblKasa2.ForeColor = Color.Black;
            }
        }
    }
}
