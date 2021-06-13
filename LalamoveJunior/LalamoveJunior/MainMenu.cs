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

            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
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

        private void Inquire_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inquiring.SelectLocation loc = new Inquiring.SelectLocation();
            loc.ShowDialog();
            this.Close();

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

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            about aboutt = new about();
            aboutt.ShowDialog();
            this.Close();
        }
    }
}
