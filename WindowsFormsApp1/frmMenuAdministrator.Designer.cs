
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxCourses = new System.Windows.Forms.PictureBox();
            this.pbxTeachers = new System.Windows.Forms.PictureBox();
            this.pbxStudents = new System.Windows.Forms.PictureBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
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
            this.pbxAcademicOfficers.Location = new System.Drawing.Point(1127, 251);
            this.pbxAcademicOfficers.Margin = new System.Windows.Forms.Padding(7);
            this.pbxAcademicOfficers.Name = "pbxAcademicOfficers";
            this.pbxAcademicOfficers.Size = new System.Drawing.Size(331, 318);
            this.pbxAcademicOfficers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAcademicOfficers.TabIndex = 56;
            this.pbxAcademicOfficers.TabStop = false;
            // 
            // btnAcademicOfficers
            // 
            this.btnAcademicOfficers.BackColor = System.Drawing.Color.White;
            this.btnAcademicOfficers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcademicOfficers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademicOfficers.Location = new System.Drawing.Point(1124, 627);
            this.btnAcademicOfficers.Margin = new System.Windows.Forms.Padding(7);
            this.btnAcademicOfficers.Name = "btnAcademicOfficers";
            this.btnAcademicOfficers.Size = new System.Drawing.Size(334, 165);
            this.btnAcademicOfficers.TabIndex = 55;
            this.btnAcademicOfficers.Text = "Academic Officers";
            this.btnAcademicOfficers.UseVisualStyleBackColor = false;
            this.btnAcademicOfficers.Click += new System.EventHandler(this.btnAcademicOfficers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(49, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1363, 82);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Texas Middle School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxCourses
            // 
            this.pbxCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCourses.Image = ((System.Drawing.Image)(resources.GetObject("pbxCourses.Image")));
            this.pbxCourses.Location = new System.Drawing.Point(761, 251);
            this.pbxCourses.Margin = new System.Windows.Forms.Padding(7);
            this.pbxCourses.Name = "pbxCourses";
            this.pbxCourses.Size = new System.Drawing.Size(331, 318);
            this.pbxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCourses.TabIndex = 51;
            this.pbxCourses.TabStop = false;
            // 
            // pbxTeachers
            // 
            this.pbxTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTeachers.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeachers.Image")));
            this.pbxTeachers.Location = new System.Drawing.Point(387, 251);
            this.pbxTeachers.Margin = new System.Windows.Forms.Padding(7);
            this.pbxTeachers.Name = "pbxTeachers";
            this.pbxTeachers.Size = new System.Drawing.Size(331, 318);
            this.pbxTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeachers.TabIndex = 50;
            this.pbxTeachers.TabStop = false;
            // 
            // pbxStudents
            // 
            this.pbxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudents.Image")));
            this.pbxStudents.Location = new System.Drawing.Point(22, 251);
            this.pbxStudents.Margin = new System.Windows.Forms.Padding(7);
            this.pbxStudents.Name = "pbxStudents";
            this.pbxStudents.Size = new System.Drawing.Size(331, 318);
            this.pbxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudents.TabIndex = 49;
            this.pbxStudents.TabStop = false;
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.White;
            this.btnTeachers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(387, 627);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(7);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(334, 165);
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
            this.btnCourses.Location = new System.Drawing.Point(761, 627);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(7);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(334, 165);
            this.btnCourses.TabIndex = 46;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.Location = new System.Drawing.Point(49, 125);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(1363, 82);
            this.lblAdminMenu.TabIndex = 54;
            this.lblAdminMenu.Text = "Administrator Menu";
            this.lblAdminMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 907);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 89);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.White;
            this.btnStudents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(19, 627);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(7);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(334, 165);
            this.btnStudents.TabIndex = 47;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // frmMenuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 1021);
            this.Controls.Add(this.pbxAcademicOfficers);
            this.Controls.Add(this.btnAcademicOfficers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxCourses);
            this.Controls.Add(this.pbxTeachers);
            this.Controls.Add(this.pbxStudents);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStudents);
            this.Name = "frmMenuAdministrator";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxCourses;
        private System.Windows.Forms.PictureBox pbxTeachers;
        private System.Windows.Forms.PictureBox pbxStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStudents;
    }
}