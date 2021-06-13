
namespace LalamoveJunior.Inquiring
{
    partial class Payment
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
            this.name = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Card = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Exp = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Cvv = new ReaLTaiizor.Controls.MaterialTextBox();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.checkBox1 = new ReaLTaiizor.Controls.CheckBox();
            this.metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            this.metroDivider3 = new ReaLTaiizor.Controls.MetroDivider();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.nightButton1 = new ReaLTaiizor.Controls.NightButton();
            this.nightLinkLabel1 = new ReaLTaiizor.Controls.NightLinkLabel();
            this.nightForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.nightLinkLabel1);
            this.nightForm1.Controls.Add(this.nightButton1);
            this.nightForm1.Controls.Add(this.foxLabel1);
            this.nightForm1.Controls.Add(this.metroDivider3);
            this.nightForm1.Controls.Add(this.metroDivider2);
            this.nightForm1.Controls.Add(this.checkBox1);
            this.nightForm1.Controls.Add(this.bigLabel1);
            this.nightForm1.Controls.Add(this.metroControlBox1);
            this.nightForm1.Controls.Add(this.Cvv);
            this.nightForm1.Controls.Add(this.Exp);
            this.nightForm1.Controls.Add(this.Card);
            this.nightForm1.Controls.Add(this.name);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(324, 450);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            this.nightForm1.Click += new System.EventHandler(this.nightForm1_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Depth = 0;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.name.Hint = "Card Holder Name";
            this.name.Location = new System.Drawing.Point(12, 125);
            this.name.MaxLength = 50;
            this.name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(301, 50);
            this.name.TabIndex = 4;
            this.name.Tag = "username";
            this.name.Text = "";
            // 
            // Card
            // 
            this.Card.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Card.Depth = 0;
            this.Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Card.Hint = "Card Number";
            this.Card.Location = new System.Drawing.Point(12, 181);
            this.Card.MaxLength = 50;
            this.Card.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Card.Multiline = false;
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(301, 50);
            this.Card.TabIndex = 5;
            this.Card.Tag = "username";
            this.Card.Text = "";
            this.Card.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // Exp
            // 
            this.Exp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp.Depth = 0;
            this.Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Exp.Hint = "Expiration";
            this.Exp.Location = new System.Drawing.Point(12, 237);
            this.Exp.MaxLength = 50;
            this.Exp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Exp.Multiline = false;
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(137, 50);
            this.Exp.TabIndex = 6;
            this.Exp.Tag = "username";
            this.Exp.Text = "";
            this.Exp.TextChanged += new System.EventHandler(this.Exp_TextChanged);
            // 
            // Cvv
            // 
            this.Cvv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cvv.Depth = 0;
            this.Cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Cvv.Hint = "CVV";
            this.Cvv.Location = new System.Drawing.Point(155, 237);
            this.Cvv.MaxLength = 50;
            this.Cvv.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Cvv.Multiline = false;
            this.Cvv.Name = "Cvv";
            this.Cvv.Size = new System.Drawing.Size(158, 50);
            this.Cvv.TabIndex = 7;
            this.Cvv.Tag = "username";
            this.Cvv.Text = "";
            this.Cvv.TextChanged += new System.EventHandler(this.Cvv_TextChanged);
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
            this.metroControlBox1.Location = new System.Drawing.Point(224, 0);
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
            this.metroControlBox1.TabIndex = 8;
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
            this.bigLabel1.Location = new System.Drawing.Point(84, 61);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(167, 46);
            this.bigLabel1.TabIndex = 9;
            this.bigLabel1.Text = "PAYMENT";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedDisabledColor = System.Drawing.Color.Gray;
            this.checkBox1.CheckedEnabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Enable = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.checkBox1.Location = new System.Drawing.Point(12, 321);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "CASH ON DELIVERY (COD)";
            // 
            // metroDivider2
            // 
            this.metroDivider2.IsDerivedStyle = true;
            this.metroDivider2.Location = new System.Drawing.Point(12, 304);
            this.metroDivider2.Name = "metroDivider2";
            this.metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            this.metroDivider2.Size = new System.Drawing.Size(121, 4);
            this.metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider2.StyleManager = null;
            this.metroDivider2.TabIndex = 11;
            this.metroDivider2.Text = "metroDivider2";
            this.metroDivider2.ThemeAuthor = "Taiizor";
            this.metroDivider2.ThemeName = "MetroLight";
            this.metroDivider2.Thickness = 1;
            // 
            // metroDivider3
            // 
            this.metroDivider3.IsDerivedStyle = true;
            this.metroDivider3.Location = new System.Drawing.Point(176, 304);
            this.metroDivider3.Name = "metroDivider3";
            this.metroDivider3.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            this.metroDivider3.Size = new System.Drawing.Size(137, 4);
            this.metroDivider3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider3.StyleManager = null;
            this.metroDivider3.TabIndex = 12;
            this.metroDivider3.Text = "metroDivider3";
            this.metroDivider3.ThemeAuthor = "Taiizor";
            this.metroDivider3.ThemeName = "MetroLight";
            this.metroDivider3.Thickness = 1;
            // 
            // foxLabel1
            // 
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(142, 296);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(30, 19);
            this.foxLabel1.TabIndex = 13;
            this.foxLabel1.Text = "OR";
            // 
            // nightButton1
            // 
            this.nightButton1.BackColor = System.Drawing.Color.Transparent;
            this.nightButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nightButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nightButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightButton1.HoverForeColor = System.Drawing.Color.White;
            this.nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.nightButton1.Location = new System.Drawing.Point(92, 366);
            this.nightButton1.MinimumSize = new System.Drawing.Size(144, 47);
            this.nightButton1.Name = "nightButton1";
            this.nightButton1.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.nightButton1.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightButton1.PressedForeColor = System.Drawing.Color.White;
            this.nightButton1.Radius = 20;
            this.nightButton1.Size = new System.Drawing.Size(144, 47);
            this.nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.nightButton1.TabIndex = 14;
            this.nightButton1.Text = "PAY";
            this.nightButton1.Click += new System.EventHandler(this.nightButton1_Click);
            // 
            // nightLinkLabel1
            // 
            this.nightLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.nightLinkLabel1.AutoSize = true;
            this.nightLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.nightLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightLinkLabel1.Location = new System.Drawing.Point(146, 416);
            this.nightLinkLabel1.Name = "nightLinkLabel1";
            this.nightLinkLabel1.Size = new System.Drawing.Size(37, 15);
            this.nightLinkLabel1.TabIndex = 15;
            this.nightLinkLabel1.TabStop = true;
            this.nightLinkLabel1.Text = "BACK";
            this.nightLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.nightForm1.ResumeLayout(false);
            this.nightForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.MaterialTextBox Cvv;
        private ReaLTaiizor.Controls.MaterialTextBox Exp;
        private ReaLTaiizor.Controls.MaterialTextBox Card;
        private ReaLTaiizor.Controls.MaterialTextBox name;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.MetroDivider metroDivider3;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private ReaLTaiizor.Controls.CheckBox checkBox1;
        private ReaLTaiizor.Controls.NightLinkLabel nightLinkLabel1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
    }
}