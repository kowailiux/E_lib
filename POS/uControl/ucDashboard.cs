using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.uControl
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //((Form)this.TopLevelControl).Close();
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime iDateTime = DateTime.Now;
            lblDateTime.Text = iDateTime.ToLongDateString() + " at " + iDateTime.ToLongTimeString( );
           
        }
 
 

    
    }
}
