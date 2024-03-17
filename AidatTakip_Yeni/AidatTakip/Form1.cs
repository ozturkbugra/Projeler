using System.Data;
using System.Data.SqlClient;

namespace AidatTakip
{
    public partial class Form1 : Form
    {
        public static string c = listele.conStr;
        SqlConnection conn1 = new SqlConnection(c);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
       
            try
            {
                conn1.Open();
                progressBar1.Value = 100;
                lblVeri.ForeColor = Color.Green;
                lblVeri.Text = "Veri tabanýna baðlantý baþarýlý";
            }
            catch (Exception ex)
            {
                progressBar1.Value = 10;
                lblVeri.ForeColor = Color.Red;
                lblVeri.Text = "Veri tabanýna baðlantý baþarýsýz";
            }
            finally
            {
                conn1.Close();
            }


        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblVeri.Text == "Veri tabanýna baðlantý baþarýsýz")
            {
                MessageBox.Show("Veri tabanýna baðlantý olmadýðý için giriþ baþarýsýz");
            }
            else
            {
                
                string kullanici = textBox1.Text;
                string parola = textBox2.Text;
                SqlCommand cmd = new SqlCommand();
                conn1.Open();
                cmd.Connection = conn1;
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
                    MessageBox.Show("Hatalý giriþ");
                }
                conn1.Close();
            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                string kullanici = textBox1.Text;
                string parola = textBox2.Text;
                SqlCommand cmd = new SqlCommand();
                conn1.Open();
                cmd.Connection = conn1;
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
                    MessageBox.Show("Hatalý giriþ");
                }
                conn1.Close();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}