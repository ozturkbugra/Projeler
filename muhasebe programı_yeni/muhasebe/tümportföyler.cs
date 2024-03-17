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
    public partial class tümportföyler : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        public tümportföyler()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tümportföyler_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT AdSoyad AS 'Kişi', PAd AS 'Ad',PTur 'TÜR',SUM(PMiktar) AS 'Toplam Miktar' FROM ViewPortfoy GROUP BY PAd, AdSoyad, PTur HAVING SUM(PMiktar) > 0";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(dt);
            dgvEmtia.DataSource = dt;


            conn.Close();


        }
    }
}
