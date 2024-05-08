using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeYazilimi
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YukleDataGridView();
        }
        private void Rapor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void YukleDataGridView()
        {
            var filtrelenmisKelimeler = KelimeDeposu.kelimeListesi.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Türkçe Kelime", typeof(string));
            dt.Columns.Add("İngilizce Karşılığı", typeof(string));
            dt.Columns.Add("Örnek Cümle", typeof(string));
            dt.Columns.Add("Bilinme Sayısı", typeof(int));
            dt.Columns.Add("Yanlış Yapma Sayısı", typeof(int));
            dt.Columns.Add("Sonraki Tekrar Günü", typeof(int));
            foreach (var kelime in filtrelenmisKelimeler)
            {
                dt.Rows.Add(kelime.TurkceKelime, kelime.IngilizceKarsiligi, kelime.OrnekCumle, 
                kelime.BilinmeSeviyesi, kelime.YanlisYapmaSayisi, kelime.SonrakiTekrarGunu);
            }
            dataGridView1.DataSource = dt;
        }
        private int _currentPageIndex = 0;
        private int _rowIndex = 0;
        private int _rowsPerPage = 0;
        private int _totalPages = 0;
        private void YazdirButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
 
      
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Yazdırılacak DataGridView'in başlıklarını çiz
            DrawHeader(e.Graphics);

            // DataGridView içeriğini yazdır
            DrawRows(e.Graphics, e.MarginBounds, e.Graphics.VisibleClipBounds.Height);

            // Bir sonraki sayfa varsa yazdırmaya devam et
            e.HasMorePages = (_currentPageIndex < _totalPages);
        }
        private void DrawHeader(Graphics graphics)
        {
            // DataGridView'in sütun başlıklarını yazdır
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                graphics.DrawString(dataGridView1.Columns[i].HeaderText, dataGridView1.Font, Brushes.Black, new PointF(100 * i, 100));
            }
        }

        private void DrawRows(Graphics graphics, Rectangle marginBounds, float pageHeight)
        {
            // Yazdırılacak satırları say
            int numRows = dataGridView1.Rows.Count;

            // Her sayfada kaç satır gösterileceğini belirle
            int numVisibleRows = (int)Math.Floor(pageHeight / dataGridView1.Rows[0].Height);
            _rowsPerPage = numVisibleRows;

            // Toplam sayfa sayısını belirle
            _totalPages = (int)Math.Ceiling((double)numRows / numVisibleRows);

            // Belirli bir sayfada gösterilecek satır aralığını belirle
            int startIndex = _currentPageIndex * numVisibleRows;
            int endIndex = Math.Min(startIndex + numVisibleRows, numRows) - 1;

            // Belirtilen aralıktaki satırları yazdır
            for (int i = startIndex; i <= endIndex; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    graphics.DrawString(row.Cells[j].Value.ToString(), dataGridView1.Font, Brushes.Black, new PointF(100 * j, 100 + (i - startIndex + 1) * dataGridView1.Rows[0].Height));
                }
            }

            // Bir sonraki sayfa için sayfa indeksini güncelle
            _currentPageIndex++;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            _currentPageIndex = 0;
        }

        private void printPreviewDialog1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // PrintPreviewDialog kapandığında sayfa indeksini sıfırla
            _currentPageIndex = 0;
        }
    }
}
