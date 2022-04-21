
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
            this.tbxMeetingDays = new System.Windows.Forms.TextBox();
            this.lblMeetingDays = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tbxMeetingTime = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.tbxCourseID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseMeetingTime = new System.Windows.Forms.Label();
            this.lblCourseDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEditCourse = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxCourseInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourseInformation
            // 
            this.gbxCourseInformation.Controls.Add(this.tbxMeetingDays);
            this.gbxCourseInformation.Controls.Add(this.lblMeetingDays);
            this.gbxCourseInformation.Controls.Add(this.endTimePicker);
            this.gbxCourseInformation.Controls.Add(this.lblEndDate);
            this.gbxCourseInformation.Controls.Add(this.tbxMeetingTime);
            this.gbxCourseInformation.Controls.Add(this.startTimePicker);
            this.gbxCourseInformation.Controls.Add(this.tbxRoom);
            this.gbxCourseInformation.Controls.Add(this.tbxCourseID);
            this.gbxCourseInformation.Controls.Add(this.tbxName);
            this.gbxCourseInformation.Controls.Add(this.lblCourseID);
            this.gbxCourseInformation.Controls.Add(this.lblRoom);
            this.gbxCourseInformation.Controls.Add(this.lblName);
            this.gbxCourseInformation.Controls.Add(this.lblCourseMeetingTime);
            this.gbxCourseInformation.Controls.Add(this.lblCourseDate);
            this.gbxCourseInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCourseInformation.Location = new System.Drawing.Point(41, 100);
            this.gbxCourseInformation.Margin = new System.Windows.Forms.Padding(1);
            this.gbxCourseInformation.Name = "gbxCourseInformation";
            this.gbxCourseInformation.Padding = new System.Windows.Forms.Padding(1);
            this.gbxCourseInformation.Size = new System.Drawing.Size(574, 357);
            this.gbxCourseInformation.TabIndex = 0;
            this.gbxCourseInformation.TabStop = false;
            this.gbxCourseInformation.Text = "Course Information";
            // 
            // tbxMeetingDays
            // 
            this.tbxMeetingDays.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMeetingDays.Location = new System.Drawing.Point(236, 245);
            this.tbxMeetingDays.Margin = new System.Windows.Forms.Padding(10);
            this.tbxMeetingDays.Name = "tbxMeetingDays";
            this.tbxMeetingDays.Size = new System.Drawing.Size(279, 29);
            this.tbxMeetingDays.TabIndex = 5;
            // 
            // lblMeetingDays
            // 
            this.lblMeetingDays.AutoSize = true;
            this.lblMeetingDays.BackColor = System.Drawing.Color.Transparent;
            this.lblMeetingDays.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingDays.Location = new System.Drawing.Point(60, 245);
            this.lblMeetingDays.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMeetingDays.Name = "lblMeetingDays";
            this.lblMeetingDays.Size = new System.Drawing.Size(134, 22);
            this.lblMeetingDays.TabIndex = 87;
            this.lblMeetingDays.Text = "Meeting Day\'s:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTimePicker.Location = new System.Drawing.Point(236, 209);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(278, 29);
            this.endTimePicker.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(60, 209);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 22);
            this.lblEndDate.TabIndex = 85;
            this.lblEndDate.Text = "End Date:";
            // 
            // tbxMeetingTime
            // 
            this.tbxMeetingTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMeetingTime.Location = new System.Drawing.Point(236, 281);
            this.tbxMeetingTime.Margin = new System.Windows.Forms.Padding(10);
            this.tbxMeetingTime.Name = "tbxMeetingTime";
            this.tbxMeetingTime.Size = new System.Drawing.Size(279, 29);
            this.tbxMeetingTime.TabIndex = 6;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimePicker.Location = new System.Drawing.Point(236, 173);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(278, 29);
            this.startTimePicker.TabIndex = 3;
            // 
            // tbxRoom
            // 
            this.tbxRoom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoom.Location = new System.Drawing.Point(236, 137);
            this.tbxRoom.Margin = new System.Windows.Forms.Padding(10);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.Size = new System.Drawing.Size(278, 29);
            this.tbxRoom.TabIndex = 2;
            this.tbxRoom.TextChanged += new System.EventHandler(this.tbxGuardianPlaceofWork_TextChanged);
            // 
            // tbxCourseID
            // 
            this.tbxCourseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxCourseID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCourseID.Location = new System.Drawing.Point(236, 65);
            this.tbxCourseID.Margin = new System.Windows.Forms.Padding(10);
            this.tbxCourseID.Name = "tbxCourseID";
            this.tbxCourseID.ReadOnly = true;
            this.tbxCourseID.Size = new System.Drawing.Size(279, 29);
            this.tbxCourseID.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(236, 101);
            this.tbxName.Margin = new System.Windows.Forms.Padding(10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(278, 29);
            this.tbxName.TabIndex = 1;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(60, 65);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(102, 22);
            this.lblCourseID.TabIndex = 71;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(60, 137);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 22);
            this.lblRoom.TabIndex = 70;
            this.lblRoom.Text = "Room:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 101);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 22);
            this.lblName.TabIndex = 67;
            this.lblName.Text = "Name:";
            // 
            // lblCourseMeetingTime
            // 
            this.lblCourseMeetingTime.AutoSize = true;
            this.lblCourseMeetingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseMeetingTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseMeetingTime.Location = new System.Drawing.Point(60, 281);
            this.lblCourseMeetingTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCourseMeetingTime.Name = "lblCourseMeetingTime";
            this.lblCourseMeetingTime.Size = new System.Drawing.Size(129, 22);
            this.lblCourseMeetingTime.TabIndex = 69;
            this.lblCourseMeetingTime.Text = "Meeting Time:";
            // 
            // lblCourseDate
            // 
            this.lblCourseDate.AutoSize = true;
            this.lblCourseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDate.Location = new System.Drawing.Point(60, 173);
            this.lblCourseDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCourseDate.Name = "lblCourseDate";
            this.lblCourseDate.Size = new System.Drawing.Size(99, 22);
            this.lblCourseDate.TabIndex = 68;
            this.lblCourseDate.Text = "Start Date:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(41, 479);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditCourse
            // 
            this.lblEditCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblEditCourse.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCourse.Location = new System.Drawing.Point(10, 38);
            this.lblEditCourse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditCourse.Name = "lblEditCourse";
            this.lblEditCourse.Size = new System.Drawing.Size(625, 37);
            this.lblEditCourse.TabIndex = 83;
            this.lblEditCourse.Text = "Edit Course Information";
            this.lblEditCourse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(452, 479);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(159, 40);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEditCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 529);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblEditCourse);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxCourseInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 505);
            this.Name = "frmEditCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Edit Course";
            this.Load += new System.EventHandler(this.frmEditCourses_Load);
            this.gbxCourseInformation.ResumeLayout(false);
            this.gbxCourseInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourseInformation;
        private System.Windows.Forms.TextBox tbxMeetingTime;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.TextBox tbxCourseID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseMeetingTime;
        private System.Windows.Forms.Label lblCourseDate;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEditCourse;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox tbxMeetingDays;
        private System.Windows.Forms.Label lblMeetingDays;
    }
}