using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class frmGeneralCarTypes : Form
    {
        public frmGeneralCarTypes()
        {
            InitializeComponent();
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSUV();
            frm1.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
