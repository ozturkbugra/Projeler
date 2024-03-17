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
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
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

            dgvGider.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);

            string query = "SELECT SektorId,SektorAdi FROM tblSektor order by SektorAdi asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtSektör.DisplayMember = "SektorAdi"; // ComboBox'ta gösterilecek sütun adı
            txtSektör.ValueMember = "SektorId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtSektör.DataSource = table;
            try
            {
                txtSektör.SelectedIndex = 0; // İlk veriyi seçili getir
            }
            catch
            {

            }



            string query2 = "SELECT OdemeId,OdemeAd FROM tblOdemeTuru order by OdemeAd asc";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            txtOdemeTuru.DisplayMember = "OdemeAd"; // ComboBox'ta gösterilecek sütun adı
            txtOdemeTuru.ValueMember = "OdemeId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtOdemeTuru.DataSource = table2;
            try
            {
                txtOdemeTuru.SelectedIndex = 0; // İlk veriyi seçili getir
            }
            catch
            {


            }


            string query3 = "SELECT SektorId,SektorAdi FROM tblSektor order by SektorAdi asc";
            SqlDataAdapter adapter3 = new SqlDataAdapter(query3, conn);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            sektör2.DisplayMember = "SektorAdi"; // ComboBox'ta gösterilecek sütun adı
            sektör2.ValueMember = "SektorId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            sektör2.DataSource = table3;
            try
            {
                sektör2.SelectedIndex = 0; // İlk veriyi seçili getir
            }
            catch
            {


            }

            string query5 = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter5 = new SqlDataAdapter(query5, conn);
            DataTable table5 = new DataTable();
            adapter5.Fill(table5);
            txtKisi.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi.DataSource = table5;


            dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] from ViewGiderler order by Tarih desc");
            dgvGider.Columns["Ay"].Visible = false;
            dgvGider.Columns["Yil"].Visible = false;
            dgvGider.Columns["GiderId"].Visible = false;
          
            dgvGider.Columns["Açıklama"].Width = 160;
            
    


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
            DateTime tarih = txtTarih.Value.Date;
            if (txtAciklama.Text == "" || txtFiyat.Text == "" || txtSektör.Text == "")
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
                    string kayit = "INSERT INTO tblGiderler(Aciklama, Sektor, Tutar, Tarih, OdemeTuru, Ay, Yil, KisiId) values (@Aciklama, @Sektor, @Tutar, @Tarih, @OdemeTuru, @Ay, @Yil, @KisiId) ";
                    SqlCommand cmd = new SqlCommand(kayit, conn);
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    cmd.Parameters.AddWithValue("@Sektor", txtSektör.SelectedValue);
                    cmd.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.Parameters.AddWithValue("@OdemeTuru", txtOdemeTuru.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ay", tarih.ToString("MM"));
                    cmd.Parameters.AddWithValue("@Yil", tarih.ToString("yyyy"));
                    cmd.Parameters.AddWithValue("@KisiId", txtKisi.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] from ViewGiderler Order By Tarih desc");
                    MessageBox.Show(txtAciklama.Text + " Başarıyla eklendi", "İşlem Başarılı");
                }


            }
        }

        private void dgvGider_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            txtAciklama.Text = dgvGider.CurrentRow.Cells["Açıklama"].Value.ToString();
            txtSektör.Text = dgvGider.CurrentRow.Cells["Sektör Adı"].Value.ToString();
            txtFiyat.Text = dgvGider.CurrentRow.Cells["Tutar"].Value.ToString();
            object a = dgvGider.CurrentRow.Cells["Tarih"].Value;
            if (a != null && DateTime.TryParse(a.ToString(), out DateTime tarih))
            {
                // DateTimePicker'a tarihi aktar
                txtTarih.Value = tarih;
            }
            txtOdemeTuru.Text = dgvGider.CurrentRow.Cells["Ödeme Şekli"].Value.ToString();
            txtKisi.Text = dgvGider.CurrentRow.Cells["Kişi"].Value.ToString();



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
            dgvGider.DataSource = b.veriAl("SELECT GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] FROM ViewGiderler WHERE [Açıklama] LIKE '" + txtAra.Text + "%' or [Sektör Adı] LIKE '" + txtAra.Text + "%'");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] from ViewGiderler Where [Sektör Adı]='" + sektör2.Text + "' Order By Tarih desc");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] from ViewGiderler Order By Tarih desc");

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
                    cmd.CommandText = "delete from tblGiderler where GiderId=" + dgvGider.CurrentRow.Cells["GiderId"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil,[Kişi] from ViewGiderler Order By Tarih desc");

                    MessageBox.Show("Başarıyla silindi", "İşlem başarılı");
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime tarih = txtTarih.Value.Date;
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
                    cmd.CommandText = "update tblGiderler set Aciklama=@Aciklama ,Sektor=@Sektor ,Tutar=@Tutar ,Tarih=@Tarih, OdemeTuru=@OdemeTuru, Ay=@Ay, Yil=@Yil, KisiId=@KisiId where GiderId=" + dgvGider.CurrentRow.Cells["GiderId"].Value.ToString() + "";
                    cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    cmd.Parameters.AddWithValue("@Sektor", txtSektör.SelectedValue);
                    cmd.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.Parameters.AddWithValue("@OdemeTuru", txtOdemeTuru.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ay", tarih.ToString("MM"));
                    cmd.Parameters.AddWithValue("@Yil", tarih.ToString("yyyy"));
                    cmd.Parameters.AddWithValue("@KisiId", txtKisi.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvGider.DataSource = b.veriAl("Select GiderId,[Açıklama],[Sektör Adı],Tutar,Tarih,[Ödeme Şekli],Ay,Yil from ViewGiderler Order By Tarih desc");
                    MessageBox.Show("Başarıyla güncellendi", "İşlem başarılı");




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
            DateTime bas = dtBas.Value.Date;  // Sadece tarih kısmını al
            DateTime son = dtSon.Value.Date.AddDays(1).AddTicks(-1);  // Günün sonu (23:59:59) olarak ayarla

            conn.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT GiderId, [Açıklama], [Sektör Adı], Tutar, Tarih, [Ödeme Şekli], Ay, Yil, [Kişi] FROM ViewGiderler WHERE Tarih BETWEEN @dtBas AND @dtSon Order By Tarih desc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("dtBas", bas);
            da.SelectCommand.Parameters.AddWithValue("dtSon", son);
            da.Fill(dt);
            dgvGider.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {


        }
    }
}

