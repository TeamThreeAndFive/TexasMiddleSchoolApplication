
namespace WindowsFormsApp1
{
    partial class frmTeacherGradebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherGradebook));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblChangeGrade = new System.Windows.Forms.Label();
            this.tbxChangeGrade = new System.Windows.Forms.TextBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.lbxAssignments = new System.Windows.Forms.ListBox();
            this.lblGradebook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStudnetList = new System.Windows.Forms.Label();
            this.lblAssignmentsList = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(628, 443);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 40);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblChangeGrade
            // 
            this.lblChangeGrade.AutoSize = true;
            this.lblChangeGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeGrade.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeGrade.Location = new System.Drawing.Point(346, 450);
            this.lblChangeGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeGrade.Name = "lblChangeGrade";
            this.lblChangeGrade.Size = new System.Drawing.Size(167, 27);
            this.lblChangeGrade.TabIndex = 23;
            this.lblChangeGrade.Text = "Change Grade:";
            // 
            // tbxChangeGrade
            // 
            this.tbxChangeGrade.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChangeGrade.Location = new System.Drawing.Point(517, 448);
            this.tbxChangeGrade.Margin = new System.Windows.Forms.Padding(2);
            this.tbxChangeGrade.Name = "tbxChangeGrade";
            this.tbxChangeGrade.Size = new System.Drawing.Size(91, 29);
            this.tbxChangeGrade.TabIndex = 22;
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 18;
            this.lbxStudents.Items.AddRange(new object[] {
            "List of Students",
            "Will Appear Here"});
            this.lbxStudents.Location = new System.Drawing.Point(20, 190);
            this.lbxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(246, 238);
            this.lbxStudents.TabIndex = 16;
            // 
            // lbxAssignments
            // 
            this.lbxAssignments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAssignments.FormattingEnabled = true;
            this.lbxAssignments.ItemHeight = 18;
            this.lbxAssignments.Items.AddRange(new object[] {
            "List of Assignments Will Appear Here ",
            "Homework, Quiz, Test, Exam etc..."});
            this.lbxAssignments.Location = new System.Drawing.Point(292, 190);
            this.lbxAssignments.Margin = new System.Windows.Forms.Padding(2);
            this.lbxAssignments.Name = "lbxAssignments";
            this.lbxAssignments.Size = new System.Drawing.Size(428, 238);
            this.lbxAssignments.TabIndex = 17;
            // 
            // lblGradebook
            // 
            this.lblGradebook.BackColor = System.Drawing.Color.Transparent;
            this.lblGradebook.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradebook.Location = new System.Drawing.Point(78, 68);
            this.lblGradebook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradebook.Name = "lblGradebook";
            this.lblGradebook.Size = new System.Drawing.Size(584, 37);
            this.lblGradebook.TabIndex = 21;
            this.lblGradebook.Text = "Gradebook";
            this.lblGradebook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 443);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.closeToolStripMenuItem.Text = "Print";
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
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(741, 28);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.seatingChartToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem.Click += new System.EventHandler(this.seatingChartToolStripMenuItem_Click);
            // 
            // lblStudnetList
            // 
            this.lblStudnetList.AutoSize = true;
            this.lblStudnetList.BackColor = System.Drawing.Color.Transparent;
            this.lblStudnetList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudnetList.Location = new System.Drawing.Point(16, 153);
            this.lblStudnetList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudnetList.Name = "lblStudnetList";
            this.lblStudnetList.Size = new System.Drawing.Size(125, 22);
            this.lblStudnetList.TabIndex = 25;
            this.lblStudnetList.Text = "Students List:";
            // 
            // lblAssignmentsList
            // 
            this.lblAssignmentsList.AutoSize = true;
            this.lblAssignmentsList.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignmentsList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentsList.Location = new System.Drawing.Point(288, 153);
            this.lblAssignmentsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignmentsList.Name = "lblAssignmentsList";
            this.lblAssignmentsList.Size = new System.Drawing.Size(160, 22);
            this.lblAssignmentsList.TabIndex = 26;
            this.lblAssignmentsList.Text = "Assignments List:";
            // 
            // frmTeacherGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 510);
            this.ControlBox = false;
            this.Controls.Add(this.lblAssignmentsList);
            this.Controls.Add(this.lblStudnetList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChangeGrade);
            this.Controls.Add(this.tbxChangeGrade);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.lbxAssignments);
            this.Controls.Add(this.lblGradebook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 503);
            this.Name = "frmTeacherGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Gradebook";
            this.Load += new System.EventHandler(this.frmTeacherGradebook_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblChangeGrade;
        private System.Windows.Forms.TextBox tbxChangeGrade;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.ListBox lbxAssignments;
        private System.Windows.Forms.Label lblGradebook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblStudnetList;
        private System.Windows.Forms.Label lblAssignmentsList;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
    }
}