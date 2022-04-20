using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KartaAC
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        private Button currentButton = null;

 
        private Forms.FormCalculations formCalculations;
        private Forms.FormViewTable formViewTable;
        private Forms.FormSettings formSettings;
        private Forms.FormChart formChart;
        public bool importedData = false;

        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            Text = string.Empty;

            formChart = new Forms.FormChart();
            OpenChildForm(formChart, btnChart);

            //csvLoader = new csvLoader(@"D:/danectp/dane1.csv");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        // Windows corner buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Dragging bar method
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }


        // Open Forms
        private void OpenChildForm(Form childForm, object btnSender) 
        {
            if (activeForm != null) 
            {
                activeForm.Hide();   
            }

            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Height = Height;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            {
                var button = btnSender as Button;
                if (currentButton != button) 
                {
                    if (currentButton != null) 
                    {
                        DisableButton(currentButton);
                    }
                    
                    currentButton = button;
                    pnlNav.Height = currentButton.Height;
                    pnlNav.Top = currentButton.Top;
                    pnlNav.Left = currentButton.Left;
                    currentButton.BackColor = Color.FromArgb(46, 51, 73);
                }
            }
            
        }

        private void DisableButton(Button button) 
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnViewTable_Click(object btnSender, EventArgs e)
        {
            if (formChart != null) 
            {
                if (formChart.DataImported)
                {
                    if (formViewTable is null)
                    {
                        //Validate if chart was created
                        formViewTable = new Forms.FormViewTable(formChart);
                        OpenChildForm(formViewTable, btnSender);
                    }
                    else
                    {
                        formViewTable.BringToFront();
                        formViewTable.Show();
                        ActivateButton(btnSender);
                    }

                    activeForm = formViewTable;

                }
                else
                {
                    MessageBox.Show("You must first import data!");
                }
            }
            else
            {
                MessageBox.Show("You must first import data!");
            }
        }

        private void btnCalc_Click(object btnSender, EventArgs e)
        {
            if (formCalculations is null)
            {
                formCalculations = new Forms.FormCalculations(formChart);
                OpenChildForm(formCalculations, btnSender);
            }
            else {
                formCalculations.BringToFront();
                formCalculations.Show();
                ActivateButton(btnSender);
            }

            activeForm = formCalculations;

        }

        private void btnSettings_Click(object btnSender, EventArgs e)
        {
            if (formSettings is null)
            {
                formSettings = new Forms.FormSettings();
                OpenChildForm(formSettings, btnSender);
            }
            else
            {
                formSettings.BringToFront();
                formSettings.Show();
                ActivateButton(btnSender);
            }

            activeForm = formSettings;
        }

        private void btnChart_Click(object btnSender, EventArgs e)
        {
            formChart.BringToFront();
            formChart.Show();
            
            activeForm = formChart;
            ActivateButton(btnSender);

        }


    }
}

