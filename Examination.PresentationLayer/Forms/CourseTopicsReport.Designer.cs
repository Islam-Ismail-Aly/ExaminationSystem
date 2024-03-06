namespace Examination.PresentationLayer.Forms
{
    partial class CourseTopicsReport
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
            btnCourseTopics = new Button();
            comboCourse = new ComboBox();
            label1 = new Label();
            reportCourseTopics = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnCourseTopics
            // 
            btnCourseTopics.BackColor = Color.DeepSkyBlue;
            btnCourseTopics.FlatAppearance.BorderSize = 0;
            btnCourseTopics.FlatStyle = FlatStyle.Flat;
            btnCourseTopics.Font = new Font("Segoe UI", 10F);
            btnCourseTopics.ForeColor = Color.White;
            btnCourseTopics.Location = new Point(328, 14);
            btnCourseTopics.Name = "btnCourseTopics";
            btnCourseTopics.Size = new Size(109, 30);
            btnCourseTopics.TabIndex = 13;
            btnCourseTopics.Text = "Get Data";
            btnCourseTopics.UseVisualStyleBackColor = false;
            btnCourseTopics.Click += btnCourseTopics_Click;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(109, 18);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(164, 23);
            comboCourse.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 11;
            label1.Text = "Course :";
            // 
            // reportCourseTopics
            // 
            reportCourseTopics.Location = new Point(15, 70);
            reportCourseTopics.Name = "ReportViewer";
            reportCourseTopics.ServerReport.BearerToken = null;
            reportCourseTopics.Size = new Size(650, 450);
            reportCourseTopics.TabIndex = 0;
            // 
            // CourseTopicsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(reportCourseTopics);
            Controls.Add(btnCourseTopics);
            Controls.Add(comboCourse);
            Controls.Add(label1);
            Name = "CourseTopicsReport";
            ShowIcon = false;
            Text = "Course Topics Report";
            Load += CourseTopicsReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCourseTopics;
        private ComboBox comboCourse;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportCourseTopics;
    }
}