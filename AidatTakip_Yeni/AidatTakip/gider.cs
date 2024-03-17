using iTextSharp.text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AidatTakip
{
    public partial class gider : Form
    {
        string o;
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);

        listele b = new listele();
       
        public gider()
        {
            InitializeComponent();
        }

        private void gider_Load(object sender, EventArgs e)
        {
            txtTur.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTur.KeyPress += (sender, e) => { e.Handled = true; };

            txtTur.SelectedIndex = 0;


            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd1.Parameters.AddWithValue("@veri2", 1);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                txtAciklama1.Text = dr[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd2.Parameters.AddWithValue("@veri2", 1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txtTutar1.Text = dr2[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd3 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd3.Parameters.AddWithValue("@veri2", 2);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                txtAciklama2.Text = dr3[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd4.Parameters.AddWithValue("@veri2", 2);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                txtTutar2.Text = dr4[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd5 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd5.Parameters.AddWithValue("@veri2", 3);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                txtAciklama3.Text = dr5[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd6.Parameters.AddWithValue("@veri2", 3);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                txtTutar3.Text = dr6[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd7 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd7.Parameters.AddWithValue("@veri2", 4);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                txtAciklama4.Text = dr7[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd8 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd8.Parameters.AddWithValue("@veri2", 4);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                txtTutar4.Text = dr8[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd9 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd9.Parameters.AddWithValue("@veri2", 5);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                txtAciklama5.Text = dr9[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd10 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd10.Parameters.AddWithValue("@veri2", 5);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                txtTutar5.Text = dr10[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd11 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd11.Parameters.AddWithValue("@veri2", 6);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            if (dr11.Read())
            {
                txtAciklama6.Text = dr11[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd12 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd12.Parameters.AddWithValue("@veri2", 6);
            SqlDataReader dr12 = cmd12.ExecuteReader();
            if (dr12.Read())
            {
                txtTutar6.Text = dr12[2].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd13 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd13.Parameters.AddWithValue("@veri2", 7);
            SqlDataReader dr13 = cmd13.ExecuteReader();
            if (dr13.Read())
            {
                txtAciklama7.Text = dr13[1].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd14 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd14.Parameters.AddWithValue("@veri2", 7);
            SqlDataReader dr14 = cmd14.ExecuteReader();
            if (dr14.Read())
            {
                txtTutar7.Text = dr14[2].ToString();
            }
            conn.Close();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" || txtTutar.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string sql9 = "select IDENT_CURRENT('tblGiderler') +1";
                SqlCommand cmd9 = new SqlCommand(sql9, conn);
                SqlDataReader dr2 = cmd9.ExecuteReader();
                if (dr2.Read())
                {
                    o = dr2[0].ToString();
                }

                conn.Close();
                conn.Open();
                string ekle = "Insert Into tblGiderler (aciklama, tutar, tarih, ay, yıl, tur) values (@aciklama, @tutar, @tarih, @ay, @yıl, @tur)";
                SqlCommand cmd = new SqlCommand(ekle, conn);
                cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@tutar", Convert.ToInt32(txtTutar.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
                cmd.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
                cmd.Parameters.AddWithValue("@tur", txtTur.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                gidermakbuz a = new gidermakbuz();
                a.lblGiderAciklama.Text = txtAciklama.Text;
                a.lblToplam.Text = txtTutar.Text;
                a.lblTutar.Text = txtTutar.Text;
                a.lblTutar2.Text = "# " + txtTutar.Text + " #";
                a.lblMakNo.Text = o;
                a.ShowDialog();
                a.Dispose();
                txtAciklama.Text = "";
                txtTutar.Text = "";

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAciklama1.Enabled = true;
            txtAciklama2.Enabled = true;
            txtAciklama3.Enabled = true;
            txtAciklama4.Enabled = true;
            txtAciklama5.Enabled = true;
            txtAciklama6.Enabled = true;
            txtAciklama7.Enabled = true;
            txtTutar1.Enabled = true;
            txtTutar2.Enabled = true;
            txtTutar3.Enabled = true;
            txtTutar4.Enabled = true;
            txtTutar5.Enabled = true;
            txtTutar6.Enabled = true;
            txtTutar7.Enabled = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=1";
            cmd.Parameters.AddWithValue("@ad", txtAciklama1.Text);
            cmd.Parameters.AddWithValue("@tutar", txtTutar1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd1 = new SqlCommand();
            conn.Open();
            cmd1.Connection = conn;
            cmd1.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=2";
            cmd1.Parameters.AddWithValue("@ad", txtAciklama2.Text);
            cmd1.Parameters.AddWithValue("@tutar", txtTutar2.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd2 = new SqlCommand();
            conn.Open();
            cmd2.Connection = conn;
            cmd2.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=3";
            cmd2.Parameters.AddWithValue("@ad", txtAciklama3.Text);
            cmd2.Parameters.AddWithValue("@tutar", txtTutar3.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd3 = new SqlCommand();
            conn.Open();
            cmd3.Connection = conn;
            cmd3.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=4";
            cmd3.Parameters.AddWithValue("@ad", txtAciklama4.Text);
            cmd3.Parameters.AddWithValue("@tutar", txtTutar4.Text);
            cmd3.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd4 = new SqlCommand();
            conn.Open();
            cmd4.Connection = conn;
            cmd4.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=5";
            cmd4.Parameters.AddWithValue("@ad", txtAciklama5.Text);
            cmd4.Parameters.AddWithValue("@tutar", txtTutar5.Text);
            cmd4.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd5 = new SqlCommand();
            conn.Open();
            cmd5.Connection = conn;
            cmd5.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=6";
            cmd5.Parameters.AddWithValue("@ad", txtAciklama6.Text);
            cmd5.Parameters.AddWithValue("@tutar", txtTutar6.Text);
            cmd5.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd6 = new SqlCommand();
            conn.Open();
            cmd6.Connection = conn;
            cmd6.CommandText = "update tblSabit set ad=@ad ,tutar=@tutar where ID=7";
            cmd6.Parameters.AddWithValue("@ad", txtAciklama7.Text);
            cmd6.Parameters.AddWithValue("@tutar", txtTutar7.Text);
            cmd6.ExecuteNonQuery();
            conn.Close();

            txtAciklama1.Enabled = false;
            txtAciklama2.Enabled = false;
            txtAciklama3.Enabled = false;
            txtAciklama4.Enabled = false;
            txtAciklama5.Enabled = false;
            txtAciklama6.Enabled = false;
            txtAciklama7.Enabled = false;
            txtTutar1.Enabled = false;
            txtTutar2.Enabled = false;
            txtTutar3.Enabled = false;
            txtTutar4.Enabled = false;
            txtTutar5.Enabled = false;
            txtTutar6.Enabled = false;
            txtTutar7.Enabled = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                txtAciklama.Text = txtAciklama1.Text;
                txtTutar.Text = txtTutar1.Text;
            }
            if (rb2.Checked)
            {
                txtAciklama.Text = txtAciklama2.Text;
                txtTutar.Text = txtTutar2.Text;
            }
            if (rb3.Checked)
            {
                txtAciklama.Text = txtAciklama3.Text;
                txtTutar.Text = txtTutar3.Text;
            }
            if (rb4.Checked)
            {
                txtAciklama.Text = txtAciklama4.Text;
                txtTutar.Text = txtTutar4.Text;
            }
            if (rb5.Checked)
            {
                txtAciklama.Text = txtAciklama5.Text;
                txtTutar.Text = txtTutar5.Text;
            }
            if (rb6.Checked)
            {
                txtAciklama.Text = txtAciklama6.Text;
                txtTutar.Text = txtTutar6.Text;
            }
            if (rb7.Checked)
            {
                txtAciklama.Text = txtAciklama7.Text;
                txtTutar.Text = txtTutar7.Text;
            }
        }

        private void txtTutar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTutar7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
