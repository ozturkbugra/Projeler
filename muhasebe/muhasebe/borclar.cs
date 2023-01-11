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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
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
            dgvBorc.DataSource = b.veriAl("Select * from VwBorclar Where [Borç Bitti]<1");
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
                string kayit = "INSERT INTO tblBorclar(borcAdi, borcMiktari, tarih, borcAciklama) values (@borcAdi, @borcMiktari, @tarih, @borcAciklama) ";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@borcAdi", txtBorcAdi.Text);
                cmd.Parameters.AddWithValue("@borcMiktari", Convert.ToDouble(txtFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.Parameters.AddWithValue("@borcAciklama", txtAciklama.Text);
                cmd.ExecuteNonQuery();

                string ekle = "INSERT INTO tblGelirler(gelirAdi, fiyat, tarih, gelirAciklama) values (@gelirAdi, @fiyat, @tarih, @gelirAciklama) ";
                SqlCommand cmd1 = new SqlCommand(ekle, conn);
                cmd1.Parameters.AddWithValue("@gelirAdi", txtBorcAdi.Text);
                cmd1.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                cmd1.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd1.Parameters.AddWithValue("@gelirAciklama", txtAciklama.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar Where [Borç Bitti]<1");
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
                cmd.CommandText = "update tblBorclar set borcAdi=@borcAdi ,borcMiktari=@borcMiktari ,tarih=@tarih, borcAciklama=@borcAciklama where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.Parameters.AddWithValue("@borcAdi", txtBorcAdi.Text);
                cmd.Parameters.AddWithValue("@borcMiktari", Convert.ToDouble(txtFiyat.Text));
                cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd.Parameters.AddWithValue("@borcAciklama", txtAciklama.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar where [Borç Bitti]<1");
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
                cmd.CommandText = "delete from tblBorclar where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar");
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
                cmd.CommandText = "update tblBorclar set bitti=1 where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();

                string ekle = "INSERT INTO tblGiderler(giderAdi, sektör, fiyat, tarih, giderAciklama) values (@giderAdi, @sektör , @fiyat, @tarih, @giderAciklama) ";
                SqlCommand cmd1 = new SqlCommand(ekle, conn);
                cmd1.Parameters.AddWithValue("@giderAdi", txtBorcAdi.Text);
                cmd1.Parameters.AddWithValue("@sektör", "Diğer");
                cmd1.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                cmd1.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd1.Parameters.AddWithValue("@giderAciklama", txtAciklama.Text);
                cmd1.ExecuteNonQuery();

                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar where [Borç Bitti]<1");
                MessageBox.Show("Borç Ödendi");

                
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar where [Borç Bitti]=1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar where [Borç Bitti]=0");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar WHERE [Borç Adı] LIKE '" + txtAra.Text + "%'");
        }

        private void dgvBorc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgvBorc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBorc.CurrentRow.Cells != null )
            {
                txtBorcAdi.Text = dgvBorc.CurrentRow.Cells[1].Value.ToString();
                txtFiyat.Text = dgvBorc.CurrentRow.Cells[3].Value.ToString();
                txtAciklama.Text= dgvBorc.CurrentRow.Cells[2].Value.ToString();
                //txtTarih.Value = DateTime.Parse(dgvBorc.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                MessageBox.Show("hata");
            }
            
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
            if (dgvBorc.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update tblBorclar set bitti=0 where ID=" + dgvBorc.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();

                string ekle = "INSERT INTO tblGelirler(gelirAdi, fiyat, tarih, gelirAciklama) values (@gelirAdi, @fiyat, @tarih, @gelirAciklama) ";
                SqlCommand cmd1 = new SqlCommand(ekle, conn);
                cmd1.Parameters.AddWithValue("@gelirAdi", txtBorcAdi.Text);
                cmd1.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                cmd1.Parameters.AddWithValue("@tarih", txtTarih.Value);
                cmd1.Parameters.AddWithValue("@gelirAciklama", txtAciklama.Text);
                cmd1.ExecuteNonQuery();

                conn.Close();
                dgvBorc.DataSource = b.veriAl("SELECT * FROM VwBorclar where [Borç Bitti]=0");
                MessageBox.Show("Borç Geri Alındı");



            }
        }
    }
}
