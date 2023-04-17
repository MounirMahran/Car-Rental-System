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
    public partial class frmSUVTucsonInfo : Form
    {
        public frmSUVTucsonInfo()
        {
            InitializeComponent();
        }

        void SubstitueRentalMessage()
        {
            MessageBox.Show("Rental Details Will Be Here", "Rent Now", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void rbPhoto1_CheckedChanged(object sender, EventArgs e)
        {
            pbTucson.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Tucson\2022_Hyundai_Tucson_Review1.jfif");
        }

        private void rbPhoto2_CheckedChanged(object sender, EventArgs e)
        {
            pbTucson.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Tucson\2022_Hyundai_Tucson_Review5.jfif");
        }

        private void rbPhoto3_CheckedChanged(object sender, EventArgs e)
        {
            pbTucson.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Tucson\2022_Hyundai_Tucson_Review2.jfif");
        }

        private void rbPhoto4_CheckedChanged(object sender, EventArgs e)
        {
            pbTucson.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Tucson\2022_Hyundai_Tucson_Review3.jfif");
        }

        private void rbPhoto5_CheckedChanged(object sender, EventArgs e)
        {
            pbTucson.Image = Image.FromFile(@"C:\Users\DELL\Desktop\.Net Projects\Car-Rental-System\Car-Rental-System\Car Rental System Images And Icons\SUV\Tucson\2022_Hyundai_Tucson_Review4.jfif");
        }

        private void btnRentJeep_Click(object sender, EventArgs e)
        {
            SubstitueRentalMessage();
        }
    }
}
