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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseTopicsReport));
            comboCourse = new ComboBox();
            label1 = new Label();
            reportCourseTopics = new Microsoft.Reporting.WinForms.ReportViewer();
            btnCourseTopics = new CustomMaterialDesign.RButton();
            pictureBox6 = new PictureBox();
            btn_Exit = new PictureBox();
            btn_Minimize = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).BeginInit();
            SuspendLayout();
            // 
            // comboCourse
            // 
            comboCourse.Font = new Font("Gabriola", 12F);
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(133, 17);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(142, 37);
            comboCourse.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 15F);
            label1.Location = new Point(61, 17);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 11;
            label1.Text = "Course";
            // 
            // reportCourseTopics
            // 
            reportCourseTopics.Location = new Point(15, 70);
            reportCourseTopics.Name = "ReportViewer";
            reportCourseTopics.ServerReport.BearerToken = null;
            reportCourseTopics.Size = new Size(650, 450);
            reportCourseTopics.TabIndex = 0;
            // 
            // btnCourseTopics
            // 
            btnCourseTopics.BackColor = Color.DarkTurquoise;
            btnCourseTopics.BackgroundColor = Color.DarkTurquoise;
            btnCourseTopics.BorderColor = Color.White;
            btnCourseTopics.BorderRadius = 20;
            btnCourseTopics.BorderSize = 0;
            btnCourseTopics.FlatAppearance.BorderSize = 0;
            btnCourseTopics.FlatStyle = FlatStyle.Flat;
            btnCourseTopics.Font = new Font("Gabriola", 14F);
            btnCourseTopics.ForeColor = Color.White;
            btnCourseTopics.Location = new Point(361, 12);
            btnCourseTopics.Name = "btnCourseTopics";
            btnCourseTopics.Size = new Size(142, 40);
            btnCourseTopics.TabIndex = 14;
            btnCourseTopics.Text = "Get Data";
            btnCourseTopics.TextColor = Color.White;
            btnCourseTopics.UseVisualStyleBackColor = false;
            btnCourseTopics.Click += btnCourseTopics_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Image = (Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new Point(725, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(35, 28);
            btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Exit.TabIndex = 16;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Image = (Image)resources.GetObject("btn_Minimize.Image");
            btn_Minimize.Location = new Point(695, 5);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(30, 24);
            btn_Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Minimize.TabIndex = 17;
            btn_Minimize.TabStop = false;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // CourseTopicsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(btn_Minimize);
            Controls.Add(btn_Exit);
            Controls.Add(pictureBox6);
            Controls.Add(reportCourseTopics);
            Controls.Add(comboCourse);
            Controls.Add(label1);
            Controls.Add(btnCourseTopics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseTopicsReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Topics Report";
            Load += CourseTopicsReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboCourse;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportCourseTopics;
        private CustomMaterialDesign.RButton btnCourseTopics;
        private PictureBox pictureBox6;
        private PictureBox btn_Exit;
        private PictureBox btn_Minimize;
    }
}