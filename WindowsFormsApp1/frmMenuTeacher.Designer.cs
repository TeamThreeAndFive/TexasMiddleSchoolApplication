
namespace WindowsFormsApp1
{
    partial class frmMenuTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuTeacher));
            this.lblTeacherMenu = new System.Windows.Forms.Label();
            this.pbxAttendance = new System.Windows.Forms.PictureBox();
            this.pbxSeating = new System.Windows.Forms.PictureBox();
            this.pbxGrades = new System.Windows.Forms.PictureBox();
            this.btnSeating = new System.Windows.Forms.Button();
            this.btnGradebook = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherMenu
            // 
            this.lblTeacherMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherMenu.Location = new System.Drawing.Point(8, 45);
            this.lblTeacherMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeacherMenu.Name = "lblTeacherMenu";
            this.lblTeacherMenu.Size = new System.Drawing.Size(620, 37);
            this.lblTeacherMenu.TabIndex = 0;
            this.lblTeacherMenu.Text = "Teacher Menu";
            this.lblTeacherMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxAttendance
            // 
            this.pbxAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAttendance.Image = ((System.Drawing.Image)(resources.GetObject("pbxAttendance.Image")));
            this.pbxAttendance.Location = new System.Drawing.Point(428, 119);
            this.pbxAttendance.Name = "pbxAttendance";
            this.pbxAttendance.Size = new System.Drawing.Size(143, 143);
            this.pbxAttendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAttendance.TabIndex = 29;
            this.pbxAttendance.TabStop = false;
            // 
            // pbxSeating
            // 
            this.pbxSeating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSeating.Image = ((System.Drawing.Image)(resources.GetObject("pbxSeating.Image")));
            this.pbxSeating.Location = new System.Drawing.Point(245, 119);
            this.pbxSeating.Name = "pbxSeating";
            this.pbxSeating.Size = new System.Drawing.Size(143, 143);
            this.pbxSeating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeating.TabIndex = 28;
            this.pbxSeating.TabStop = false;
            // 
            // pbxGrades
            // 
            this.pbxGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxGrades.Image = ((System.Drawing.Image)(resources.GetObject("pbxGrades.Image")));
            this.pbxGrades.Location = new System.Drawing.Point(68, 119);
            this.pbxGrades.Name = "pbxGrades";
            this.pbxGrades.Size = new System.Drawing.Size(143, 143);
            this.pbxGrades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGrades.TabIndex = 27;
            this.pbxGrades.TabStop = false;
            // 
            // btnSeating
            // 
            this.btnSeating.BackColor = System.Drawing.Color.White;
            this.btnSeating.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeating.Location = new System.Drawing.Point(244, 288);
            this.btnSeating.Name = "btnSeating";
            this.btnSeating.Size = new System.Drawing.Size(143, 74);
            this.btnSeating.TabIndex = 2;
            this.btnSeating.Text = "Seating Arrangement";
            this.btnSeating.UseVisualStyleBackColor = false;
            this.btnSeating.Click += new System.EventHandler(this.btnSeating_Click);
            // 
            // btnGradebook
            // 
            this.btnGradebook.BackColor = System.Drawing.Color.White;
            this.btnGradebook.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradebook.Location = new System.Drawing.Point(66, 288);
            this.btnGradebook.Name = "btnGradebook";
            this.btnGradebook.Size = new System.Drawing.Size(143, 74);
            this.btnGradebook.TabIndex = 1;
            this.btnGradebook.Text = "Gradebook";
            this.btnGradebook.UseVisualStyleBackColor = false;
            this.btnGradebook.Click += new System.EventHandler(this.btnGradebook_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.White;
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(426, 288);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(143, 74);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(68, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 38);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Log-out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmMenuTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 476);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTeacherMenu);
            this.Controls.Add(this.pbxAttendance);
            this.Controls.Add(this.pbxSeating);
            this.Controls.Add(this.pbxGrades);
            this.Controls.Add(this.btnSeating);
            this.Controls.Add(this.btnGradebook);
            this.Controls.Add(this.btnAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 459);
            this.Name = "frmMenuTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Teacher Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherMenu;
        private System.Windows.Forms.PictureBox pbxAttendance;
        private System.Windows.Forms.PictureBox pbxSeating;
        private System.Windows.Forms.PictureBox pbxGrades;
        private System.Windows.Forms.Button btnSeating;
        private System.Windows.Forms.Button btnGradebook;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnBack;
    }
}