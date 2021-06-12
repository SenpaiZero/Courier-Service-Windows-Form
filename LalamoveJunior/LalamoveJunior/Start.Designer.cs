
namespace LalamoveJunior
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.LoginBtn = new ReaLTaiizor.Controls.NightButton();
            this.Password = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Username = new ReaLTaiizor.Controls.MaterialTextBox();
            this.RegBtn = new ReaLTaiizor.Controls.NightLinkLabel();
            this.nightLinkLabel1 = new ReaLTaiizor.Controls.NightLinkLabel();
            this.nightForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.nightLinkLabel1);
            this.nightForm1.Controls.Add(this.RegBtn);
            this.nightForm1.Controls.Add(this.metroControlBox1);
            this.nightForm1.Controls.Add(this.bigLabel1);
            this.nightForm1.Controls.Add(this.LoginBtn);
            this.nightForm1.Controls.Add(this.Password);
            this.nightForm1.Controls.Add(this.Username);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(384, 361);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(284, 0);
            this.metroControlBox1.MaximizeBox = true;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 5;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(128, 56);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(118, 46);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "LOGIN";
            this.bigLabel1.Click += new System.EventHandler(this.bigLabel1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LoginBtn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LoginBtn.HoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.LoginBtn.Location = new System.Drawing.Point(114, 257);
            this.LoginBtn.MinimumSize = new System.Drawing.Size(144, 47);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LoginBtn.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.LoginBtn.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LoginBtn.PressedForeColor = System.Drawing.Color.White;
            this.LoginBtn.Radius = 20;
            this.LoginBtn.Size = new System.Drawing.Size(144, 47);
            this.LoginBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Password";
            this.Password.Location = new System.Drawing.Point(39, 189);
            this.Password.MaxLength = 50;
            this.Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(301, 50);
            this.Password.TabIndex = 2;
            this.Password.Tag = "password";
            this.Password.Text = "";
            this.Password.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Username.Hint = "Username";
            this.Username.Location = new System.Drawing.Point(39, 133);
            this.Username.MaxLength = 50;
            this.Username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(301, 50);
            this.Username.TabIndex = 1;
            this.Username.Tag = "username";
            this.Username.Text = "";
            this.Username.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // RegBtn
            // 
            this.RegBtn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.RegBtn.AutoSize = true;
            this.RegBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RegBtn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.RegBtn.Location = new System.Drawing.Point(118, 307);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(135, 15);
            this.RegBtn.TabIndex = 6;
            this.RegBtn.TabStop = true;
            this.RegBtn.Text = "I don\'t Have an Account";
            this.RegBtn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.RegBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegBtn_LinkClicked);
            // 
            // nightLinkLabel1
            // 
            this.nightLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.nightLinkLabel1.AutoSize = true;
            this.nightLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.nightLinkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.nightLinkLabel1.Location = new System.Drawing.Point(3, 337);
            this.nightLinkLabel1.Name = "nightLinkLabel1";
            this.nightLinkLabel1.Size = new System.Drawing.Size(95, 15);
            this.nightLinkLabel1.TabIndex = 7;
            this.nightLinkLabel1.TabStop = true;
            this.nightLinkLabel1.Text = "Forgot Password";
            this.nightLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.nightLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nightLinkLabel1_LinkClicked);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nightForm1.ResumeLayout(false);
            this.nightForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.MaterialTextBox Password;
        private ReaLTaiizor.Controls.MaterialTextBox Username;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightButton LoginBtn;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.NightLinkLabel RegBtn;
        private ReaLTaiizor.Controls.NightLinkLabel nightLinkLabel1;
    }
}

