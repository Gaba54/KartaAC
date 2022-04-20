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
        /// 


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.btnViewTable);
            this.panel1.Controls.Add(this.btnChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 631);
            this.panel1.TabIndex = 30;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 581);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(244, 50);
            this.btnSettings.TabIndex = 38;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 50);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 100);
            this.pnlNav.TabIndex = 15;
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.Location = new System.Drawing.Point(0, 100);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(244, 50);
            this.btnCalc.TabIndex = 37;
            this.btnCalc.Text = "Calculations";
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnViewTable.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTable.Image")));
            this.btnViewTable.Location = new System.Drawing.Point(0, 50);
            this.btnViewTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(244, 50);
            this.btnViewTable.TabIndex = 36;
            this.btnViewTable.Text = "View table";
            this.btnViewTable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.Location = new System.Drawing.Point(0, 0);
            this.btnChart.Margin = new System.Windows.Forms.Padding(2);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(244, 50);
            this.btnChart.TabIndex = 37;
            this.btnChart.Text = "Chart";
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(47)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1338, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 31;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFull
            // 
            this.btnFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(47)))));
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Image = ((System.Drawing.Image)(resources.GetObject("btnFull.Image")));
            this.btnFull.Location = new System.Drawing.Point(1302, 0);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(30, 30);
            this.btnFull.TabIndex = 32;
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(47)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1266, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 33;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(47)))));
            this.pnlTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1384, 30);
            this.pnlTopBar.TabIndex = 34;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(244, 30);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1140, 631);
            this.pnlDesktop.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopBar);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartaA/C";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnChart;
    }
}

