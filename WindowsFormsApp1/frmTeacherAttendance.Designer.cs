
namespace WindowsFormsApp1
{
    partial class frmTeacherAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherAttendance));
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbxTakeRoll = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbPresent = new System.Windows.Forms.RadioButton();
            this.rbLate = new System.Windows.Forms.RadioButton();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.gbxStudents = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTakeRoll.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.gbxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(24, 91);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(165, 47);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(51, 497);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(245, 89);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(322, 497);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(219, 89);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbxTakeRoll
            // 
            this.gbxTakeRoll.BackColor = System.Drawing.SystemColors.Control;
            this.gbxTakeRoll.Controls.Add(this.btnPrevious);
            this.gbxTakeRoll.Controls.Add(this.btnSave);
            this.gbxTakeRoll.Controls.Add(this.btnNext);
            this.gbxTakeRoll.Controls.Add(this.rbPresent);
            this.gbxTakeRoll.Controls.Add(this.rbLate);
            this.gbxTakeRoll.Controls.Add(this.rbAbsent);
            this.gbxTakeRoll.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTakeRoll.Location = new System.Drawing.Point(801, 274);
            this.gbxTakeRoll.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTakeRoll.Name = "gbxTakeRoll";
            this.gbxTakeRoll.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTakeRoll.Size = new System.Drawing.Size(849, 622);
            this.gbxTakeRoll.TabIndex = 4;
            this.gbxTakeRoll.TabStop = false;
            this.gbxTakeRoll.Text = "Take Roll";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(588, 497);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 89);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbPresent
            // 
            this.rbPresent.AutoSize = true;
            this.rbPresent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPresent.Location = new System.Drawing.Point(51, 147);
            this.rbPresent.Margin = new System.Windows.Forms.Padding(2);
            this.rbPresent.Name = "rbPresent";
            this.rbPresent.Size = new System.Drawing.Size(206, 53);
            this.rbPresent.TabIndex = 0;
            this.rbPresent.TabStop = true;
            this.rbPresent.Text = "Present";
            this.rbPresent.UseVisualStyleBackColor = true;
            // 
            // rbLate
            // 
            this.rbLate.AutoSize = true;
            this.rbLate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLate.Location = new System.Drawing.Point(51, 261);
            this.rbLate.Margin = new System.Windows.Forms.Padding(2);
            this.rbLate.Name = "rbLate";
            this.rbLate.Size = new System.Drawing.Size(139, 53);
            this.rbLate.TabIndex = 1;
            this.rbLate.TabStop = true;
            this.rbLate.Text = "Late";
            this.rbLate.UseVisualStyleBackColor = true;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbsent.Location = new System.Drawing.Point(51, 366);
            this.rbAbsent.Margin = new System.Windows.Forms.Padding(2);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(194, 53);
            this.rbAbsent.TabIndex = 2;
            this.rbAbsent.TabStop = true;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UseVisualStyleBackColor = true;
            // 
            // cbxCourse
            // 
            this.cbxCourse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(211, 91);
            this.cbxCourse.Margin = new System.Windows.Forms.Padding(7);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(443, 57);
            this.cbxCourse.TabIndex = 1;
            this.cbxCourse.SelectedIndexChanged += new System.EventHandler(this.cbxCourse_SelectedIndexChanged);
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 41;
            this.lbxStudents.Location = new System.Drawing.Point(32, 227);
            this.lbxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(622, 414);
            this.lbxStudents.TabIndex = 2;
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
            this.menuStrip.Size = new System.Drawing.Size(1673, 57);
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
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(403, 58);
            this.closeToolStripMenuItem.Text = "Print";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatingChartToolStripMenuItem,
            this.gradebookToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(154, 53);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem.Click += new System.EventHandler(this.seatingChartToolStripMenuItem_Click);
            // 
            // gradebookToolStripMenuItem
            // 
            this.gradebookToolStripMenuItem.Name = "gradebookToolStripMenuItem";
            this.gradebookToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.gradebookToolStripMenuItem.Text = "Gradebook";
            this.gradebookToolStripMenuItem.Click += new System.EventHandler(this.gradebookToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 53);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(32, 103);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 89);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAttendance
            // 
            this.lblAttendance.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendance.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(154, 109);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(1363, 83);
            this.lblAttendance.TabIndex = 2;
            this.lblAttendance.Text = "Attendance";
            this.lblAttendance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxStudents
            // 
            this.gbxStudents.Controls.Add(this.label1);
            this.gbxStudents.Controls.Add(this.cbxCourse);
            this.gbxStudents.Controls.Add(this.lblCourse);
            this.gbxStudents.Controls.Add(this.lbxStudents);
            this.gbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudents.Location = new System.Drawing.Point(32, 274);
            this.gbxStudents.Name = "gbxStudents";
            this.gbxStudents.Size = new System.Drawing.Size(692, 655);
            this.gbxStudents.TabIndex = 3;
            this.gbxStudents.TabStop = false;
            this.gbxStudents.Text = "Student Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID # | Last Name, First Name";
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1673, 1023);
            this.ControlBox = false;
            this.Controls.Add(this.gbxStudents);
            this.Controls.Add(this.gbxTakeRoll);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1486, 1025);
            this.Name = "frmTeacherAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Attendance ";
            this.Load += new System.EventHandler(this.frmTeacherAttendance_Load);
            this.gbxTakeRoll.ResumeLayout(false);
            this.gbxTakeRoll.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbxStudents.ResumeLayout(false);
            this.gbxStudents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbxTakeRoll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbPresent;
        private System.Windows.Forms.RadioButton rbLate;
        private System.Windows.Forms.RadioButton rbAbsent;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.GroupBox gbxStudents;
        private System.Windows.Forms.Label label1;
    }
}