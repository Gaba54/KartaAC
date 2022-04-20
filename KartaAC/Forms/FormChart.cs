using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaAC.Forms {
    public partial class FormChart : Form {
        public enum EWhatChart {
            ChartX,
            ChartY,
            ChartXY,
            ChartDXDT,
            ChartDYDT,
            Empty
        };

        public Chart Chart { get { return mainChart; } }
        public DataGridView Data { get { return data; } }

        EWhatChart whatChart = EWhatChart.Empty;

        public CsvLoader csvLoader = null;
        string pathFiles = string.Empty;
        List<string> listFileds = null;
        DataGridView data = new DataGridView();
        DataTable table = new DataTable();
        RowDataDecimal p = null;
        double x = 0;

        public bool DataImported = false;

        public FormChart() {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
        }

        private void GenerateChart_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartXY;
                table.Columns.Clear();

                //Adding file cvs to datatable 
                table.Columns.Add("Time");
                table.Columns.Add("X");
                table.Columns.Add("Y");
                foreach (var item in csvLoader.listData) {
                    var row = table.NewRow();
                    row["Time"] = item.Time;
                    row["X"] = item.X;
                    row["Y"] = item.Y;

                    table.Rows.Add(row);

                }
                mainChart.DataSource = table;

                mainChart.Series.Clear();

                var seriesX = mainChart.Series.Add("X");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Blue;

                var seriesY = mainChart.Series.Add("Y");
                mainChart.Series[1].ChartType = SeriesChartType.Line;
                mainChart.Series[1].Color = Color.Orange;

                /*                var chartAreaX = mainChart.ChartAreas[seriesX.ChartArea];
                                chartAreaX.CursorX.AutoScroll = true;
                                chartAreaX.AxisX.ScrollBar.Enabled = true;
                                chartAreaX.AxisX.ScaleView.Zoomable = true;
                                chartAreaX.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                                chartAreaX.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

                                var chartAreaY = mainChart.ChartAreas[seriesY.ChartArea];
                                chartAreaY.AxisX.ScrollBar.Enabled = true;
                                chartAreaY.CursorX.AutoScroll = true;
                                chartAreaY.AxisX.ScaleView.Zoomable = true;
                                chartAreaY.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                                chartAreaY.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;*/



                //chart2.Series["X"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "X");
                //chart2.Series["Y"].Points.DataBindXY(table.DefaultView, "Time", table.DefaultView, "Y");

                foreach (RowDataDecimal x in csvLoader.listData) {
                    mainChart.Series["X"].Points.AddXY(x.Time, x.X);
                    mainChart.Series["Y"].Points.AddXY(x.Time, x.Y);
                }

                //chart2.Series["X"].Points.AddY(csvLoader.listData.Select(x => x.X).ToArray());
                //chart2.DataBind();
            } else {
                MessageBox.Show("You must import data first!");
            }


        }


        private void ChanegRangeX_Click(object sender, EventArgs e) {
            if (textBoxMaxX.Text.Length > 0) {
                double maxX = double.Parse(textBoxMaxX.Text.Replace('.', ','));
                mainChart.ChartAreas[0].AxisX.Maximum = maxX;
            }

            if (textBoxMinX.Text.Length > 0) {
                double minX = double.Parse(textBoxMinX.Text.Replace('.', ','));
                mainChart.ChartAreas[0].AxisX.Minimum = minX;
            }

        }

        private void ChanegRangeY_Click(object sender, EventArgs e) {
            if (textBoxMaxY.Text.Length > 0) {
                double maxY = double.Parse(textBoxMaxY.Text.Replace('.', ','));
                mainChart.ChartAreas[0].AxisY.Maximum = maxY;
            }

            if (textBoxMinY.Text.Length > 0) {
                double minY = double.Parse(textBoxMinY.Text.Replace('.', ','));
                mainChart.ChartAreas[0].AxisY.Minimum = minY;
            }


        }

        private void PlotY_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartY;
                mainChart.Series.Clear();
                mainChart.Series.Add("OnlyY");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Green;

                foreach (RowDataDecimal x in csvLoader.listData) {
                    mainChart.Series["OnlyY"].Points.AddXY(x.Time, x.Y);
                }
            } else { MessageBox.Show("You must generate the chart first!"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void PlotX_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartX;
                mainChart.Series.Clear();
                mainChart.Series.Add("OnlyX");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Red;

                foreach (RowDataDecimal x in csvLoader.listData) {
                    mainChart.Series["OnlyX"].Points.AddXY(x.Time, x.X);
                }
            } else { MessageBox.Show("You must generate the chart first!"); }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            csvLoader = new CsvLoader(pathFiles + @"\" + cbFiles.SelectedValue);
            LoadData();
        }

        private void ChartScroll_ValueChanged(object sender, EventArgs e) {
            //    List<double> a = csvLoader.listData.Select(x => double.Parse(x.Time)).ToList();
            //    //List<double> b = csvLoader.listData.Select(x => double.Parse(x.Y)).ToList();
            //    //MessageBox.Show(((int)a.Max()).ToString());
            //    ChartScroll.Maximum = (int)a.Max();
            //    chart2.ChartAreas[0].AxisX.Maximum = ChartScroll.Value + 20;
            //    chart2.ChartAreas[0].AxisX.Minimum = ChartScroll.Value - 20;
        }


        private void btnImport_Click(object btnSender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                pathFiles = dialog.SelectedPath;
                tbPath.Text = pathFiles;
                string sourceEnvoa = dialog.SelectedPath;
                DirectoryInfo fieldE = new DirectoryInfo(sourceEnvoa);
                listFileds = new List<string>();
                var fieldsE = fieldE.GetFiles("*.*");
                foreach (var field in fieldsE) {
                    listFileds.Add(field.Name);

                }

                cbFiles.DataSource = listFileds;
                LoadData();
                DataImported = true;
            } else {
                //TODO: Change this to a text msg or something in the future
                MessageBox.Show("You didn't select a folder!");
            }

            csvLoader = new CsvLoader(pathFiles + @"\" + listFileds.First());

        }

        public DataGridView LoadData() {
            data.Location = new Point(0, 0);
            data.Size = new Size(400, 600);
            data.BackgroundColor = Color.White;
            data.Font = new Font("Times New Roman", 10.0f);
            data.AutoResizeColumns();

            data.DataSource = csvLoader.listData;
            return data;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (p == null) {
                p = csvLoader.listData.First();
            } else if (csvLoader.listData.IndexOf(p) < csvLoader.listData.Count() - 1) {
                p = csvLoader.listData[csvLoader.listData.IndexOf(p) + 1];
            } else {
                timer1.Stop();
            }

            switch (whatChart) {
                case EWhatChart.ChartXY: {
                        mainChart.Series[0].Points.AddXY(p.Time, p.X);
                        mainChart.Series[1].Points.AddXY(p.Time, p.Y);
                        mainChart.ChartAreas[0].AxisX.Minimum = mainChart.Series[0].Points[0].XValue;
                        mainChart.ChartAreas[0].AxisX.Maximum = p.Time;
                        mainChart.ChartAreas[0].AxisY.Maximum = Math.Round(csvLoader.listData.Select(x => x.X).Max()) + 2;
                        mainChart.ChartAreas[0].AxisY.Minimum = Math.Round(csvLoader.listData.Select(x => x.X).Min()) - 3;
                        break;
                    }


                case EWhatChart.ChartX: {
                        mainChart.Series[0].Points.AddXY(p.Time, p.X);
                        mainChart.ChartAreas[0].AxisX.Minimum = mainChart.Series[0].Points[0].XValue;
                        mainChart.ChartAreas[0].AxisX.Maximum = p.Time;
                        mainChart.ChartAreas[0].AxisY.Maximum = csvLoader.listData.Select(x => x.X).Max();
                        mainChart.ChartAreas[0].AxisY.Minimum = csvLoader.listData.Select(x => x.X).Min();
                        break;
                    }


                case EWhatChart.ChartY: {
                        mainChart.Series[0].Points.AddXY(p.Time, p.Y);
                        mainChart.ChartAreas[0].AxisX.Minimum = mainChart.Series[0].Points[0].XValue;
                        mainChart.ChartAreas[0].AxisX.Maximum = p.Time;
                        mainChart.ChartAreas[0].AxisY.Maximum = csvLoader.listData.Select(x => x.Y).Max();
                        mainChart.ChartAreas[0].AxisY.Minimum = csvLoader.listData.Select(x => x.Y).Min();
                        break;
                    }


                case EWhatChart.ChartDXDT: {
                        mainChart.Series[0].Points.AddXY(p.Time, p.X);
                        mainChart.Series[1].Points.AddXY(p.Time, p.dxdt);
                        mainChart.ChartAreas[0].AxisX.Minimum = mainChart.Series[0].Points[0].XValue;
                        mainChart.ChartAreas[0].AxisX.Maximum = p.Time;
                        var maxX = csvLoader.listData.Select(row => row.X).Max();
                        var maxDXDT = csvLoader.listData.Select(row => row.dxdt).Max();
                        var minX = csvLoader.listData.Select(row => row.X).Min();
                        var minDXDT = csvLoader.listData.Select(row => row.dxdt).Min();
                        mainChart.ChartAreas[0].AxisY.Maximum = Math.Round(maxX > maxDXDT ? maxX : maxDXDT) + 2;
                        mainChart.ChartAreas[0].AxisY.Minimum = Math.Round(minX < minDXDT ? minX : minDXDT) - 3;
                        break;
                    }

                case EWhatChart.ChartDYDT: {
                        mainChart.Series[0].Points.AddXY(p.Time, p.Y);
                        mainChart.Series[1].Points.AddXY(p.Time, p.dydt);
                        mainChart.ChartAreas[0].AxisX.Minimum = mainChart.Series[0].Points[0].XValue;
                        mainChart.ChartAreas[0].AxisX.Maximum = p.Time;
                        var maxY = csvLoader.listData.Select(row => row.Y).Max();
                        var maxDYDT = csvLoader.listData.Select(row => row.dydt).Max();
                        var minY = csvLoader.listData.Select(row => row.Y).Min();
                        var minDYDT = csvLoader.listData.Select(row => row.dydt).Min();
                        mainChart.ChartAreas[0].AxisY.Maximum = Math.Round(maxY > maxDYDT ? maxY : maxDYDT) + 0.1;
                        mainChart.ChartAreas[0].AxisY.Minimum = Math.Round(minY < minDYDT ? minY : minDYDT) - 1.1;
                        break;
                    }
                case EWhatChart.Empty: {
                        break;
                    }

            }

            if (mainChart.Series[0].Points.Count > 500) {
                mainChart.Series[0].Points.RemoveAt(0);
            }


        }

        private void buttonXY_Click(object sender, EventArgs e) {
            if (timer1.Enabled)
                timer1.Stop();
            else {
                mainChart.Series.Clear();
                switch (whatChart) {
                    case EWhatChart.ChartXY:
                        mainChart.Series.Add("X");
                        mainChart.Series[0].ChartType = SeriesChartType.Line;
                        mainChart.Series[0].Color = Color.Blue;

                        mainChart.Series.Add("Y");
                        mainChart.Series[1].ChartType = SeriesChartType.Line;
                        mainChart.Series[1].Color = Color.Orange;
                        break;
                    case EWhatChart.ChartX:
                        mainChart.Series.Add("OnlyX");
                        mainChart.Series[0].ChartType = SeriesChartType.Line;
                        mainChart.Series[0].Color = Color.Red;
                        //chart2.ChartAreas[0].AxisX.Maximum = csvLoader.listData.First().X+0.00001;
                        //chart2.ChartAreas[0].AxisX.Minimum = csvLoader.listData.Select(x => x.X).Min();
                        break;

                    case EWhatChart.ChartY:
                        mainChart.Series.Add("OnlyY");
                        mainChart.Series[0].ChartType = SeriesChartType.Line;
                        mainChart.Series[0].Color = Color.Green;
                        break;
                    case EWhatChart.ChartDXDT:
                        mainChart.Series.Add("X");
                        mainChart.Series[0].ChartType = SeriesChartType.Line;
                        mainChart.Series[0].Color = Color.Red;

                        mainChart.Series.Add("DXDT");
                        mainChart.Series[1].ChartType = SeriesChartType.Line;
                        mainChart.Series[1].Color = Color.Purple;
                        break;
                    case EWhatChart.ChartDYDT:
                        mainChart.Series.Add("Y");
                        mainChart.Series[0].ChartType = SeriesChartType.Line;
                        mainChart.Series[0].Color = Color.Green;

                        mainChart.Series.Add("DYDT");
                        mainChart.Series[1].ChartType = SeriesChartType.Line;
                        mainChart.Series[1].Color = Color.Pink;
                        break;
                    case EWhatChart.Empty:
                        MessageBox.Show("You must generate the chart first!");
                        return;

                }

                timer1.Interval = 10;
                timer1.Start();
            }

        }


        private void PlotXY_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartXY;
                mainChart.Series.Clear();
                mainChart.Series.Add("X");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Blue;

                mainChart.Series.Add("Y");
                mainChart.Series[1].ChartType = SeriesChartType.Line;
                mainChart.Series[1].Color = Color.Orange;

                foreach (RowDataDecimal x in csvLoader.listData) {
                    mainChart.Series["X"].Points.AddXY(x.Time, x.X);
                    mainChart.Series["Y"].Points.AddXY(x.Time, x.Y);
                }
            } else { MessageBox.Show("You must generate the chart first!"); }

        }

        private void btnDerivativeX_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartDXDT;
                mainChart.Series.Clear();

                mainChart.Series.Add("X");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Red;

                mainChart.Series.Add("DXDT");
                mainChart.Series[1].ChartType = SeriesChartType.Line;
                mainChart.Series[1].Color = Color.Purple;

                foreach (RowDataDecimal row in csvLoader.listData) {
                    mainChart.Series["X"].Points.AddXY(row.Time, row.X);
                    mainChart.Series["DXDT"].Points.AddXY(row.Time, row.dxdt);
                }

            } else {
                MessageBox.Show("You must import data first!");
            }
        }

        private void btnDerivativeY_Click(object sender, EventArgs e) {
            if (DataImported) {
                whatChart = EWhatChart.ChartDYDT;
                mainChart.Series.Clear();

                mainChart.Series.Add("Y");
                mainChart.Series[0].ChartType = SeriesChartType.Line;
                mainChart.Series[0].Color = Color.Green;

                mainChart.Series.Add("DYDT");
                mainChart.Series[1].ChartType = SeriesChartType.Line;
                mainChart.Series[1].Color = Color.Pink;

                foreach (RowDataDecimal row in csvLoader.listData) {
                    mainChart.Series["Y"].Points.AddXY(row.Time, row.Y);
                    mainChart.Series["DYDT"].Points.AddXY(row.Time, row.dydt);
                }

            } else {
                MessageBox.Show("You must import data first!");
            }
        }
    }
}
