using System.Data;
using System.Data.SqlClient;

namespace kütüphaneotomasyon
{
    public partial class Form1 : Form
    {
        uye cagir = new uye();
        static string conString = "Data Source=DESKTOP-T7M1F5P\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvKitap.DataSource = cagir.veriAl("Select * from kitaplar Where Stok>0");
            dgvUye.DataSource = cagir.veriAl("Select * from uyeler where Ceza_puanı < 50");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void üYELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyeler uyeler = new uyeler();
            uyeler.ShowDialog();
            uyeler.Dispose();
            dgvUye.DataSource = cagir.veriAl("Select * from uyeler where Ceza_puanı < 50");

        }

        private void kİTAPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitaplar kitaplar = new kitaplar();
            kitaplar.ShowDialog();
            kitaplar.Dispose();
            dgvKitap.DataSource = cagir.veriAl("Select * from kitaplar Where Stok>0");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
            
            if (DateTime.Parse(dateVerilis.Value.ToString()) < DateTime.Parse(dateAlınıs.Value.ToString()))
            {
                conn.Open();
                string kayit = "INSERT INTO Teslim(Kitapal, Kitapiade, uyeID, kitapID) values (@Kitapal, @Kitapiade, @uyeID, @kitapID)";
                SqlCommand cmd = new SqlCommand(kayit, conn);
                cmd.Parameters.AddWithValue("@Kitapal", dateVerilis.Value);
                cmd.Parameters.AddWithValue("@Kitapiade", dateAlınıs.Value);
                cmd.Parameters.AddWithValue("@uyeID", dgvUye.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@kitapID", dgvKitap.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                string guncelle = "Update [dbo].[kitaplar] set [Stok]= [Stok] - 1 Where ID=" + dgvKitap.CurrentRow.Cells[0].Value;
                SqlCommand cmd2 = new SqlCommand(guncelle, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Kitabın alınış tarihi veriliş tarihinden küçük olamaz");
            }
     
            dgvKitap.DataSource = cagir.veriAl("Select * from kitaplar Where Stok>0");

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kİTAPTAKİPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takip takip = new takip();
            takip.ShowDialog();
            takip.Dispose();
            dgvKitap.DataSource = cagir.veriAl("Select * from kitaplar Where Stok>0");
            dgvUye.DataSource = cagir.veriAl("Select * from uyeler where Ceza_puanı < 50");

        }

        private void txtuyeara_TextChanged(object sender, EventArgs e)
        {
            dgvUye.DataSource = cagir.veriAl("SELECT * FROM uyeler WHERE Ad LIKE '" + txtuyeara.Text + "%' and Ceza_puanı<50");
        }

        private void txtkitapara_TextChanged(object sender, EventArgs e)
        {
            dgvKitap.DataSource = cagir.veriAl("SELECT * FROM kitaplar WHERE KitapAdı LIKE '" + txtkitapara.Text + "%' and Stok>0" );
        }

        private void dgvUye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kİTABIVERENLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste a = new liste();
            a.ShowDialog();
            a.Dispose();
        }

        private void kİTABIVERMEYENLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste2 a = new liste2();
            a.ShowDialog();
            a.Dispose();

        }
    }
}