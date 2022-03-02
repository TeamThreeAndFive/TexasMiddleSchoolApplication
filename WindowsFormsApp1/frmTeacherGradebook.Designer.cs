
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1195, 865);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 89);
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
            this.lblChangeGrade.Location = new System.Drawing.Point(667, 881);
            this.lblChangeGrade.Name = "lblChangeGrade";
            this.lblChangeGrade.Size = new System.Drawing.Size(365, 59);
            this.lblChangeGrade.TabIndex = 23;
            this.lblChangeGrade.Text = "Change Grade:";
            // 
            // tbxChangeGrade
            // 
            this.tbxChangeGrade.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChangeGrade.Location = new System.Drawing.Point(1038, 881);
            this.tbxChangeGrade.Name = "tbxChangeGrade";
            this.tbxChangeGrade.Size = new System.Drawing.Size(151, 56);
            this.tbxChangeGrade.TabIndex = 22;
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 41;
            this.lbxStudents.Items.AddRange(new object[] {
            "List of Students",
            "Will Appear Here"});
            this.lbxStudents.Location = new System.Drawing.Point(44, 281);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(569, 578);
            this.lbxStudents.TabIndex = 16;
            // 
            // lbxAssignments
            // 
            this.lbxAssignments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAssignments.FormattingEnabled = true;
            this.lbxAssignments.ItemHeight = 41;
            this.lbxAssignments.Items.AddRange(new object[] {
            "List of Assignments Will Appear Here ",
            "Homework, Quiz, Test, Exam etc..."});
            this.lbxAssignments.Location = new System.Drawing.Point(677, 281);
            this.lbxAssignments.Name = "lbxAssignments";
            this.lbxAssignments.Size = new System.Drawing.Size(725, 578);
            this.lbxAssignments.TabIndex = 17;
            // 
            // lblGradebook
            // 
            this.lblGradebook.BackColor = System.Drawing.Color.Transparent;
            this.lblGradebook.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradebook.Location = new System.Drawing.Point(51, 156);
            this.lblGradebook.Name = "lblGradebook";
            this.lblGradebook.Size = new System.Drawing.Size(1363, 82);
            this.lblGradebook.TabIndex = 21;
            this.lblGradebook.Text = "Gradebook";
            this.lblGradebook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1363, 82);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Texas Middle School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(44, 865);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 89);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 53);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.seatingChartToolStripMenuItem,
            this.gradebookToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(154, 53);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gradebookToolStripMenuItem
            // 
            this.gradebookToolStripMenuItem.Name = "gradebookToolStripMenuItem";
            this.gradebookToolStripMenuItem.Size = new System.Drawing.Size(450, 58);
            this.gradebookToolStripMenuItem.Text = "Gradebook";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(273, 58);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(273, 58);
            this.closeToolStripMenuItem.Text = "Print";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
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
            this.menuStrip.Size = new System.Drawing.Size(1472, 57);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            // 
            // frmTeacherGradebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 1021);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChangeGrade);
            this.Controls.Add(this.tbxChangeGrade);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.lbxAssignments);
            this.Controls.Add(this.lblGradebook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(1500, 1100);
            this.Name = "frmTeacherGradebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Gradebook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}