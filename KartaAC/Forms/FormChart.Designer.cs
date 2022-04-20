using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace KartaAC.Forms
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartScroll = new System.Windows.Forms.HScrollBar();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnImport = new System.Windows.Forms.Button();
            this.ChanegRangeX = new System.Windows.Forms.Button();
            this.ChanegRangeY = new System.Windows.Forms.Button();
            this.GenerateChart = new System.Windows.Forms.Button();
            this.cbFiles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonXY = new System.Windows.Forms.Button();
            this.PlotX = new System.Windows.Forms.Button();
            this.PlotY = new System.Windows.Forms.Button();
            this.PlotXY = new System.Windows.Forms.Button();
            this.btnDerivativeX = new System.Windows.Forms.Button();
            this.btnDerivativeY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartScroll
            // 
            this.ChartScroll.Location = new System.Drawing.Point(43, 354);
            this.ChartScroll.MaximumSize = new System.Drawing.Size(449, 18);
            this.ChartScroll.Name = "ChartScroll";
            this.ChartScroll.Size = new System.Drawing.Size(439, 18);
            this.ChartScroll.TabIndex = 49;
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(43, 90);
            this.mainChart.Margin = new System.Windows.Forms.Padding(2);
            this.mainChart.Name = "mainChart";
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
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(439, 262);
            this.mainChart.TabIndex = 39;
            this.mainChart.Tag = "";
            this.mainChart.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Name = "Title1";
            title1.Text = "Time";
            this.mainChart.Titles.Add(title1);
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImport.Location = new System.Drawing.Point(517, 11);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 50);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Import data";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ChanegRangeX
            // 
            this.ChanegRangeX.Location = new System.Drawing.Point(812, 119);
            this.ChanegRangeX.Margin = new System.Windows.Forms.Padding(2);
            this.ChanegRangeX.Name = "ChanegRangeX";
            this.ChanegRangeX.Size = new System.Drawing.Size(95, 22);
            this.ChanegRangeX.TabIndex = 37;
            this.ChanegRangeX.Text = "Modify";
            this.ChanegRangeX.UseVisualStyleBackColor = true;
            this.ChanegRangeX.Click += new System.EventHandler(this.ChanegRangeX_Click);
            // 
            // ChanegRangeY
            // 
            this.ChanegRangeY.Location = new System.Drawing.Point(811, 212);
            this.ChanegRangeY.Margin = new System.Windows.Forms.Padding(2);
            this.ChanegRangeY.Name = "ChanegRangeY";
            this.ChanegRangeY.Size = new System.Drawing.Size(95, 22);
            this.ChanegRangeY.TabIndex = 45;
            this.ChanegRangeY.Tag = "";
            this.ChanegRangeY.Text = "Modify";
            this.ChanegRangeY.UseVisualStyleBackColor = true;
            this.ChanegRangeY.Click += new System.EventHandler(this.ChanegRangeY_Click);
            // 
            // GenerateChart
            // 
            this.GenerateChart.FlatAppearance.BorderSize = 2;
            this.GenerateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateChart.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GenerateChart.Location = new System.Drawing.Point(687, 11);
            this.GenerateChart.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateChart.Name = "GenerateChart";
            this.GenerateChart.Size = new System.Drawing.Size(150, 50);
            this.GenerateChart.TabIndex = 38;
            this.GenerateChart.Tag = "";
            this.GenerateChart.Text = "Generate chart";
            this.GenerateChart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GenerateChart.UseVisualStyleBackColor = true;
            this.GenerateChart.Click += new System.EventHandler(this.GenerateChart_Click);
            // 
            // cbFiles
            // 
            this.cbFiles.FormattingEnabled = true;
            this.cbFiles.Location = new System.Drawing.Point(43, 40);
            this.cbFiles.Margin = new System.Windows.Forms.Padding(2);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Size = new System.Drawing.Size(439, 21);
            this.cbFiles.TabIndex = 48;
            this.cbFiles.Tag = "";
            this.cbFiles.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Max Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Min Y:";
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(641, 214);
            this.textBoxMaxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(63, 20);
            this.textBoxMaxY.TabIndex = 42;
            this.textBoxMaxY.Tag = "";
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(728, 214);
            this.textBoxMinY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinY.TabIndex = 41;
            this.textBoxMinY.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Y range";
            // 
            // textMax
            // 
            this.textMax.AutoSize = true;
            this.textMax.Location = new System.Drawing.Point(651, 91);
            this.textMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(40, 13);
            this.textMax.TabIndex = 35;
            this.textMax.Text = "Max X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Min X:";
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(641, 121);
            this.textBoxMaxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(63, 20);
            this.textBoxMaxX.TabIndex = 33;
            this.textBoxMaxX.Tag = "";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(728, 121);
            this.textBoxMinX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinX.TabIndex = 32;
            this.textBoxMinX.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "X range";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(43, 11);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(439, 20);
            this.tbPath.TabIndex = 30;
            this.tbPath.Tag = "";
            this.tbPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonXY
            // 
            this.buttonXY.FlatAppearance.BorderSize = 2;
            this.buttonXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXY.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonXY.Location = new System.Drawing.Point(184, 389);
            this.buttonXY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXY.Name = "buttonXY";
            this.buttonXY.Size = new System.Drawing.Size(150, 50);
            this.buttonXY.TabIndex = 51;
            this.buttonXY.Text = "Start / Stop Simulation";
            this.buttonXY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonXY.UseVisualStyleBackColor = true;
            this.buttonXY.Click += new System.EventHandler(this.buttonXY_Click);
            // 
            // PlotX
            // 
            this.PlotX.FlatAppearance.BorderSize = 2;
            this.PlotX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlotX.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PlotX.Location = new System.Drawing.Point(687, 282);
            this.PlotX.Margin = new System.Windows.Forms.Padding(2);
            this.PlotX.Name = "PlotX";
            this.PlotX.Size = new System.Drawing.Size(150, 50);
            this.PlotX.TabIndex = 52;
            this.PlotX.Tag = "";
            this.PlotX.Text = "Chart X";
            this.PlotX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlotX.UseVisualStyleBackColor = true;
            this.PlotX.Click += new System.EventHandler(this.PlotX_Click);
            // 
            // PlotY
            // 
            this.PlotY.FlatAppearance.BorderSize = 2;
            this.PlotY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlotY.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PlotY.Location = new System.Drawing.Point(853, 282);
            this.PlotY.Margin = new System.Windows.Forms.Padding(2);
            this.PlotY.Name = "PlotY";
            this.PlotY.Size = new System.Drawing.Size(150, 50);
            this.PlotY.TabIndex = 53;
            this.PlotY.Tag = "";
            this.PlotY.Text = "Chart Y";
            this.PlotY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlotY.UseVisualStyleBackColor = true;
            this.PlotY.Click += new System.EventHandler(this.PlotY_Click);
            // 
            // PlotXY
            // 
            this.PlotXY.FlatAppearance.BorderSize = 2;
            this.PlotXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlotXY.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PlotXY.Location = new System.Drawing.Point(517, 282);
            this.PlotXY.Margin = new System.Windows.Forms.Padding(2);
            this.PlotXY.Name = "PlotXY";
            this.PlotXY.Size = new System.Drawing.Size(150, 50);
            this.PlotXY.TabIndex = 54;
            this.PlotXY.Tag = "";
            this.PlotXY.Text = "Chart XY";
            this.PlotXY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlotXY.UseVisualStyleBackColor = true;
            this.PlotXY.Click += new System.EventHandler(this.PlotXY_Click);
            // 
            // btnDerivativeX
            // 
            this.btnDerivativeX.FlatAppearance.BorderSize = 2;
            this.btnDerivativeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerivativeX.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerivativeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDerivativeX.Location = new System.Drawing.Point(687, 354);
            this.btnDerivativeX.Margin = new System.Windows.Forms.Padding(2);
            this.btnDerivativeX.Name = "btnDerivativeX";
            this.btnDerivativeX.Size = new System.Drawing.Size(150, 50);
            this.btnDerivativeX.TabIndex = 55;
            this.btnDerivativeX.Tag = "";
            this.btnDerivativeX.Text = "Generate derivative X";
            this.btnDerivativeX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDerivativeX.UseVisualStyleBackColor = true;
            this.btnDerivativeX.Click += new System.EventHandler(this.btnDerivativeX_Click);
            // 
            // btnDerivativeY
            // 
            this.btnDerivativeY.FlatAppearance.BorderSize = 2;
            this.btnDerivativeY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerivativeY.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerivativeY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDerivativeY.Location = new System.Drawing.Point(853, 354);
            this.btnDerivativeY.Margin = new System.Windows.Forms.Padding(2);
            this.btnDerivativeY.Name = "btnDerivativeY";
            this.btnDerivativeY.Size = new System.Drawing.Size(150, 50);
            this.btnDerivativeY.TabIndex = 56;
            this.btnDerivativeY.Tag = "";
            this.btnDerivativeY.Text = "Generate derivative Y";
            this.btnDerivativeY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDerivativeY.UseVisualStyleBackColor = true;
            this.btnDerivativeY.Click += new System.EventHandler(this.btnDerivativeY_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1030, 595);
            this.Controls.Add(this.btnDerivativeY);
            this.Controls.Add(this.btnDerivativeX);
            this.Controls.Add(this.PlotXY);
            this.Controls.Add(this.PlotY);
            this.Controls.Add(this.PlotX);
            this.Controls.Add(this.buttonXY);
            this.Controls.Add(this.ChartScroll);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.ChanegRangeX);
            this.Controls.Add(this.ChanegRangeY);
            this.Controls.Add(this.GenerateChart);
            this.Controls.Add(this.cbFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxY);
            this.Controls.Add(this.textBoxMinY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaxX);
            this.Controls.Add(this.textBoxMinX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPath);
            this.Name = "FormChart";
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar ChartScroll;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button ChanegRangeX;
        private System.Windows.Forms.Button ChanegRangeY;
        private System.Windows.Forms.Button GenerateChart;
        private System.Windows.Forms.ComboBox cbFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonXY;
        private System.Windows.Forms.Button PlotX;
        private System.Windows.Forms.Button PlotY;
        private System.Windows.Forms.Button PlotXY;
        private System.Windows.Forms.Button btnDerivativeX;
        private System.Windows.Forms.Button btnDerivativeY;
    }
}