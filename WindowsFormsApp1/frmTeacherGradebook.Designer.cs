
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
            this.tbxChangeGrade = new System.Windows.Forms.TextBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.lbxAssignments = new System.Windows.Forms.ListBox();
            this.lblGradebook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxGrade = new System.Windows.Forms.TextBox();
            this.lblChangeGrade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.printMidtermGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(334, 216);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(205, 80);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxChangeGrade
            // 
            this.tbxChangeGrade.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChangeGrade.Location = new System.Drawing.Point(334, 145);
            this.tbxChangeGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxChangeGrade.Name = "tbxChangeGrade";
            this.tbxChangeGrade.Size = new System.Drawing.Size(205, 56);
            this.tbxChangeGrade.TabIndex = 2;
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 41;
            this.lbxStudents.Location = new System.Drawing.Point(28, 96);
            this.lbxStudents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(489, 455);
            this.lbxStudents.TabIndex = 0;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // lbxAssignments
            // 
            this.lbxAssignments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAssignments.FormattingEnabled = true;
            this.lbxAssignments.ItemHeight = 41;
            this.lbxAssignments.Location = new System.Drawing.Point(21, 96);
            this.lbxAssignments.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbxAssignments.Name = "lbxAssignments";
            this.lbxAssignments.Size = new System.Drawing.Size(494, 455);
            this.lbxAssignments.TabIndex = 0;
            this.lbxAssignments.SelectedIndexChanged += new System.EventHandler(this.lbxAssignments_SelectedIndexChanged);
            // 
            // lblGradebook
            // 
            this.lblGradebook.BackColor = System.Drawing.Color.Transparent;
            this.lblGradebook.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradebook.Location = new System.Drawing.Point(222, 96);
            this.lblGradebook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGradebook.Name = "lblGradebook";
            this.lblGradebook.Size = new System.Drawing.Size(1269, 83);
            this.lblGradebook.TabIndex = 2;
            this.lblGradebook.Text = "Gradebook";
            this.lblGradebook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 96);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 89);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 53);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(604, 58);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printMidtermGradesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(117, 53);
            this.fileToolStripMenuItem.Text = "File";
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1729, 57);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.seatingChartToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(154, 53);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem.Click += new System.EventHandler(this.seatingChartToolStripMenuItem_Click);
            // 
            // tbxGrade
            // 
            this.tbxGrade.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrade.Location = new System.Drawing.Point(28, 65);
            this.tbxGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxGrade.Name = "tbxGrade";
            this.tbxGrade.ReadOnly = true;
            this.tbxGrade.Size = new System.Drawing.Size(237, 56);
            this.tbxGrade.TabIndex = 0;
            // 
            // lblChangeGrade
            // 
            this.lblChangeGrade.AutoSize = true;
            this.lblChangeGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeGrade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeGrade.Location = new System.Drawing.Point(7, 145);
            this.lblChangeGrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChangeGrade.Name = "lblChangeGrade";
            this.lblChangeGrade.Size = new System.Drawing.Size(316, 49);
            this.lblChangeGrade.TabIndex = 1;
            this.lblChangeGrade.Text = "Change Grade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxGrade);
            this.groupBox1.Controls.Add(this.lblChangeGrade);
            this.groupBox1.Controls.Add(this.tbxChangeGrade);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1134, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment Grade:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAssignments);
            this.groupBox2.Controls.Add(this.lbxAssignments);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(565, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(539, 613);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assignments List:";
            // 
            // lblAssignments
            // 
            this.lblAssignments.AutoSize = true;
            this.lblAssignments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignments.Location = new System.Drawing.Point(14, 51);
            this.lblAssignments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(402, 41);
            this.lblAssignments.TabIndex = 3;
            this.lblAssignments.Text = "ID # | Assignment Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStudents);
            this.groupBox3.Controls.Add(this.lbxStudents);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(546, 613);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students List:";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(21, 51);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(389, 41);
            this.lblStudents.TabIndex = 2;
            this.lblStudents.Text = "Last Name, First Name";
            // 
            // printMidtermGradesToolStripMenuItem
            // 
            this.printMidtermGradesToolStripMenuItem.Name = "printMidtermGradesToolStripMenuItem";
            this.printMidtermGradesToolStripMenuItem.Size = new System.Drawing.Size(604, 58);
            this.printMidtermGradesToolStripMenuItem.Text = "Print Midterm Grades";
            this.printMidtermGradesToolStripMenuItem.Click += new System.EventHandler(this.printMidtermGradesToolStripMenuItem_Click);
            // 
            // frmTeacherGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1729, 1069);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGradebook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1470, 976);
            this.Name = "frmTeacherGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Gradebook";
            this.Load += new System.EventHandler(this.frmTeacherGradebook_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxChangeGrade;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.ListBox lbxAssignments;
        private System.Windows.Forms.Label lblGradebook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxGrade;
        private System.Windows.Forms.Label lblChangeGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.ToolStripMenuItem printMidtermGradesToolStripMenuItem;
    }
}