using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KartaAC.Forms
{
    public partial class FormViewTable : Form
    {
        private DataGridView sheetData;
        private Chart mainChart;
        private FormChart formChart;
        public Panel SheetPanel { get { return tpData; } }
        public FormViewTable(FormChart form)
        {
            InitializeComponent();
            formChart = form;
            sheetData = formChart.Data;
            mainChart = formChart.Chart;
            tpData.Controls.Add(sheetData);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            exportToPDF();
        }

        private void exportToPDF() 
        {
            if (sheetData.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Nie można zapisać pliku" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(sheetData.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in sheetData.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in sheetData.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            //dodawanie wykresu
                            var chartimage = new MemoryStream();
                            mainChart.SaveImage(chartimage, ChartImageFormat.Png);
                            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());



                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Add(Chart_image);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Zapis do pliku zakończony sukcesem", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error podczas eksportu danych" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie znalezniono rekordu", "Info");
            }
        }
    }
}
