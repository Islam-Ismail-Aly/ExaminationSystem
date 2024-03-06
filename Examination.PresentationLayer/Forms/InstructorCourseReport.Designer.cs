namespace Examination.PresentationLayer.Forms
{
    partial class InstructorCourseReport
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
            btnInstructorCourse = new Button();
            comboInstructor = new ComboBox();
            label1 = new Label();
            reportInstructorCourse = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnInstructorCourse
            // 
            btnInstructorCourse.BackColor = Color.DeepSkyBlue;
            btnInstructorCourse.FlatAppearance.BorderSize = 0;
            btnInstructorCourse.FlatStyle = FlatStyle.Flat;
            btnInstructorCourse.Font = new Font("Segoe UI", 10F);
            btnInstructorCourse.ForeColor = Color.White;
            btnInstructorCourse.Location = new Point(326, 19);
            btnInstructorCourse.Name = "btnInstructorCourse";
            btnInstructorCourse.Size = new Size(109, 30);
            btnInstructorCourse.TabIndex = 10;
            btnInstructorCourse.Text = "Get Data";
            btnInstructorCourse.UseVisualStyleBackColor = false;
            btnInstructorCourse.Click += btnInstructorCourse_Click;
            // 
            // comboInstructor
            // 
            comboInstructor.FormattingEnabled = true;
            comboInstructor.Location = new Point(107, 23);
            comboInstructor.Name = "comboInstructor";
            comboInstructor.Size = new Size(164, 23);
            comboInstructor.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 8;
            label1.Text = "Instructor :";
            // 
            // reportInstructorCourse
            // 
            reportInstructorCourse.Location = new Point(15, 80);
            reportInstructorCourse.Name = "ReportViewer";
            reportInstructorCourse.ServerReport.BearerToken = null;
            reportInstructorCourse.Size = new Size(650, 450);
            reportInstructorCourse.TabIndex = 0;
            // 
            // InstructorCourseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(763, 569);
            Controls.Add(reportInstructorCourse);
            Controls.Add(btnInstructorCourse);
            Controls.Add(comboInstructor);
            Controls.Add(label1);
            Name = "InstructorCourseReport";
            ShowIcon = false;
            Text = "Instructor Course Report";
            Load += InstructorCourseReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInstructorCourse;
        private ComboBox comboInstructor;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportInstructorCourse;
    }
}