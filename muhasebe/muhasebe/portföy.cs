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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public portföy()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.veriAl("SELECT * FROM VwDoviz");
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPortföy.Text == "")
            {
                MessageBox.Show("Hatalı işlem");
            }
            else if (rdEmtia.Checked)
            {
                conn.Open();
                string kayit = "INSERT INTO tblEmtia(miktar, tarih) values (@miktar, @tarih) ";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.DataSource = b.veriAl("SELECT ID,miktar,tarih FROM tblEmtia");
                MessageBox.Show(txtPortföy.Text + " başarıyla eklendi");
            }
            else if (rdHisse.Checked)
            {
                conn.Open();
                string kayit = "INSERT INTO tblHisse(miktar, tarih) values (@miktar, @tarih) ";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.DataSource = b.veriAl("SELECT ID,miktar,tarih FROM tblHisse");
                MessageBox.Show(txtPortföy.Text + " başarıyla eklendi");
            }
            else if (rdDoviz.Checked)
            {
                conn.Open();
                string kayit = "INSERT INTO tblDoviz(miktar, tarih) values (@miktar, @tarih) ";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.DataSource = b.veriAl("SELECT ID,miktar,tarih FROM tblDoviz");
                MessageBox.Show(txtPortföy.Text + " başarıyla eklendi");
            }
            else
            {
                MessageBox.Show("Hatalı İşlem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hatalı işlem");
            }
            else
            {
                
                if (rdDoviz.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblDoviz where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblDoviz");
                    MessageBox.Show("başarıyla silindi");
                }
                else if (rdEmtia.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblEmtia where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblEmtia");
                    MessageBox.Show("başarıyla silindi");
                }
                else if (rdHisse.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblHisse where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblHisse");
                    MessageBox.Show("başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Lütfen portföy türünü seçiniz");
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hatalı işlem");

            }else
            {
                
                if (rdDoviz.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblDoviz set miktar=@miktar ,tarih=@tarih where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblDoviz");
                    MessageBox.Show("başarıyla güncellendi");
                }
                else if (rdEmtia.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblEmtia set miktar=@miktar ,tarih=@tarih where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblEmtia");
                    MessageBox.Show("başarıyla güncellendi");
                }
                else if (rdHisse.Checked)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblHisse set miktar=@miktar ,tarih=@tarih where ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@miktar", txtPortföy.Text);
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.DataSource = b.veriAl("Select ID,miktar,tarih from tblHisse");
                    MessageBox.Show("başarıyla güncellendi");
                }
                else
                {
                    MessageBox.Show("Lütfen portföy türünü seçiniz");
                   
                }

              
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.veriAl("SELECT * FROM VwHisse");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.veriAl("SELECT * FROM VwEmtia");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void portföy_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPortföy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtTarih.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
