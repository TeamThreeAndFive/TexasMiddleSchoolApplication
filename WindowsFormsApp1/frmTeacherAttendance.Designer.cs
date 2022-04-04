﻿
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
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.gbxTakeRoll.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(22, 123);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(92, 27);
            this.lblCourse.TabIndex = 26;
            this.lblCourse.Text = "Course:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(22, 223);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 40);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(138, 223);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbxTakeRoll
            // 
            this.gbxTakeRoll.BackColor = System.Drawing.Color.White;
            this.gbxTakeRoll.Controls.Add(this.btnPrevious);
            this.gbxTakeRoll.Controls.Add(this.btnSave);
            this.gbxTakeRoll.Controls.Add(this.btnNext);
            this.gbxTakeRoll.Controls.Add(this.rbPresent);
            this.gbxTakeRoll.Controls.Add(this.rbLate);
            this.gbxTakeRoll.Controls.Add(this.rbAbsent);
            this.gbxTakeRoll.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTakeRoll.Location = new System.Drawing.Point(318, 123);
            this.gbxTakeRoll.Margin = new System.Windows.Forms.Padding(1);
            this.gbxTakeRoll.Name = "gbxTakeRoll";
            this.gbxTakeRoll.Padding = new System.Windows.Forms.Padding(1);
            this.gbxTakeRoll.Size = new System.Drawing.Size(364, 281);
            this.gbxTakeRoll.TabIndex = 24;
            this.gbxTakeRoll.TabStop = false;
            this.gbxTakeRoll.Text = "Take Roll";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(252, 223);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbPresent
            // 
            this.rbPresent.AutoSize = true;
            this.rbPresent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPresent.Location = new System.Drawing.Point(22, 66);
            this.rbPresent.Margin = new System.Windows.Forms.Padding(1);
            this.rbPresent.Name = "rbPresent";
            this.rbPresent.Size = new System.Drawing.Size(100, 26);
            this.rbPresent.TabIndex = 0;
            this.rbPresent.TabStop = true;
            this.rbPresent.Text = "Present";
            this.rbPresent.UseVisualStyleBackColor = true;
            // 
            // rbLate
            // 
            this.rbLate.AutoSize = true;
            this.rbLate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLate.Location = new System.Drawing.Point(22, 117);
            this.rbLate.Margin = new System.Windows.Forms.Padding(1);
            this.rbLate.Name = "rbLate";
            this.rbLate.Size = new System.Drawing.Size(68, 26);
            this.rbLate.TabIndex = 1;
            this.rbLate.TabStop = true;
            this.rbLate.Text = "Late";
            this.rbLate.UseVisualStyleBackColor = true;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbsent.Location = new System.Drawing.Point(22, 164);
            this.rbAbsent.Margin = new System.Windows.Forms.Padding(1);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(93, 26);
            this.rbAbsent.TabIndex = 2;
            this.rbAbsent.TabStop = true;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UseVisualStyleBackColor = true;
            // 
            // cbxCourse
            // 
            this.cbxCourse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Items.AddRange(new object[] {
            "Math",
            "Science",
            "English",
            "Spanish",
            "Physical Education"});
            this.cbxCourse.Location = new System.Drawing.Point(118, 123);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(178, 30);
            this.cbxCourse.TabIndex = 0;
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 18;
            this.lbxStudents.Items.AddRange(new object[] {
            "List of Students",
            "Will Appear Here "});
            this.lbxStudents.Location = new System.Drawing.Point(27, 176);
            this.lbxStudents.Margin = new System.Windows.Forms.Padding(1);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(269, 346);
            this.lbxStudents.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(717, 28);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.backToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.closeToolStripMenuItem.Text = "Print";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seatingChartToolStripMenuItem,
            this.gradebookToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem.Click += new System.EventHandler(this.seatingChartToolStripMenuItem_Click);
            // 
            // gradebookToolStripMenuItem
            // 
            this.gradebookToolStripMenuItem.Name = "gradebookToolStripMenuItem";
            this.gradebookToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.gradebookToolStripMenuItem.Text = "Gradebook";
            this.gradebookToolStripMenuItem.Click += new System.EventHandler(this.gradebookToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(318, 482);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAttendance
            // 
            this.lblAttendance.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendance.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(66, 49);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(584, 37);
            this.lblAttendance.TabIndex = 22;
            this.lblAttendance.Text = "Attendance";
            this.lblAttendance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 560);
            this.ControlBox = false;
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.gbxTakeRoll);
            this.Controls.Add(this.cbxCourse);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 503);
            this.Name = "frmTeacherAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Attendance ";
            this.gbxTakeRoll.ResumeLayout(false);
            this.gbxTakeRoll.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAttendance;
    }
}