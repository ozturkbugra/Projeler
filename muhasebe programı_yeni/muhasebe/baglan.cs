using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace muhasebe
{
    internal class baglan
    {
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=YeniMuhasebe;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(conStr);

        public DataTable veriAl(string sql)

        {

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            conn.Open();

            da.Fill(dt);

            conn.Close();

            return dt;

        }


    }

}