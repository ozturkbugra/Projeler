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
    public partial class Kasa : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        AnaSayfa a = new AnaSayfa();
        int id;
        public string kadi;
        baglan b = new baglan();

        public Kasa()
        {
            InitializeComponent();
        }

        private void Kasa_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baslangic = dtBaslangic.Value.ToString("yyyy-MM-dd");
            string bitis = dtBitis.Value.ToString("yyyy-MM-dd");

            string sql = "DECLARE @BaslangicTarihi DATE = @Baslangic, @BitisTarihi DATE = @Bitis; " +
                "SELECT s.Ad AS 'Şirket Adı', COALESCE(SUM(g.Tutar), 0) AS 'Toplam Gelir', COALESCE(SUM(f.Tutar), 0) AS 'Toplam Gider', " +
                "COALESCE(SUM(g.Tutar) - SUM(f.Tutar), 0) AS 'Kasa' FROM tblSirket s " +
                "LEFT JOIN tblGelir g ON s.ID = g.SirketID AND g.Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi " +
                "LEFT JOIN tblGider f ON s.ID = f.SirketID AND f.Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi " +
                "WHERE s.KullaniciID = @ID GROUP BY s.ID, s.Ad";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Baslangic", baslangic);
            cmd.Parameters.AddWithValue("@Bitis", bitis);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKasa.DataSource = dt;
            conn.Close();
        }
    }
}
