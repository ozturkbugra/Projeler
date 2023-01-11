using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneotomasyon
{
    public partial class liste2 : Form
    {
        uye cagir = new uye();
        public liste2()
        {
            InitializeComponent();
        }

        private void liste2_Load(object sender, EventArgs e)
        {
            dgvtarih.DataSource = cagir.veriAl("Select * from Vwtarih3 where Verildimi=0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
