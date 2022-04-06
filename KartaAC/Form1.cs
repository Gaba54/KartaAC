using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace KartaAC
{
    public partial class Form1 : Form
    {
        public enum EWhatChart
        {
            ChartX,
            ChartY,
            ChartXY,
            Empty
        };

        string nameChart = string.Empty;

        CsvLoading csvLoading = null;
        string pathFiles = string.Empty;
        List<string> listFileds = null;
        EWhatChart whatChart = EWhatChart.Empty;

        DataGridView data = new DataGridView();
        DataTable table = new DataTable();

        public Form1()
        {

            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            //csvLoading = new CsvLoading(@"D:/danectp/dane1.csv");
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = diag.SelectedPath;
                pathFiles = diag.SelectedPath;
                string sourceEnvoa = diag.SelectedPath;
                DirectoryInfo fieldE = new DirectoryInfo(sourceEnvoa);
                listFileds = new List<string>();
                var fieldsE = fieldE.GetFiles("*.*");
                foreach (var field in fieldsE)
                {
                    listFileds.Add(field.Name);

                }
                comboBox1.DataSource = listFileds;
            }
            else
            {
                MessageBox.Show("You didn't selecet the folder!");
            }
            csvLoading = new CsvLoading(pathFiles + @"\" + listFileds.First());
            LoadingData();


        }

        private void LoadingData()
        {


            data.Location = new Point(0, 0);
            data.Size = new Size(900, 962);
            data.BackgroundColor = Color.White;
            data.Font = new System.Drawing.Font("Times New Roman", 10.0f);
            data.AutoResizeColumns();

            data.DataSource = csvLoading.listData;
            tabPage1.Controls.Add(data);
        }
        private void ChanegRangeX_Click(object sender, EventArgs e)
        {

            double maxX = double.Parse(textBoxMaxX.Text.Replace('.', ','));
            double minX = double.Parse(textBoxMinX.Text.Replace('.', ','));

            chart2.ChartAreas[0].AxisX.Maximum = maxX;
            chart2.ChartAreas[0].AxisX.Minimum = minX;


        }

        private void GenerateChart_Click(object sender, EventArgs e)
        {
            whatChart = EWhatChart.ChartXY;
            table.Columns.Clear();

            //Adding file cvs to datatable 
            table.Columns.Add("Time");
            table.Columns.Add("X");
            table.Columns.Add("Y");
            foreach (var item in csvLoading.listData)
            {
                var row = table.NewRow();
                row["Time"] = item.Time;
                row["X"] = item.X;
                row["Y"] = item.Y;

                table.Rows.Add(row);

            }
            chart2.DataSource = table;

            chart2.Series.Clear();

            chart2.Series.Add("X");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.Blue;

            chart2.Series.Add("Y");
            chart2.Series[1].ChartType = SeriesChartType.Line;
            chart2.Series[1].Color = Color.Orange;



            //chart2.Series["X"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "X");
            //chart2.Series["Y"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "Y");

            foreach (RowDataDecimal x in csvLoading.listData)
            {
                chart2.Series["X"].Points.AddXY(x.Time, x.X);
                chart2.Series["Y"].Points.AddXY(x.Time, x.Y);
            }


            //chart2.Series["X"].Points.AddY(csvLoading.listData.Select(x => x.X).ToArray());


            //chart2.DataBind();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ChanegRangeY_Click(object sender, EventArgs e)
        {

            double maxY = double.Parse(textBoxMaxY.Text.Replace('.', ','));
            double minY = double.Parse(textBoxMinY.Text.Replace('.', ','));

            chart2.ChartAreas[0].AxisY.Maximum = maxY;
            chart2.ChartAreas[0].AxisY.Minimum = minY;

        }

        private void PlotY_Click(object sender, EventArgs e)
        {
            whatChart = EWhatChart.ChartY;
            chart2.Series.Clear();
            chart2.Series.Add("OnlyY");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.Green;
            foreach (RowDataDecimal x in csvLoading.listData)
            {
                chart2.Series["OnlyY"].Points.AddXY(x.Time, x.Y);
            }

        }

        private void PlotX_Click(object sender, EventArgs e)
        {
            whatChart = EWhatChart.ChartX;
            chart2.Series.Clear();
            chart2.Series.Add("OnlyX");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.Red;
            foreach (RowDataDecimal x in csvLoading.listData)
            {
                chart2.Series["OnlyX"].Points.AddXY(x.Time, x.X);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            csvLoading = new CsvLoading(pathFiles + @"\" + comboBox1.SelectedValue);
            LoadingData();
        }

        private void ChartScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ExportToPDF_Click_1(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(data.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in data.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in data.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            //dodawanie wykresu
                            var chartimage = new MemoryStream();
                            chart2.SaveImage(chartimage, ChartImageFormat.Png);
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

        private void ChartScroll_ValueChanged(object sender, EventArgs e)
        {
            //    List<double> a = csvLoading.listData.Select(x => double.Parse(x.Time)).ToList();
            //    //List<double> b = csvLoading.listData.Select(x => double.Parse(x.Y)).ToList();
            //    //MessageBox.Show(((int)a.Max()).ToString());
            //    ChartScroll.Maximum = (int)a.Max();
            //    chart2.ChartAreas[0].AxisX.Maximum = ChartScroll.Value + 20;
            //    chart2.ChartAreas[0].AxisX.Minimum = ChartScroll.Value - 20;
        }
        RowDataDecimal p = null;
        double x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p == null)
                p = csvLoading.listData.First();
            else if (csvLoading.listData.IndexOf(p) < csvLoading.listData.Count())
                p = csvLoading.listData[csvLoading.listData.IndexOf(p) + 1];
            else
                timer1.Stop();


            switch (whatChart)
            {
                case EWhatChart.ChartXY:
                    chart2.Series[0].Points.AddXY(p.Time, p.X);
                    chart2.Series[1].Points.AddXY(p.Time, p.Y);
                    chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[0].Points[0].XValue;
                    chart2.ChartAreas[0].AxisX.Maximum = p.Time;
                    chart2.ChartAreas[0].AxisY.Maximum = csvLoading.listData.Select(x => x.X).Max();
                    chart2.ChartAreas[0].AxisY.Minimum = csvLoading.listData.Select(x => x.X).Min();

                    break;
                case EWhatChart.ChartX:
                    chart2.Series[0].Points.AddXY(p.Time, p.X);
                    chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[0].Points[0].XValue;
                    chart2.ChartAreas[0].AxisX.Maximum = p.Time;
                    chart2.ChartAreas[0].AxisY.Maximum = csvLoading.listData.Select(x => x.X).Max();
                    chart2.ChartAreas[0].AxisY.Minimum = csvLoading.listData.Select(x => x.X).Min();
                    break;

                case EWhatChart.ChartY:
                    chart2.Series[0].Points.AddXY(p.Time, p.Y);
                    chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[0].Points[0].XValue;
                    chart2.ChartAreas[0].AxisX.Maximum = p.Time;
                    chart2.ChartAreas[0].AxisY.Maximum = csvLoading.listData.Select(x => x.Y).Max();
                    chart2.ChartAreas[0].AxisY.Minimum = csvLoading.listData.Select(x => x.Y).Min();
                    break;
                case EWhatChart.Empty:

                    break;

            }

            if (chart2.Series[0].Points.Count > 500)
                chart2.Series[0].Points.RemoveAt(0);


            /*chart2.Series[0].Points.AddXY(x, 3 * System.Math.Sin(5 * x) + 5 * System.Math.Cos(3 * x));

            

            
            x += 0.1;*/


        }

        private void buttonXY_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else
            {

                chart2.Series.Clear();
                switch (whatChart)
                {
                    case EWhatChart.ChartXY:
                        chart2.Series.Add("X");
                        chart2.Series[0].ChartType = SeriesChartType.Line;
                        chart2.Series[0].Color = Color.Blue;

                        chart2.Series.Add("Y");
                        chart2.Series[1].ChartType = SeriesChartType.Line;
                        chart2.Series[1].Color = Color.Orange;
                        break;
                    case EWhatChart.ChartX:
                        chart2.Series.Add("OnlyX");
                        chart2.Series[0].ChartType = SeriesChartType.Line;
                        chart2.Series[0].Color = Color.Red;
                        //chart2.ChartAreas[0].AxisX.Maximum = csvLoading.listData.First().X+0.00001;
                        //chart2.ChartAreas[0].AxisX.Minimum = csvLoading.listData.Select(x => x.X).Min();
                        break;

                    case EWhatChart.ChartY:
                        chart2.Series.Add("OnlyY");
                        chart2.Series[0].ChartType = SeriesChartType.Line;
                        chart2.Series[0].Color = Color.Green;
                        break;
                    case EWhatChart.Empty:
                        MessageBox.Show("Wygeneruj najpierw wykres :D");
                        break;

                }
                timer1.Start();
            }

        }
    }
}

