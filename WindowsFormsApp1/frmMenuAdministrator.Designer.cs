
namespace WindowsFormsApp1
{
    partial class frmMenuAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdministrator));
            this.pbxAcademicOfficers = new System.Windows.Forms.PictureBox();
            this.btnAcademicOfficers = new System.Windows.Forms.Button();
            this.pbxCourses = new System.Windows.Forms.PictureBox();
            this.pbxTeachers = new System.Windows.Forms.PictureBox();
            this.pbxStudents = new System.Windows.Forms.PictureBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAcademicOfficers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAcademicOfficers
            // 
            this.pbxAcademicOfficers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAcademicOfficers.Image = ((System.Drawing.Image)(resources.GetObject("pbxAcademicOfficers.Image")));
            this.pbxAcademicOfficers.Location = new System.Drawing.Point(520, 113);
            this.pbxAcademicOfficers.Name = "pbxAcademicOfficers";
            this.pbxAcademicOfficers.Size = new System.Drawing.Size(143, 144);
            this.pbxAcademicOfficers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAcademicOfficers.TabIndex = 56;
            this.pbxAcademicOfficers.TabStop = false;
            // 
            // btnAcademicOfficers
            // 
            this.btnAcademicOfficers.BackColor = System.Drawing.Color.White;
            this.btnAcademicOfficers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcademicOfficers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademicOfficers.Location = new System.Drawing.Point(519, 281);
            this.btnAcademicOfficers.Name = "btnAcademicOfficers";
            this.btnAcademicOfficers.Size = new System.Drawing.Size(143, 74);
            this.btnAcademicOfficers.TabIndex = 55;
            this.btnAcademicOfficers.Text = "Academic Officers";
            this.btnAcademicOfficers.UseVisualStyleBackColor = false;
            this.btnAcademicOfficers.Click += new System.EventHandler(this.btnAcademicOfficers_Click);
            // 
            // pbxCourses
            // 
            this.pbxCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCourses.Image = ((System.Drawing.Image)(resources.GetObject("pbxCourses.Image")));
            this.pbxCourses.Location = new System.Drawing.Point(363, 113);
            this.pbxCourses.Name = "pbxCourses";
            this.pbxCourses.Size = new System.Drawing.Size(143, 144);
            this.pbxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCourses.TabIndex = 51;
            this.pbxCourses.TabStop = false;
            // 
            // pbxTeachers
            // 
            this.pbxTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTeachers.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeachers.Image")));
            this.pbxTeachers.Location = new System.Drawing.Point(203, 113);
            this.pbxTeachers.Name = "pbxTeachers";
            this.pbxTeachers.Size = new System.Drawing.Size(143, 144);
            this.pbxTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeachers.TabIndex = 50;
            this.pbxTeachers.TabStop = false;
            // 
            // pbxStudents
            // 
            this.pbxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudents.Image")));
            this.pbxStudents.Location = new System.Drawing.Point(46, 113);
            this.pbxStudents.Name = "pbxStudents";
            this.pbxStudents.Size = new System.Drawing.Size(143, 144);
            this.pbxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudents.TabIndex = 49;
            this.pbxStudents.TabStop = false;
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.White;
            this.btnTeachers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(203, 281);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(143, 74);
            this.btnTeachers.TabIndex = 48;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.White;
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourses.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(363, 281);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(143, 74);
            this.btnCourses.TabIndex = 46;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.Location = new System.Drawing.Point(24, 36);
            this.lblAdminMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(584, 37);
            this.lblAdminMenu.TabIndex = 54;
            this.lblAdminMenu.Text = "Administrator Menu";
            this.lblAdminMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.White;
            this.btnStudents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(45, 281);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(143, 74);
            this.btnStudents.TabIndex = 47;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(45, 394);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 38);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 458);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbxAcademicOfficers);
            this.Controls.Add(this.btnAcademicOfficers);
            this.Controls.Add(this.pbxCourses);
            this.Controls.Add(this.pbxTeachers);
            this.Controls.Add(this.pbxStudents);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 483);
            this.Name = "frmMenuAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Administrator Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAcademicOfficers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAcademicOfficers;
        private System.Windows.Forms.Button btnAcademicOfficers;
        private System.Windows.Forms.PictureBox pbxCourses;
        private System.Windows.Forms.PictureBox pbxTeachers;
        private System.Windows.Forms.PictureBox pbxStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnExit;
    }
}