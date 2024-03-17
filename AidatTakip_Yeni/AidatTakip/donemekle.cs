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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AidatTakip
{
    public partial class donemekle : Form
    {
        listele b = new listele();
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        int daire;
        int aidat;
        int ek;
        int zam;
        int aidat2;
        string aidat1, ek1, gider1, tahsilat1;
        int durum;
        public donemekle()
        {
            InitializeComponent();
        }


        private void donemekle_Load(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd99 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd99.Parameters.AddWithValue("@veri2", 10);
            SqlDataReader dr99 = cmd99.ExecuteReader();
            if (dr99.Read())
            {
                zam = Convert.ToInt32(dr99[2]);
                txtZam.Text = dr99[2].ToString();
            }
            conn.Close();


            conn.Open();
            SqlCommand cmd10 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd10.Parameters.AddWithValue("@veri2", 8);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                aidat2 = Convert.ToInt32(dr10[2]);
            }
            conn.Close();


            txtAy.Enabled = false;
            txtYıl.Enabled = false;
            txtZam.Enabled = false;

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

            txtAy.DataSource = table2; // Combo


            conn.Close();




            conn.Open();



            //toplam daire numarasını alıp daire adlı değişkene atıyoruz
            SqlCommand cmd9 = new SqlCommand("select count(No) from tblSakinler", conn);
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                daire = Convert.ToInt32(dr9[0].ToString());
            }
            conn.Close();

            txtYıl.Text = DateTime.Now.ToString("yyyy");
            txtAy.Text = DateTime.Now.ToString("MMMMM");

            //burada veri tabanından aidat ve ek ücretlerini çekiyoruz.
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd1.Parameters.AddWithValue("@veri2", 8);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                txtAidat.Text = dr[2].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from tblSabit where ID=@veri2", conn);
            cmd2.Parameters.AddWithValue("@veri2", 9);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txtEk.Text = dr2[2].ToString();
            }
            conn.Close();
        }

        private void txtAidat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtEk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        public void ekle(int daireNo)
        {
            //ekleme fonksiyonu bütün dairelere aidat ekliyoruz 
            conn.Open();
            string güncelle = "Update tblSakinler set borc= borc + " + Convert.ToInt32(txtAidat.Text) + " where No= '" + daireNo + "'";
            SqlCommand cmd = new SqlCommand(güncelle, conn);
            cmd.ExecuteNonQuery();

            string ekle = "INSERT INTO tblAidat(aidatAdi, aidatYili, tutar, daireNo) values (@aidatAdi, @aidatYili, @tutar, @daireNo) ";
            SqlCommand cmd1 = new SqlCommand(ekle, conn);
            cmd1.Parameters.AddWithValue("@aidatAdi", txtAy.Text);
            cmd1.Parameters.AddWithValue("@aidatYili", txtYıl.Text);
            cmd1.Parameters.AddWithValue("@tutar", txtAidat.Text);
            cmd1.Parameters.AddWithValue("@daireNo", daireNo);
            cmd1.ExecuteNonQuery();
            conn.Close();

        }
        public void ekle2(int daireNo)
        {
            conn.Open();
            string güncelle = "Update tblSakinler set borc= borc + " + Convert.ToInt32(txtEk.Text) + " where No= '" + daireNo + "'";
            SqlCommand cmd = new SqlCommand(güncelle, conn);
            cmd.ExecuteNonQuery();

            string ekle = "INSERT INTO tblEk(ekAyi, ekYili, tutar, daireNo) values (@ekAyi, @ekYili, @tutar, @daireNo) ";
            SqlCommand cmd1 = new SqlCommand(ekle, conn);
            cmd1.Parameters.AddWithValue("@ekAyi", txtAy.Text);
            cmd1.Parameters.AddWithValue("@ekYili", txtYıl.Text);
            cmd1.Parameters.AddWithValue("@tutar", txtEk.Text);
            cmd1.Parameters.AddWithValue("@daireNo", daireNo);
            cmd1.ExecuteNonQuery();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.lblAidat.Text = "1";

            string sql1905 = "select count(*) from tblAidat where bitti=0 and tutar =" + aidat2 + "";
            conn.Open();
            SqlCommand cmd1905 = new SqlCommand(sql1905, conn);
            SqlDataReader dr1905 = cmd1905.ExecuteReader();
            if (dr1905.Read())
            {
                durum = Convert.ToInt32(dr1905[0]);
            }
            conn.Close();

            if (durum >= 1)
            {
                MessageBox.Show("Aidatını ödemeyen bazı dairelere gecikme zammı eklemediniz. Lütfen ekleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                borcartis ba = new borcartis();
                ba.ShowDialog();
                ba.Dispose();
                string sql19051 = "select count(*) from tblAidat where bitti=0 and tutar =" + aidat2 + "";
                conn.Open();
                SqlCommand cmd19051 = new SqlCommand(sql19051, conn);
                SqlDataReader dr19051 = cmd19051.ExecuteReader();
                if (dr19051.Read())
                {
                    durum = Convert.ToInt32(dr19051[0]);
                }
                conn.Close();
            }
            else
            {

                //aynı aidatı tekrar eklememek için kontrol yapıyoruz
                conn.Open();
                SqlCommand cmd10 = new SqlCommand("Select * from tblAidat Where aidatAdi= '" + txtAy.Text + "' and aidatYili= '" + txtYıl.Text + "' ", conn);
                SqlDataReader dr10 = cmd10.ExecuteReader();
                if (dr10.Read())
                {
                    aidat = 1;
                }
                else
                {
                    aidat = 0;
                }

                conn.Close();
                if (txtAidat.Text == "")
                {

                    MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (aidat == 1)
                    {
                        MessageBox.Show("Bu ayın aidatını eklediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult cevap = new DialogResult();
                        cevap = MessageBox.Show("Dönemi eklemek İstiyor musunuz?", "Dönem ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //burada eğer cevap 0 ise daire no kadar bütün dairelere aidat ekliyor
                        if (cevap == DialogResult.Yes)
                        {
                            for (int i = 1; i <= daire; i++)
                            {
                                ekle(i);
                            }

                            conn.Open();
                            string sql3 = "Select Sum(tutar) from tblAidat WHERE bitti=1";
                            SqlCommand cmd = new SqlCommand(sql3, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                aidat1 = dr[0].ToString();
                            }
                            conn.Close();

                            //alınan eklerin hesaplanması ve griedviewe aktarma
                            conn.Open();
                            string sql4 = "Select Sum(tutar) from tblEk WHERE bitti=1";
                            SqlCommand cmd1 = new SqlCommand(sql4, conn);
                            SqlDataReader dr2 = cmd1.ExecuteReader();
                            if (dr2.Read())
                            {
                                ek1 = dr2[0].ToString();

                            }
                            conn.Close();

                            //alınan tahsilatların hesaplanması ve griedviewe aktarma
                            conn.Open();
                            string sql5 = "Select Sum(tutar) from tblTahsilat";
                            SqlCommand cmd2 = new SqlCommand(sql5, conn);
                            SqlDataReader dr3 = cmd2.ExecuteReader();
                            if (dr3.Read())
                            {
                                tahsilat1 = dr3[0].ToString();

                            }
                            conn.Close();

                            //verilen giderlerin hesaplanması ve griedviewe aktarılması
                            conn.Open();
                            string sql6 = "Select Sum(tutar) from tblGiderler";
                            SqlCommand cmd3 = new SqlCommand(sql6, conn);
                            SqlDataReader dr4 = cmd3.ExecuteReader();
                            if (dr4.Read())
                            {
                                gider1 = dr4[0].ToString();

                            }
                            conn.Close();

                            int gider = Convert.ToInt32(gider1);
                            int aidat = Convert.ToInt32(aidat1);
                            int tahsilat = Convert.ToInt32(tahsilat1);
                            int ek = Convert.ToInt32(ek1);
                            int eski = 45996;
                            int toplamgelir = aidat + tahsilat + ek + eski;

                            int toplam = toplamgelir - gider;

                            conn.Open();
                            string sql31 = "INSERT INTO Kasa (ay, yıl, tutar) values (@ay, @yıl, @tutar) ";
                            SqlCommand cmd31 = new SqlCommand(sql31, conn);
                            cmd31.Parameters.AddWithValue("@ay", txtAy.Text);
                            cmd31.Parameters.AddWithValue("@yıl", txtYıl.Text);
                            cmd31.Parameters.AddWithValue("@tutar", toplam.ToString());
                            cmd31.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show(txtAy.Text + " dönemi başarıyla eklendi", "İşlem Başarılı");
                        }
                    }
                }





            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd10 = new SqlCommand("Select * from tblEk Where ekAyi= '" + txtAy.Text + "' and ekYili= '" + txtYıl.Text + "' ", conn);
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                ek = 1;
            }
            else
            {
                ek = 0;
            }
            conn.Close();
            if (txtEk.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ek == 1)
                {
                    MessageBox.Show("Bu ayın EK'ini zaten eklediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult cevap = new DialogResult();
                    cevap = MessageBox.Show("Dönemi eklemek İstiyor musunuz?", "Dönem ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.Yes)
                    {
                        for (int i = 1; i <= daire; i++)
                        {
                            ekle2(i);
                        }
                        MessageBox.Show(txtAy.Text + " dönemi (EK) başarıyla eklendi", "İşlem Başarılı");
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAy.Enabled = true;
            txtYıl.Enabled = true;

            // this.Hide();
            // güvenlik a = new güvenlik();
            // a.ShowDialog();
            // a.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAidat.Enabled = true;
            txtEk.Enabled = true;
            txtZam.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //burası aidat güncelleme kısmı
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update tblSabit set tutar=@tutar where ID=8";
            cmd.Parameters.AddWithValue("@tutar", txtAidat.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd1 = new SqlCommand();
            conn.Open();
            cmd1.Connection = conn;
            cmd1.CommandText = "update tblSabit set tutar=@tutar where ID=9";
            cmd1.Parameters.AddWithValue("@tutar", txtEk.Text);
            cmd1.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd2 = new SqlCommand();
            conn.Open();
            cmd2.Connection = conn;
            cmd2.CommandText = "update tblSabit set tutar=@tutar where ID=10";
            cmd2.Parameters.AddWithValue("@tutar", txtZam.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();

            txtAidat.Enabled = false;
            txtEk.Enabled = false;
            txtZam.Enabled = false;
        }

        private void txtYıl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
