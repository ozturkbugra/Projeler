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
    public partial class borclar : Form
    {
        decimal o;
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        public borclar()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void borclar_Load(object sender, EventArgs e)
        {
            dgvBorc.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
            string query = "SELECT CariId,CariAd FROM tblCariler order by CariAd asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtCari.DisplayMember = "CariAd"; // ComboBox'ta gösterilecek sütun adı
            txtCari.ValueMember = "CariId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtCari.DataSource = table;
            txtCari.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
            conn.Open();
            string sql = "Insert Into tblHareketler (CariId,Tutar,Tarih,Aciklama) values (@CariId,@Tutar,@Tarih,@Aciklama)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CariId", txtCari.SelectedValue);
            cmd.Parameters.AddWithValue("@Tutar", Decimal.Parse(txtFiyat.Text));
            cmd.Parameters.AddWithValue("@Tarih", tarih);
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvBorc.DataSource = b.veriAl("Select HareketId,[Cari Adı],Tutar,Tarih,[Açıklama] from ViewBorclar where [Cari Adı] = '" + txtCari.Text + "' order by HareketId desc");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(Tutar) from ViewBorclar where [Cari Adı] = @p1", conn);
            cmd2.Parameters.AddWithValue("@p1", txtCari.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                o = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtCari.Text + " carisinin size  " + o.ToString() + " ₺ borcu vardır.";
            }
            else if (o == 0)
            {
                lblAd.Text = txtCari.Text + " carisinin bakiyesi  " + o.ToString() + " ₺'dir";
            }
            else
            {
                lblAd.Text = txtCari.Text + " carisinin sizden  " + Math.Abs(o).ToString() + " ₺ alacağı vardır.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBorc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvBorc_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void txtTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
            conn.Open();
            string sql = "Insert Into tblHareketler (CariId,Tutar,Tarih,Aciklama) values (@CariId,@Tutar,@Tarih,@Aciklama)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CariId", txtCari.SelectedValue);
            cmd.Parameters.AddWithValue("@Tutar", Decimal.Parse("-" + txtFiyat.Text));
            cmd.Parameters.AddWithValue("@Tarih", tarih);
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvBorc.DataSource = b.veriAl("Select HareketId,[Cari Adı],Tutar,Tarih,[Açıklama] from ViewBorclar where [Cari Adı] = '" + txtCari.Text + "' order by HareketId desc");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(Tutar) from ViewBorclar where [Cari Adı] = @p1", conn);
            cmd2.Parameters.AddWithValue("@p1", txtCari.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                o = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtCari.Text + " carisinin size  " + o.ToString() + " ₺ borcu vardır.";
            }
            else if (o == 0)
            {
                lblAd.Text = txtCari.Text + " carisinin bakiyesi  " + o.ToString() + " ₺'dir";
            }
            else
            {
                lblAd.Text = txtCari.Text + " carisinin sizden  " + Math.Abs(o).ToString() + " ₺ alacağı vardır.";
            }

        }

        private void txtCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("Select HareketId,[Cari Adı],Tutar,Tarih,[Açıklama] from ViewBorclar where [Cari Adı] = '" + txtCari.Text + "' order by HareketId desc");
            dgvBorc.Columns["HareketId"].Visible = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select sum(Tutar) from ViewBorclar where [Cari Adı] = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", txtCari.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                o = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtCari.Text + " carisinin size  " + o.ToString() + " ₺ borcu vardır.";
            }
            else if (o == 0)
            {
                lblAd.Text = txtCari.Text + " carisinin bakiyesi  " + o.ToString() + " ₺'dir";
            }
            else
            {
              
                lblAd.Text = txtCari.Text + " carisinin sizden  " + Math.Abs(o).ToString() + " ₺ alacağı vardır.";
            }
        }
    }
}
