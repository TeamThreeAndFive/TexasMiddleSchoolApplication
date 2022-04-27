
namespace WindowsFormsApp1
{
    partial class frmEditAcademicOfficers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAcademicOfficers));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAcademicOfficerInfo = new System.Windows.Forms.Label();
            this.gbxAcademicOfficerInformation = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxAcademicOfficerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(32, 497);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 49);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAcademicOfficerInfo
            // 
            this.lblAcademicOfficerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademicOfficerInfo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicOfficerInfo.Location = new System.Drawing.Point(39, 54);
            this.lblAcademicOfficerInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAcademicOfficerInfo.Name = "lblAcademicOfficerInfo";
            this.lblAcademicOfficerInfo.Size = new System.Drawing.Size(779, 46);
            this.lblAcademicOfficerInfo.TabIndex = 53;
            this.lblAcademicOfficerInfo.Text = "Edit Academic Officer Information";
            this.lblAcademicOfficerInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxAcademicOfficerInformation
            // 
            this.gbxAcademicOfficerInformation.Controls.Add(this.tbxEmail);
            this.gbxAcademicOfficerInformation.Controls.Add(this.tbxPhone);
            this.gbxAcademicOfficerInformation.Controls.Add(this.tbxLastName);
            this.gbxAcademicOfficerInformation.Controls.Add(this.tbxEmployeeID);
            this.gbxAcademicOfficerInformation.Controls.Add(this.tbxFirstName);
            this.gbxAcademicOfficerInformation.Controls.Add(this.lblEmployeeID);
            this.gbxAcademicOfficerInformation.Controls.Add(this.lblPhone);
            this.gbxAcademicOfficerInformation.Controls.Add(this.lblFirstName);
            this.gbxAcademicOfficerInformation.Controls.Add(this.lblEmail);
            this.gbxAcademicOfficerInformation.Controls.Add(this.lblLastName);
            this.gbxAcademicOfficerInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAcademicOfficerInformation.Location = new System.Drawing.Point(32, 137);
            this.gbxAcademicOfficerInformation.Margin = new System.Windows.Forms.Padding(1);
            this.gbxAcademicOfficerInformation.Name = "gbxAcademicOfficerInformation";
            this.gbxAcademicOfficerInformation.Padding = new System.Windows.Forms.Padding(1);
            this.gbxAcademicOfficerInformation.Size = new System.Drawing.Size(785, 297);
            this.gbxAcademicOfficerInformation.TabIndex = 73;
            this.gbxAcademicOfficerInformation.TabStop = false;
            this.gbxAcademicOfficerInformation.Text = "Academic Officer Information";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(316, 171);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(296, 34);
            this.tbxEmail.TabIndex = 84;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(317, 212);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(1);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(295, 34);
            this.tbxPhone.TabIndex = 83;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(317, 129);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(295, 34);
            this.tbxLastName.TabIndex = 82;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(317, 49);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(1);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(296, 34);
            this.tbxEmployeeID.TabIndex = 81;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(317, 89);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(295, 34);
            this.tbxFirstName.TabIndex = 80;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(169, 59);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(108, 19);
            this.lblEmployeeID.TabIndex = 71;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(169, 222);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 19);
            this.lblPhone.TabIndex = 70;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(169, 98);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 19);
            this.lblFirstName.TabIndex = 67;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(169, 181);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(169, 139);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 19);
            this.lblLastName.TabIndex = 68;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(623, 497);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(212, 60);
            this.btnSaveChanges.TabIndex = 82;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEditAcademicOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 574);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.gbxAcademicOfficerInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAcademicOfficerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(863, 611);
            this.Name = "frmEditAcademicOfficers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditAcademicOfficers";
            this.gbxAcademicOfficerInformation.ResumeLayout(false);
            this.gbxAcademicOfficerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAcademicOfficerInfo;
        private System.Windows.Forms.GroupBox gbxAcademicOfficerInformation;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}