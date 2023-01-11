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
 
    public partial class giderler : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
        baglan b = new baglan();
        public giderler()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            

        }

        private void txtfiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void giderler_Load(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("Select * from VwGiderler");
            sektör2.SelectedIndex = 0;
            txtSektör.SelectedIndex = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void giderler_Load_1(object sender, EventArgs e)
        {
            
        }

        private void sektör2_SelectedValueChanged(object sender, EventArgs e)
        {
       
        }

        private void txtSektör_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
           
            
        }

        private void sektör2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void sektör2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //txtTarih.Value = DateTime.Parse(dgvGider.CurrentRow.Cells[4].Value.ToString());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtGiderAdi.Text == "" || txtFiyat.Text == "" || txtSektör.Text == "")
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
                    string kayit = "INSERT INTO tblGiderler(giderAdi, sektör, fiyat, tarih, giderAciklama) values (@giderAdi, @sektör, @fiyat, @tarih, @giderAciklama) ";
                    SqlCommand cmd = new SqlCommand(kayit, conn);
                    cmd.Parameters.AddWithValue("@giderAdi", txtGiderAdi.Text);
                    cmd.Parameters.AddWithValue("@sektör", txtSektör.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.Parameters.AddWithValue("@giderAciklama", txtAciklama.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select * from VwGiderler");
                    MessageBox.Show(txtGiderAdi.Text + "Başarıyla eklendi", "İşlem Başarılı");
                }
                    

            }
        }

        private void dgvGider_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtGiderAdi.Text = dgvGider.CurrentRow.Cells[1].Value.ToString();
            txtSektör.Text = dgvGider.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dgvGider.CurrentRow.Cells[3].Value.ToString();
            txtAciklama.Text = dgvGider.CurrentRow.Cells[5].Value.ToString();
        }

        private void sektör2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // yazı yazdırmaz
        }

        private void txtSektör_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // yazı yazdırmaz
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("SELECT * FROM VwGiderler WHERE [Gider Adı] LIKE '" + txtAra.Text + "%'");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("SELECT * FROM VwGiderler Where [Gider Sektörü]='" + sektör2.Text + "'");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("Select * from VwGiderler");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvGider.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblGiderler where ID=" + dgvGider.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select * from VwGiderler");
                    MessageBox.Show("Başarıyla silindi","İşlem başarılı");
                }
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgvGider.CurrentRow == null)
            {
                MessageBox.Show("Hatalı İşlem");
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Güncellemek İstiyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblGiderler set giderAdi=@giderAdi ,sektör=@sektör ,fiyat=@fiyat ,tarih=@tarih, giderAciklama=@giderAciklama where ID=" + dgvGider.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@giderAdi", txtGiderAdi.Text);
                    cmd.Parameters.AddWithValue("@sektör", txtSektör.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", txtTarih.Value);
                    cmd.Parameters.AddWithValue("@giderAciklama", txtAciklama.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select * from VwGiderler");
                    MessageBox.Show("Başarıyla güncellendi","İşlem başarılı");
                }
                    
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam ve virgül girmek için//
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string sql =("SELECT * FROM VwGiderler WHERE [Gider Tarihi] BETWEEN @dtBas and @dtSon");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            da.Fill(dt);
            dgvGider.DataSource = dt;
            conn.Close();
        }
    }
}

