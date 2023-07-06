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
    public partial class donemekle : Form
    {
        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        int daire;
        int aidat;
        int ek;
        public donemekle()
        {
            InitializeComponent();
        }
        
        
        private void donemekle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd9 = new SqlCommand("select count(No) from tblSakinler", conn);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                daire = Convert.ToInt32(dr9[0].ToString());
            }
            conn.Close();
            txtYıl.Text = DateTime.Now.ToString("yyyy");
            txtAy.Text = DateTime.Now.ToString("MMMM").ToUpper();
            
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd1.Parameters.AddWithValue("@veri2", 8);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                txtAidat.Text = dr[2].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd2.Parameters.AddWithValue("@veri2", 9);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txtEk.Text = dr2[2].ToString();
            }
            conn.Close();
        }

        private void txtAidat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtEk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        public void ekle(int daireNo)
        {
            conn.Open();
            string güncelle = "Update tblSakinler set borc= borc + " + Convert.ToInt32(txtAidat.Text) + " where No= '" + daireNo + "'";
            SqlCommand cmd = new SqlCommand(güncelle, conn);
            cmd.ExecuteNonQuery();

            string ekle = "INSERT INTO tblAidat(aidatAdi, aidatYili, tutar, daireNo) values (@aidatAdi, @aidatYili, @tutar, @daireNo) ";
            SqlCommand cmd1 = new SqlCommand(ekle, conn);
            cmd1.Parameters.AddWithValue("@aidatAdi", txtAy.Text);
            cmd1.Parameters.AddWithValue("@aidatYili", txtYıl.Text);
            cmd1.Parameters.AddWithValue("@tutar", txtAidat.Text);
            cmd1.Parameters.AddWithValue("@daireNo", daireNo);
            cmd1.ExecuteNonQuery();
            conn.Close();

        }
        public void ekle2(int daireNo)
        {
            conn.Open();
            string güncelle = "Update tblSakinler set borc= borc + " + Convert.ToInt32(txtEk.Text) + " where No= '" + daireNo + "'";
            SqlCommand cmd = new SqlCommand(güncelle, conn);
            cmd.ExecuteNonQuery();

            string ekle = "INSERT INTO tblEk(ekAyi, ekYili, tutar, daireNo) values (@ekAyi, @ekYili, @tutar, @daireNo) ";
            SqlCommand cmd1 = new SqlCommand(ekle, conn);
            cmd1.Parameters.AddWithValue("@ekAyi", txtAy.Text);
            cmd1.Parameters.AddWithValue("@ekYili", txtYıl.Text);
            cmd1.Parameters.AddWithValue("@tutar", txtEk.Text);
            cmd1.Parameters.AddWithValue("@daireNo", daireNo);
            cmd1.ExecuteNonQuery();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.lblAidat.Text = "1";
            conn.Open();
            SqlCommand cmd10 = new SqlCommand("Select * from tblAidat Where aidatAdi= '" + txtAy.Text + "' and aidatYili= '" + txtYıl.Text + "' ", conn);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                aidat = 1;
            }
            else
            {
                aidat = 0;
            }
            conn.Close();
            if (txtAidat.Text == "")
            {
                
                MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (aidat == 1)
                {
                    MessageBox.Show("Bu ayın aidatını eklediniz","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult cevap = new DialogResult();
                    cevap = MessageBox.Show("Dönemi eklemek İstiyor musunuz?", "Dönem ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.Yes)
                    {
                        for (int i = 0; i <= daire; i++)
                        {
                            ekle(i);
                        }

                        MessageBox.Show(txtAy.Text + " dönemi başarıyla eklendi", "İşlem Başarılı");
                    }
                }

                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd10 = new SqlCommand("Select * from tblEk Where ekAyi= '" + txtAy.Text + "' and ekYili= '" + txtYıl.Text + "' ", conn);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                ek = 1;
            }
            else
            {
                ek = 0;
            }
            conn.Close();
            if (txtEk.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ek == 1)
                {
                    MessageBox.Show("Bu ayın EK'ini zaten eklediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    DialogResult cevap = new DialogResult();
                    cevap = MessageBox.Show("Dönemi eklemek İstiyor musunuz?", "Dönem ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.Yes)
                    {
                        for (int i = 0; i <= daire; i++)
                        {
                            ekle2(i);
                        }
                        MessageBox.Show(txtAy.Text + " dönemi (EK) başarıyla eklendi", "İşlem Başarılı");
                    }
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            güvenlik a = new güvenlik();
            a.ShowDialog();
            a.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAidat.Enabled = true;
            txtEk.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update tblSabit set tutar=@tutar where ID=8";
            cmd.Parameters.AddWithValue("@tutar", txtAidat.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd1 = new SqlCommand();
            conn.Open();
            cmd1.Connection = conn;
            cmd1.CommandText = "update tblSabit set tutar=@tutar where ID=9";
            cmd1.Parameters.AddWithValue("@tutar", txtEk.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();
            
            txtAidat.Enabled = false;
            txtEk.Enabled = false;
        }
    }
}
