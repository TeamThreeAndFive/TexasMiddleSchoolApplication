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
            this.pbxMascot.Location = new System.Drawing.Point(53, 288);
            this.pbxMascot.Margin = new System.Windows.Forms.Padding(4);
            this.pbxMascot.Name = "pbxMascot";
            this.pbxMascot.Size = new System.Drawing.Size(488, 625);
            this.pbxMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMascot.TabIndex = 25;
            this.pbxMascot.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(912, 792);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(436, 121);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(880, 495);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(468, 56);
            this.tbxPassword.TabIndex = 23;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(880, 383);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(468, 56);
            this.tbxUsername.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(626, 502);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(234, 49);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblForgotPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.llblForgotPassword.Location = new System.Drawing.Point(935, 588);
            this.llblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(337, 48);
            this.llblForgotPassword.TabIndex = 20;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(623, 383);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(237, 49);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1446, 101);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Texas Middle School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmployeePortal
            // 
            this.lblEmployeePortal.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeePortal.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePortal.Location = new System.Drawing.Point(29, 142);
            this.lblEmployeePortal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeePortal.Name = "lblEmployeePortal";
            this.lblEmployeePortal.Size = new System.Drawing.Size(1430, 100);
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
            this.cbxKeepLoggedIn.Location = new System.Drawing.Point(975, 688);
            this.cbxKeepLoggedIn.Margin = new System.Windows.Forms.Padding(5);
            this.cbxKeepLoggedIn.Name = "cbxKeepLoggedIn";
            this.cbxKeepLoggedIn.Size = new System.Drawing.Size(373, 76);
            this.cbxKeepLoggedIn.TabIndex = 26;
            this.cbxKeepLoggedIn.Text = "Keep me logged in";
            this.cbxKeepLoggedIn.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(635, 792);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 121);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenuLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1472, 1021);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 1100);
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

