using System.Data.SqlClient;

namespace muhasebe
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            string kullanici = textBox1.Text;
            string parola = textBox2.Text;
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection= conn;
            cmd.CommandText = "Select * from tblAdmin where kullaniciAdi='"+textBox1.Text+"'And parola='"+textBox2.Text+"'";
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                giris a = new giris();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatal� giri�");
            }
            conn.Close();
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
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
                    giris a = new giris();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatal� giri�");
                }
                conn.Close();
            }
        }
    }
}