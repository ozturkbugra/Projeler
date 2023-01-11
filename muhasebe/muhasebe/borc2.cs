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
    public partial class borc2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public borc2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBorcAdi.Text == "" || txtFiyat.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {
                conn.Open();
                string kayit = "INSERT INTO tblBorclar2(borcAdi, borcMiktari, tarih, borcAciklama) values (@borcAdi, @borcMiktari, @tarih, @borcAciklama) ";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@borcAdi", txtBorcAdi.Text);
                cmd.Parameters.AddWithValue("@borcMiktari", Convert.ToDouble(txtFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.Parameters.AddWithValue("@borcAciklama", txtAciklama.Text );
                cmd.ExecuteNonQuery();

                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 Where [Borç Bitti]<1");
                MessageBox.Show(txtBorcAdi.Text + " başarıyla eklendi");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvBorc.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update tblBorclar2 set borcAdi=@borcAdi ,borcMiktari=@borcMiktari ,tarih=@tarih, borcAciklama=@borcAciklama where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.Parameters.AddWithValue("@borcAdi", txtBorcAdi.Text);
                cmd.Parameters.AddWithValue("@borcMiktari", Convert.ToDouble(txtFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.Parameters.AddWithValue("@borcAciklama", txtAciklama.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]<1");
                MessageBox.Show("başarıyla güncellendi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvBorc.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from tblBorclar2 where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2");
                MessageBox.Show("başarıyla silindi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvBorc.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update tblBorclar2 set bitti=1 where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();


                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]=0");
                MessageBox.Show("Borç Sıfırlandı");



            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvBorc.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update tblBorclar2 set bitti=0 where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();

                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]=1");
                MessageBox.Show("Borç Tekrar Eklendi");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]=1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]=0");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 WHERE [Borç Adı] LIKE '" + txtAra.Text + "%'");
        }

        private void dgvBorc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBorcAdi.Text = dgvBorc.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dgvBorc.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dgvBorc.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void borc2_Load(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar2 where [Borç Bitti]=0");
        }
    }
}
