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
    public partial class gelirler : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public gelirler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void gelirler_Load(object sender, EventArgs e)
        {
            dgvGelir.DataSource = b.veriAl("SELECT * FROM VwGelirler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGelirAdi.Text == "" || txtFiyat.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Eklemek İstiyor musunuz?", "Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    conn.Open();
                    string kayit = "INSERT INTO tblGelirler(gelirAdi, fiyat, tarih, gelirAciklama) values (@gelirAdi, @fiyat, @tarih, @gelirAciklama) ";
                    SqlCommand cmd = new SqlCommand(kayit, conn);
                    cmd.Parameters.AddWithValue("@gelirAdi", txtGelirAdi.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.Parameters.AddWithValue("@gelirAciklama", txtAciklama.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT * FROM VwGelirler");
                    MessageBox.Show(txtGelirAdi.Text + "Başarıyla eklendi","İşlem Başarılı");

                }
                    

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvGelir.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Güncelleme yapmak istiyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblGelirler set gelirAdi=@gelirAdi ,fiyat=@fiyat ,tarih=@tarih, gelirAciklama=@gelirAciklama where ID=" + dgvGelir.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@gelirAdi", txtGelirAdi.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.Parameters.AddWithValue("@gelirAciklama", txtAciklama.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT * FROM VwGelirler");
                    MessageBox.Show("Başarıyla güncellendi", "İşlem Başarılı");
                }
            }
        }

        private void dgvGelir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dgvGelir.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap=MessageBox.Show("Silmek istiyor musunuz", "Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (cevap==DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblGelirler where ID=" + dgvGelir.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT * FROM VwGelirler");
                    MessageBox.Show("Başarıyla silindi", "İşlem Başarılı");
                }
               
                
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvGelir.DataSource = b.veriAl("SELECT * FROM VwGelirler WHERE [Gelir Adı] LIKE '" + txtAra.Text + "%'");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvGelir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGelirAdi.Text = dgvGelir.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dgvGelir.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dgvGelir.CurrentRow.Cells[4].Value.ToString();
            //txtTarih.Value = DateTime.Parse(dgvGelir.CurrentRow.Cells[3].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string sql = ("SELECT * FROM VwGelirler WHERE [Gelir Tarihi] BETWEEN @dtBas and @dtSon");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            da.Fill(dt);
            dgvGelir.DataSource = dt;
            conn.Close();
        }
    }
}
