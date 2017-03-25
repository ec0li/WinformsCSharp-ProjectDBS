namespace UserControls
{
    partial class ucCourseDetailControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCourseForm = new System.Windows.Forms.Panel();
            this.txtCourseLevel = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseLevel = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.pnlCourseForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourseForm
            // 
            this.pnlCourseForm.Controls.Add(this.txtCourseLevel);
            this.pnlCourseForm.Controls.Add(this.txtCourseName);
            this.pnlCourseForm.Controls.Add(this.txtCourseCode);
            this.pnlCourseForm.Controls.Add(this.lblCourseLevel);
            this.pnlCourseForm.Controls.Add(this.lblCourseName);
            this.pnlCourseForm.Controls.Add(this.lblCourseCode);
            this.pnlCourseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCourseForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlCourseForm.Location = new System.Drawing.Point(0, 0);
            this.pnlCourseForm.Name = "pnlCourseForm";
            this.pnlCourseForm.Size = new System.Drawing.Size(470, 114);
            this.pnlCourseForm.TabIndex = 1;
            // 
            // txtCourseLevel
            // 
            this.txtCourseLevel.Location = new System.Drawing.Point(214, 81);
            this.txtCourseLevel.Name = "txtCourseLevel";
            this.txtCourseLevel.Size = new System.Drawing.Size(253, 22);
            this.txtCourseLevel.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(214, 46);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(253, 22);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(214, 9);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(253, 22);
            this.txtCourseCode.TabIndex = 3;
            // 
            // lblCourseLevel
            // 
            this.lblCourseLevel.AutoSize = true;
            this.lblCourseLevel.Location = new System.Drawing.Point(18, 81);
            this.lblCourseLevel.Name = "lblCourseLevel";
            this.lblCourseLevel.Size = new System.Drawing.Size(99, 16);
            this.lblCourseLevel.TabIndex = 2;
            this.lblCourseLevel.Text = "Course Level";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(18, 46);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(102, 16);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(18, 12);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(98, 16);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "Course Code";
            // 
            // ucCourseDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCourseForm);
            this.Name = "ucCourseDetailControl";
            this.Size = new System.Drawing.Size(486, 134);
            this.Load += new System.EventHandler(this.CourseDetailControl_Load);
            this.pnlCourseForm.ResumeLayout(false);
            this.pnlCourseForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCourseForm;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseLevel;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseLevel;
    }
}
