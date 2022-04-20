using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaAC.Forms
{
    public partial class FormCalculations : Form
    {
        private FormChart formChart;
        public FormCalculations(FormChart form)
        {
            InitializeComponent();
            formChart = form;
        }

        private void btnRectInt_Click(object sender, EventArgs e)
        {

        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            if (formChart.DataImported)
            {
                lblIntegralX.Text = formChart.csvLoader.integralX.ToString() + " [V]";
                lblIntegralY.Text = formChart.csvLoader.integralY.ToString() + " [V]";
            } else 
            {
                MessageBox.Show("Please import data first!");
            }
            
        }
    }

}
