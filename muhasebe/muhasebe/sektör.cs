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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public sektör()
        {
            InitializeComponent();
        }

        private void sektör_Load(object sender, EventArgs e)
        {
            txtSektör.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt2 = new DataTable();
            string sql2 = "Select [Gider Adı],[Gider Sektörü],[Gider Tutarı],[Gider Tarihi],[Gider Açıklama] from VwGiderler Where [Gider Tarihi] BETWEEN @dtBas and @dtSon and [Gider Sektörü]='" + txtSektör.Text + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da2.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            da2.Fill(dt2);
            dgvGider.DataSource = dt2;

            string sql3 = "Select Sum(fiyat) from tblGiderler WHERE tarih BETWEEN @dtBas and @dtSon and sektör='" + txtSektör.Text + "'";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.AddWithValue("@dtBas", dtBas.Value);
            cmd.Parameters.AddWithValue("@dtSon", dtSon.Value);
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblGider.Text = dr[0].ToString() + " TL";
            }

            conn.Close();


            if (lblGider.Text == " TL")
            {
                lblGider.Text = "0 TL";
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
    }
}
