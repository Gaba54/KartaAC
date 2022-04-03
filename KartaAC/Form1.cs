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
        public Form1()
        {
            
            InitializeComponent();      
            csvLoading = new CsvLoading(@"C:/Users/Laptop/Downloads/dane1.csv");
        }

        DataGridView data = new DataGridView();
        DataTable table = new DataTable();


        private void OpenFile_Click(object sender, EventArgs e)
        {

            data.Location = new Point(0, 0);
            data.Size = new Size(900, 962);
            data.BackgroundColor = Color.White;
            data.Font = new Font("Times New Roman", 10.0f);
            data.AutoResizeColumns();

            data.DataSource = csvLoading.listData;
            tabPage1.Controls.Add(data);


        }
        private void ChanegRange_Click(object sender, EventArgs e)
        {
            double max = Double.Parse(textBoxMax.Text);
            double min = Double.Parse(textBoxMin.Text);

            chart2.ChartAreas[0].AxisY.Maximum = max;
            chart2.ChartAreas[0].AxisY.Minimum = min;


            //double x;

            //if (Double.TryParse(this.textBoxMax.Text, out x))
            //{        
            //    chart2.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(this.textBoxMax.Text);

            //}

            //double y;

            //if (Double.TryParse(this.textBoxMax.Text, out y) && y > chart2.ChartAreas[0].AxisX.Minimum)
            //{
            //    chart2.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(this.textBoxMin.Text);

            //}


        }

        private void GenerateChart_Click(object sender, EventArgs e)
        {
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

            chart2.Series["X"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "X");
            chart2.Series["Y"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "Y");

            chart2.DataBind();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
