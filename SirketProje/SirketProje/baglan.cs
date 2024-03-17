using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketProje
{
    internal class baglan
    {
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Sirket2024;Integrated Security=True";

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
