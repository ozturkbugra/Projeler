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
    public partial class TumBorclar : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        baglan b = new baglan();
        public TumBorclar()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TumBorclar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "  SELECT [Cari Adı],SUM(Tutar) AS 'Borç & Alacak Tutarı ₺' FROM ViewBorclar GROUP BY [Cari Adı] Having SUM(Tutar) <> 0 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            conn.Open();
            da.Fill(dt);
            dgvEmtia.DataSource = dt;


            conn.Close();
        }
    }
}
