using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  POS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uControl.ucDashboard ucDashboard = new uControl.ucDashboard();
            ucDashboard.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDashboard);

        }

 

        private void picMore_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width >= 226)
            {
                panelLeft.Width = 52;
                picMore.Left = 10;

                btnDashboard.Text = "";
                btnCustomer.Text = "";
                btnCatalog.Text = "";
                btnProduct.Text = "";
                btnReport.Text = "";
            }
            else {
                panelLeft.Width = 226;
                picMore.Left = 190;

                btnDashboard.Text = "   Dashboard";
                btnCustomer.Text = "   Customers";
                btnCatalog.Text = "   Categories";
                btnProduct.Text = "   Products";
                btnReport.Text = "   Reports";
            }
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            //Form frmCatalog = new frmCatalog();
            //frmCatalog.Show();
            uControl.ucCatalog ucCatalog = new uControl.ucCatalog();
            ucCatalog.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucCatalog);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uControl.ucDashboard ucDashboard = new uControl.ucDashboard();
            ucDashboard.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDashboard);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            uControl.ucProduct ucProduct = new uControl.ucProduct();
            ucProduct.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucProduct);
        }
 
 
        
    }
}
