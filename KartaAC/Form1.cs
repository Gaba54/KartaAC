using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace KartaAC
{
    public partial class Form1 : Form
    {
        CsvLoading csvLoading = null;
        string pathFiles = string.Empty;
        List<string> listFileds = null;

        public Form1()
        {
            
            InitializeComponent();      
           csvLoading = new CsvLoading(@"D:/danectp/dane1.csv");
        }

        DataGridView data = new DataGridView();
        DataTable table = new DataTable();


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
            data.Font = new Font("Times New Roman", 10.0f);
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

            chart2.Series["X"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "X");
            chart2.Series["Y"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "Y");
            
            
            chart2.DataBind();
          
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
            chart2.Series.Clear();
            chart2.Series.Add("OnlyY");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.Green;
            chart2.Series["OnlyY"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "Y");

        }

        private void PlotX_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Series.Add("OnlyX");
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].Color = Color.Red;
            chart2.Series["OnlyX"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "X");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            csvLoading = new CsvLoading(pathFiles + @"\" + comboBox1.SelectedValue);
            LoadingData();
        }

        private void ChartScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ExportToPDF_Click(object sender, EventArgs e)
        {
            
            //string fileName = "Output.pdf";
            //string filePath = "C://Users//Laptop//Desktop//Dane";
            //if (!Directory.Exists(filePath))
            //{
            //    Directory.CreateDirectory(filePath);
            //}
            

        }

 
        private void ChartScroll_ValueChanged(object sender, EventArgs e)
        {
            List<double> a = csvLoading.listData.Select(x => double.Parse(x.Time)).ToList();
            //List<double> b = csvLoading.listData.Select(x => double.Parse(x.Y)).ToList();
            //MessageBox.Show(((int)a.Max()).ToString());
            ChartScroll.Maximum = (int)a.Max();
            chart2.ChartAreas[0].AxisX.Maximum = ChartScroll.Value + 20;
            chart2.ChartAreas[0].AxisX.Minimum = ChartScroll.Value - 20;
        }


    }
}
