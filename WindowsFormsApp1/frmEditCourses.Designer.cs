
namespace WindowsFormsApp1
{
    partial class frmEditCourses
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
            this.gbxCourseInformation = new System.Windows.Forms.GroupBox();
            this.tbxCourseTime = new System.Windows.Forms.TextBox();
            this.dtpCourseDate = new System.Windows.Forms.DateTimePicker();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.tbxCourseID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseTime = new System.Windows.Forms.Label();
            this.lblCourseDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEditCourse = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxCourseInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourseInformation
            // 
            this.gbxCourseInformation.Controls.Add(this.tbxCourseTime);
            this.gbxCourseInformation.Controls.Add(this.dtpCourseDate);
            this.gbxCourseInformation.Controls.Add(this.tbxRoom);
            this.gbxCourseInformation.Controls.Add(this.tbxCourseID);
            this.gbxCourseInformation.Controls.Add(this.tbxName);
            this.gbxCourseInformation.Controls.Add(this.lblCourseID);
            this.gbxCourseInformation.Controls.Add(this.lblRoom);
            this.gbxCourseInformation.Controls.Add(this.lblName);
            this.gbxCourseInformation.Controls.Add(this.lblCourseTime);
            this.gbxCourseInformation.Controls.Add(this.lblCourseDate);
            this.gbxCourseInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCourseInformation.Location = new System.Drawing.Point(336, 267);
            this.gbxCourseInformation.Name = "gbxCourseInformation";
            this.gbxCourseInformation.Size = new System.Drawing.Size(788, 453);
            this.gbxCourseInformation.TabIndex = 73;
            this.gbxCourseInformation.TabStop = false;
            this.gbxCourseInformation.Text = "Course Information";
            // 
            // tbxCourseTime
            // 
            this.tbxCourseTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCourseTime.Location = new System.Drawing.Point(253, 280);
            this.tbxCourseTime.Name = "tbxCourseTime";
            this.tbxCourseTime.Size = new System.Drawing.Size(282, 56);
            this.tbxCourseTime.TabIndex = 84;
            // 
            // dtpCourseDate
            // 
            this.dtpCourseDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCourseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCourseDate.Location = new System.Drawing.Point(253, 205);
            this.dtpCourseDate.Name = "dtpCourseDate";
            this.dtpCourseDate.Size = new System.Drawing.Size(280, 56);
            this.dtpCourseDate.TabIndex = 82;
            // 
            // tbxRoom
            // 
            this.tbxRoom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoom.Location = new System.Drawing.Point(253, 354);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.Size = new System.Drawing.Size(280, 56);
            this.tbxRoom.TabIndex = 83;
            this.tbxRoom.TextChanged += new System.EventHandler(this.tbxGuardianPlaceofWork_TextChanged);
            // 
            // tbxCourseID
            // 
            this.tbxCourseID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCourseID.Location = new System.Drawing.Point(253, 59);
            this.tbxCourseID.Name = "tbxCourseID";
            this.tbxCourseID.Size = new System.Drawing.Size(282, 56);
            this.tbxCourseID.TabIndex = 81;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(253, 131);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(280, 56);
            this.tbxName.TabIndex = 80;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(29, 68);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(219, 47);
            this.lblCourseID.TabIndex = 71;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(83, 363);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(144, 47);
            this.lblRoom.TabIndex = 70;
            this.lblRoom.Text = "Room:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(83, 140);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 47);
            this.lblName.TabIndex = 67;
            this.lblName.Text = "Name:";
            // 
            // lblCourseTime
            // 
            this.lblCourseTime.AutoSize = true;
            this.lblCourseTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTime.Location = new System.Drawing.Point(96, 289);
            this.lblCourseTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseTime.Name = "lblCourseTime";
            this.lblCourseTime.Size = new System.Drawing.Size(125, 47);
            this.lblCourseTime.TabIndex = 69;
            this.lblCourseTime.Text = "Time:";
            // 
            // lblCourseDate
            // 
            this.lblCourseDate.AutoSize = true;
            this.lblCourseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDate.Location = new System.Drawing.Point(100, 214);
            this.lblCourseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseDate.Name = "lblCourseDate";
            this.lblCourseDate.Size = new System.Drawing.Size(120, 47);
            this.lblCourseDate.TabIndex = 68;
            this.lblCourseDate.Text = "Date:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 781);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 89);
            this.btnBack.TabIndex = 81;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1450, 83);
            this.lblTitle.TabIndex = 82;
            this.lblTitle.Text = "Texas Middle School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditCourse
            // 
            this.lblEditCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblEditCourse.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCourse.Location = new System.Drawing.Point(2, 136);
            this.lblEditCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditCourse.Name = "lblEditCourse";
            this.lblEditCourse.Size = new System.Drawing.Size(1459, 83);
            this.lblEditCourse.TabIndex = 83;
            this.lblEditCourse.Text = "Edit Course Information";
            this.lblEditCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(1089, 761);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(372, 109);
            this.btnSaveChanges.TabIndex = 84;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEditCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 881);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEditCourse);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxCourseInformation);
            this.Name = "frmEditCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Edit Course";
            this.gbxCourseInformation.ResumeLayout(false);
            this.gbxCourseInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourseInformation;
        private System.Windows.Forms.TextBox tbxCourseTime;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.TextBox tbxCourseID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseTime;
        private System.Windows.Forms.Label lblCourseDate;
        private System.Windows.Forms.DateTimePicker dtpCourseDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEditCourse;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}