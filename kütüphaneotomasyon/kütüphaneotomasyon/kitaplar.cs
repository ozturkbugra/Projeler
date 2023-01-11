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
    public partial class kitaplar : Form
    {
        uye uye = new uye();
        public kitaplar()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-T7M1F5P\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conString);

        private void kitaplar_Load(object sender, EventArgs e)
        {
           dgvkitap.DataSource=uye.veriAl("SELECT * FROM kitaplar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayfa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvkitap.DataSource = uye.veriAl("SELECT * FROM kitaplar WHERE KitapAdı LIKE '" + txtAra.Text + "%'");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update kitaplar set KitapAdı='" + txtAd.Text + "',Sayfa='" + txtSayfa.Text + "',Yazar='" + txtYazar.Text + "',Stok='" + txtStok.Text + "' where ID=" + dgvkitap.CurrentRow.Cells[0].Value.ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvkitap.DataSource = uye.veriAl("SELECT * FROM kitaplar");
        }

        private void dgvkitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvkitap.CurrentRow.Cells[1].Value.ToString();
            txtSayfa.Text = dgvkitap.CurrentRow.Cells[2].Value.ToString();
            txtYazar.Text = dgvkitap.CurrentRow.Cells[3].Value.ToString();
            txtStok.Text = dgvkitap.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kayit = "INSERT INTO kitaplar(KitapAdı, Sayfa, Yazar, Stok) values (@KitapAdı, @Sayfa, @Yazar, @Stok) ";
            SqlCommand cmd = new SqlCommand(kayit, conn);
            cmd.Parameters.AddWithValue("@KitapAdı", txtAd.Text);
            cmd.Parameters.AddWithValue("@Sayfa", txtSayfa.Text);
            cmd.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            cmd.Parameters.AddWithValue("@Stok", txtStok.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvkitap.DataSource = uye.veriAl("SELECT * FROM kitaplar");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from kitaplar where ID=" + dgvkitap.CurrentRow.Cells[0].Value.ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvkitap.DataSource = uye.veriAl("SELECT * FROM kitaplar");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
