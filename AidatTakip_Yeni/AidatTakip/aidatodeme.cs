using Microsoft.Office.Interop.Excel;
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
    public partial class aidatodeme : Form
    {
        string o;
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        listele b = new listele();
        int aidat;
        int zam;

        public aidatodeme()
        {
            InitializeComponent();
        }


        private void aidatodeme_Load(object sender, EventArgs e)
        {
            txtBorc2.Enabled = false;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd1.Parameters.AddWithValue("@veri2", 10);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                zam = Convert.ToInt32(dr[2]);
            }
            conn.Close();


            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd2.Parameters.AddWithValue("@veri2", 8);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                aidat = Convert.ToInt32(dr2[2]);
            }
            conn.Close();


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDaireNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //harf girilmesini engelleme kodu
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvAidat.CurrentRow == null)
            {
                MessageBox.Show("Lüfen ödemek istediğiniz aidatı seçiniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //tblmakbuzun son id'sini 1 arttırma
                conn.Open();
                string sql9 = "select IDENT_CURRENT('tblMakbuz') +1";
                SqlCommand cmd9 = new SqlCommand(sql9, conn);
                SqlDataReader dr2 = cmd9.ExecuteReader();
                if (dr2.Read())
                {
                    o = dr2[0].ToString();
                }

                conn.Close();
                conn.Open();
                string sql = "Update tblAidat set bitti=1 where ID='" + dgvAidat.CurrentRow.Cells[0].Value.ToString() + "' and daireNo= '" + dgvAidat.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sql2 = "set dateformat dmy Insert into tblMakbuz (daireNo, ad, soyad, aidatAdi, tutar, makTarih, ay, yıl) values (@daireNo, @ad, @soyad, @aidatAdi, @tutar, @makTarih, @ay , @yıl) select SCOPE_IDENTITY()";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@daireNo", txtDaireNo.Text);
                cmd2.Parameters.AddWithValue("@ad", lblAd.Text);
                cmd2.Parameters.AddWithValue("@soyad", lblSoyad.Text);
                cmd2.Parameters.AddWithValue("@aidatAdi", dgvAidat.CurrentRow.Cells[1].Value.ToString() + " - " + dgvAidat.CurrentRow.Cells[2].Value.ToString());
                cmd2.Parameters.AddWithValue("@tutar", dgvAidat.CurrentRow.Cells[3].Value.ToString());
                cmd2.Parameters.AddWithValue("@makTarih", DateTime.Now.ToString("d"));
                cmd2.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
                cmd2.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
                cmd2.ExecuteNonQuery();
                dgvMakbuz.DataSource = b.veriAl("Select * from VwMakbuz Where [Daire No]='" + txtDaireNo.Text + "'");
                string sql3 = "Update tblSakinler set borc = borc - " + dgvAidat.CurrentRow.Cells[3].Value.ToString() + " Where No = '" + txtDaireNo.Text + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                aidatmakbuz a = new aidatmakbuz();
                a.lblAidatAdi.Text = dgvAidat.CurrentRow.Cells[1].Value.ToString() + " - " + dgvAidat.CurrentRow.Cells[2].Value.ToString();
                a.lblAd.Text = lblAd.Text + " " + lblSoyad.Text;
                a.lblBorc.Text = lblBorc.Text;
                 if (Convert.ToInt32(dgvAidat.CurrentRow.Cells[3].Value.ToString()) > aidat)
                {
                    a.lblTutar.Text = aidat.ToString();
                    a.lblGecikmeTutar.Text = (Convert.ToInt32(dgvAidat.CurrentRow.Cells[3].Value.ToString()) - aidat).ToString();
                }
                if (Convert.ToInt32(dgvAidat.CurrentRow.Cells[3].Value.ToString()) <= aidat)
                {
                    a.lblTutar.Text = dgvAidat.CurrentRow.Cells[3].Value.ToString();
                    a.lblGecikmeTutar.Text = "0";
                }
                a.lblGecikme.Text = "GECİKME ZAMMI";
                             
                a.lblToplam.Text = dgvAidat.CurrentRow.Cells[3].Value.ToString();
                a.lblDaireNo.Text = txtDaireNo.Text;
                a.lblMakNo.Text = o;
                if (cbBorc0.Checked)
                {
                    a.lblBorc.Text = "0";
                }
                if (cbBorcFarkli.Checked)
                {
                    a.lblBorc.Text = txtBorc2.Text;
                }
                if (!cbBorc0.Checked && !cbBorcFarkli.Checked)
                {
                    a.lblBorc.Text = (Convert.ToInt32(lblBorc.Text) - Convert.ToInt32(dgvAidat.CurrentRow.Cells[3].Value.ToString())).ToString();

                }
                a.ShowDialog();
                a.Dispose();
                lblBorc.Text = (Convert.ToInt32(lblBorc.Text) - Convert.ToInt32(dgvAidat.CurrentRow.Cells[3].Value.ToString())).ToString();
                dgvAidat.DataSource = b.veriAl("Select * from VwAidat Where [Daire No]='" + txtDaireNo.Text + "' and Bitti=0");
                conn.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dgvEk.CurrentRow == null)
            {
                MessageBox.Show("Lüfen ödemek istediğiniz aidatı seçiniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string sql9 = "select IDENT_CURRENT('tblMakbuz') +1";
                SqlCommand cmd9 = new SqlCommand(sql9, conn);
                SqlDataReader dr2 = cmd9.ExecuteReader();
                if (dr2.Read())
                {
                    o = dr2[0].ToString();
                }
                conn.Close();
                conn.Open();
                string sql = "Update tblEk set bitti=1 where ID='" + dgvEk.CurrentRow.Cells[0].Value.ToString() + "' and daireNo= '" + dgvEk.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sql2 = "set dateformat dmy Insert into tblMakbuz (daireNo, ad, soyad, ekAyi, tutar2, makTarih, ay, yıl) values (@daireNo, @ad, @soyad, @ekAyi, @tutar2, @makTarih, @ay, @yıl)";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@daireNo", txtDaireNo.Text);
                cmd2.Parameters.AddWithValue("@ad", lblAd.Text);
                cmd2.Parameters.AddWithValue("@soyad", lblSoyad.Text);
                cmd2.Parameters.AddWithValue("@ekAyi", dgvEk.CurrentRow.Cells[1].Value.ToString() + " - " + dgvEk.CurrentRow.Cells[2].Value.ToString());
                cmd2.Parameters.AddWithValue("@tutar2", dgvEk.CurrentRow.Cells[3].Value.ToString());
                cmd2.Parameters.AddWithValue("@makTarih", DateTime.Now.ToString("d"));
                cmd2.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
                cmd2.Parameters.AddWithValue("@yıl", DateTime.Now.ToString("yyyy"));
                cmd2.ExecuteNonQuery();
                dgvMakbuz.DataSource = b.veriAl("Select * from VwMakbuz Where [Daire No]='" + txtDaireNo.Text + "'");
                string sql3 = "Update tblSakinler set borc = borc - " + dgvEk.CurrentRow.Cells[3].Value.ToString() + " Where No = '" + txtDaireNo.Text + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                ekmakbuz a = new ekmakbuz();
                a.lblEkAdi.Text = dgvEk.CurrentRow.Cells[1].Value.ToString() + " - " + dgvEk.CurrentRow.Cells[2].Value.ToString();
                a.lblAd.Text = lblAd.Text + " " + lblSoyad.Text;
                a.lblBorc.Text = lblBorc.Text;
                a.lblTutar.Text = dgvEk.CurrentRow.Cells[3].Value.ToString();
                a.lblToplam.Text = dgvEk.CurrentRow.Cells[3].Value.ToString();
                if (cbBorc0.Checked)
                {
                    a.lblBorc.Text = "0";
                }
                if (cbBorcFarkli.Checked)
                {
                    a.lblBorc.Text = txtBorc2.Text;
                }
                if (!cbBorc0.Checked && !cbBorcFarkli.Checked)
                {
                    a.lblBorc.Text = (Convert.ToInt32(lblBorc.Text) - Convert.ToInt32(dgvEk.CurrentRow.Cells[3].Value.ToString())).ToString();

                }
                a.lblDaireNo.Text = txtDaireNo.Text;
                a.lblMakNo.Text = o;
                a.ShowDialog();
                a.Dispose();
                lblBorc.Text = (Convert.ToInt32(lblBorc.Text) - Convert.ToInt32(dgvEk.CurrentRow.Cells[3].Value.ToString())).ToString();
                dgvEk.DataSource = b.veriAl("Select * from VwEk Where [Daire No]='" + txtDaireNo.Text + "' and Bitti=0");
                conn.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDaireNo.Text == "")
            {
                MessageBox.Show("Geçerli Daire Numarası Giriniz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string sql = "select * from tblSakinler where No ='" + txtDaireNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblAd.Text = dr["ad"].ToString();
                    lblSoyad.Text = dr["soyad"].ToString();
                    lblDurum.Text = dr["durum"].ToString();
                    lblBorc.Text = dr["borc"].ToString();
                    dgvAidat.DataSource = b.veriAl("Select * from VwAidat Where [Daire No]='" + txtDaireNo.Text + "' and Bitti=0");
                    dgvEk.DataSource = b.veriAl("Select * from VwEk Where [Daire No]='" + txtDaireNo.Text + "' and Bitti=0");
                    dgvMakbuz.DataSource = b.veriAl("Select [Makbuz No],[Daire No],[Aidat Ayı],[Aidat Tutarı],[Ek Ayı],[Ek Tutarı] from VwMakbuz Where [Daire No]='" + txtDaireNo.Text + "'");
                    dgvAidat.Columns[0].Visible = false;
                    dgvAidat.Columns[4].Visible = false;
                    dgvAidat.Columns[5].Visible = false;
                    dgvEk.Columns[0].Visible = false;
                    dgvEk.Columns[4].Visible = false;
                    dgvEk.Columns[5].Visible = false;
                }
                else
                {
                    MessageBox.Show("Geçerli daire numarası giriniz");
                    dgvAidat.DataSource = null;
                    dgvEk.DataSource = null;
                    dgvMakbuz.DataSource = null;
                    lblAd.Text = "-";
                    lblSoyad.Text = "-";
                    lblDurum.Text = "-";
                    lblBorc.Text = "-";
                }
                conn.Close();





            }




        }

        private void dgvMakbuz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rbAidat.Checked) { }
            if (!rbEk.Checked) { }
            if (txtDaireNo.Text == "") { }
            else
            {
                if (rbAidat.Checked)
                {
                    dgvMakbuz.DataSource = b.veriAl("Select [Aidat Ayı],[Aidat Yılı],[Aidat Tutarı],[Daire No],[Bitti] from VwAidat Where [Daire No]='" + txtDaireNo.Text + "' and [Aidat Yılı] ='" + cb1.Text + "' and Bitti=1");
                }
                if (rbEk.Checked)
                {
                    dgvMakbuz.DataSource = b.veriAl("Select [Ek Ayı],[Ek Yılı],[Ek Tutarı],[Daire No],[Bitti] from VwEk Where [Daire No]='" + txtDaireNo.Text + "' and [Ek Yılı] ='" + cb1.Text + "' and Bitti=1");
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBorcFarkli_CheckedChanged(object sender, EventArgs e)
        {
            txtBorc2.Enabled = true;
        }
    }
}
