using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Rectangle = System.Drawing.Rectangle;
using Font = System.Drawing.Font;
using Color = System.Drawing.Color;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace muhasebe
{
    public partial class gelirgidernew : Form
    {
        public static string c = baglan.conStr;
        SqlConnection conn = new SqlConnection(c);
        decimal gider;
        decimal gelir;
        decimal gider2;
        decimal gelir2;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        baglan b = new baglan();
        public gelirgidernew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
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
                    foreach (DataGridViewColumn GridCol in dgvGelir.Columns)
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

                while (iRow <= dgvGelir.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvGelir.Rows[iRow];

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

                            e.Graphics.DrawString("Gelirler", new Font(dgvGelir.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Gelirler", new Font(dgvGelir.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dgvGelir.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvGelir.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Gelirler", new Font(new Font(dgvGelir.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvGelir.Columns)
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
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
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

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in dgvGelir.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
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

                            e.Graphics.DrawString("Giderler", new Font(dgvGider.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Giderler", new Font(dgvGider.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dgvGider.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvGider.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(new Font(dgvGider.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


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
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
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

        private void printDocument2_BeginPrint(object sender, PrintEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public static void PDF_Disa_Aktar(DataGridView dataGridView1)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        public class ComboBoxItem
        {
            public string Value { get; }
            public string DisplayText { get; }

            public ComboBoxItem(string value, string displayText)
            {
                Value = value;
                DisplayText = displayText;
            }
        }
        private void gelirgidernew_Load(object sender, EventArgs e)
        {
            txtYil.SelectedIndex = 0;

            string query = "SELECT AySayi,AyYazi FROM tblAylar order by AySayi asc";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            txtAy.DisplayMember = "AyYazi"; // ComboBox'ta gösterilecek sütun adı
            txtAy.ValueMember = "AySayi"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtAy.DataSource = table;
            txtAy.SelectedIndex = 0;


            string query2 = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            txtKisi.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi.DataSource = table2;
            txtKisi.SelectedIndex = 0;

            string query3 = "SELECT KisiId,AdSoyad FROM tblKisi order by AdSoyad asc";
            SqlDataAdapter adapter3 = new SqlDataAdapter(query3, conn);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            txtKisi2.DisplayMember = "AdSoyad"; // ComboBox'ta gösterilecek sütun adı
            txtKisi2.ValueMember = "KisiId"; // ComboBox'ta seçilen öğenin değerini belirleyen sütun adı
            txtKisi2.DataSource = table3;
            txtKisi2.SelectedIndex = 0;

            dgvGelir.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
            dgvGider.DefaultCellStyle.Font = new Font("Source Sans Pro", 12);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dgvGelir_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dgvGelir);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DateTime bas = dtBas.Value.Date;
            DateTime son = dtSon.Value.Date.AddDays(1).AddSeconds(-1);

            if (txtAktif.Checked)
            {
                DataTable dt = new DataTable();
                string sql = "Select [Açıklama],[Tutar],[Tarih],[Kişi] from ViewGelirler WHERE [Tarih]>=@dtBas and [Tarih]<=@dtSon and [Kişi]='" + txtKisi.Text + "'";

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("dtBas", bas);
                da.SelectCommand.Parameters.AddWithValue("dtSon", son);
                da.Fill(dt);
                conn.Close();

                dgvGelir.DataSource = dt;

                DataTable dt2 = new DataTable();
                string sql2 = "Select [Açıklama],[Sektör Adı],[Tutar],[Tarih],[Kişi] from ViewGiderler Where [Tarih]>= @dtBas and [Tarih]<=@dtSon and [Kişi]='" + txtKisi.Text + "'";

                conn.Open();
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                da2.SelectCommand.Parameters.AddWithValue("dtBas", bas);
                da2.SelectCommand.Parameters.AddWithValue("dtSon", son);
                da2.Fill(dt2);
                conn.Close();

                dgvGider.DataSource = dt2;

                decimal gelir = 0;
                decimal gider = 0;

                conn.Open();
                string sql3 = "Select Sum(Tutar) from ViewGelirler WHERE Tarih>= @dtBas and Tarih<=@dtSon and [Kişi]='" + txtKisi.Text + "'";
                SqlCommand cmd = new SqlCommand(sql3, conn);
                cmd.Parameters.AddWithValue("@dtBas", bas);
                cmd.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gelir = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
                }
                conn.Close();

                conn.Open();
                string sql4 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih>= @dtBas and Tarih<=@dtSon and [Kişi]='" + txtKisi.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql4, conn);
                cmd1.Parameters.AddWithValue("@dtBas", bas);
                cmd1.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr2 = cmd1.ExecuteReader();
                if (dr2.Read())
                {
                    gider = dr2[0] != DBNull.Value ? Convert.ToDecimal(dr2[0]) : 0;
                }
                conn.Close();

                int satir = dgvGelir.Rows.Count - 1;
                double tutar = 0;
                for (int i = 0; i < satir; i++)
                {
                    tutar = tutar + Double.Parse(dgvGelir.Rows[i].Cells["Tutar"].Value.ToString());
                }

                dgvGelir.Rows[satir].Cells["Tutar"].Value = tutar;
                dgvGelir.Rows[satir].Cells["Açıklama"].Value = "Toplam Tutar";

                int satir2 = dgvGider.Rows.Count - 1;
                double tutar2 = 0;
                for (int i = 0; i < satir2; i++)
                {
                    tutar2 = tutar2 + Double.Parse(dgvGider.Rows[i].Cells["Tutar"].Value.ToString());
                }

                dgvGider.Rows[satir2].Cells["Tutar"].Value = tutar2;
                dgvGider.Rows[satir2].Cells["Sektör Adı"].Value = "Toplam Tutar";

                if (lblGelir.Text == "")
                {
                    lblGelir.Text = "0";
                }

                if (lblGider.Text == "")
                {
                    lblGider.Text = "0";
                }

                lblGelir.Text = gelir.ToString();
                lblGider.Text = gider.ToString();

                decimal toplam = gelir - gider;
                lblKasa.Text = toplam.ToString();

                if (Double.Parse(lblKasa.Text) > 0)
                {
                    lblKasa.ForeColor = Color.Green;
                    MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
                }
                else if (Double.Parse(lblKasa.Text) < 0)
                {
                    lblKasa.ForeColor = Color.Red;
                    MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
                }
                else if (Double.Parse(lblKasa.Text) == 0)
                {
                    lblKasa.ForeColor = Color.Black;
                }

            }
            else
            {
                DataTable dt = new DataTable();
                string sql = "Select [Açıklama],[Tutar],[Tarih],[Kişi] from ViewGelirler WHERE [Tarih]>=@dtBas and [Tarih]<=@dtSon";

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("dtBas", bas);
                da.SelectCommand.Parameters.AddWithValue("dtSon", son);
                da.Fill(dt);
                conn.Close();

                dgvGelir.DataSource = dt;

                DataTable dt2 = new DataTable();
                string sql2 = "Select [Açıklama],[Sektör Adı],[Tutar],[Tarih],[Kişi] from ViewGiderler Where [Tarih]>= @dtBas and [Tarih]<=@dtSon";

                conn.Open();
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                da2.SelectCommand.Parameters.AddWithValue("dtBas", bas);
                da2.SelectCommand.Parameters.AddWithValue("dtSon", son);
                da2.Fill(dt2);
                conn.Close();

                dgvGider.DataSource = dt2;

                decimal gelir = 0;
                decimal gider = 0;

                conn.Open();
                string sql3 = "Select Sum(Tutar) from ViewGelirler WHERE Tarih>= @dtBas and Tarih<=@dtSon";
                SqlCommand cmd = new SqlCommand(sql3, conn);
                cmd.Parameters.AddWithValue("@dtBas", bas);
                cmd.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gelir = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
                }
                conn.Close();

                conn.Open();
                string sql4 = "Select Sum(Tutar) from ViewGiderler WHERE Tarih>= @dtBas and Tarih<=@dtSon";
                SqlCommand cmd1 = new SqlCommand(sql4, conn);
                cmd1.Parameters.AddWithValue("@dtBas", bas);
                cmd1.Parameters.AddWithValue("@dtSon", son);
                SqlDataReader dr2 = cmd1.ExecuteReader();
                if (dr2.Read())
                {
                    gider = dr2[0] != DBNull.Value ? Convert.ToDecimal(dr2[0]) : 0;
                }
                conn.Close();

                int satir = dgvGelir.Rows.Count - 1;
                double tutar = 0;
                for (int i = 0; i < satir; i++)
                {
                    tutar = tutar + Double.Parse(dgvGelir.Rows[i].Cells["Tutar"].Value.ToString());
                }

                dgvGelir.Rows[satir].Cells["Tutar"].Value = tutar;
                dgvGelir.Rows[satir].Cells["Açıklama"].Value = "Toplam Tutar";

                int satir2 = dgvGider.Rows.Count - 1;
                double tutar2 = 0;
                for (int i = 0; i < satir2; i++)
                {
                    tutar2 = tutar2 + Double.Parse(dgvGider.Rows[i].Cells["Tutar"].Value.ToString());
                }

                dgvGider.Rows[satir2].Cells["Tutar"].Value = tutar2;
                dgvGider.Rows[satir2].Cells["Sektör Adı"].Value = "Toplam Tutar";

                if (lblGelir.Text == "")
                {
                    lblGelir.Text = "0";
                }

                if (lblGider.Text == "")
                {
                    lblGider.Text = "0";
                }

                lblGelir.Text = gelir.ToString();
                lblGider.Text = gider.ToString();

                decimal toplam = gelir - gider;
                lblKasa.Text = toplam.ToString();

                if (Double.Parse(lblKasa.Text) > 0)
                {
                    lblKasa.ForeColor = Color.Green;
                    MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
                }
                else if (Double.Parse(lblKasa.Text) < 0)
                {
                    lblKasa.ForeColor = Color.Red;
                    MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
                }
                else if (Double.Parse(lblKasa.Text) == 0)
                {
                    lblKasa.ForeColor = Color.Black;
                }
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dgvGider);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme2 = new PrintPreviewDialog();
            onizleme2.Document = printDocument2;
            onizleme2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {



            DataTable dt = new DataTable();
            string sql = "Select [Açıklama],[Tutar],[Tarih],[Kişi],[Ay],[Yil] from ViewGelirler WHERE [Kişi]='" + txtKisi2.Text + "' and [Ay]='" + txtAy.SelectedValue + "' and [Yil]='" + txtYil.Text + "'";

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();

            dgvGelir2.DataSource = dt;
            dgvGelir2.Columns["Ay"].Visible = false;
            dgvGelir2.Columns["Yil"].Visible = false;
            DataTable dt2 = new DataTable();
            string sql2 = "SELECT [Kişi],[Sektör Adı],[Ay],[Yil], SUM([Tutar]) AS 'Toplam Tutar' FROM [ViewGiderler] GROUP BY [Kişi],[Sektör Adı],[Ay],[Yil] Having  [Kişi]='" + txtKisi2.Text + "' and [Ay]='" + txtAy.SelectedValue + "' and [Yil]='" + txtYil.Text + "'";

            conn.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.Fill(dt2);
            conn.Close();

            dgvGider2.DataSource = dt2;
            dgvGider2.Columns["Ay"].Visible = false;
            dgvGider2.Columns["Yil"].Visible = false;


            decimal gelir = 0;
            decimal gider = 0;

            conn.Open();
            string sql3 = "Select Sum(Tutar) from ViewGelirler WHERE  [Kişi]='" + txtKisi2.Text + "' and [Ay]='" + txtAy.SelectedValue + "' and [Yil]='" + txtYil.Text + "'";
            SqlCommand cmd = new SqlCommand(sql3, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gelir = dr[0] != DBNull.Value ? Convert.ToDecimal(dr[0]) : 0;
            }
            conn.Close();

            conn.Open();
            string sql4 = "Select Sum(Tutar) from ViewGiderler WHERE [Kişi]='" + txtKisi2.Text + "' and [Ay]='" + txtAy.SelectedValue + "' and [Yil]='" + txtYil.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql4, conn);

            SqlDataReader dr2 = cmd1.ExecuteReader();
            if (dr2.Read())
            {
                gider = dr2[0] != DBNull.Value ? Convert.ToDecimal(dr2[0]) : 0;
            }
            conn.Close();


            if (lblGelir2.Text == "")
            {
                lblGelir2.Text = "0";
            }

            if (lblGider2.Text == "")
            {
                lblGider2.Text = "0";
            }

            lblGelir2.Text = gelir.ToString();
            lblGider2.Text = gider.ToString();

            decimal toplam = gelir - gider;
            lblKasa2.Text = toplam.ToString();

            if (Double.Parse(lblKasa2.Text) > 0)
            {
                lblKasa.ForeColor = Color.Green;
                MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
            }
            else if (Double.Parse(lblKasa2.Text) < 0)
            {
                lblKasa.ForeColor = Color.Red;
                MessageBox.Show(dtBas.Value + " Tarihi ile " + dtSon.Value + " tarihi arası kasa durumunuz hesaplanmıştır");
            }
            else if (Double.Parse(lblKasa2.Text) == 0)
            {
                lblKasa.ForeColor = Color.Black;
            }


        }
    }
}
