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
    public partial class frmLandCruiserInfo : Form
    {
        public frmLandCruiserInfo()
        {
            InitializeComponent();
        }

        void SubstitueRentalMessage()
        {
            MessageBox.Show("Rental Details Will Be Here", "Rent Now", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRentJeep_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();

        }

        private void rbPhoto1_CheckedChanged(object sender, EventArgs e)
        {
            pbLandCruiser.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Land Cruiser\2021_Toyota_Land_Cruiser_Review1.jpg");
        }

        private void rbPhoto2_CheckedChanged(object sender, EventArgs e)
        {
            pbLandCruiser.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Land Cruiser\2021_Toyota_Land_Cruiser_Review2.jpg");
        }

        private void rbPhoto3_CheckedChanged(object sender, EventArgs e)
        {
            pbLandCruiser.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Land Cruiser\2021_Toyota_Land_Cruiser_Review5.jpg");
        }

        private void rbPhoto4_CheckedChanged(object sender, EventArgs e)
        {
            pbLandCruiser.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Land Cruiser\2021_Toyota_Land_Cruiser_Review3.jpg");
        }

        private void rbPhoto5_CheckedChanged(object sender, EventArgs e)
        {
            pbLandCruiser.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Land Cruiser\2021_Toyota_Land_Cruiser_Review4.jpg");
        }
    }
}
