namespace ProjectDBS
{
    partial class SysUserRegistration
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
            Model.RegisterUser registerUser3 = new Model.RegisterUser();
            this.grpNewSysUserRegistration = new System.Windows.Forms.GroupBox();
            this.ucSystemUserRegistration1 = new UserControls.ucSystemUserRegistration();
            this.menuNewSysUserForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpNewSysUserRegistration.SuspendLayout();
            this.menuNewSysUserForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewSysUserRegistration
            // 
            this.grpNewSysUserRegistration.Controls.Add(this.ucSystemUserRegistration1);
            this.grpNewSysUserRegistration.Controls.Add(this.menuNewSysUserForm);
            this.grpNewSysUserRegistration.Controls.Add(this.btnExit);
            this.grpNewSysUserRegistration.Controls.Add(this.btnSubmit);
            this.grpNewSysUserRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewSysUserRegistration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpNewSysUserRegistration.Location = new System.Drawing.Point(8, 12);
            this.grpNewSysUserRegistration.Name = "grpNewSysUserRegistration";
            this.grpNewSysUserRegistration.Size = new System.Drawing.Size(551, 585);
            this.grpNewSysUserRegistration.TabIndex = 1;
            this.grpNewSysUserRegistration.TabStop = false;
            this.grpNewSysUserRegistration.Text = "New System Users";
            // 
            // ucSystemUserRegistration1
            // 
            this.ucSystemUserRegistration1.EditOnly = false;
            this.ucSystemUserRegistration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSystemUserRegistration1.Location = new System.Drawing.Point(8, 48);
            this.ucSystemUserRegistration1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucSystemUserRegistration1.Name = "ucSystemUserRegistration1";
            registerUser3.EmployeeFirstName = "";
            registerUser3.EmployeeId = 0;
            registerUser3.EmployeeLastName = "";
            registerUser3.EmployeeUsername = "";
            registerUser3.JobTitle = "";
            registerUser3.ManagerEmail = "";
            registerUser3.ManagerFirstName = "";
            registerUser3.ManagerId = "";
            registerUser3.ManagerLastName = "";
            registerUser3.Password = "218571632389410775135085191239149962414417521679";
            registerUser3.UserStatus = "";
            registerUser3.UserType = "";
            this.ucSystemUserRegistration1.NewUser = registerUser3;
            this.ucSystemUserRegistration1.ReadOnly = false;
            this.ucSystemUserRegistration1.Size = new System.Drawing.Size(543, 490);
            this.ucSystemUserRegistration1.TabIndex = 5;
            // 
            // menuNewSysUserForm
            // 
            this.menuNewSysUserForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuNewStudent});
            this.menuNewSysUserForm.Location = new System.Drawing.Point(3, 20);
            this.menuNewSysUserForm.Name = "menuNewSysUserForm";
            this.menuNewSysUserForm.Size = new System.Drawing.Size(545, 24);
            this.menuNewSysUserForm.TabIndex = 4;
            this.menuNewSysUserForm.Text = "menuStrip1";
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
            this.logoutToolStripMenuItem.Text = "Login";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
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
            this.btnExit.Location = new System.Drawing.Point(147, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(313, 550);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 30);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SysUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 604);
            this.Controls.Add(this.grpNewSysUserRegistration);
            this.Name = "SysUserRegistration";
            this.Text = "SysUserRegistration";
            this.Load += new System.EventHandler(this.SysUserRegistration_Load);
            this.grpNewSysUserRegistration.ResumeLayout(false);
            this.grpNewSysUserRegistration.PerformLayout();
            this.menuNewSysUserForm.ResumeLayout(false);
            this.menuNewSysUserForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewSysUserRegistration;
        private System.Windows.Forms.MenuStrip menuNewSysUserForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private UserControls.ucSystemUserRegistration ucSystemUserRegistration1;
    }
}