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
    public partial class Payment : Form
    {
        public Payment()
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

        private void Payment_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Card.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Card.Text = Card.Text.Remove(Card.Text.Length - 1);
            }
        }

        private void Exp_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Exp.Text, "[^0-9/]"))
            {
                MessageBox.Show("Please enter only numbers.\nExample: 12/23");
                Exp.Text = Exp.Text.Remove(Exp.Text.Length - 1);
            }
        }

        private void Cvv_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cvv.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cvv.Text = Cvv.Text.Remove(Cvv.Text.Length - 1);
            }
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("Your Purchase is now processing. Please wait for your driver to call.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                if (name.Text != string.Empty && Card.Text != string.Empty && Cvv.Text != string.Empty)
                {
                    MessageBox.Show("Your Purchase is now processing. Please wait for your driver to call.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occureed. Please Try Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
