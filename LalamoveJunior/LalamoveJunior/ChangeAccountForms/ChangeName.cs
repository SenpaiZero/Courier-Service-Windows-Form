using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LalamoveJunior.ChangeAccountForms
{
    public partial class ChangeName : Form
    {
        SqlConnection cn;
        string passCN;
        public ChangeName()
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

        private void nightButton1_Click(object sender, EventArgs e)
        {
            if (CurrentName.Text != string.Empty || NewName.Text != string.Empty || Pass.Text != string.Empty)
            {
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginDB.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from userLogin where username='" + passCN +
                    "' and password='" + Pass.Text +
                    "' and Name='" + CurrentName.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("update userLogin set Name='" + NewName.Text + "' where username='" + passCN + "'", cn);
                        DialogResult result = MessageBox.Show("Name Has Been Changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Wrong Password or Name. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeName_Load(object sender, EventArgs e)
        {
            passCN = Start.username;
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
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
    }
}
