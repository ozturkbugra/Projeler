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

        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
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
            dgvGelir.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
            string query = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtKisi.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi.DataSource = table;

            try
            {
                txtKisi.SelectedIndex = 0; // İlk veriyi seçili getir
            }
            catch
            {

            }

            dgvGelir.DataSource = b.veriAl("SELECT GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler");
            dgvGelir.Columns["GelirId"].Visible = false;
            dgvGelir.Columns["Ay"].Visible = false;
            dgvGelir.Columns["Yil"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;

            if (txtAciklama.Text == "" || txtFiyat.Text == "")
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
                    string kayit = "INSERT INTO tblGelirler(Aciklama, Tutar, Tarih, KisiId, Ay, Yil) values (@Aciklama, @Tutar, @Tarih, @KisiId, @Ay, @Yil) ";
                    SqlCommand cmd = new SqlCommand(kayit, conn);
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    cmd.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@KisiId", txtKisi.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ay", tarih.ToString("MM"));
                    cmd.Parameters.AddWithValue("@Yil", tarih.ToString("yyyy"));

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler order by Tarih desc");


                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
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
                    cmd.CommandText = "update tblGelirler set Aciklama=@Aciklama, Tutar=@Tutar, Tarih=@Tarih, KisiId=@KisiId, Ay=@Ay, Yil=@Yil where GelirId=" + dgvGelir.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    cmd.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@KisiId", txtKisi.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ay", tarih.ToString("MM"));
                    cmd.Parameters.AddWithValue("@Yil", tarih.ToString("yyyy"));

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler order by Tarih desc");
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
                cevap = MessageBox.Show("Silmek istiyor musunuz", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from tblGelirler where GelirId=" + dgvGelir.CurrentRow.Cells["GelirId"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGelir.DataSource = b.veriAl("SELECT GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler order by Tarih desc");
                    MessageBox.Show("Başarıyla silindi", "İşlem Başarılı");
                }


            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvGelir.DataSource = b.veriAl("SELECT  GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler WHERE [Açıklama] LIKE '" + txtAra.Text + "%' order by Tarih desc");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvGelir_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtFiyat.Text = dgvGelir.CurrentRow.Cells["Tutar"].Value.ToString();
            txtAciklama.Text = dgvGelir.CurrentRow.Cells["Açıklama"].Value.ToString();
            txtKisi.Text = dgvGelir.CurrentRow.Cells["Kişi"].Value.ToString();
            object a = dgvGelir.CurrentRow.Cells["Tarih"].Value;
            if (a != null && DateTime.TryParse(a.ToString(), out DateTime tarih))
            {
                // DateTimePicker'a tarihi aktar
                txtTarih.Value = tarih;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime bas = dtBas.Value.Date;  // Sadece tarih kısmını al
            DateTime son = dtSon.Value.Date.AddDays(1).AddTicks(-1);  // Günün sonu (23:59:59) olarak ayarla
            conn.Open();
            DataTable dt = new DataTable();
            string sql = ("SELECT GelirId,[Kişi],[Açıklama],Tutar,Tarih,Ay,Yil FROM ViewGelirler WHERE [Tarih] BETWEEN @dtBas and @dtSon order by Tarih desc");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("dtBas", bas);
            da.SelectCommand.Parameters.AddWithValue("dtSon", son);
            da.Fill(dt);
            dgvGelir.DataSource = dt;
            conn.Close();
        }
    }
}
