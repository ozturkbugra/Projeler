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
    public partial class makbuzara : Form
    {
        string o;
        listele b = new listele();
        public static string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=apartman;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        public makbuzara()
        {
            InitializeComponent();
        }

        private void makbuzara_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rdMakNo.Checked)
            {
                if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }
                else {
                    dgvMakbuz.DataSource = b.veriAl("Select * from VwMakbuz WHERE [Makbuz No] = '" + txtAra.Text + "'");
                    conn.Open();
                    string sql = "select * from tblSakinler where No ='" + dgvMakbuz.CurrentRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        o = dr[5].ToString();
                    }
                    conn.Close();
                }
                
                
            }
            if (rbDaireNo.Checked)
            {
                if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }
                else
                {
                    dgvMakbuz.DataSource = b.veriAl("SELECT * FROM VwMakbuz WHERE [Daire No] = '" + txtAra.Text + "'");
                    conn.Open();
                    string sql = "select * from tblSakinler where No ='" + txtAra.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        o = dr[5].ToString();
                    }
                    conn.Close();
                }
                
                

            }
            if (rdGider.Checked)
            {
                if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }
                else {
                    dgvMakbuz.DataSource = b.veriAl("Select * from VwGiderler WHERE [Gider No] = '" + txtAra.Text + "'");
                } 
               
            }
            if (rdTahsilat.Checked)
            {
                if (txtAra.Text == "")
                {
                    MessageBox.Show("Lütfen arama yerini boş bırakmayın");
                }

                else
                {
                    dgvMakbuz.DataSource = b.veriAl("Select * from VwTahsilat WHERE [Tahsilat No] = '" + txtAra.Text + "'");

                }


            }
            if (!rdMakNo.Checked && !rbDaireNo.Checked && !rdGider.Checked && !rdTahsilat.Checked)
            {
                MessageBox.Show("Lütfen arama yapmak için gerekli yeri seçin");
     
            }
            
        }

        private void dgvMakbuz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdGider.Checked)
            {
                gidermakbuz g = new gidermakbuz();
                g.lblGiderAciklama.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                g.lblMakNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                g.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                g.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString();
                g.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString();
                g.lblTutar2.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString();
                g.ShowDialog();
                g.Dispose();
            }
            
            if (rdMakNo.Checked)
            {
                if (dgvMakbuz.CurrentRow.Cells[6].Value.ToString() == "")
                {
                    aidatmakbuz a = new aidatmakbuz();
                    a.lblAidatAdi.Text = dgvMakbuz.CurrentRow.Cells[4].Value.ToString();
                    a.lblAd.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString() + " " + dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                    a.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[5].Value.ToString();
                    a.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[5].Value.ToString();
                    a.lblMakNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                    a.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[8].Value.ToString();
                    a.lblDaireNo.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                    a.lblBorc.Text = o;
                    a.ShowDialog();
                    a.Dispose();
                }
                else
                {
                    ekmakbuz f = new ekmakbuz();
                    f.lblEkAdi.Text = dgvMakbuz.CurrentRow.Cells[6].Value.ToString();
                    f.lblAd.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString() + " " + dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                    f.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[7].Value.ToString();
                    f.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[7].Value.ToString();
                    f.lblMakNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                    f.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[8].Value.ToString();
                    f.lblDaireNo.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                    f.lblBorc.Text = o;
                    f.ShowDialog();
                }
            }

            if (rbDaireNo.Checked)
            {
                if (dgvMakbuz.CurrentRow.Cells[6].Value.ToString() == "")
                {
                    aidatmakbuz a = new aidatmakbuz();
                    a.lblAidatAdi.Text = dgvMakbuz.CurrentRow.Cells[4].Value.ToString();
                    a.lblAd.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString() + " " + dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                    a.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[5].Value.ToString();
                    a.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[5].Value.ToString();
                    a.lblMakNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                    a.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[8].Value.ToString();
                    a.lblDaireNo.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                    a.lblBorc.Text = o;
                    a.ShowDialog();
                    a.Dispose();
                }
                else
                {
                    ekmakbuz f = new ekmakbuz();
                    f.lblEkAdi.Text = dgvMakbuz.CurrentRow.Cells[6].Value.ToString();
                    f.lblAd.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString() + " " + dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                    f.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[7].Value.ToString();
                    f.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[7].Value.ToString();
                    f.lblMakNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                    f.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[8].Value.ToString();
                    f.lblDaireNo.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                    f.lblBorc.Text = o;
                    f.ShowDialog();
                }
            }

            if (rdTahsilat.Checked)
            {
                tahsilatmakbuz t = new tahsilatmakbuz();
                t.lblTahsilatAciklama.Text = dgvMakbuz.CurrentRow.Cells[1].Value.ToString();
                t.lblTahsilatNo.Text = dgvMakbuz.CurrentRow.Cells[0].Value.ToString();
                t.lblTarih.Text = dgvMakbuz.CurrentRow.Cells[3].Value.ToString();
                t.lblToplam.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString();
                t.lblTutar.Text = dgvMakbuz.CurrentRow.Cells[2].Value.ToString();
                t.ShowDialog();
                t.Dispose();
            }

        }
    }
}
