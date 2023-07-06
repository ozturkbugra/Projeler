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
    public partial class tahsilat : Form
    {
        string o;
        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public tahsilat()
        {
            InitializeComponent();
        }

        private void tahsilat_Load(object sender, EventArgs e)
        {

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
            if (txtAciklama.Text == "" || txtTutar.Text== "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string sql9 = "select IDENT_CURRENT('tblTahsilat') +1";
                SqlCommand cmd9 = new SqlCommand(sql9, conn);
                SqlDataReader dr2 = cmd9.ExecuteReader();
                if (dr2.Read())
                {
                    o = dr2[0].ToString();
                }

                conn.Close();
                conn.Open();
                string ekle = "Insert Into tblTahsilat (aciklama, tutar, tarih) values (@aciklama, @tutar, @tarih)";
                SqlCommand cmd = new SqlCommand(ekle , conn);
                cmd.Parameters.AddWithValue("@aciklama",txtAciklama.Text);
                cmd.Parameters.AddWithValue("@tutar", Convert.ToInt32(txtTutar.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.ExecuteNonQuery();
                conn.Close();
                tahsilatmakbuz a = new tahsilatmakbuz();
                a.lblTahsilatAciklama.Text = txtAciklama.Text;
                a.lblToplam.Text = txtTutar.Text;
                a.lblTutar.Text = txtTutar.Text;
                a.lblTahsilatNo.Text = o;
                a.ShowDialog();
                a.Dispose();
                txtAciklama.Text = "";
                txtTutar.Text = "";
            }
            
        }
    }
}
