using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AidatTakip
{
    public partial class rprGider : Form
    {
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        string ay = DateTime.Now.ToString("MMMM");
        string yıl = DateTime.Now.ToString("yyyy");
        listele b = new listele();
        public static string c = listele.conStr;
        SqlConnection conn = new SqlConnection(c);
        public rprGider()
        {
            InitializeComponent();
        }

        private void rprGider_Load(object sender, EventArgs e)
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


            conn.Close();

            txtAy.Text = ay;
            txtYıl.Text = yıl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt4 = new DataTable();
            string sql4 = "Select * from VwGiderler  WHERE yıl=@yıl and ay=@ay";
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
            da4.SelectCommand.Parameters.AddWithValue("@yıl", txtYıl.Text);
            da4.SelectCommand.Parameters.AddWithValue("@ay", txtAy.Text);
            da4.Fill(dt4);
            dgvGider.DataSource = dt4;
            dgvGider.Columns[4].Visible = false;
            dgvGider.Columns[5].Visible = false;

           

            int satir3 = dgvGider.Rows.Count - 1;
            int tutar3 = 0;
            for (int i = 0; i < satir3; i++)
            {
                tutar3 = tutar3 + Convert.ToInt32(dgvGider.Rows[i].Cells["Gider Tutarı"].Value.ToString());

            }

            dgvGider.Rows[satir3].Cells["Gider Tutarı"].Value = tutar3;
            dgvGider.Rows[satir3].Cells["Gider Açıklama"].Value = "Toplam Tutar";

            conn.Close();



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvGider.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dgvGider.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvGider.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString("Giderler", new Font(dgvGider.Font.FontFamily, 12, FontStyle.Bold),
                                     Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                     e.Graphics.MeasureString("Giderler", new Font(dgvGider.Font.FontFamily, 12, FontStyle.Bold),
                                     e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dgvGider.Font.FontFamily, 10, FontStyle.Bold),
                                     Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                     e.Graphics.MeasureString(strDate, new Font(dgvGider.Font.FontFamily, 10, FontStyle.Bold),
                                     e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                     e.Graphics.MeasureString("Giderler", new Font(dgvGider.Font.FontFamily, 10, FontStyle.Bold),
                                     e.MarginBounds.Width).Height - 13);

                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvGider.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                // Veri hücresi yazı boyutunu küçült
                                e.Graphics.DrawString(Cel.Value.ToString(), new Font(dgvGider.Font.FontFamily, 8),
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvGider.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme2 = new PrintPreviewDialog();
            onizleme2.Document = printDocument1;
            onizleme2.ShowDialog();
        }
    }
}
