
namespace WindowsFormsApp1
{
    partial class frmTeacherSeatingChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherSeatingChart));
            this.lblCourse = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSeating = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxSeating = new System.Windows.Forms.GroupBox();
            this.gbxStudents = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.gbxSeating.SuspendLayout();
            this.gbxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(70, 147);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(202, 59);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course:";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 53);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(198, 271);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(2);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(425, 138);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle Seating Arrangement";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // cbxCourse
            // 
            this.cbxCourse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(294, 147);
            this.cbxCourse.Margin = new System.Windows.Forms.Padding(7);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(452, 57);
            this.cbxCourse.TabIndex = 1;
            this.cbxCourse.SelectedIndexChanged += new System.EventHandler(this.cbxCourse_SelectedIndexChanged);
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 41;
            this.lbxStudents.Location = new System.Drawing.Point(18, 121);
            this.lbxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(644, 414);
            this.lbxStudents.TabIndex = 0;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(403, 58);
            this.closeToolStripMenuItem.Text = "Print";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1680, 57);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(117, 53);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.gradebookToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(154, 53);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(404, 58);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click_1);
            // 
            // gradebookToolStripMenuItem
            // 
            this.gradebookToolStripMenuItem.Name = "gradebookToolStripMenuItem";
            this.gradebookToolStripMenuItem.Size = new System.Drawing.Size(404, 58);
            this.gradebookToolStripMenuItem.Text = "Gradebook";
            this.gradebookToolStripMenuItem.Click += new System.EventHandler(this.gradebookToolStripMenuItem_Click_1);
            // 
            // lblSeating
            // 
            this.lblSeating.BackColor = System.Drawing.Color.Transparent;
            this.lblSeating.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeating.Location = new System.Drawing.Point(269, 129);
            this.lblSeating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeating.Name = "lblSeating";
            this.lblSeating.Size = new System.Drawing.Size(1121, 83);
            this.lblSeating.TabIndex = 2;
            this.lblSeating.Text = "Seating Chart";
            this.lblSeating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(45, 105);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 89);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxSeating
            // 
            this.gbxSeating.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSeating.Controls.Add(this.lblCourse);
            this.gbxSeating.Controls.Add(this.cbxCourse);
            this.gbxSeating.Controls.Add(this.btnShuffle);
            this.gbxSeating.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSeating.Location = new System.Drawing.Point(817, 240);
            this.gbxSeating.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSeating.Name = "gbxSeating";
            this.gbxSeating.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSeating.Size = new System.Drawing.Size(810, 563);
            this.gbxSeating.TabIndex = 4;
            this.gbxSeating.TabStop = false;
            this.gbxSeating.Text = "Shuffle Seating";
            // 
            // gbxStudents
            // 
            this.gbxStudents.Controls.Add(this.label1);
            this.gbxStudents.Controls.Add(this.lbxStudents);
            this.gbxStudents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudents.Location = new System.Drawing.Point(45, 240);
            this.gbxStudents.Name = "gbxStudents";
            this.gbxStudents.Size = new System.Drawing.Size(692, 563);
            this.gbxStudents.TabIndex = 3;
            this.gbxStudents.TabStop = false;
            this.gbxStudents.Text = "Student Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seat # | Last Name , First Name";
            // 
            // frmTeacherSeatingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 974);
            this.ControlBox = false;
            this.Controls.Add(this.gbxStudents);
            this.Controls.Add(this.gbxSeating);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblSeating);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1486, 976);
            this.Name = "frmTeacherSeatingChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Seating Chart";
            this.Load += new System.EventHandler(this.frmTeacherSeatingChart_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbxSeating.ResumeLayout(false);
            this.gbxSeating.PerformLayout();
            this.gbxStudents.ResumeLayout(false);
            this.gbxStudents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblSeating;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxSeating;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradebookToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxStudents;
        private System.Windows.Forms.Label label1;
    }
}