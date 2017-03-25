namespace ProjectDBS
{
    partial class NewStudent
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
            Model.UpdateCourseRecord updateCourseRecord1 = new Model.UpdateCourseRecord();
            Model.UpdateStudentRecord updateStudentRecord1 = new Model.UpdateStudentRecord();
            this.grpNewStudent = new System.Windows.Forms.GroupBox();
            this.btnSerialise = new System.Windows.Forms.Button();
            this.ucCourseDetailControl1 = new UserControls.ucCourseDetailControl();
            this.ucNewStudentDetails = new UserControls.ucUpdateRecordControl();
            this.menuNewStudentForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpNewStudent.SuspendLayout();
            this.menuNewStudentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewStudent
            // 
            this.grpNewStudent.Controls.Add(this.btnSerialise);
            this.grpNewStudent.Controls.Add(this.ucCourseDetailControl1);
            this.grpNewStudent.Controls.Add(this.ucNewStudentDetails);
            this.grpNewStudent.Controls.Add(this.menuNewStudentForm);
            this.grpNewStudent.Controls.Add(this.btnExit);
            this.grpNewStudent.Controls.Add(this.btnSave);
            this.grpNewStudent.Controls.Add(this.btnHome);
            this.grpNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewStudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpNewStudent.Location = new System.Drawing.Point(12, 12);
            this.grpNewStudent.Name = "grpNewStudent";
            this.grpNewStudent.Size = new System.Drawing.Size(552, 567);
            this.grpNewStudent.TabIndex = 0;
            this.grpNewStudent.TabStop = false;
            this.grpNewStudent.Text = "New Student";
            // 
            // btnSerialise
            // 
            this.btnSerialise.Location = new System.Drawing.Point(310, 519);
            this.btnSerialise.Name = "btnSerialise";
            this.btnSerialise.Size = new System.Drawing.Size(85, 30);
            this.btnSerialise.TabIndex = 6;
            this.btnSerialise.Text = "Serialise";
            this.btnSerialise.UseVisualStyleBackColor = true;
            this.btnSerialise.Click += new System.EventHandler(this.btnSerialise_Click);
            // 
            // ucCourseDetailControl1
            // 
            this.ucCourseDetailControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCourseDetailControl1.Location = new System.Drawing.Point(9, 344);
            this.ucCourseDetailControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucCourseDetailControl1.Name = "ucCourseDetailControl1";
            this.ucCourseDetailControl1.ReadOnly = false;
            this.ucCourseDetailControl1.Size = new System.Drawing.Size(535, 168);
            this.ucCourseDetailControl1.TabIndex = 5;
            updateCourseRecord1.CourseCode = "";
            updateCourseRecord1.CourseLevel = "";
            updateCourseRecord1.CourseName = "";
            this.ucCourseDetailControl1.UpdateCourse = updateCourseRecord1;
            // 
            // ucNewStudentDetails
            // 
            this.ucNewStudentDetails.EditOnly = false;
            this.ucNewStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNewStudentDetails.Location = new System.Drawing.Point(0, 48);
            this.ucNewStudentDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucNewStudentDetails.Name = "ucNewStudentDetails";
            this.ucNewStudentDetails.ReadOnly = false;
            this.ucNewStudentDetails.ReadWrite = false;
            this.ucNewStudentDetails.Size = new System.Drawing.Size(544, 359);
            this.ucNewStudentDetails.TabIndex = 4;
            updateStudentRecord1.AddressLine1 = "";
            updateStudentRecord1.AddressLine2 = "";
            updateStudentRecord1.City = "";
            updateStudentRecord1.County = "";
            updateStudentRecord1.Email = "";
            updateStudentRecord1.FirstName = "";
            updateStudentRecord1.Level = "";
            updateStudentRecord1.Phone = "";
            updateStudentRecord1.StudentNumber = 0;
            updateStudentRecord1.Surname = "";
            this.ucNewStudentDetails.UpdateStudent = updateStudentRecord1;
            // 
            // menuNewStudentForm
            // 
            this.menuNewStudentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuNewStudent});
            this.menuNewStudentForm.Location = new System.Drawing.Point(3, 20);
            this.menuNewStudentForm.Name = "menuNewStudentForm";
            this.menuNewStudentForm.Size = new System.Drawing.Size(546, 24);
            this.menuNewStudentForm.TabIndex = 3;
            this.menuNewStudentForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // menuNewStudent
            // 
            this.menuNewStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.exitStudentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem1});
            this.menuNewStudent.Name = "menuNewStudent";
            this.menuNewStudent.Size = new System.Drawing.Size(60, 20);
            this.menuNewStudent.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // exitStudentToolStripMenuItem
            // 
            this.exitStudentToolStripMenuItem.Name = "exitStudentToolStripMenuItem";
            this.exitStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitStudentToolStripMenuItem.Text = "Edit Student";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem2.Text = "View Enrolled Students";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(444, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(159, 519);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 30);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(573, 590);
            this.Controls.Add(this.grpNewStudent);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            this.grpNewStudent.ResumeLayout(false);
            this.grpNewStudent.PerformLayout();
            this.menuNewStudentForm.ResumeLayout(false);
            this.menuNewStudentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MenuStrip menuNewStudentForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private UserControls.ucUpdateRecordControl ucNewStudentDetails;
        private UserControls.ucCourseDetailControl ucCourseDetailControl1;
        private System.Windows.Forms.Button btnSerialise;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}