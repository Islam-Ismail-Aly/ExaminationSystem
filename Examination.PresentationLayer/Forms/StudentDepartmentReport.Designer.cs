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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDepartmentReport));
            label1 = new Label();
            comboDepartment = new ComboBox();
            reportViewerStudentDepartment = new Microsoft.Reporting.WinForms.ReportViewer();
            btn_Exit = new PictureBox();
            btnStudentDepartment = new CustomMaterialDesign.RButton();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(173, 24);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(141, 23);
            comboDepartment.TabIndex = 1;
            // 
            // reportViewerStudentDepartment
            // 
            reportViewerStudentDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewerStudentDepartment.Location = new Point(15, 70);
            reportViewerStudentDepartment.Name = "ReportViewer";
            reportViewerStudentDepartment.ServerReport.BearerToken = null;
            reportViewerStudentDepartment.Size = new Size(663, 450);
            reportViewerStudentDepartment.TabIndex = 0;
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
            btnStudentDepartment.Location = new Point(427, 13);
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
            pictureBox6.Location = new Point(16, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // StudentDepartmentReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(pictureBox6);
            Controls.Add(btnStudentDepartment);
            Controls.Add(btn_Exit);
            Controls.Add(reportViewerStudentDepartment);
            Controls.Add(comboDepartment);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDepartmentReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Department Report";
            Load += StudentDepartmentReport_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboDepartment;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStudentDepartment;
        private PictureBox btn_Exit;
        private CustomMaterialDesign.RButton btnStudentDepartment;
        private PictureBox pictureBox6;
    }
}