
namespace WindowsFormsApp1
{
    partial class frmEditStudents
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEditStudents = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblMailingAddress = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGuardianID = new System.Windows.Forms.Label();
            this.lblGuardianPlaceofWork = new System.Windows.Forms.Label();
            this.lblGuardianWorkPhone = new System.Windows.Forms.Label();
            this.lblGuardianPhone = new System.Windows.Forms.Label();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.gbxGuardianInformation = new System.Windows.Forms.GroupBox();
            this.tbxGuardianWorkPhone = new System.Windows.Forms.TextBox();
            this.tbxGuardianPlaceofWork = new System.Windows.Forms.TextBox();
            this.tbxGuardianPhone = new System.Windows.Forms.TextBox();
            this.tbxGuardianID = new System.Windows.Forms.TextBox();
            this.tbxGuardianName = new System.Windows.Forms.TextBox();
            this.gbxStudentInformation = new System.Windows.Forms.GroupBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxStreetAddress = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxMailingAddress = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbxGuardianInformation.SuspendLayout();
            this.gbxStudentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(976, 454);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 55);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEditStudents
            // 
            this.lblEditStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblEditStudents.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStudents.Location = new System.Drawing.Point(172, 57);
            this.lblEditStudents.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEditStudents.Name = "lblEditStudents";
            this.lblEditStudents.Size = new System.Drawing.Size(1120, 46);
            this.lblEditStudents.TabIndex = 53;
            this.lblEditStudents.Text = "Edit Student Information";
            this.lblEditStudents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(25, 45);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 19);
            this.lblStudentID.TabIndex = 54;
            this.lblStudentID.Text = "Student ID:";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(25, 86);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 19);
            this.lblFirstName.TabIndex = 55;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(25, 126);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(108, 19);
            this.lblMiddleName.TabIndex = 56;
            this.lblMiddleName.Text = "Middle Name:";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(25, 168);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 19);
            this.lblLastName.TabIndex = 57;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(25, 209);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(79, 19);
            this.lblBirthdate.TabIndex = 58;
            this.lblBirthdate.Text = "Birthdate:";
            this.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMailingAddress
            // 
            this.lblMailingAddress.AutoSize = true;
            this.lblMailingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblMailingAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingAddress.Location = new System.Drawing.Point(421, 45);
            this.lblMailingAddress.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMailingAddress.Name = "lblMailingAddress";
            this.lblMailingAddress.Size = new System.Drawing.Size(129, 19);
            this.lblMailingAddress.TabIndex = 59;
            this.lblMailingAddress.Text = "Mailing Address:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(421, 86);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(121, 19);
            this.lblStreetAddress.TabIndex = 60;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(421, 126);
            this.lblCity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 19);
            this.lblCity.TabIndex = 61;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(421, 168);
            this.lblState.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 19);
            this.lblState.TabIndex = 62;
            this.lblState.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(421, 209);
            this.lblZip.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(36, 19);
            this.lblZip.TabIndex = 63;
            this.lblZip.Text = "Zip:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(24, 292);
            this.lblYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 19);
            this.lblYear.TabIndex = 65;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 254);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuardianID
            // 
            this.lblGuardianID.AutoSize = true;
            this.lblGuardianID.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianID.Location = new System.Drawing.Point(33, 54);
            this.lblGuardianID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuardianID.Name = "lblGuardianID";
            this.lblGuardianID.Size = new System.Drawing.Size(103, 19);
            this.lblGuardianID.TabIndex = 71;
            this.lblGuardianID.Text = "Guardian ID:";
            // 
            // lblGuardianPlaceofWork
            // 
            this.lblGuardianPlaceofWork.AutoSize = true;
            this.lblGuardianPlaceofWork.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianPlaceofWork.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianPlaceofWork.Location = new System.Drawing.Point(33, 218);
            this.lblGuardianPlaceofWork.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuardianPlaceofWork.Name = "lblGuardianPlaceofWork";
            this.lblGuardianPlaceofWork.Size = new System.Drawing.Size(119, 19);
            this.lblGuardianPlaceofWork.TabIndex = 70;
            this.lblGuardianPlaceofWork.Text = "Place of Work:";
            // 
            // lblGuardianWorkPhone
            // 
            this.lblGuardianWorkPhone.AutoSize = true;
            this.lblGuardianWorkPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianWorkPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianWorkPhone.Location = new System.Drawing.Point(33, 177);
            this.lblGuardianWorkPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuardianWorkPhone.Name = "lblGuardianWorkPhone";
            this.lblGuardianWorkPhone.Size = new System.Drawing.Size(106, 19);
            this.lblGuardianWorkPhone.TabIndex = 69;
            this.lblGuardianWorkPhone.Text = "Work Phone:";
            // 
            // lblGuardianPhone
            // 
            this.lblGuardianPhone.AutoSize = true;
            this.lblGuardianPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianPhone.Location = new System.Drawing.Point(33, 135);
            this.lblGuardianPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuardianPhone.Name = "lblGuardianPhone";
            this.lblGuardianPhone.Size = new System.Drawing.Size(61, 19);
            this.lblGuardianPhone.TabIndex = 68;
            this.lblGuardianPhone.Text = "Phone:";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardianName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(33, 95);
            this.lblGuardianName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(56, 19);
            this.lblGuardianName.TabIndex = 67;
            this.lblGuardianName.Text = "Name:";
            // 
            // gbxGuardianInformation
            // 
            this.gbxGuardianInformation.Controls.Add(this.tbxGuardianWorkPhone);
            this.gbxGuardianInformation.Controls.Add(this.tbxGuardianPlaceofWork);
            this.gbxGuardianInformation.Controls.Add(this.tbxGuardianPhone);
            this.gbxGuardianInformation.Controls.Add(this.tbxGuardianID);
            this.gbxGuardianInformation.Controls.Add(this.tbxGuardianName);
            this.gbxGuardianInformation.Controls.Add(this.lblGuardianID);
            this.gbxGuardianInformation.Controls.Add(this.lblGuardianPlaceofWork);
            this.gbxGuardianInformation.Controls.Add(this.lblGuardianName);
            this.gbxGuardianInformation.Controls.Add(this.lblGuardianWorkPhone);
            this.gbxGuardianInformation.Controls.Add(this.lblGuardianPhone);
            this.gbxGuardianInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGuardianInformation.Location = new System.Drawing.Point(976, 137);
            this.gbxGuardianInformation.Margin = new System.Windows.Forms.Padding(1);
            this.gbxGuardianInformation.Name = "gbxGuardianInformation";
            this.gbxGuardianInformation.Padding = new System.Windows.Forms.Padding(1);
            this.gbxGuardianInformation.Size = new System.Drawing.Size(451, 303);
            this.gbxGuardianInformation.TabIndex = 1;
            this.gbxGuardianInformation.TabStop = false;
            this.gbxGuardianInformation.Text = "Guardian Information";
            // 
            // tbxGuardianWorkPhone
            // 
            this.tbxGuardianWorkPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuardianWorkPhone.Location = new System.Drawing.Point(196, 166);
            this.tbxGuardianWorkPhone.Margin = new System.Windows.Forms.Padding(1);
            this.tbxGuardianWorkPhone.Name = "tbxGuardianWorkPhone";
            this.tbxGuardianWorkPhone.Size = new System.Drawing.Size(205, 30);
            this.tbxGuardianWorkPhone.TabIndex = 3;
            // 
            // tbxGuardianPlaceofWork
            // 
            this.tbxGuardianPlaceofWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuardianPlaceofWork.Location = new System.Drawing.Point(196, 207);
            this.tbxGuardianPlaceofWork.Margin = new System.Windows.Forms.Padding(1);
            this.tbxGuardianPlaceofWork.Name = "tbxGuardianPlaceofWork";
            this.tbxGuardianPlaceofWork.Size = new System.Drawing.Size(204, 30);
            this.tbxGuardianPlaceofWork.TabIndex = 4;
            // 
            // tbxGuardianPhone
            // 
            this.tbxGuardianPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuardianPhone.Location = new System.Drawing.Point(196, 124);
            this.tbxGuardianPhone.Margin = new System.Windows.Forms.Padding(1);
            this.tbxGuardianPhone.Name = "tbxGuardianPhone";
            this.tbxGuardianPhone.Size = new System.Drawing.Size(204, 30);
            this.tbxGuardianPhone.TabIndex = 2;
            // 
            // tbxGuardianID
            // 
            this.tbxGuardianID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuardianID.Location = new System.Drawing.Point(196, 44);
            this.tbxGuardianID.Margin = new System.Windows.Forms.Padding(1);
            this.tbxGuardianID.Name = "tbxGuardianID";
            this.tbxGuardianID.ReadOnly = true;
            this.tbxGuardianID.Size = new System.Drawing.Size(205, 30);
            this.tbxGuardianID.TabIndex = 0;
            // 
            // tbxGuardianName
            // 
            this.tbxGuardianName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGuardianName.Location = new System.Drawing.Point(196, 84);
            this.tbxGuardianName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxGuardianName.Name = "tbxGuardianName";
            this.tbxGuardianName.Size = new System.Drawing.Size(204, 30);
            this.tbxGuardianName.TabIndex = 1;
            // 
            // gbxStudentInformation
            // 
            this.gbxStudentInformation.Controls.Add(this.dtpBirthdate);
            this.gbxStudentInformation.Controls.Add(this.tbxZip);
            this.gbxStudentInformation.Controls.Add(this.tbxCity);
            this.gbxStudentInformation.Controls.Add(this.tbxState);
            this.gbxStudentInformation.Controls.Add(this.tbxStreetAddress);
            this.gbxStudentInformation.Controls.Add(this.tbxYear);
            this.gbxStudentInformation.Controls.Add(this.tbxMailingAddress);
            this.gbxStudentInformation.Controls.Add(this.tbxEmail);
            this.gbxStudentInformation.Controls.Add(this.tbxLastName);
            this.gbxStudentInformation.Controls.Add(this.tbxFirstName);
            this.gbxStudentInformation.Controls.Add(this.tbxMiddleName);
            this.gbxStudentInformation.Controls.Add(this.tbxStudentID);
            this.gbxStudentInformation.Controls.Add(this.lblEmail);
            this.gbxStudentInformation.Controls.Add(this.lblMiddleName);
            this.gbxStudentInformation.Controls.Add(this.lblBirthdate);
            this.gbxStudentInformation.Controls.Add(this.lblStudentID);
            this.gbxStudentInformation.Controls.Add(this.lblYear);
            this.gbxStudentInformation.Controls.Add(this.lblLastName);
            this.gbxStudentInformation.Controls.Add(this.lblMailingAddress);
            this.gbxStudentInformation.Controls.Add(this.lblZip);
            this.gbxStudentInformation.Controls.Add(this.lblStreetAddress);
            this.gbxStudentInformation.Controls.Add(this.lblState);
            this.gbxStudentInformation.Controls.Add(this.lblFirstName);
            this.gbxStudentInformation.Controls.Add(this.lblCity);
            this.gbxStudentInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudentInformation.Location = new System.Drawing.Point(44, 137);
            this.gbxStudentInformation.Margin = new System.Windows.Forms.Padding(1);
            this.gbxStudentInformation.Name = "gbxStudentInformation";
            this.gbxStudentInformation.Padding = new System.Windows.Forms.Padding(1);
            this.gbxStudentInformation.Size = new System.Drawing.Size(899, 369);
            this.gbxStudentInformation.TabIndex = 0;
            this.gbxStudentInformation.TabStop = false;
            this.gbxStudentInformation.Text = "Student Information";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(157, 205);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(1);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(217, 30);
            this.dtpBirthdate.TabIndex = 4;
            // 
            // tbxZip
            // 
            this.tbxZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZip.Location = new System.Drawing.Point(583, 201);
            this.tbxZip.Margin = new System.Windows.Forms.Padding(1);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(264, 30);
            this.tbxZip.TabIndex = 12;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(583, 119);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(1);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(265, 30);
            this.tbxCity.TabIndex = 10;
            // 
            // tbxState
            // 
            this.tbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxState.Location = new System.Drawing.Point(583, 161);
            this.tbxState.Margin = new System.Windows.Forms.Padding(1);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(264, 30);
            this.tbxState.TabIndex = 11;
            // 
            // tbxStreetAddress
            // 
            this.tbxStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStreetAddress.Location = new System.Drawing.Point(583, 81);
            this.tbxStreetAddress.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStreetAddress.Name = "tbxStreetAddress";
            this.tbxStreetAddress.Size = new System.Drawing.Size(264, 30);
            this.tbxStreetAddress.TabIndex = 9;
            // 
            // tbxYear
            // 
            this.tbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxYear.Location = new System.Drawing.Point(155, 289);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(1);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(219, 30);
            this.tbxYear.TabIndex = 7;
            // 
            // tbxMailingAddress
            // 
            this.tbxMailingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMailingAddress.Location = new System.Drawing.Point(583, 39);
            this.tbxMailingAddress.Margin = new System.Windows.Forms.Padding(1);
            this.tbxMailingAddress.Name = "tbxMailingAddress";
            this.tbxMailingAddress.Size = new System.Drawing.Size(264, 30);
            this.tbxMailingAddress.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(156, 247);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(217, 30);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(157, 161);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(217, 30);
            this.tbxLastName.TabIndex = 3;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(156, 81);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(219, 30);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMiddleName.Location = new System.Drawing.Point(157, 119);
            this.tbxMiddleName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(217, 30);
            this.tbxMiddleName.TabIndex = 2;
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentID.Location = new System.Drawing.Point(157, 39);
            this.tbxStudentID.Margin = new System.Windows.Forms.Padding(1);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.ReadOnly = true;
            this.tbxStudentID.Size = new System.Drawing.Size(217, 30);
            this.tbxStudentID.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(1129, 454);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(297, 55);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmEditStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp3340065;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1465, 572);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.gbxStudentInformation);
            this.Controls.Add(this.gbxGuardianInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEditStudents);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1102, 584);
            this.Name = "frmEditStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texas Middle School - Edit Student";
            this.Load += new System.EventHandler(this.frmEditStudents_Load);
            this.gbxGuardianInformation.ResumeLayout(false);
            this.gbxGuardianInformation.PerformLayout();
            this.gbxStudentInformation.ResumeLayout(false);
            this.gbxStudentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEditStudents;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblMailingAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGuardianID;
        private System.Windows.Forms.Label lblGuardianPlaceofWork;
        private System.Windows.Forms.Label lblGuardianWorkPhone;
        private System.Windows.Forms.Label lblGuardianPhone;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.GroupBox gbxGuardianInformation;
        private System.Windows.Forms.GroupBox gbxStudentInformation;
        private System.Windows.Forms.TextBox tbxGuardianWorkPhone;
        private System.Windows.Forms.TextBox tbxGuardianPlaceofWork;
        private System.Windows.Forms.TextBox tbxGuardianPhone;
        private System.Windows.Forms.TextBox tbxGuardianID;
        private System.Windows.Forms.TextBox tbxGuardianName;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxStreetAddress;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxMailingAddress;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}