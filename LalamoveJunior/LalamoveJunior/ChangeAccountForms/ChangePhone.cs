using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LalamoveJunior.ChangeAccountForms
{
    public partial class ChangePhone : Form
    {
        SqlConnection cn;
        string passCN;
        public ChangePhone()
        {
            InitializeComponent();
        }

        private void cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountInfoForm acc = new AccountInfoForm();
            acc.ShowDialog();
            this.Close();
        }

        private void CurrentNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CurrentNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                CurrentNumber.Text = CurrentNumber.Text.Remove(CurrentNumber.Text.Length - 1);
            }
        }

        private void NewNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(NewNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                NewNumber.Text = NewNumber.Text.Remove(NewNumber.Text.Length - 1);
            }
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
        }

        private void ChangePhone_Load(object sender, EventArgs e)
        {
            passCN = Start.username;
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            if (CurrentNumber.Text != string.Empty || NewNumber.Text != string.Empty || Pass.Text != string.Empty)
            {
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from userLogin where username='" + passCN +
                    "' and password='" + Pass.Text +
                    "' and PhoneNumber='" + CurrentNumber.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("update userLogin set PhoneNumber='" + NewNumber.Text + "' where username='" + passCN + "'", cn);
                        DialogResult result = MessageBox.Show("Phone Number Has Been Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            AccountInfoForm acc = new AccountInfoForm();
                            acc.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Wrong Password or Phone Number. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
