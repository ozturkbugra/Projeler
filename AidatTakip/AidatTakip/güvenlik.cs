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
    public partial class güvenlik : Form
    {
        public güvenlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            string kullanici = textBox1.Text;
            string parola = textBox2.Text;
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from tblAdmin where kullaniciAdi='" + textBox1.Text + "'And parola='" + textBox2.Text + "'";
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                donemekle a = new donemekle();
                a.txtAy.Enabled = true;
                a.txtYıl.Enabled = true;
                this.Hide();
                a.ShowDialog();
                a.Dispose();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
            conn.Close();
        }
    }
}
