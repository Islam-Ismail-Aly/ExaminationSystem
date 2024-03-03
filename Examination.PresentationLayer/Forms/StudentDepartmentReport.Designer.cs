namespace Examination.PresentationLayer.Forms
{
    partial class StudentDepartmentReport
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
            label1 = new Label();
            comboDepartment = new ComboBox();
            btnStudentDepartment = new Button();
            reportViewerStudentDepartment = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "Department :";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(108, 19);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(164, 23);
            comboDepartment.TabIndex = 1;
            // 
            // btnStudentDepartment
            // 
            btnStudentDepartment.BackColor = Color.DeepSkyBlue;
            btnStudentDepartment.FlatAppearance.BorderSize = 0;
            btnStudentDepartment.FlatStyle = FlatStyle.Flat;
            btnStudentDepartment.Font = new Font("Segoe UI", 10F);
            btnStudentDepartment.ForeColor = Color.White;
            btnStudentDepartment.Location = new Point(327, 15);
            btnStudentDepartment.Name = "btnStudentDepartment";
            btnStudentDepartment.Size = new Size(109, 30);
            btnStudentDepartment.TabIndex = 7;
            btnStudentDepartment.Text = "Get Data";
            btnStudentDepartment.UseVisualStyleBackColor = false;
            btnStudentDepartment.Click += btnStudentDepartment_Click;
            // 
            // reportViewerStudentDepartment
            // 
            reportViewerStudentDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewerStudentDepartment.Location = new Point(15, 70);
            reportViewerStudentDepartment.Name = "ReportViewer";
            reportViewerStudentDepartment.ServerReport.BearerToken = null;
            reportViewerStudentDepartment.Size = new Size(633, 450);
            reportViewerStudentDepartment.TabIndex = 0;
            // 
            // StudentDepartmentReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(733, 569);
            Controls.Add(reportViewerStudentDepartment);
            Controls.Add(btnStudentDepartment);
            Controls.Add(comboDepartment);
            Controls.Add(label1);
            Name = "StudentDepartmentReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Department Report";
            Load += StudentDepartmentReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboDepartment;
        private Button btnStudentDepartment;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStudentDepartment;
    }
}