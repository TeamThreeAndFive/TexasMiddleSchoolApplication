
namespace WindowsFormsApp1
{
    partial class frmForgotPassword
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRecovery = new System.Windows.Forms.Label();
            this.gbxStep1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblStep11Info = new System.Windows.Forms.Label();
            this.gbxStep2 = new System.Windows.Forms.GroupBox();
            this.pbxShowNoShowPassword = new System.Windows.Forms.PictureBox();
            this.btnConfirmReset = new System.Windows.Forms.Button();
            this.tbxRecoveryCode = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblStep2Info = new System.Windows.Forms.Label();
            this.btnBackToLogIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxStep1.SuspendLayout();
            this.gbxStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowNoShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 30F);
            this.lblTitle.Location = new System.Drawing.Point(287, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Forgot password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblRecovery
            // 
            this.lblRecovery.AutoSize = true;
            this.lblRecovery.Location = new System.Drawing.Point(529, 112);
            this.lblRecovery.Name = "lblRecovery";
            this.lblRecovery.Size = new System.Drawing.Size(144, 22);
            this.lblRecovery.TabIndex = 2;
            this.lblRecovery.Text = "Recovery code:";
            // 
            // gbxStep1
            // 
            this.gbxStep1.Controls.Add(this.btnSend);
            this.gbxStep1.Controls.Add(this.tbxEmail);
            this.gbxStep1.Controls.Add(this.lblStep11Info);
            this.gbxStep1.Controls.Add(this.lblEmail);
            this.gbxStep1.Location = new System.Drawing.Point(23, 91);
            this.gbxStep1.Name = "gbxStep1";
            this.gbxStep1.Size = new System.Drawing.Size(618, 158);
            this.gbxStep1.TabIndex = 3;
            this.gbxStep1.TabStop = false;
            this.gbxStep1.Text = "Step 1: Get a recovery code";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnSend.Font = new System.Drawing.Font("Arial", 14F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(394, 98);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 29);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.tbxEmail.Location = new System.Drawing.Point(102, 98);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(274, 29);
            this.tbxEmail.TabIndex = 0;
            // 
            // lblStep11Info
            // 
            this.lblStep11Info.AutoSize = true;
            this.lblStep11Info.Font = new System.Drawing.Font("Arial", 12.25F);
            this.lblStep11Info.ForeColor = System.Drawing.Color.Black;
            this.lblStep11Info.Location = new System.Drawing.Point(37, 51);
            this.lblStep11Info.Name = "lblStep11Info";
            this.lblStep11Info.Size = new System.Drawing.Size(488, 19);
            this.lblStep11Info.TabIndex = 2;
            this.lblStep11Info.Text = "To get the recovery code, please enter your email then click send.";
            // 
            // gbxStep2
            // 
            this.gbxStep2.Controls.Add(this.pbxShowNoShowPassword);
            this.gbxStep2.Controls.Add(this.btnConfirmReset);
            this.gbxStep2.Controls.Add(this.tbxRecoveryCode);
            this.gbxStep2.Controls.Add(this.tbxNewPassword);
            this.gbxStep2.Controls.Add(this.tbxConfirmPassword);
            this.gbxStep2.Controls.Add(this.lblConfirmPassword);
            this.gbxStep2.Controls.Add(this.lblNewPassword);
            this.gbxStep2.Controls.Add(this.lblStep2Info);
            this.gbxStep2.Controls.Add(this.lblRecovery);
            this.gbxStep2.Location = new System.Drawing.Point(23, 280);
            this.gbxStep2.Name = "gbxStep2";
            this.gbxStep2.Size = new System.Drawing.Size(840, 223);
            this.gbxStep2.TabIndex = 4;
            this.gbxStep2.TabStop = false;
            this.gbxStep2.Text = "Setp 2: Enter a new password.";
            // 
            // pbxShowNoShowPassword
            // 
            this.pbxShowNoShowPassword.Image = global::WindowsFormsApp1.Properties.Resources.showNoShow;
            this.pbxShowNoShowPassword.Location = new System.Drawing.Point(443, 112);
            this.pbxShowNoShowPassword.Name = "pbxShowNoShowPassword";
            this.pbxShowNoShowPassword.Size = new System.Drawing.Size(34, 26);
            this.pbxShowNoShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShowNoShowPassword.TabIndex = 6;
            this.pbxShowNoShowPassword.TabStop = false;
            this.pbxShowNoShowPassword.Click += new System.EventHandler(this.pbxShowNoShowPassword_Click_1);
            // 
            // btnConfirmReset
            // 
            this.btnConfirmReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnConfirmReset.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReset.Location = new System.Drawing.Point(533, 144);
            this.btnConfirmReset.Name = "btnConfirmReset";
            this.btnConfirmReset.Size = new System.Drawing.Size(267, 36);
            this.btnConfirmReset.TabIndex = 3;
            this.btnConfirmReset.Text = "Confirm reset";
            this.btnConfirmReset.UseVisualStyleBackColor = false;
            this.btnConfirmReset.Click += new System.EventHandler(this.btnConfirmReset_Click);
            // 
            // tbxRecoveryCode
            // 
            this.tbxRecoveryCode.BackColor = System.Drawing.SystemColors.Info;
            this.tbxRecoveryCode.Location = new System.Drawing.Point(679, 109);
            this.tbxRecoveryCode.Name = "tbxRecoveryCode";
            this.tbxRecoveryCode.Size = new System.Drawing.Size(121, 29);
            this.tbxRecoveryCode.TabIndex = 2;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNewPassword.Location = new System.Drawing.Point(211, 112);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(217, 29);
            this.tbxNewPassword.TabIndex = 0;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackColor = System.Drawing.SystemColors.Info;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(211, 151);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(217, 29);
            this.tbxConfirmPassword.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(34, 153);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(169, 22);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(34, 114);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(139, 22);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New password:";
            // 
            // lblStep2Info
            // 
            this.lblStep2Info.Font = new System.Drawing.Font("Arial", 12.25F);
            this.lblStep2Info.ForeColor = System.Drawing.Color.Black;
            this.lblStep2Info.Location = new System.Drawing.Point(34, 45);
            this.lblStep2Info.Name = "lblStep2Info";
            this.lblStep2Info.Size = new System.Drawing.Size(766, 43);
            this.lblStep2Info.TabIndex = 3;
            this.lblStep2Info.Text = "To update your password, enter a new password, then re-enter your new password to" +
    " confirm. lastly enter a recovery code that you received in you email and confir" +
    "m reset.";
            // 
            // btnBackToLogIn
            // 
            this.btnBackToLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnBackToLogIn.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogIn.Location = new System.Drawing.Point(663, 153);
            this.btnBackToLogIn.Name = "btnBackToLogIn";
            this.btnBackToLogIn.Size = new System.Drawing.Size(184, 45);
            this.btnBackToLogIn.TabIndex = 5;
            this.btnBackToLogIn.Text = "Back to logIn";
            this.btnBackToLogIn.UseVisualStyleBackColor = false;
            this.btnBackToLogIn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(73)))));
            this.btnClear.Location = new System.Drawing.Point(663, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.ClientSize = new System.Drawing.Size(886, 534);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackToLogIn);
            this.Controls.Add(this.gbxStep2);
            this.Controls.Add(this.gbxStep1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassword";
            this.gbxStep1.ResumeLayout(false);
            this.gbxStep1.PerformLayout();
            this.gbxStep2.ResumeLayout(false);
            this.gbxStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowNoShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRecovery;
        private System.Windows.Forms.GroupBox gbxStep1;
        private System.Windows.Forms.Label lblStep11Info;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.GroupBox gbxStep2;
        private System.Windows.Forms.Label lblStep2Info;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConfirmReset;
        private System.Windows.Forms.TextBox tbxRecoveryCode;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnBackToLogIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbxShowNoShowPassword;
    }
}