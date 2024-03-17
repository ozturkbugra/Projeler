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

namespace SirketProje
{
    public partial class Giderler : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        AnaSayfa a = new AnaSayfa();
        int id;
        public string kadi;
        baglan b = new baglan();

        public Giderler()
        {
            InitializeComponent();
        }

        private void Giderler_Load(object sender, EventArgs e)
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

        private void CbSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvGider.DataSource = b.veriAl("Select ID,Aciklama,Tutar,Tarih from GiderView where SirketID= " + CbSirket.SelectedValue + "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into tblGider (Aciklama,Tutar,SirketID,Tarih) values (@p1,@p2,@p3,@p4) ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@p2", Decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@p3", CbSirket.SelectedValue);
            cmd.Parameters.AddWithValue("@p4", txtTarih.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Gider oluşturuldu");
            dgvGider.DataSource = b.veriAl("Select ID,Aciklama,Tutar,Tarih from GiderView where SirketID= " + CbSirket.SelectedValue + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblGider where ID=@p1 ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", dgvGider.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Gider silindi");
            dgvGider.DataSource = b.veriAl("Select ID,Aciklama,Tutar,Tarih from GiderView where SirketID= " + CbSirket.SelectedValue + "");
        }
    }
}
