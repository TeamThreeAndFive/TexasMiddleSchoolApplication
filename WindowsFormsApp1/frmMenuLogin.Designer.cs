namespace WindowsFormsApp1
{
    partial class frmMenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuLogin));
            this.pbxMascot = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeePortal = new System.Windows.Forms.Label();
            this.cbxKeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascot)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMascot
            // 
            this.pbxMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMascot.Image = ((System.Drawing.Image)(resources.GetObject("pbxMascot.Image")));
            this.pbxMascot.Location = new System.Drawing.Point(29, 159);
            this.pbxMascot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxMascot.Name = "pbxMascot";
            this.pbxMascot.Size = new System.Drawing.Size(279, 347);
            this.pbxMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMascot.TabIndex = 25;
            this.pbxMascot.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(521, 437);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(249, 66);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(503, 273);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(269, 34);
            this.tbxPassword.TabIndex = 1;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(503, 210);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(269, 34);
            this.tbxUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(357, 277);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(133, 29);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblForgotPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblForgotPassword.Location = new System.Drawing.Point(533, 324);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(191, 28);
            this.llblForgotPassword.TabIndex = 20;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot Password";
            this.llblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForgotPassword_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(356, 210);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 29);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(827, 57);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Texas Middle School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmployeePortal
            // 
            this.lblEmployeePortal.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeePortal.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePortal.Location = new System.Drawing.Point(17, 78);
            this.lblEmployeePortal.Name = "lblEmployeePortal";
            this.lblEmployeePortal.Size = new System.Drawing.Size(817, 55);
            this.lblEmployeePortal.TabIndex = 18;
            this.lblEmployeePortal.Text = "Employee Portal";
            this.lblEmployeePortal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxKeepLoggedIn
            // 
            this.cbxKeepLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.cbxKeepLoggedIn.Checked = true;
            this.cbxKeepLoggedIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxKeepLoggedIn.Font = new System.Drawing.Font("Arial", 10F);
            this.cbxKeepLoggedIn.Location = new System.Drawing.Point(557, 380);
            this.cbxKeepLoggedIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKeepLoggedIn.Name = "cbxKeepLoggedIn";
            this.cbxKeepLoggedIn.Size = new System.Drawing.Size(213, 42);
            this.cbxKeepLoggedIn.TabIndex = 2;
            this.cbxKeepLoggedIn.Text = "Remember me";
            this.cbxKeepLoggedIn.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(363, 437);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenuLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(849, 571);
            this.Controls.Add(this.pbxMascot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.llblForgotPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmployeePortal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbxKeepLoggedIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 608);
            this.Name = "frmMenuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMascot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMascot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPassword;

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeePortal;
        private System.Windows.Forms.CheckBox cbxKeepLoggedIn;
        private System.Windows.Forms.Button btnExit;
      

    }
}

