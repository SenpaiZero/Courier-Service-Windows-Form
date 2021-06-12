using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LalamoveJunior;
using LalamoveJunior.ChangeAccountForms;

namespace LalamoveJunior
{
    public partial class AccountInfoForm : Form
    {
        SqlConnection cn;
        string passwordSQL;
        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;

            string username_ = Start.username;

            using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
            {
                cn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("select username from userLogin where username='" + username_ + "'", cn);
                string usernameSQL = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("select Name from userLogin where username='" + username_ + "'", cn);
                string nameSQL = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("select PhoneNumber from userLogin where username='" + username_ + "'", cn);
                string phoneNumberSQL = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("select password from userLogin where username='" + username_ + "'", cn);
                passwordSQL = cmd.ExecuteScalar().ToString();

                UsernameTxt.Text = usernameSQL;
                NameTxt.Text = nameSQL;
                PhoneNumberTxt.Text = phoneNumberSQL;

            }
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You can't change username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender)
        {
            if (checkBox1.Checked == true)
            {
                passtxt.Text = passwordSQL;
            }
            else
            {
                passtxt.Text = "************";
            }
        }

        private void ChangeUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangeName cName = new ChangeName();
            cName.ShowDialog();
            this.Close();
        }

        private void ChangePhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePhone cPhone = new ChangePhone();
            cPhone.ShowDialog();
            this.Close();
        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePassword cPass = new ChangePassword();
            cPass.ShowDialog();
            this.Close();
        }
    }
}
