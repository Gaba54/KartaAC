namespace KartaAC
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.Button();
            this.ChanegRangeX = new System.Windows.Forms.Button();
            this.GenerateChart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.Panel();
            this.ChanegRangeY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlotY = new System.Windows.Forms.Button();
            this.PlotX = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartScroll = new System.Windows.Forms.HScrollBar();
            this.ExportToPDF = new System.Windows.Forms.Button();
            this.buttonXY = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importuj:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 451);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zmien zakres X";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(820, 466);
            this.textBoxMinX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(83, 22);
            this.textBoxMinX.TabIndex = 5;
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(713, 466);
            this.textBoxMaxX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(83, 22);
            this.textBoxMaxX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min X:";
            // 
            // textMax
            // 
            this.textMax.AutoSize = true;
            this.textMax.Location = new System.Drawing.Point(714, 443);
            this.textMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(46, 16);
            this.textMax.TabIndex = 8;
            this.textMax.Text = "Max X:";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(800, 10);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(129, 31);
            this.OpenFile.TabIndex = 12;
            this.OpenFile.Text = "Otwórz plik";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ChanegRangeX
            // 
            this.ChanegRangeX.Location = new System.Drawing.Point(962, 451);
            this.ChanegRangeX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChanegRangeX.Name = "ChanegRangeX";
            this.ChanegRangeX.Size = new System.Drawing.Size(127, 27);
            this.ChanegRangeX.TabIndex = 13;
            this.ChanegRangeX.Text = "Zmien zakres";
            this.ChanegRangeX.UseVisualStyleBackColor = true;
            this.ChanegRangeX.Click += new System.EventHandler(this.ChanegRangeX_Click);
            // 
            // GenerateChart
            // 
            this.GenerateChart.Location = new System.Drawing.Point(147, 582);
            this.GenerateChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateChart.Name = "GenerateChart";
            this.GenerateChart.Size = new System.Drawing.Size(174, 40);
            this.GenerateChart.TabIndex = 14;
            this.GenerateChart.Text = "Generuj wykres X i Y ";
            this.GenerateChart.UseVisualStyleBackColor = true;
            this.GenerateChart.Click += new System.EventHandler(this.GenerateChart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(25, 57);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(455, 497);
            this.tabPage1.TabIndex = 16;
            // 
            // ChanegRangeY
            // 
            this.ChanegRangeY.Location = new System.Drawing.Point(962, 507);
            this.ChanegRangeY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChanegRangeY.Name = "ChanegRangeY";
            this.ChanegRangeY.Size = new System.Drawing.Size(127, 27);
            this.ChanegRangeY.TabIndex = 23;
            this.ChanegRangeY.Text = "Zmien zakres";
            this.ChanegRangeY.UseVisualStyleBackColor = true;
            this.ChanegRangeY.Click += new System.EventHandler(this.ChanegRangeY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Max Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Min Y:";
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(713, 522);
            this.textBoxMaxY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(83, 22);
            this.textBoxMaxY.TabIndex = 20;
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(820, 522);
            this.textBoxMinY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(83, 22);
            this.textBoxMinY.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 507);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zmien zakres Y";
            // 
            // PlotY
            // 
            this.PlotY.Location = new System.Drawing.Point(844, 559);
            this.PlotY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlotY.Name = "PlotY";
            this.PlotY.Size = new System.Drawing.Size(143, 35);
            this.PlotY.TabIndex = 24;
            this.PlotY.Text = "Wykres Y";
            this.PlotY.UseVisualStyleBackColor = true;
            this.PlotY.Click += new System.EventHandler(this.PlotY_Click);
            // 
            // PlotX
            // 
            this.PlotX.Location = new System.Drawing.Point(576, 559);
            this.PlotX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlotX.Name = "PlotX";
            this.PlotX.Size = new System.Drawing.Size(143, 35);
            this.PlotX.TabIndex = 25;
            this.PlotX.Text = "Wykres X";
            this.PlotX.UseVisualStyleBackColor = true;
            this.PlotX.Click += new System.EventHandler(this.PlotX_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(504, 57);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "X";
            series3.Name = "X";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Y";
            series4.Name = "Y";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(599, 322);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Name = "Title1";
            title2.Text = "Time";
            this.chart2.Titles.Add(title2);
            // 
            // ChartScroll
            // 
            this.ChartScroll.Location = new System.Drawing.Point(504, 380);
            this.ChartScroll.MaximumSize = new System.Drawing.Size(599, 22);
            this.ChartScroll.Name = "ChartScroll";
            this.ChartScroll.Size = new System.Drawing.Size(599, 22);
            this.ChartScroll.TabIndex = 27;
            this.ChartScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChartScroll_Scroll);
            // 
            // ExportToPDF
            // 
            this.ExportToPDF.Location = new System.Drawing.Point(955, 10);
            this.ExportToPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportToPDF.Name = "ExportToPDF";
            this.ExportToPDF.Size = new System.Drawing.Size(134, 31);
            this.ExportToPDF.TabIndex = 28;
            this.ExportToPDF.Text = "Eksportuj do PDF";
            this.ExportToPDF.UseVisualStyleBackColor = true;
            this.ExportToPDF.Click += new System.EventHandler(this.ExportToPDF_Click_1);
            // 
            // buttonXY
            // 
            this.buttonXY.Location = new System.Drawing.Point(504, 414);
            this.buttonXY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXY.Name = "buttonXY";
            this.buttonXY.Size = new System.Drawing.Size(206, 35);
            this.buttonXY.TabIndex = 29;
            this.buttonXY.Text = "Włącz symulację";
            this.buttonXY.UseVisualStyleBackColor = true;
            this.buttonXY.Click += new System.EventHandler(this.buttonXY_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 664);
            this.Controls.Add(this.buttonXY);
            this.Controls.Add(this.ExportToPDF);
            this.Controls.Add(this.ChartScroll);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PlotX);
            this.Controls.Add(this.PlotY);
            this.Controls.Add(this.ChanegRangeY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxY);
            this.Controls.Add(this.textBoxMinY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabPage1);
            this.Controls.Add(this.GenerateChart);
            this.Controls.Add(this.ChanegRangeX);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaxX);
            this.Controls.Add(this.textBoxMinX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1138, 732);
            this.Name = "Form1";
            this.Text = "KartaA/C";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textMax;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button ChanegRangeX;
        private System.Windows.Forms.Button GenerateChart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel tabPage1;
        private System.Windows.Forms.Button ChanegRangeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PlotY;
        private System.Windows.Forms.Button PlotX;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.HScrollBar ChartScroll;
        private System.Windows.Forms.Button ExportToPDF;
        private System.Windows.Forms.Button buttonXY;
        private System.Windows.Forms.Timer timer1;
    }
}

