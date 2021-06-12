using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LalamoveJunior
{
    public partial class Register : Form
    {
        SqlConnection cn;
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.ShowDialog();
            cn.Close();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (Password2.Text != string.Empty || Password.Text != string.Empty || Username.Text != string.Empty)
            {
                if (Password.Text == Password2.Text)
                {
                    using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("select * from userLogin where username='" + Username.Text + "'", cn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into userLogin values(@username,@password,@Name,@PhoneNumber)", cn);
                            cmd.Parameters.AddWithValue("username", Username.Text);
                            cmd.Parameters.AddWithValue("password", Password.Text);
                            cmd.Parameters.AddWithValue("Name", Name.Text);
                            cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.ShowDialog();
            cn.Close();
            this.Close();
        }
    }
}
