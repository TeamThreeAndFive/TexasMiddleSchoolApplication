
namespace WindowsFormsApp1
{
    partial class frmEditTeachers
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
            this.gbxTeacherInformation = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEditTeachers = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxTeacherInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTeacherInformation
            // 
            this.gbxTeacherInformation.Controls.Add(this.tbxPassword);
            this.gbxTeacherInformation.Controls.Add(this.lblPassword);
            this.gbxTeacherInformation.Controls.Add(this.tbxEmail);
            this.gbxTeacherInformation.Controls.Add(this.tbxPhone);
            this.gbxTeacherInformation.Controls.Add(this.tbxLastName);
            this.gbxTeacherInformation.Controls.Add(this.tbxFirstName);
            this.gbxTeacherInformation.Controls.Add(this.tbxEmployeeID);
            this.gbxTeacherInformation.Controls.Add(this.lblEmail);
            this.gbxTeacherInformation.Controls.Add(this.lblPhone);
            this.gbxTeacherInformation.Controls.Add(this.lblEmployeeID);
            this.gbxTeacherInformation.Controls.Add(this.lblLastName);
            this.gbxTeacherInformation.Controls.Add(this.lblFirstName);
            this.gbxTeacherInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTeacherInformation.Location = new System.Drawing.Point(41, 117);
            this.gbxTeacherInformation.Margin = new System.Windows.Forms.Padding(1);
            this.gbxTeacherInformation.Name = "gbxTeacherInformation";
            this.gbxTeacherInformation.Padding = new System.Windows.Forms.Padding(1);
            this.gbxTeacherInformation.Size = new System.Drawing.Size(781, 368);
            this.gbxTeacherInformation.TabIndex = 78;
            this.gbxTeacherInformation.TabStop = false;
            this.gbxTeacherInformation.Text = "Teacher Information";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(349, 304);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(1);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(287, 30);
            this.tbxPassword.TabIndex = 75;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(145, 304);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 27);
            this.lblPassword.TabIndex = 74;
            this.lblPassword.Text = "Password:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(348, 258);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(287, 30);
            this.tbxEmail.TabIndex = 73;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(349, 212);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(1);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(287, 30);
            this.tbxPhone.TabIndex = 71;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(349, 166);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(287, 30);
            this.tbxLastName.TabIndex = 70;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(348, 120);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(288, 30);
            this.tbxFirstName.TabIndex = 69;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(349, 74);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(1);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(287, 30);
            this.tbxEmployeeID.TabIndex = 67;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(144, 258);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 27);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(144, 212);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 27);
            this.lblPhone.TabIndex = 64;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(144, 74);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(156, 27);
            this.lblEmployeeID.TabIndex = 54;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(144, 166);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 27);
            this.lblLastName.TabIndex = 57;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(144, 120);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(136, 27);
            this.lblFirstName.TabIndex = 55;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(41, 501);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 49);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditTeachers
            // 
            this.lblEditTeachers.BackColor = System.Drawing.Color.Transparent;
            this.lblEditTeachers.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTeachers.Location = new System.Drawing.Point(13, 42);
            this.lblEditTeachers.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditTeachers.Name = "lblEditTeachers";
            this.lblEditTeachers.Size = new System.Drawing.Size(831, 46);
            this.lblEditTeachers.TabIndex = 76;
            this.lblEditTeachers.Text = "Edit Teacher Information";
            this.lblEditTeachers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(611, 501);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(212, 60);
            this.btnSaveChanges.TabIndex = 82;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEditTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 574);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.gbxTeacherInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEditTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(863, 611);
            this.Name = "frmEditTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Edit Teacher";
            this.Load += new System.EventHandler(this.frmEditTeachers_Load);
            this.gbxTeacherInformation.ResumeLayout(false);
            this.gbxTeacherInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTeacherInformation;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEditTeachers;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}