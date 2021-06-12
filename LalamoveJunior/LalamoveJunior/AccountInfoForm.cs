using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class AccountInfoForm : Form
    {
        SqlConnection cn;
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

                UsernameTxt.Text = usernameSQL;
                NameTxt.Text = nameSQL;
                PhoneNumberTxt.Text = phoneNumberSQL;
            }
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
