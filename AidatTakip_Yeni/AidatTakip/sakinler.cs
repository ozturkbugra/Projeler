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
    public partial class sakinler : Form
    {
        listele b = new listele();
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        public sakinler()
        {
            InitializeComponent();
        }

        private void sakinler_Load(object sender, EventArgs e)
        {
            txtDurum.SelectedIndex = 0;
            dgvSakin1.DataSource = b.veriAl("Select * from VwSakinler");

        }

        private void txtDurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;


        }

        private void txtTelNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSakin1.CurrentRow == null)
            {
                MessageBox.Show("Boş alanı düzenleyemezsiniz!","Hatalı İşlem",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("Düzenlemek İstiyor musunuz?", "Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "update tblSakinler set ad=@ad ,soyad=@soyad ,telno=@telno ,durum=@durum where No=" + dgvSakin1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@telno", txtTelNo.Text);
                    cmd.Parameters.AddWithValue("@durum", txtDurum.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvSakin1.DataSource = b.veriAl("Select * from VwSakinler");
                    MessageBox.Show("Başarıyla düzenlendi", "İşlem başarılı");
                }

            }

        }

        private void dgvSakin1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvSakin1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvSakin1.CurrentRow.Cells[2].Value.ToString();
            txtTelNo.Text = dgvSakin1.CurrentRow.Cells[3].Value.ToString();
            txtDurum.Text = dgvSakin1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (rdAd.Checked)
            {
               if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }
               else
                {
                    dgvSakin2.DataSource = b.veriAl("Select * from VwSakinler WHERE Ad = '" + txtAra.Text + "'");

                }
            }
            if (rdDaireNo.Checked)
            {
                if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }
                else
                {
                    dgvSakin2.DataSource = b.veriAl("SELECT * FROM VwSakinler WHERE [Daire No] = '" + txtAra.Text + "'");

                }
            }
            if (!rdAd.Checked && !rdDaireNo.Checked)
            {
                MessageBox.Show("Lütfen arama yapmak için gerekli yeri seçin");
            }

        }
    }
}

