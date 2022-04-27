
namespace WindowsFormsApp1
{
    partial class frmMenuAcademicOfficer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAcademicOfficer));
            this.pbxCourses = new System.Windows.Forms.PictureBox();
            this.pbxTeachers = new System.Windows.Forms.PictureBox();
            this.pbxStudents = new System.Windows.Forms.PictureBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.lblAcademicOfficerMenu = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCourses
            // 
            this.pbxCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCourses.Image = ((System.Drawing.Image)(resources.GetObject("pbxCourses.Image")));
            this.pbxCourses.Location = new System.Drawing.Point(402, 121);
            this.pbxCourses.Name = "pbxCourses";
            this.pbxCourses.Size = new System.Drawing.Size(143, 144);
            this.pbxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCourses.TabIndex = 39;
            this.pbxCourses.TabStop = false;
            // 
            // pbxTeachers
            // 
            this.pbxTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTeachers.Image = ((System.Drawing.Image)(resources.GetObject("pbxTeachers.Image")));
            this.pbxTeachers.Location = new System.Drawing.Point(241, 121);
            this.pbxTeachers.Name = "pbxTeachers";
            this.pbxTeachers.Size = new System.Drawing.Size(143, 144);
            this.pbxTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTeachers.TabIndex = 38;
            this.pbxTeachers.TabStop = false;
            // 
            // pbxStudents
            // 
            this.pbxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudents.Image")));
            this.pbxStudents.Location = new System.Drawing.Point(85, 121);
            this.pbxStudents.Name = "pbxStudents";
            this.pbxStudents.Size = new System.Drawing.Size(143, 144);
            this.pbxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudents.TabIndex = 37;
            this.pbxStudents.TabStop = false;
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.White;
            this.btnTeachers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(241, 290);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(143, 74);
            this.btnTeachers.TabIndex = 36;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.White;
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCourses.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(402, 290);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(143, 74);
            this.btnCourses.TabIndex = 34;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // lblAcademicOfficerMenu
            // 
            this.lblAcademicOfficerMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademicOfficerMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicOfficerMenu.Location = new System.Drawing.Point(22, 45);
            this.lblAcademicOfficerMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAcademicOfficerMenu.Name = "lblAcademicOfficerMenu";
            this.lblAcademicOfficerMenu.Size = new System.Drawing.Size(584, 37);
            this.lblAcademicOfficerMenu.TabIndex = 43;
            this.lblAcademicOfficerMenu.Text = "Academic Officer Menu";
            this.lblAcademicOfficerMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.White;
            this.btnStudents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(84, 290);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(143, 74);
            this.btnStudents.TabIndex = 35;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(28, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 38);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "Log-out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMenuAcademicOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbxCourses);
            this.Controls.Add(this.pbxTeachers);
            this.Controls.Add(this.pbxStudents);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.lblAcademicOfficerMenu);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 483);
            this.Name = "frmMenuAcademicOfficer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Academic Officer Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxCourses;
        private System.Windows.Forms.PictureBox pbxTeachers;
        private System.Windows.Forms.PictureBox pbxStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label lblAcademicOfficerMenu;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBack;
    }
}