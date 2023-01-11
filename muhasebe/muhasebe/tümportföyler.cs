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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True");
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
            DataTable dt = new DataTable();
            string sql = "Select [Emtia Miktarı],[Emtia Tarihi] from VwEmtia WHERE [Emtia Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            conn.Open();
            da.Fill(dt);
            dgvEmtia.DataSource = dt;

            DataTable dt2 = new DataTable();
            string sql2 = "Select [Döviz Miktarı],[Döviz Tarihi] from VwDoviz WHERE [Döviz Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da2.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            da2.Fill(dt2);
            dgvDoviz.DataSource = dt2;

            DataTable dt3 = new DataTable();
            string sql3 = "Select [Hisse Miktarı],[Hisse Tarihi] from VwHisse WHERE [Hisse Tarihi] BETWEEN @dtBas and @dtSon";
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            da3.SelectCommand.Parameters.AddWithValue("dtBas", dtBas.Value);
            da3.SelectCommand.Parameters.AddWithValue("dtSon", dtSon.Value);
            da3.Fill(dt3);
            dgvHisse.DataSource = dt3;

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
