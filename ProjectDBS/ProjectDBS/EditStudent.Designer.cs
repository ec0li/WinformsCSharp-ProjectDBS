namespace ProjectDBS
{
    partial class EditStudent
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
            Model.UpdateStudentRecord updateStudentRecord1 = new Model.UpdateStudentRecord();
            Model.UpdateStudentRecord updateStudentRecord2 = new Model.UpdateStudentRecord();
            this.grpEditStudent = new System.Windows.Forms.GroupBox();
            this.ucUpdateRecordControl1 = new UserControls.ucUpdateRecordControl();
            this.menuEditStudentForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpEditStudent.SuspendLayout();
            this.menuEditStudentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditStudent
            // 
            this.grpEditStudent.Controls.Add(this.ucUpdateRecordControl1);
            this.grpEditStudent.Controls.Add(this.menuEditStudentForm);
            this.grpEditStudent.Controls.Add(this.btnExit);
            this.grpEditStudent.Controls.Add(this.btnHome);
            this.grpEditStudent.Controls.Add(this.btnSave);
            this.grpEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditStudent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpEditStudent.Location = new System.Drawing.Point(12, 12);
            this.grpEditStudent.Name = "grpEditStudent";
            this.grpEditStudent.Size = new System.Drawing.Size(551, 453);
            this.grpEditStudent.TabIndex = 0;
            this.grpEditStudent.TabStop = false;
            this.grpEditStudent.Text = "Edit Student";
            // 
            // ucUpdateRecordControl1
            // 
            updateStudentRecord1.AddressLine1 = null;
            updateStudentRecord1.AddressLine2 = null;
            updateStudentRecord1.City = null;
            updateStudentRecord1.County = null;
            updateStudentRecord1.Email = null;
            updateStudentRecord1.FirstName = null;
            updateStudentRecord1.Level = null;
            updateStudentRecord1.Phone = null;
            updateStudentRecord1.StudentNumber = 0;
            updateStudentRecord1.Surname = null;
            this.ucUpdateRecordControl1.DisplayEditRecord = updateStudentRecord1;
            this.ucUpdateRecordControl1.EditOnly = false;
            this.ucUpdateRecordControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUpdateRecordControl1.Location = new System.Drawing.Point(8, 48);
            this.ucUpdateRecordControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ucUpdateRecordControl1.Name = "ucUpdateRecordControl1";
            this.ucUpdateRecordControl1.ReadOnly = false;
            this.ucUpdateRecordControl1.ReadWrite = false;
            this.ucUpdateRecordControl1.Size = new System.Drawing.Size(540, 332);
            this.ucUpdateRecordControl1.TabIndex = 5;
            updateStudentRecord2.AddressLine1 = "";
            updateStudentRecord2.AddressLine2 = "";
            updateStudentRecord2.City = "";
            updateStudentRecord2.County = "";
            updateStudentRecord2.Email = "";
            updateStudentRecord2.FirstName = "";
            updateStudentRecord2.Level = "";
            updateStudentRecord2.Phone = "";
            updateStudentRecord2.StudentNumber = 0;
            updateStudentRecord2.Surname = "";
            this.ucUpdateRecordControl1.UpdateStudent = updateStudentRecord2;
            // 
            // menuEditStudentForm
            // 
            this.menuEditStudentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuNewStudent});
            this.menuEditStudentForm.Location = new System.Drawing.Point(3, 20);
            this.menuEditStudentForm.Name = "menuEditStudentForm";
            this.menuEditStudentForm.Size = new System.Drawing.Size(545, 24);
            this.menuEditStudentForm.TabIndex = 4;
            this.menuEditStudentForm.Text = "menuStrip1";
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
            this.editStudentToolStripMenuItem,
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
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem2.Text = "View Enrolled Students";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(100, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(228, 398);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 30);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 471);
            this.Controls.Add(this.grpEditStudent);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.grpEditStudent.ResumeLayout(false);
            this.grpEditStudent.PerformLayout();
            this.menuEditStudentForm.ResumeLayout(false);
            this.menuEditStudentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuEditStudentForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private UserControls.ucUpdateRecordControl ucUpdateRecordControl1;
    }
}