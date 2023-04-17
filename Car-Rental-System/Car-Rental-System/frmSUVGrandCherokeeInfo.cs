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
    public partial class frmSUVGrandCherokeeInfo : Form
    {
        public frmSUVGrandCherokeeInfo()
        {
            InitializeComponent();
        }

        void SubstitueRentalMessage()
        {
            MessageBox.Show("Rental Details Will Be Here", "Rent Now", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbPhoto1_CheckedChanged(object sender, EventArgs e)
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-1.jpg");
        }

        private void rbPhoto2_CheckedChanged(object sender, EventArgs e)
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-5.jpg");
        }

        private void rbPhoto3_CheckedChanged(object sender, EventArgs e)
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-4.jpg");
        }

        private void rbPhoto4_CheckedChanged(object sender, EventArgs e)
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-2.jpg");
        }

        private void rbPhoto5_CheckedChanged(object sender, EventArgs e)
        {
            pbGrandCherokee.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Grand Cherokee\2022_Jeep_Cherokee_inline-3.jpg");
        }

        private void btnRentJeep_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();
        }

        private void lblPice_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxSpeed_Click(object sender, EventArgs e)
        {

        }

        private void lblTransmission_Click(object sender, EventArgs e)
        {

        }

        private void lblHorsePower_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbGrandCherokee_Click(object sender, EventArgs e)
        {

        }
    }
}
