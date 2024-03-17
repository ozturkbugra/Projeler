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

namespace AidatTakip
{
    public partial class rprgelirgider : Form
    {
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        string elektrik, su, yonetim, temizlik, bakım, demirbas, maas, ssk, diger, aidat, ek, tahsilat, eskikasa5;

        string yil = DateTime.Now.Date.ToString("yyyy");

        string ay = DateTime.Now.Date.ToString("MMMM");




        public rprgelirgider()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            Rapor a = new Rapor();
            a.lblAy.Text = txtAy.Text + " - " + txtYıl.Text;
            conn.Open();
            string sql6 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='ELEKTRİK'";
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            cmd6.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd6.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                elektrik = dr6[0].ToString();
            }
            conn.Close();
            a.lblElektrik.Text = elektrik;

            conn.Open();
            string sql7 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='SU'";
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            cmd7.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd7.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                su = dr7[0].ToString();
            }
            conn.Close();
            a.lblSu.Text = su;


            conn.Open();
            string sql8 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='YÖNETİM'";
            SqlCommand cmd8 = new SqlCommand(sql8, conn);
            cmd8.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd8.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                yonetim = dr8[0].ToString();
            }
            conn.Close();
            a.lblYonetim.Text = yonetim;

            conn.Open();
            string sql1 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='TEMİZLİK'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd1.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                temizlik = dr1[0].ToString();
            }
            conn.Close();
            a.lblTemizlik.Text = temizlik;

            conn.Open();
            string sql2 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='BAKIM ONARIM'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd2.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                bakım = dr2[0].ToString();
            }
            conn.Close();
            a.lblBakım.Text = bakım;

            conn.Open();
            string sql3 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='DEMİRBAŞ'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd3.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                demirbas = dr3[0].ToString();
            }
            conn.Close();
            a.lblDemirbas.Text = demirbas;

            conn.Open();
            string sql4 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='MAAŞ'";
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            cmd4.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd4.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                maas = dr4[0].ToString();
            }
            conn.Close();
            a.lblMaas.Text = maas;


            conn.Open();
            string sql5 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='SSK'";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            cmd5.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd5.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                ssk = dr5[0].ToString();
            }
            conn.Close();
            a.lblSsk.Text = ssk;

            conn.Open();
            string sql9 = "Select Sum(tutar) from tblGiderler  WHERE yıl=@yıl and ay=@ay and tur='DİĞER'";
            SqlCommand cmd9 = new SqlCommand(sql9, conn);
            cmd9.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd9.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                diger = dr9[0].ToString();
            }
            conn.Close();
            a.lblDiger.Text = diger;

            conn.Open();
            string sql10 = "Select Sum(tutar) from tblMakbuz WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd10 = new SqlCommand(sql10, conn);
            cmd10.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd10.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                aidat = dr10[0].ToString();
            }
            conn.Close();
            a.lblAidat.Text = aidat;

            conn.Open();
            string sql11 = "Select Sum(tutar2) from tblMakbuz WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd11 = new SqlCommand(sql11, conn);
            cmd11.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd11.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr11 = cmd11.ExecuteReader();
            if (dr11.Read())
            {
                if (dr11[0] != DBNull.Value && dr11[0] != null)
                {
                    ek = dr11[0].ToString();
                }
                else
                {
                    ek = "0";
                }


            }
            conn.Close();

            conn.Open();
            string sql12 = "Select Sum(tutar) from tblTahsilat WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd12 = new SqlCommand(sql12, conn);
            cmd12.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd12.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr12 = cmd12.ExecuteReader();
            if (dr12.Read())
            {
                if (dr12[0] != DBNull.Value && dr12[0] != null)
                {
                    tahsilat = dr12[0].ToString();
                }
                else
                {
                    tahsilat = "0";
                }

            }
            conn.Close();

            conn.Open();
            string sql13 = "Select * from Kasa WHERE yıl=@yıl and ay=@ay";
            SqlCommand cmd13 = new SqlCommand(sql13, conn);
            cmd13.Parameters.AddWithValue("@yıl", txtYıl.Text);
            cmd13.Parameters.AddWithValue("@ay", txtAy.Text);
            SqlDataReader dr13 = cmd13.ExecuteReader();
            if (dr13.Read())
            {
                if (dr13[3] != DBNull.Value && dr13[3] != null)
                {
                    eskikasa5 = dr13[3].ToString();
                }
                else
                {
                    eskikasa5 = "0";
                }

            }
            conn.Close();

            int ek2 = Convert.ToInt32(ek) + Convert.ToInt32(tahsilat);
            a.lblDigerGelir.Text = ek2.ToString();

            a.lblEskiKasa.Text = eskikasa5;



            a.ShowDialog();

        }

        private void rprgelirgider_Load(object sender, EventArgs e)
        {
            txtAy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAy.KeyPress += (sender, e) => { e.Handled = true; };

            txtYıl.DropDownStyle = ComboBoxStyle.DropDownList;
            txtYıl.KeyPress += (sender, e) => { e.Handled = true; };

            string query = "SELECT ID, YIL FROM tblYil"; // Veri tabanından veri çekme sorgusu
            string query2 = "SELECT ID, AY FROM tblAylar";
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            adapter.Fill(table);

            txtYıl.DisplayMember = "YIL"; // ComboBox'ta gösterilecek sütun adı
            txtYıl.ValueMember = "YIL"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı

            txtYıl.DataSource = table;

            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();

            adapter2.Fill(table2);

            txtAy.DisplayMember = "AY"; // ComboBox'ta gösterilecek sütun adı
            txtAy.ValueMember = "AY"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı

            txtAy.DataSource = table2;

            txtYıl.Text = yil;
            txtAy.Text = ay;


            conn.Close();
        }

        private void txtEskiKasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }

            if (e.KeyChar == 8) // 8 = Backspace tuşu ASCII değeri
            {
                e.Handled = false; // Backspace tuşuna izin ver
            }
        }
    }
}
