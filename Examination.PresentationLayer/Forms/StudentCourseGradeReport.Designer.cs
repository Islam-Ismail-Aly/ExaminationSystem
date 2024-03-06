namespace Examination.PresentationLayer.Forms
{
    partial class StudentCourseGradeReport
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
            btnStudentDepartment = new Button();
            comboStudnet = new ComboBox();
            label1 = new Label();
            reportStudentCourseGrades = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnStudentDepartment
            // 
            btnStudentDepartment.BackColor = Color.DeepSkyBlue;
            btnStudentDepartment.FlatAppearance.BorderSize = 0;
            btnStudentDepartment.FlatStyle = FlatStyle.Flat;
            btnStudentDepartment.Font = new Font("Segoe UI", 10F);
            btnStudentDepartment.ForeColor = Color.White;
            btnStudentDepartment.Location = new Point(295, 19);
            btnStudentDepartment.Name = "btnStudentDepartment";
            btnStudentDepartment.Size = new Size(109, 30);
            btnStudentDepartment.TabIndex = 10;
            btnStudentDepartment.Text = "Get Data";
            btnStudentDepartment.UseVisualStyleBackColor = false;
            btnStudentDepartment.Click += btnStudentDepartment_Click;
            // 
            // comboStudnet
            // 
            comboStudnet.FormattingEnabled = true;
            comboStudnet.Location = new Point(83, 24);
            comboStudnet.Name = "comboStudnet";
            comboStudnet.Size = new Size(164, 23);
            comboStudnet.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 8;
            label1.Text = "Student :";
            // 
            // reportStudentCourseGrades
            // 
            reportStudentCourseGrades.Location = new Point(15, 70);
            reportStudentCourseGrades.Name = "ReportViewer";
            reportStudentCourseGrades.ServerReport.BearerToken = null;
            reportStudentCourseGrades.Size = new Size(650, 450);
            reportStudentCourseGrades.TabIndex = 0;
            // 
            // StudentCourseGradeReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(reportStudentCourseGrades);
            Controls.Add(btnStudentDepartment);
            Controls.Add(comboStudnet);
            Controls.Add(label1);
            Name = "StudentCourseGradeReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Course Grades Report";
            Load += StudentCourseGradeReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentDepartment;
        private ComboBox comboStudnet;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportStudentCourseGrades;
    }
}