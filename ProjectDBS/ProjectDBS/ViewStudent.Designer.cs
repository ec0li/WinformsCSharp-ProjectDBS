namespace ProjectDBS
{
    partial class ViewStudent
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
            this.grpViewStudent = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.menuViewStudentForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordControl1 = new UserControls.ucUpdateRecordControl();
            this.courseDetailControl1 = new UserControls.ucCourseDetailControl();
            this.grpViewStudent.SuspendLayout();
            this.menuViewStudentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpViewStudent
            // 
            this.grpViewStudent.Controls.Add(this.courseDetailControl1);
            this.grpViewStudent.Controls.Add(this.updateRecordControl1);
            this.grpViewStudent.Controls.Add(this.menuViewStudentForm);
            this.grpViewStudent.Controls.Add(this.btnUpdateStudent);
            this.grpViewStudent.Controls.Add(this.btnDeleteStudent);
            this.grpViewStudent.Controls.Add(this.btnHome);
            this.grpViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewStudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpViewStudent.Location = new System.Drawing.Point(12, 12);
            this.grpViewStudent.Name = "grpViewStudent";
            this.grpViewStudent.Size = new System.Drawing.Size(549, 558);
            this.grpViewStudent.TabIndex = 1;
            this.grpViewStudent.TabStop = false;
            this.grpViewStudent.Text = "View Student";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(232, 517);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 30);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(55, 517);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(137, 30);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(369, 517);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(144, 30);
            this.btnUpdateStudent.TabIndex = 5;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // menuViewStudentForm
            // 
            this.menuViewStudentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuNewStudent});
            this.menuViewStudentForm.Location = new System.Drawing.Point(3, 20);
            this.menuViewStudentForm.Name = "menuViewStudentForm";
            this.menuViewStudentForm.Size = new System.Drawing.Size(543, 24);
            this.menuViewStudentForm.TabIndex = 6;
            this.menuViewStudentForm.Text = "menuStrip1";
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
            // updateRecordControl1
            // 
            this.updateRecordControl1.EditOnly = false;
            this.updateRecordControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecordControl1.Location = new System.Drawing.Point(8, 48);
            this.updateRecordControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.updateRecordControl1.Name = "updateRecordControl1";
            this.updateRecordControl1.ReadOnly = false;
            this.updateRecordControl1.ReadWrite = false;
            this.updateRecordControl1.Size = new System.Drawing.Size(541, 341);
            this.updateRecordControl1.TabIndex = 7;
            // 
            // courseDetailControl1
            // 
            this.courseDetailControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDetailControl1.Location = new System.Drawing.Point(3, 379);
            this.courseDetailControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.courseDetailControl1.Name = "courseDetailControl1";
            this.courseDetailControl1.Size = new System.Drawing.Size(550, 117);
            this.courseDetailControl1.TabIndex = 8;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 576);
            this.Controls.Add(this.grpViewStudent);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.grpViewStudent.ResumeLayout(false);
            this.grpViewStudent.PerformLayout();
            this.menuViewStudentForm.ResumeLayout(false);
            this.menuViewStudentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpViewStudent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.MenuStrip menuViewStudentForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private UserControls.ucCourseDetailControl courseDetailControl1;
        private UserControls.ucUpdateRecordControl updateRecordControl1;
    }
}