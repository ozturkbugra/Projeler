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
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        string ay = DateTime.Now.ToString("MMMM");
        string yıl = DateTime.Now.ToString("yyyy");
        public kasa2()
        {
            InitializeComponent();
        }

        private void kasa2_Load(object sender, EventArgs e)
        {

            txtAy.Text = ay;
            txtYıl.Text = yıl;
            
            txtAy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAy.KeyPress += (sender, e) => { e.Handled = true; };

            txtYıl.DropDownStyle = ComboBoxStyle.DropDownList;
            txtYıl.KeyPress += (sender, e) => { e.Handled = true; };

            string query = "SELECT ID, YIL FROM tblYil"; // Veri tabanından veri çekme sorgusu
            string query2 = "SELECT ID, AY FROM tblAylar";
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            adapter.Fill(table);

            txtYıl.DisplayMember = "YIL"; // ComboBox'ta gösterilecek sütun adı
            txtYıl.ValueMember = "YIL"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı

            txtYıl.DataSource = table;

            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();

            adapter2.Fill(table2);

            txtAy.DisplayMember = "AY"; // ComboBox'ta gösterilecek sütun adı
            txtAy.ValueMember = "AY"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı

            txtAy.DataSource = table2;


            conn.Close();


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

            txtAy.Text = ay;
            txtYıl.Text = yıl;
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
            da2.SelectCommand.Parameters.AddWithValue("@dtBas", dtBas.Value);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string sql = "Select [Daire No],[Aidat Ayı],[Aidat Tutarı],[Makbuz Tarihi],[ay],[yıl] from VwMakbuz WHERE yıl=@yıl and ay=@ay ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@yıl", txtYıl.Text);
            da.SelectCommand.Parameters.AddWithValue("@ay", txtAy.Text);
            da.Fill(dt);
            dgvAidat.DataSource = dt;
            dgvAidat.Columns[4].Visible = false;
            dgvAidat.Columns[5].Visible = false;
            conn.Close();

            conn.Open();
            DataTable dt2 = new DataTable();
            string sql2 = "Select [Daire No],[Ek Ayı],[Ek Tutarı],[Makbuz Tarihi],[ay],[yıl] from VwMakbuz WHERE yıl=@yıl and ay=@ay";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.SelectCommand.Parameters.AddWithValue("@yıl", txtYıl.Text);
            da2.SelectCommand.Parameters.AddWithValue("@ay", txtAy.Text);
            da2.Fill(dt2);
            dgvEk.DataSource = dt2;
            dgvEk.Columns[4].Visible = false;
            dgvEk.Columns[5].Visible = false;
            conn.Close();

            conn.Open();
            DataTable dt3 = new DataTable();
            string sql3 = "Select * from VwTahsilat WHERE yıl=@yıl and ay=@ay";
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            da3.SelectCommand.Parameters.AddWithValue("@yıl", txtYıl.Text);
            da3.SelectCommand.Parameters.AddWithValue("@ay", txtAy.Text);
            da3.Fill(dt3);
            dgvTahsilat.DataSource = dt3;
            dgvTahsilat.Columns[4].Visible = false;
            dgvTahsilat.Columns[5].Visible = false;
            conn.Close();

            conn.Open();
            DataTable dt4 = new DataTable();
            string sql4 = "Select * from VwGiderler  WHERE yıl=@yıl and ay=@ay";
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
            da4.SelectCommand.Parameters.AddWithValue("@yıl", txtYıl.Text);
            da4.SelectCommand.Parameters.AddWithValue("@ay", txtAy.Text);
            da4.Fill(dt4);
            dgvGider.DataSource = dt4;
            dgvGider.Columns[4].Visible = false;
            dgvGider.Columns[5].Visible = false;
            conn.Close();

            conn.Open();
            string sql5 = "Select Sum([Aidat Tutarı]) from VwMakbuz  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            cmd5.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd5.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                txtAidat.Text = dr5[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql6 = "Select Sum([Gider Tutarı]) from VwGiderler  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            cmd6.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd6.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                txtGider.Text = dr6[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql7 = "Select Sum([Ek Tutarı]) from VwMakbuz  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            cmd7.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd7.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                txtEk.Text = dr7[0].ToString();
            }

            conn.Close();

            conn.Open();
            string sql8 = "Select Sum([Tahsilat Tutar]) from VwTahsilat  WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd8 = new SqlCommand(sql8, conn);
            cmd8.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd8.Parameters.AddWithValue("@ay", txtAy.Text);
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
    }
}
