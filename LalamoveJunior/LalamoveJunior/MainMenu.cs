using System;
using System.Windows.Forms;

namespace LalamoveJunior
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
            this.Close();
        }

        private void account_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfoForm acc = new AccountInfoForm();
            acc.ShowDialog();
            this.Close();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm report = new ReportForm();
            report.ShowDialog();
            this.Close();
        }
    }
}
