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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorCourseReport));
            comboInstructor = new ComboBox();
            label1 = new Label();
            reportInstructorCourse = new Microsoft.Reporting.WinForms.ReportViewer();
            btn_Exit = new PictureBox();
            pictureBox6 = new PictureBox();
            btnInstructorCourse = new CustomMaterialDesign.RButton();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // comboInstructor
            // 
            comboInstructor.FormattingEnabled = true;
            comboInstructor.Location = new Point(161, 24);
            comboInstructor.Name = "comboInstructor";
            comboInstructor.Size = new Size(158, 23);
            comboInstructor.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 8;
            label1.Text = "Instructor";
            // 
            // reportInstructorCourse
            // 
            reportInstructorCourse.Location = new Point(15, 80);
            reportInstructorCourse.Name = "ReportViewer";
            reportInstructorCourse.ServerReport.BearerToken = null;
            reportInstructorCourse.Size = new Size(650, 450);
            reportInstructorCourse.TabIndex = 0;
            // 
            // btn_Exit
            // 
            btn_Exit.Image = (Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new Point(728, 2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(35, 28);
            btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Exit.TabIndex = 17;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // btnInstructorCourse
            // 
            btnInstructorCourse.BackColor = Color.DarkTurquoise;
            btnInstructorCourse.BackgroundColor = Color.DarkTurquoise;
            btnInstructorCourse.BorderColor = Color.White;
            btnInstructorCourse.BorderRadius = 20;
            btnInstructorCourse.BorderSize = 0;
            btnInstructorCourse.FlatAppearance.BorderSize = 0;
            btnInstructorCourse.FlatStyle = FlatStyle.Flat;
            btnInstructorCourse.Font = new Font("Microsoft Sans Serif", 10.5F);
            btnInstructorCourse.ForeColor = Color.White;
            btnInstructorCourse.Location = new Point(381, 16);
            btnInstructorCourse.Name = "btnInstructorCourse";
            btnInstructorCourse.Size = new Size(142, 40);
            btnInstructorCourse.TabIndex = 19;
            btnInstructorCourse.Text = "Get Data";
            btnInstructorCourse.TextColor = Color.White;
            btnInstructorCourse.UseVisualStyleBackColor = false;
            btnInstructorCourse.Click += btnInstructorCourse_Click;
            // 
            // InstructorCourseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(btnInstructorCourse);
            Controls.Add(pictureBox6);
            Controls.Add(btn_Exit);
            Controls.Add(reportInstructorCourse);
            Controls.Add(comboInstructor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstructorCourseReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Course Report";
            Load += InstructorCourseReport_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboInstructor;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportInstructorCourse;
        private PictureBox btn_Exit;
        private PictureBox pictureBox6;
        private CustomMaterialDesign.RButton btnInstructorCourse;
    }
}