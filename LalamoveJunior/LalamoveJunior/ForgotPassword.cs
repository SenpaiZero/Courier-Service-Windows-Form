using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LalamoveJunior
{
    public partial class ForgotPassword : Form
    {
        SqlConnection cn;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            if (Username.Text != string.Empty || Name.Text != string.Empty || PhoneNumber.Text != string.Empty)
            {
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from userLogin where username='" + Username.Text +
                        "' AND Name='" + Name.Text +
                        "' AND PhoneNumber='" + PhoneNumber.Text + 
                        "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("select password from userLogin where username='" + Username.Text +
                        "' AND Name='" + Name.Text +
                        "' AND PhoneNumber='" + PhoneNumber.Text +
                        "'", cn);
                        string password = cmd.ExecuteScalar().ToString();
                        MessageBox.Show("Your Password is " + password, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Incorrect Information. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
            this.Close();
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

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                PhoneNumber.Text = PhoneNumber.Text.Remove(PhoneNumber.Text.Length - 1);
            }
        }
    }
}
