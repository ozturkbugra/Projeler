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
    public partial class sektör : Form
    {
        decimal gider;
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        public sektör()
        {
            InitializeComponent();
        }

        private void sektör_Load(object sender, EventArgs e)
        {


            txtKisi.DropDownStyle = ComboBoxStyle.DropDownList;
            txtKisi.KeyPress += (sender, e) => { e.Handled = true; };

            string query2 = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            txtKisi.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi.DataSource = table2;

            string query = "SELECT SektorId,SektorAdi FROM tblSektor order by SektorAdi asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtSektör.DisplayMember = "SektorAdi"; // ComboBox'ta gösterilecek sütun adı
            txtSektör.ValueMember = "SektorId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtSektör.DataSource = table;

            /*dtBas.Format = DateTimePickerFormat.Custom;
            dtBas.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtSon.Format = DateTimePickerFormat.Custom;
            dtSon.CustomFormat = "dd/MM/yyyy HH:mm:ss";*/

            txtSektör.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bas = dtBas.Value.Date;
            DateTime son = dtSon.Value.Date.AddDays(1).AddSeconds(-1);

            if (txtAktif.Checked)
            {
               
                string sql5 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih BETWEEN @dtBas and @dtSon and [Sektör Adı]='" + txtSektör.Text + "' and [Kişi]='" + txtKisi.Text + "'";
                string ilk6 = "Select TOP(1) [Sektör Adı],[Ödeme Şekli],[GiderId],[Açıklama],[Tutar],[Tarih],[Ay],[Yil] FROM ViewGiderler where [Sektör Adı]='" + txtSektör.Text + "' and [Tarih] BETWEEN @dtBas and @dtSon and [Kişi] ='" + txtKisi.Text + "' order by Tarih desc";
                string son7 = "Select TOP(1) [Sektör Adı],[Ödeme Şekli],[GiderId],[Açıklama],[Tutar],[Tarih],[Ay],[Yil] FROM ViewGiderler where [Sektör Adı]='" + txtSektör.Text + "' and [Tarih] BETWEEN @dtBas and @dtSon and [Kişi] ='" + txtKisi.Text + "' order by Tarih asc";
                conn.Open();
                DataTable dt10 = new DataTable();
                string sql4 = "Select [Açıklama],[Sektör Adı],[Tutar],[Tarih],[Kişi] from ViewGiderler Where [Tarih] BETWEEN @dtBas and @dtSon and [Sektör Adı]='" + txtSektör.Text + "' and [Kişi]='" + txtKisi.Text + "'";
                SqlDataAdapter da10 = new SqlDataAdapter(sql4, conn);
                da10.SelectCommand.Parameters.AddWithValue("dtBas", bas);
                da10.SelectCommand.Parameters.AddWithValue("dtSon", son);
                da10.Fill(dt10);
                dgvGider.DataSource = dt10;


                SqlCommand cmd = new SqlCommand(sql5, conn);
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

                conn.Open();

                SqlCommand cmd7 = new SqlCommand(ilk6, conn);
                cmd7.Parameters.AddWithValue("@dtBas", bas);
                cmd7.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr7 = cmd7.ExecuteReader();
                if (dr7.Read())
                {
                    txtSon.Text = dr7[4].ToString();
                }
                else
                {
                    txtSon.Text = "0";

                }
                conn.Close();
                conn.Open();
                SqlCommand cmd8 = new SqlCommand(son7, conn);
                cmd8.Parameters.AddWithValue("@dtBas", bas);
                cmd8.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr8 = cmd8.ExecuteReader();

                if (dr8.Read())
                {
                    txtBas.Text = dr8[4].ToString();
                }
                else
                {
                    txtBas.Text = "0";

                }
                conn.Close();
            }
            else
            {



                string sql2 = "Select [Açıklama],[Sektör Adı],[Tutar],[Tarih],[Kişi] from ViewGiderler Where [Tarih] BETWEEN @dtBas and @dtSon and [Sektör Adı]='" + txtSektör.Text + "'";
                string sql3 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih BETWEEN @dtBas and @dtSon and [Sektör Adı]='" + txtSektör.Text + "'";
                string ilk = "Select TOP(1) [Sektör Adı],[Ödeme Şekli],[GiderId],[Açıklama],[Tutar],[Tarih],[Ay],[Yil] FROM ViewGiderler where [Sektör Adı]='" + txtSektör.Text + "' and [Tarih] BETWEEN @dtBas and @dtSon order by Tarih desc";
                string son2 = "Select TOP(1) [Sektör Adı],[Ödeme Şekli],[GiderId],[Açıklama],[Tutar],[Tarih],[Ay],[Yil] FROM ViewGiderler where [Sektör Adı]='" + txtSektör.Text + "' and [Tarih] BETWEEN @dtBas and @dtSon order by Tarih asc";
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

                conn.Open();

                SqlCommand cmd7 = new SqlCommand(ilk, conn);
                cmd7.Parameters.AddWithValue("@dtBas", bas);
                cmd7.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr7 = cmd7.ExecuteReader();
                if (dr7.Read())
                {
                    txtSon.Text = dr7[4].ToString();
                }
                else
                {
                    txtSon.Text = "0";

                }
                conn.Close();
                conn.Open();
                SqlCommand cmd8 = new SqlCommand(son2, conn);
                cmd8.Parameters.AddWithValue("@dtBas", bas);
                cmd8.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr8 = cmd8.ExecuteReader();

                if (dr8.Read())
                {
                    txtBas.Text = dr8[4].ToString();
                }
                else
                {
                    txtBas.Text = "0";

                }
                conn.Close();
            }
        }

        private void txtSektör_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGider_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvGider_CellClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void dgvGider_MouseClick(object sender, MouseEventArgs e)
        {



        }

        int son = 0;
        private void dgvGider_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            son = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtBas.Text);
            double b = Double.Parse(txtSon.Text);

            double sonuc2 = b - a;

            double sonuc = (sonuc2 / a) * 100;

            lblEnflasyon.Text = sonuc.ToString("0.##");
        }

        private void txtBas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void txtSon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gelirgidernew.PDF_Disa_Aktar(dgvGider);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAktif_CheckedChanged(object sender, EventArgs e)
        {
            txtKisi.DropDownStyle = ComboBoxStyle.DropDownList;
            txtKisi.KeyPress += (sender, e) => { e.Handled = false; };
        }
    }
}
