namespace KartaAC.Forms
{
    partial class FormCalculations
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
            this.btnIntegral = new System.Windows.Forms.Button();
            this.lblIntegralX = new System.Windows.Forms.Label();
            this.lblIntegralTagX = new System.Windows.Forms.Label();
            this.lblIntegralTagY = new System.Windows.Forms.Label();
            this.lblIntegralY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIntegral
            // 
            this.btnIntegral.FlatAppearance.BorderSize = 2;
            this.btnIntegral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntegral.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnIntegral.Location = new System.Drawing.Point(42, 135);
            this.btnIntegral.Margin = new System.Windows.Forms.Padding(2);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(150, 50);
            this.btnIntegral.TabIndex = 56;
            this.btnIntegral.Tag = "";
            this.btnIntegral.Text = "Calculate integral";
            this.btnIntegral.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // lblIntegralX
            // 
            this.lblIntegralX.AutoSize = true;
            this.lblIntegralX.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegralX.Location = new System.Drawing.Point(260, 35);
            this.lblIntegralX.Name = "lblIntegralX";
            this.lblIntegralX.Size = new System.Drawing.Size(23, 26);
            this.lblIntegralX.TabIndex = 57;
            this.lblIntegralX.Text = "0";
            // 
            // lblIntegralTagX
            // 
            this.lblIntegralTagX.AutoSize = true;
            this.lblIntegralTagX.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegralTagX.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblIntegralTagX.Location = new System.Drawing.Point(37, 35);
            this.lblIntegralTagX.Name = "lblIntegralTagX";
            this.lblIntegralTagX.Size = new System.Drawing.Size(137, 26);
            this.lblIntegralTagX.TabIndex = 58;
            this.lblIntegralTagX.Text = "Integral for X:";
            // 
            // lblIntegralTagY
            // 
            this.lblIntegralTagY.AutoSize = true;
            this.lblIntegralTagY.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegralTagY.ForeColor = System.Drawing.Color.Coral;
            this.lblIntegralTagY.Location = new System.Drawing.Point(37, 82);
            this.lblIntegralTagY.Name = "lblIntegralTagY";
            this.lblIntegralTagY.Size = new System.Drawing.Size(136, 26);
            this.lblIntegralTagY.TabIndex = 60;
            this.lblIntegralTagY.Text = "Integral for Y:";
            // 
            // lblIntegralY
            // 
            this.lblIntegralY.AutoSize = true;
            this.lblIntegralY.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegralY.Location = new System.Drawing.Point(260, 82);
            this.lblIntegralY.Name = "lblIntegralY";
            this.lblIntegralY.Size = new System.Drawing.Size(23, 26);
            this.lblIntegralY.TabIndex = 59;
            this.lblIntegralY.Text = "0";
            // 
            // FormCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntegralTagY);
            this.Controls.Add(this.lblIntegralY);
            this.Controls.Add(this.lblIntegralTagX);
            this.Controls.Add(this.lblIntegralX);
            this.Controls.Add(this.btnIntegral);
            this.Name = "FormCalculations";
            this.Text = "FormCalculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.Label lblIntegralX;
        private System.Windows.Forms.Label lblIntegralTagX;
        private System.Windows.Forms.Label lblIntegralTagY;
        private System.Windows.Forms.Label lblIntegralY;
    }
}