namespace KartaAC.Forms
{
    partial class FormViewTable
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
            this.tpData = new System.Windows.Forms.Panel();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tpData
            // 
            this.tpData.BackColor = System.Drawing.Color.White;
            this.tpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpData.Location = new System.Drawing.Point(0, 0);
            this.tpData.Margin = new System.Windows.Forms.Padding(2);
            this.tpData.MinimumSize = new System.Drawing.Size(400, 500);
            this.tpData.Name = "tpData";
            this.tpData.Size = new System.Drawing.Size(580, 573);
            this.tpData.TabIndex = 17;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExportPdf.FlatAppearance.BorderSize = 2;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExportPdf.Location = new System.Drawing.Point(0, 523);
            this.btnExportPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(580, 50);
            this.btnExportPdf.TabIndex = 37;
            this.btnExportPdf.Text = "Export to PDF";
            this.btnExportPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // FormViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(580, 573);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.tpData);
            this.Name = "FormViewTable";
            this.Text = "FormViewTable";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel tpData;
        private System.Windows.Forms.Button btnExportPdf;
    }
}