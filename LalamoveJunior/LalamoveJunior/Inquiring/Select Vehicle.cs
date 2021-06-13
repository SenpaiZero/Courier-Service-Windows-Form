using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LalamoveJunior.Inquiring
{
    public partial class Select_Vehicle : Form
    {
        public static int price;
        public static int vehiclePrice;
        public static string vehicleTxt;
        public Select_Vehicle()
        {
            InitializeComponent();
        }

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLocation selL = new SelectLocation();
            selL.ShowDialog();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(Motorcycle.Checked)
            {
                vehiclePrice = 50;
                vehicleTxt = "Motorcycle";
            }
            else if(PickupTruck.Checked)
            {
                vehiclePrice = 100;
                vehicleTxt = "Pickup Truck";
            }
            else if(Smalltruck.Checked)
            {
                vehiclePrice = 150;
                vehicleTxt = "Small Truck";
            }
            else if(MidTruck.Checked)
            {
                vehiclePrice = 300;
                vehicleTxt = "Medium Truck";
            }
            else if(BigTruck.Checked)
            {
                vehiclePrice = 600;
                vehicleTxt = "Large Truck";
            }

            if (vehiclePrice >= 0)
            {
                price += vehiclePrice;

                this.Hide();
                Details det = new Details();
                det.ShowDialog();
                this.Close();
            }
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Price: 50 PHP \n" +
                "Capacity: Up To 20 KG", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nightLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Price: 150 PHP \n" +
                "Capacity: Up To 200 KG", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nightLinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Price: 100 PHP \n" +
                "Capacity: Up To 100 KG", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hopePictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void nightLinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Price: 600 PHP \n" +
                "Capacity: Up To 1500 KG", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nightLinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Price: 300 PHP \n" +
                "Capacity: Up To 600 KG", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Select_Vehicle_Load(object sender, EventArgs e)
        {
            price = SelectLocation.price;
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }
    }
}
