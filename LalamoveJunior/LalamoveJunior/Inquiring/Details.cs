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
    public partial class Details : Form
    {
        public Details()
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

        private void Details_Load(object sender, EventArgs e)
        {
            PickTxt.Text = SelectLocation.pickupTxt;
            DropTxt.Text = SelectLocation.dropoutTxt;
            VehicleTxt.Text = Select_Vehicle.vehicleTxt;
            LocPrice.Text = SelectLocation.price.ToString();
            VehiclePrice.Text = Select_Vehicle.vehiclePrice.ToString();
            TotalPrice.Text = Select_Vehicle.price.ToString();
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void nightButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select_Vehicle selV = new Select_Vehicle();
            selV.ShowDialog();
            this.Close();
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.ShowDialog();
            this.Close();
        }
    }
}
