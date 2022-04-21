
namespace WindowsFormsApp1
{
    partial class frmCourseAssign
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
            this.gbxSelectCourses = new System.Windows.Forms.GroupBox();
            this.pbxAddButton = new System.Windows.Forms.PictureBox();
            this.lbxCourses = new System.Windows.Forms.ListBox();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.gbxSelectTeachers = new System.Windows.Forms.GroupBox();
            this.lbxTeachers = new System.Windows.Forms.ListBox();
            this.gbxAssignedCourses = new System.Windows.Forms.GroupBox();
            this.pictureRemoveButton = new System.Windows.Forms.PictureBox();
            this.lbxAssignedCourses = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxSelectCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddButton)).BeginInit();
            this.gbxSelectTeachers.SuspendLayout();
            this.gbxAssignedCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRemoveButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSelectCourses
            // 
            this.gbxSelectCourses.Controls.Add(this.pbxAddButton);
            this.gbxSelectCourses.Controls.Add(this.lbxCourses);
            this.gbxSelectCourses.Location = new System.Drawing.Point(406, 126);
            this.gbxSelectCourses.Margin = new System.Windows.Forms.Padding(6);
            this.gbxSelectCourses.Name = "gbxSelectCourses";
            this.gbxSelectCourses.Padding = new System.Windows.Forms.Padding(6);
            this.gbxSelectCourses.Size = new System.Drawing.Size(324, 536);
            this.gbxSelectCourses.TabIndex = 0;
            this.gbxSelectCourses.TabStop = false;
            this.gbxSelectCourses.Text = "Select from available courses";
            // 
            // pbxAddButton
            // 
            this.pbxAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbxAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAddButton.Image = global::WindowsFormsApp1.Properties.Resources.plusNew;
            this.pbxAddButton.Location = new System.Drawing.Point(229, 448);
            this.pbxAddButton.Name = "pbxAddButton";
            this.pbxAddButton.Size = new System.Drawing.Size(61, 59);
            this.pbxAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAddButton.TabIndex = 3;
            this.pbxAddButton.TabStop = false;
            this.pbxAddButton.Click += new System.EventHandler(this.pbxAddButton_Click);
            this.pbxAddButton.MouseEnter += new System.EventHandler(this.pbxAddButton_MouseEnter);
            this.pbxAddButton.MouseLeave += new System.EventHandler(this.pbxAddButton_MouseLeave);
            // 
            // lbxCourses
            // 
            this.lbxCourses.FormattingEnabled = true;
            this.lbxCourses.ItemHeight = 24;
            this.lbxCourses.Location = new System.Drawing.Point(21, 56);
            this.lbxCourses.Name = "lbxCourses";
            this.lbxCourses.Size = new System.Drawing.Size(283, 460);
            this.lbxCourses.TabIndex = 0;
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.Location = new System.Drawing.Point(274, 61);
            this.lblAdminMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(584, 37);
            this.lblAdminMenu.TabIndex = 1;
            this.lblAdminMenu.Text = "Assign Courses to the Teachers";
            this.lblAdminMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxSelectTeachers
            // 
            this.gbxSelectTeachers.Controls.Add(this.lbxTeachers);
            this.gbxSelectTeachers.Location = new System.Drawing.Point(46, 126);
            this.gbxSelectTeachers.Margin = new System.Windows.Forms.Padding(6);
            this.gbxSelectTeachers.Name = "gbxSelectTeachers";
            this.gbxSelectTeachers.Padding = new System.Windows.Forms.Padding(6);
            this.gbxSelectTeachers.Size = new System.Drawing.Size(324, 536);
            this.gbxSelectTeachers.TabIndex = 1;
            this.gbxSelectTeachers.TabStop = false;
            this.gbxSelectTeachers.Text = "Select teachers";
            // 
            // lbxTeachers
            // 
            this.lbxTeachers.FormattingEnabled = true;
            this.lbxTeachers.ItemHeight = 24;
            this.lbxTeachers.Location = new System.Drawing.Point(21, 56);
            this.lbxTeachers.Name = "lbxTeachers";
            this.lbxTeachers.Size = new System.Drawing.Size(283, 460);
            this.lbxTeachers.TabIndex = 0;
            this.lbxTeachers.SelectedIndexChanged += new System.EventHandler(this.lbxTeachers_SelectedIndexChanged);
            // 
            // gbxAssignedCourses
            // 
            this.gbxAssignedCourses.Controls.Add(this.pictureRemoveButton);
            this.gbxAssignedCourses.Controls.Add(this.lbxAssignedCourses);
            this.gbxAssignedCourses.Location = new System.Drawing.Point(762, 126);
            this.gbxAssignedCourses.Margin = new System.Windows.Forms.Padding(6);
            this.gbxAssignedCourses.Name = "gbxAssignedCourses";
            this.gbxAssignedCourses.Padding = new System.Windows.Forms.Padding(6);
            this.gbxAssignedCourses.Size = new System.Drawing.Size(324, 536);
            this.gbxAssignedCourses.TabIndex = 2;
            this.gbxAssignedCourses.TabStop = false;
            this.gbxAssignedCourses.Text = "Assigned Courses";
            // 
            // pictureRemoveButton
            // 
            this.pictureRemoveButton.BackColor = System.Drawing.Color.Tomato;
            this.pictureRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRemoveButton.Image = global::WindowsFormsApp1.Properties.Resources.subtract;
            this.pictureRemoveButton.Location = new System.Drawing.Point(233, 448);
            this.pictureRemoveButton.Name = "pictureRemoveButton";
            this.pictureRemoveButton.Size = new System.Drawing.Size(61, 59);
            this.pictureRemoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRemoveButton.TabIndex = 4;
            this.pictureRemoveButton.TabStop = false;
            this.pictureRemoveButton.Click += new System.EventHandler(this.pictureRemoveButton_Click);
            this.pictureRemoveButton.MouseEnter += new System.EventHandler(this.pictureRemoveButton_MouseEnter);
            this.pictureRemoveButton.MouseLeave += new System.EventHandler(this.pictureRemoveButton_MouseLeave);
            // 
            // lbxAssignedCourses
            // 
            this.lbxAssignedCourses.FormattingEnabled = true;
            this.lbxAssignedCourses.ItemHeight = 24;
            this.lbxAssignedCourses.Location = new System.Drawing.Point(21, 56);
            this.lbxAssignedCourses.Name = "lbxAssignedCourses";
            this.lbxAssignedCourses.Size = new System.Drawing.Size(283, 460);
            this.lbxAssignedCourses.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(46, 682);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmCourseAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 739);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxAssignedCourses);
            this.Controls.Add(this.gbxSelectCourses);
            this.Controls.Add(this.gbxSelectTeachers);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCourseAssign";
            this.Load += new System.EventHandler(this.frmCourseAssign_Load);
            this.gbxSelectCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddButton)).EndInit();
            this.gbxSelectTeachers.ResumeLayout(false);
            this.gbxAssignedCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRemoveButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelectCourses;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.ListBox lbxCourses;
        private System.Windows.Forms.GroupBox gbxSelectTeachers;
        private System.Windows.Forms.ListBox lbxTeachers;
        private System.Windows.Forms.GroupBox gbxAssignedCourses;
        private System.Windows.Forms.ListBox lbxAssignedCourses;
        private System.Windows.Forms.PictureBox pbxAddButton;
        private System.Windows.Forms.PictureBox pictureRemoveButton;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}