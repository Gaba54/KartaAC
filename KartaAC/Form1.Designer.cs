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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importuj:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(743, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 873);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zmien zakres X";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(1639, 903);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(162, 38);
            this.textBoxMinX.TabIndex = 5;
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(1426, 903);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(162, 38);
            this.textBoxMaxX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1642, 859);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min X:";
            // 
            // textMax
            // 
            this.textMax.AutoSize = true;
            this.textMax.Location = new System.Drawing.Point(1427, 859);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(101, 32);
            this.textMax.TabIndex = 8;
            this.textMax.Text = "Max X:";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(1599, 19);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(258, 61);
            this.OpenFile.TabIndex = 12;
            this.OpenFile.Text = "Otwórz plik";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ChanegRangeX
            // 
            this.ChanegRangeX.Location = new System.Drawing.Point(1923, 873);
            this.ChanegRangeX.Name = "ChanegRangeX";
            this.ChanegRangeX.Size = new System.Drawing.Size(254, 52);
            this.ChanegRangeX.TabIndex = 13;
            this.ChanegRangeX.Text = "Zmien zakres";
            this.ChanegRangeX.UseVisualStyleBackColor = true;
            this.ChanegRangeX.Click += new System.EventHandler(this.ChanegRangeX_Click);
            // 
            // GenerateChart
            // 
            this.GenerateChart.Location = new System.Drawing.Point(294, 1128);
            this.GenerateChart.Name = "GenerateChart";
            this.GenerateChart.Size = new System.Drawing.Size(347, 78);
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
            this.tabPage1.Location = new System.Drawing.Point(50, 111);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(910, 962);
            this.tabPage1.TabIndex = 16;
            // 
            // ChanegRangeY
            // 
            this.ChanegRangeY.Location = new System.Drawing.Point(1923, 982);
            this.ChanegRangeY.Name = "ChanegRangeY";
            this.ChanegRangeY.Size = new System.Drawing.Size(254, 52);
            this.ChanegRangeY.TabIndex = 23;
            this.ChanegRangeY.Text = "Zmien zakres";
            this.ChanegRangeY.UseVisualStyleBackColor = true;
            this.ChanegRangeY.Click += new System.EventHandler(this.ChanegRangeY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1427, 968);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Max Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1642, 968);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Min Y:";
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(1426, 1012);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(162, 38);
            this.textBoxMaxY.TabIndex = 20;
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(1639, 1012);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(162, 38);
            this.textBoxMinY.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1013, 982);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zmien zakres Y";
            // 
            // PlotY
            // 
            this.PlotY.Location = new System.Drawing.Point(1687, 1084);
            this.PlotY.Name = "PlotY";
            this.PlotY.Size = new System.Drawing.Size(286, 67);
            this.PlotY.TabIndex = 24;
            this.PlotY.Text = "Wykres Y";
            this.PlotY.UseVisualStyleBackColor = true;
            this.PlotY.Click += new System.EventHandler(this.PlotY_Click);
            // 
            // PlotX
            // 
            this.PlotX.Location = new System.Drawing.Point(1151, 1084);
            this.PlotX.Name = "PlotX";
            this.PlotX.Size = new System.Drawing.Size(286, 67);
            this.PlotX.TabIndex = 25;
            this.PlotX.Text = "Wykres X";
            this.PlotX.UseVisualStyleBackColor = true;
            this.PlotX.Click += new System.EventHandler(this.PlotX_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(998, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(554, 39);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(1007, 111);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "X";
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Y";
            series2.Name = "Y";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1198, 623);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Name = "Title1";
            title1.Text = "Time";
            this.chart2.Titles.Add(title1);
            // 
            // ChartScroll
            // 
            this.ChartScroll.Location = new System.Drawing.Point(1007, 737);
            this.ChartScroll.MaximumSize = new System.Drawing.Size(1198, 43);
            this.ChartScroll.Name = "ChartScroll";
            this.ChartScroll.Size = new System.Drawing.Size(1198, 43);
            this.ChartScroll.TabIndex = 27;
            this.ChartScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChartScroll_Scroll);
            // 
            // ExportToPDF
            // 
            this.ExportToPDF.Location = new System.Drawing.Point(1910, 19);
            this.ExportToPDF.Name = "ExportToPDF";
            this.ExportToPDF.Size = new System.Drawing.Size(267, 61);
            this.ExportToPDF.TabIndex = 28;
            this.ExportToPDF.Text = "Eksportuj do PDF";
            this.ExportToPDF.UseVisualStyleBackColor = true;
            this.ExportToPDF.Click += new System.EventHandler(this.ExportToPDF_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2227, 1287);
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
            this.MaximumSize = new System.Drawing.Size(2259, 1375);
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
    }
}

