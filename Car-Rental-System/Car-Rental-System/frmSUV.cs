using Car_Rental_System.Properties;
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
    public partial class frmSUV : Form
    {
        public frmSUV()
        {
            InitializeComponent();
        }

        void SetJeepImage()
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-1.jpg");

        }

        void SubstitueRentalMessage()
        {
            MessageBox.Show("Rental Details Will Be Here", "Rent Now", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSUV_Load(object sender, EventArgs e)
        {
            SetJeepImage();
        }

        private void pbGrandCherokee_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSUVGrandCherokeeInfo();
            frm1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRentJeep_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();
        }

        private void btnRentLangCruiser_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();
        }

        private void btnRentHyundaiTucson_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();
        }

        private void pbSedan_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmLandCruiserInfo();
            frm1.ShowDialog();
        }

        private void pbHatchBack_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSUVTucsonInfo();
            frm1.ShowDialog();
        }
    }
}
