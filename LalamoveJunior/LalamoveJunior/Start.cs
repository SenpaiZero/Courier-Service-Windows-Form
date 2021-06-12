using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Start : Form
    {
        public static string username;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True");
            cn.Open();
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (Password.Text != string.Empty || Username.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from userLogin where username='" + Username.Text + "' and password='" + Password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    username = Username.Text;
                    dr.Close();
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.ShowDialog();
                    cn.Close();
                    this.Close();
                    return;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();
            this.Close();
        }
    }
}
