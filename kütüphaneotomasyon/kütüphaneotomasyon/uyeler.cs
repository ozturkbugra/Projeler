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

namespace kütüphaneotomasyon
{
    public partial class uyeler : Form
    {
        uye uye = new uye();
        public uyeler()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-T7M1F5P\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conString);
        private void uyeler_Load(object sender, EventArgs e)
        {
            dgvuye.DataSource=uye.veriAl("Select * From uyeler");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            char[] yazilanlar = txtCeza.Text.ToCharArray();
            foreach (char c in yazilanlar)
            {
                if (!(Char.IsNumber(c)))
                {
                    txtCeza.Text = txtCeza.Text.Remove(txtCeza.Text.IndexOf(c));
                    lbldurum.Text = " Hatalı ceza puanı girişi";
                    lbldurum.ForeColor = Color.Red;
                    lbldurum.Visible = true;
                }
                else
                    lbldurum.Visible = false;
            }
            txtCeza.Select(txtCeza.Text.Length, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kayit = "INSERT INTO uyeler(Ad, Soyad, Ceza_puanı) values (@Ad, @Soyad, @Ceza_puanı) ";
            SqlCommand cmd  = new SqlCommand(kayit, conn);
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Ceza_puanı", txtCeza.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvuye.DataSource=uye.veriAl("SELECT * FROM uyeler");
        }

        private void dgvuye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvuye.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvuye.CurrentRow.Cells[2].Value.ToString();
            txtCeza.Text = dgvuye.CurrentRow.Cells[3].Value.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from uyeler where ID=" + dgvuye.CurrentRow.Cells[0].Value.ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvuye.DataSource = uye.veriAl("SELECT * FROM uyeler");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update uyeler set Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Ceza_puanı='" + txtCeza.Text + "' where ID=" + dgvuye.CurrentRow.Cells[0].Value.ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvuye.DataSource = uye.veriAl("SELECT * FROM uyeler");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvuye.DataSource = uye.veriAl("SELECT * FROM uyeler WHERE Ad LIKE '" + txtAra.Text + "%'");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
