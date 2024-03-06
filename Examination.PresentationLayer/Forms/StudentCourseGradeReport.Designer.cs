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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCourseGradeReport));
            comboStudnet = new ComboBox();
            label1 = new Label();
            reportStudentCourseGrades = new Microsoft.Reporting.WinForms.ReportViewer();
            btn_Exit = new PictureBox();
            btnStudentDepartment = new CustomMaterialDesign.RButton();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // comboStudnet
            // 
            comboStudnet.FormattingEnabled = true;
            comboStudnet.Location = new Point(135, 22);
            comboStudnet.Name = "comboStudnet";
            comboStudnet.Size = new Size(145, 23);
            comboStudnet.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(65, 22);
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
            // btn_Exit
            // 
            btn_Exit.Image = (Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new Point(727, 1);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(35, 28);
            btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Exit.TabIndex = 17;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btnStudentDepartment
            // 
            btnStudentDepartment.BackColor = Color.DarkTurquoise;
            btnStudentDepartment.BackgroundColor = Color.DarkTurquoise;
            btnStudentDepartment.BorderColor = Color.White;
            btnStudentDepartment.BorderRadius = 20;
            btnStudentDepartment.BorderSize = 0;
            btnStudentDepartment.FlatAppearance.BorderSize = 0;
            btnStudentDepartment.FlatStyle = FlatStyle.Flat;
            btnStudentDepartment.Font = new Font("Microsoft Sans Serif", 10.5F);
            btnStudentDepartment.ForeColor = Color.White;
            btnStudentDepartment.Location = new Point(366, 12);
            btnStudentDepartment.Name = "btnStudentDepartment";
            btnStudentDepartment.Size = new Size(142, 40);
            btnStudentDepartment.TabIndex = 18;
            btnStudentDepartment.Text = "Get Data";
            btnStudentDepartment.TextColor = Color.White;
            btnStudentDepartment.UseVisualStyleBackColor = false;
            btnStudentDepartment.Click += btnStudentDepartment_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 17);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // StudentCourseGradeReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(pictureBox6);
            Controls.Add(btnStudentDepartment);
            Controls.Add(btn_Exit);
            Controls.Add(reportStudentCourseGrades);
            Controls.Add(comboStudnet);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentCourseGradeReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Course Grades Report";
            Load += StudentCourseGradeReport_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboStudnet;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportStudentCourseGrades;
        private PictureBox btn_Exit;
        private CustomMaterialDesign.RButton btnStudentDepartment;
        private PictureBox pictureBox6;
    }
}