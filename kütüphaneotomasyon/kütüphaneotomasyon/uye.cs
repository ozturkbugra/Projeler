using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace kütüphaneotomasyon
{
    internal class uye
    {
        public static string baglan = "Data Source=DESKTOP-T7M1F5P\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True";
        SqlConnection conn = new SqlConnection(baglan);

        public DataTable veriAl(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }



    }

}
