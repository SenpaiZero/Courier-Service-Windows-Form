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
    public partial class SelectLocation : Form
    {
        public static string pickupTxt, dropoutTxt, pickupDrop, dropoutDrop, noteTxt;
        public static int price;
        int pick1, drop1, pd;
        public SelectLocation()
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

        private void totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void SelectLocation_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void foxLinkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Where to pickup: This is where you will give your package to the courier", "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Where to drop: This is where the courier will deliver your package", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Notes: In case that you want to include a specific location, you can type it in notes", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            if(PickTxt.Text != string.Empty && DropTxt.Text != string.Empty && pickDrop.Text != string.Empty && dropDrop.Text != string.Empty)
            {
                pickupTxt = PickTxt.Text;
                dropoutTxt = DropTxt.Text;
                pickupDrop = pickDrop.Text;
                dropoutDrop = dropDrop.Text;
                noteTxt = Note.Text;
                dropPrice();
                int countChar = PickTxt.Text.ToString().Length;
                int countChar1 = DropTxt.Text.ToString().Length;
                price = (countChar + countChar1) * pd;

                this.Hide();
                Select_Vehicle selV = new Select_Vehicle();
                selV.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Don't leave a blank space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dropPrice()
        {
            if(pickDrop.Text == "Luzon")
            {
                pick1 = 1;
            }
            if (pickDrop.Text == "Visayas")
            {
                pick1 = 2;
            }
            if (pickDrop.Text == "Mindanao")
            {
                pick1 = 3;
            }
            if (dropDrop.Text == "Luzon")
            {
                drop1 = 1;
            }
            if (dropDrop.Text == "Visayas")
            {
                drop1 = 2;
            }
            if (dropDrop.Text == "Mindanao")
            {
                drop1 = 3;
            }

            pd = (drop1 - pick1) + 1;
        }
    }
}
