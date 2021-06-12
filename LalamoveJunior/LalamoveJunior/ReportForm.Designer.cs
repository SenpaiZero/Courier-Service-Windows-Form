
namespace LalamoveJunior
{
    partial class ReportForm
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
            this.back = new ReaLTaiizor.Controls.NightLinkLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.ContinueBtn = new ReaLTaiizor.Controls.NightButton();
            this.msgTxt = new ReaLTaiizor.Controls.CrownTextBox();
            this.emailTxt = new ReaLTaiizor.Controls.CrownTextBox();
            this.problemDrop = new ReaLTaiizor.Controls.CrownComboBox();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.nightForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.back);
            this.nightForm1.Controls.Add(this.bigLabel1);
            this.nightForm1.Controls.Add(this.ContinueBtn);
            this.nightForm1.Controls.Add(this.msgTxt);
            this.nightForm1.Controls.Add(this.emailTxt);
            this.nightForm1.Controls.Add(this.problemDrop);
            this.nightForm1.Controls.Add(this.metroControlBox1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(334, 413);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // back
            // 
            this.back.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.back.Location = new System.Drawing.Point(137, 382);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(37, 15);
            this.back.TabIndex = 12;
            this.back.TabStop = true;
            this.back.Text = "BACK";
            this.back.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(58, 55);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(217, 46);
            this.bigLabel1.TabIndex = 11;
            this.bigLabel1.Text = "CONTACT US";
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContinueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ContinueBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ContinueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ContinueBtn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ContinueBtn.HoverForeColor = System.Drawing.Color.White;
            this.ContinueBtn.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.ContinueBtn.Location = new System.Drawing.Point(91, 332);
            this.ContinueBtn.MinimumSize = new System.Drawing.Size(144, 47);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ContinueBtn.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ContinueBtn.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ContinueBtn.PressedForeColor = System.Drawing.Color.White;
            this.ContinueBtn.Radius = 20;
            this.ContinueBtn.Size = new System.Drawing.Size(144, 47);
            this.ContinueBtn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.ContinueBtn.TabIndex = 10;
            this.ContinueBtn.Text = "CONTINUE";
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // msgTxt
            // 
            this.msgTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.msgTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.msgTxt.Location = new System.Drawing.Point(13, 151);
            this.msgTxt.Multiline = true;
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(301, 175);
            this.msgTxt.TabIndex = 9;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.emailTxt.Location = new System.Drawing.Point(140, 121);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(174, 23);
            this.emailTxt.TabIndex = 8;
            this.emailTxt.Text = "Email Address";
            // 
            // problemDrop
            // 
            this.problemDrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.problemDrop.FormattingEnabled = true;
            this.problemDrop.Items.AddRange(new object[] {
            "Report a Problem",
            "Suggestion"});
            this.problemDrop.Location = new System.Drawing.Point(13, 121);
            this.problemDrop.Name = "problemDrop";
            this.problemDrop.Size = new System.Drawing.Size(121, 24);
            this.problemDrop.TabIndex = 7;
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
            this.metroControlBox1.Location = new System.Drawing.Point(234, 0);
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
            this.metroControlBox1.TabIndex = 0;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 413);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.nightForm1.ResumeLayout(false);
            this.nightForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.NightLinkLabel back;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightButton ContinueBtn;
        private ReaLTaiizor.Controls.CrownTextBox msgTxt;
        private ReaLTaiizor.Controls.CrownTextBox emailTxt;
        private ReaLTaiizor.Controls.CrownComboBox problemDrop;
    }
}