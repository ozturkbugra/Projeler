using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.Common;

namespace kütüphaneotomasyon
{

    public partial class takip : Form
    {
        uye uye = new uye();
        static string conString = "Data Source=DESKTOP-T7M1F5P\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conString);
        public takip()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void takip_Load(object sender, EventArgs e)
        {
            dgvtarih.DataSource=uye.veriAl("Select * From Vwtarih where Verildimi<1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvtarih.CurrentRow == null)
            {
                MessageBox.Show("Olmayan kitabı alamayız");
            }
            else { 
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();

            string sil = "update Teslim set bitti = 1 where ID="+ dgvtarih.CurrentRow.Cells[8].Value;
            SqlCommand cmd = new SqlCommand(sil, conn);
            cmd.ExecuteNonQuery();

            string guncelle = "Update [dbo].[kitaplar] set [Stok]= [Stok]+1 Where ID=" + dgvtarih.CurrentRow.Cells[6].Value;
            SqlCommand cmd2 = new SqlCommand(guncelle, conn);
            cmd2.ExecuteNonQuery();


            if (DateTime.Parse(dgvtarih.CurrentRow.Cells[1].Value.ToString()) < DateTime.Now)
            {
                string kontrol = "UPDATE [dbo].[uyeler] SET[Ceza_puanı] = [Ceza_puanı] + 10 WHERE ID =" + dgvtarih.CurrentRow.Cells[7].Value;
                SqlCommand cmd3 = new SqlCommand(kontrol, conn);
                cmd3.ExecuteNonQuery();
            }


            string ekle = "set dateformat dmy update Teslim set verilistarihi ='"+DateTime.Now.ToString()+"' WHERE ID=" + dgvtarih.CurrentRow.Cells[8].Value;
            SqlCommand cmd4 = new SqlCommand(ekle, conn);
            cmd4.ExecuteNonQuery();

            conn.Close();

            dgvtarih.DataSource = uye.veriAl("select * from Vwtarih where Verildimi<1 ");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
