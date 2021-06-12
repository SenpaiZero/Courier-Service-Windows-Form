using System;
using System.Windows.Forms;

namespace LalamoveJunior
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainMenu menu_ = new MainMenu();
            menu_.ShowDialog();
            this.Close();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            if (msgTxt.Text == string.Empty || emailTxt.Text == string.Empty || problemDrop.Text == string.Empty)
            {
                MessageBox.Show("Please Fill Up The Forms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Email has been sent.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
