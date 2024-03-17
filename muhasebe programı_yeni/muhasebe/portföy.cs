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
    public partial class portföy : Form
    {
        decimal o;
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        public portföy()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void portföy_Load(object sender, EventArgs e)
        {
            dgvBorc.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);

            conn.Open();
            string query = "SELECT Id,PAd FROM tblPortfoyKart order by PAd asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtPAd.DisplayMember = "PAd"; // ComboBox'ta gösterilecek sütun adı
            txtPAd.ValueMember = "Id"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtPAd.DataSource = table;
            txtPAd.SelectedIndex = 0;

            string query2 = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            txtAdSoyad.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtAdSoyad.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtAdSoyad.DataSource = table2;
            txtAdSoyad.SelectedIndex = 0;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("Select [PHarketId],[PAd] AS 'Ad',[PTur],[PMiktar] AS 'Miktar',[PTarih] AS 'Tarih',[PAciklama] AS 'Açıklama',[AdSoyad] AS 'Kişi' from ViewPortfoy where [PAd] = '" + txtPAd.Text + "' and [AdSoyad] ='" + txtAdSoyad.Text + "' order by [PTarih] desc");
            dgvBorc.Columns["PHarketId"].Visible = false;
            dgvBorc.Columns["PTur"].Visible = false;
            conn.Close();
            conn.Open();
            string sql = "Select * from tblPortfoyKart where [PAd] = '" + txtPAd.Text + "'"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl.Text = "(" + dr["PTur"].ToString() + ")";
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(PMiktar) from ViewPortfoy where PAd = @p1 and AdSoyad = @p2", conn);
            cmd2.Parameters.AddWithValue("@p1", txtPAd.Text);
            cmd2.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            SqlDataReader dr5 = cmd2.ExecuteReader();
            if (dr5.Read())
            {
                o = dr5[0] != DBNull.Value ? Convert.ToDecimal(dr5[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else if (o == 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }


        }

        private void txtAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("Select [PHarketId],[PAd] AS 'Ad',[PTur],[PMiktar] AS 'Miktar',[PTarih] AS 'Tarih',[PAciklama] AS 'Açıklama',[AdSoyad] AS 'Kişi' from ViewPortfoy where [PAd] = '" + txtPAd.Text + "' and [AdSoyad] ='" + txtAdSoyad.Text + "' order by [PTarih] desc");
            dgvBorc.Columns["PHarketId"].Visible = false;
            dgvBorc.Columns["PTur"].Visible = false;
            conn.Close();
            conn.Open();
            string sql = "Select * from tblPortfoyKart where [PAd] = '" + txtPAd.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl.Text = "(" + dr["PTur"].ToString() + ")";
            }
            else
            {
                lbl.Text = "";
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(PMiktar) from ViewPortfoy where PAd = @p1 and AdSoyad = @p2", conn);
            cmd2.Parameters.AddWithValue("@p1", txtPAd.Text);
            cmd2.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            SqlDataReader dr5 = cmd2.ExecuteReader();
            if (dr5.Read())
            {
                o = dr5[0] != DBNull.Value ? Convert.ToDecimal(dr5[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else if (o == 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
            conn.Open();
            string sql = "Insert Into tblPortfoy (PAd,PMiktar,PTarih,PAy,PYil,PAciklama,PKisi) values (@PAd,@PMiktar,@PTarih,@PAy,@PYil,@PAciklama,@PKisi)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Pad", txtPAd.SelectedValue);
            cmd.Parameters.AddWithValue("@PMiktar", Decimal.Parse(txtFiyat.Text));
            cmd.Parameters.AddWithValue("@PTarih", tarih);
            cmd.Parameters.AddWithValue("@PAy", tarih.ToString("MM"));
            cmd.Parameters.AddWithValue("@PYil", tarih.ToString("yyyy"));
            cmd.Parameters.AddWithValue("@PAciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@PKisi", txtAdSoyad.SelectedValue);
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvBorc.DataSource = b.veriAl("Select [PHarketId],[PAd] AS 'Ad',[PTur],[PMiktar] AS 'Miktar',[PTarih] AS 'Tarih',[PAciklama] AS 'Açıklama',[AdSoyad] AS 'Kişi' from ViewPortfoy where [PAd] = '" + txtPAd.Text + "' and [AdSoyad] ='" + txtAdSoyad.Text + "' order by [PTarih] desc");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(PMiktar) from ViewPortfoy where PAd = @p1 and AdSoyad = @p2", conn);
            cmd2.Parameters.AddWithValue("@p1", txtPAd.Text);
            cmd2.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                o = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else if (o == 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
            conn.Open();
            string sql = "Insert Into tblPortfoy (PAd,PMiktar,PTarih,PAy,PYil,PAciklama,PKisi) values (@PAd,@PMiktar,@PTarih,@PAy,@PYil,@PAciklama,@PKisi)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Pad", txtPAd.SelectedValue);
            cmd.Parameters.AddWithValue("@PMiktar", Decimal.Parse("-" + txtFiyat.Text));
            cmd.Parameters.AddWithValue("@PTarih", tarih);
            cmd.Parameters.AddWithValue("@PAy", tarih.ToString("MM"));
            cmd.Parameters.AddWithValue("@PYil", tarih.ToString("yyyy"));
            cmd.Parameters.AddWithValue("@PAciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@PKisi", txtAdSoyad.SelectedValue);
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvBorc.DataSource = b.veriAl("Select [PHarketId],[PAd] AS 'Ad',[PTur],[PMiktar] AS 'Miktar',[PTarih] AS 'Tarih',[PAciklama] AS 'Açıklama',[AdSoyad] AS 'Kişi' from ViewPortfoy where [PAd] = '" + txtPAd.Text + "' and [AdSoyad] ='" + txtAdSoyad.Text + "' order by [PTarih] desc");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(PMiktar) from ViewPortfoy where PAd = @p1 and AdSoyad = @p2", conn);
            cmd2.Parameters.AddWithValue("@p1", txtPAd.Text);
            cmd2.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                o = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();
            if (o > 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else if (o == 0)
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
            else
            {
                lblAd.Text = txtPAd.Text + " Portföyünden " + o.ToString() + " " + lbl.Text + " vardır";
            }
        }
    }
}
