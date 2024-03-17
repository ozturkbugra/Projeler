using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketProje
{
    public partial class Calisanlar : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        AnaSayfa a = new AnaSayfa();
        int id;
        public string kadi;
        baglan b = new baglan();
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select ID from tblKullanicilar where KullaniciAdi= '" + kadi + " '";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            conn.Close();

            string query2 = "SELECT ID,Ad FROM tblSirket where KullaniciID= '" + id + " '";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            CbSirket.DisplayMember = "Ad"; // ComboBox'ta gösterilecek sütun adı
            CbSirket.ValueMember = "ID"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            CbSirket.DataSource = table2;
            CbSirket.SelectedIndex = 0; // İlk veriyi seçili getir
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Generate a random image name
            string randomImageName = Guid.NewGuid().ToString("N") + Path.GetExtension(txtResim.Text);

            // Specify the folder path within the project where you want to save the images
            string imageFolderPath = Path.Combine(Application.StartupPath, "resimler");

            // Combine the folder path with the random image name
            string imagePath = Path.Combine(imageFolderPath, randomImageName);

            // Save the image to the specified folder
            File.Copy(txtResim.Text, imagePath);

            // Insert the record into the database
            string sql = "INSERT INTO tblSirketCalisan (AdSoyad,Departman,Maas,SirketID,Resim) VALUES (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtDepartman.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtMaas.Text));
            cmd.Parameters.AddWithValue("@p4", CbSirket.SelectedValue);
            cmd.Parameters.AddWithValue("@p5", randomImageName);  // Use the random image name in the database
            cmd.ExecuteNonQuery();

            conn.Close();

            dgvCalisan.DataSource = b.veriAl("Select ID,AdSoyad,Departman,Maas,Resim from SirketCalisanView where SirketID= " + CbSirket.SelectedValue + "");
            MessageBox.Show("Çalışan başarılı bir şekilde eklendi");
        }

        private void dgvCalisan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked (not the header)
            {
                DataGridViewRow selectedRow = dgvCalisan.Rows[e.RowIndex];

                // Get values from the selected row
                string adSoyad = selectedRow.Cells["AdSoyad"].Value.ToString();
                string maas = selectedRow.Cells["Maas"].Value.ToString();
                string departman = selectedRow.Cells["Departman"].Value.ToString();

                // Update labels with the values
                lblAdSoyad.Text = adSoyad;
                lblMaaş.Text = maas;
                lblDepartman.Text = departman;

                // Assuming "resimler" is the folder where your images are stored
                string imageName = selectedRow.Cells["Resim"].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "resimler", imageName);

                // Set the ImageLocation property of PictureBox
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void CbSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCalisan.DataSource = b.veriAl("Select ID,AdSoyad,Departman,Maas,Resim from SirketCalisanView where SirketID= " + CbSirket.SelectedValue + "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Get the selected row from the DataGridView
            int selectedRowIndex = dgvCalisan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCalisan.Rows[selectedRowIndex];

            // Get the values needed for deletion
            int calisanID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string imageName = selectedRow.Cells["Resim"].Value.ToString();

            // Specify the folder path within the project where images are stored
            string imageFolderPath = Path.Combine(Application.StartupPath, "resimler");

            // Combine the folder path with the image name
            string imagePath = Path.Combine(imageFolderPath, imageName);

            // Delete the record from the database
            string sqlDelete = "DELETE FROM tblSirketCalisan WHERE ID = @CalisanID";
            SqlCommand cmdDelete = new SqlCommand(sqlDelete, conn);
            cmdDelete.Parameters.AddWithValue("@CalisanID", calisanID);
            cmdDelete.ExecuteNonQuery();

            // Delete the image from the folder
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }

            conn.Close();

            // Refresh the DataGridView with updated data
            dgvCalisan.DataSource = b.veriAl("Select ID,AdSoyad,Departman,Maas,Resim from SirketCalisanView where SirketID= " + CbSirket.SelectedValue + "");

            MessageBox.Show("Çalışan başarılı bir şekilde silindi");
        }
    }
}
