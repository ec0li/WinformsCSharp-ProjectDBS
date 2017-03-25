namespace ProjectDBS
{
    partial class StudentHome
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
            this.grpStudentMgtHomePage = new System.Windows.Forms.GroupBox();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.dgvViewStudentList = new System.Windows.Forms.DataGridView();
            this.menuViewStudents = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpStudentMgtHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentList)).BeginInit();
            this.menuViewStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudentMgtHomePage
            // 
            this.grpStudentMgtHomePage.Controls.Add(this.btnRefresh);
            this.grpStudentMgtHomePage.Controls.Add(this.btnEditStudent);
            this.grpStudentMgtHomePage.Controls.Add(this.BtnExit);
            this.grpStudentMgtHomePage.Controls.Add(this.btnDeleteStudent);
            this.grpStudentMgtHomePage.Controls.Add(this.btnNewStudent);
            this.grpStudentMgtHomePage.Controls.Add(this.dgvViewStudentList);
            this.grpStudentMgtHomePage.Controls.Add(this.menuViewStudents);
            this.grpStudentMgtHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentMgtHomePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpStudentMgtHomePage.Location = new System.Drawing.Point(12, 12);
            this.grpStudentMgtHomePage.Name = "grpStudentMgtHomePage";
            this.grpStudentMgtHomePage.Size = new System.Drawing.Size(637, 471);
            this.grpStudentMgtHomePage.TabIndex = 0;
            this.grpStudentMgtHomePage.TabStop = false;
            this.grpStudentMgtHomePage.Text = "Student Management Home Page";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(159, 400);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(102, 52);
            this.btnEditStudent.TabIndex = 6;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(529, 400);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(105, 52);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(281, 400);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(105, 52);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(17, 400);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(114, 52);
            this.btnNewStudent.TabIndex = 2;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // dgvViewStudentList
            // 
            this.dgvViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudentList.Location = new System.Drawing.Point(17, 64);
            this.dgvViewStudentList.Name = "dgvViewStudentList";
            this.dgvViewStudentList.Size = new System.Drawing.Size(614, 330);
            this.dgvViewStudentList.TabIndex = 1;
            // 
            // menuViewStudents
            // 
            this.menuViewStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuViewStudents.Location = new System.Drawing.Point(3, 22);
            this.menuViewStudents.Name = "menuViewStudents";
            this.menuViewStudents.Size = new System.Drawing.Size(631, 24);
            this.menuViewStudents.TabIndex = 0;
            this.menuViewStudents.Text = "menuStrip1";
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
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.exitStudentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem1});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.accountToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // exitStudentToolStripMenuItem
            // 
            this.exitStudentToolStripMenuItem.Name = "exitStudentToolStripMenuItem";
            this.exitStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitStudentToolStripMenuItem.Text = "Edit Student";
            this.exitStudentToolStripMenuItem.Click += new System.EventHandler(this.exitStudentToolStripMenuItem_Click);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(402, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 52);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 494);
            this.Controls.Add(this.grpStudentMgtHomePage);
            this.MainMenuStrip = this.menuViewStudents;
            this.Name = "StudentHome";
            this.Text = "ViewStudents";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.grpStudentMgtHomePage.ResumeLayout(false);
            this.grpStudentMgtHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudentList)).EndInit();
            this.menuViewStudents.ResumeLayout(false);
            this.menuViewStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentMgtHomePage;
        private System.Windows.Forms.MenuStrip menuViewStudents;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.DataGridView dgvViewStudentList;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnRefresh;
    }
}