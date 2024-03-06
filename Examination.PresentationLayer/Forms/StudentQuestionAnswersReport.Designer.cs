namespace Examination.PresentationLayer.Reports
{
    partial class StudentQuestionAnswersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentQuestionAnswersReport));
            comboStudnet = new ComboBox();
            label1 = new Label();
            reportStudentQuestionAnswer = new Microsoft.Reporting.WinForms.ReportViewer();
            comboExamId = new ComboBox();
            label2 = new Label();
            btn_Exit = new PictureBox();
            btnStudentQuestionAnswer = new CustomMaterialDesign.RButton();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboStudnet
            // 
            comboStudnet.FormattingEnabled = true;
            comboStudnet.Location = new Point(149, 75);
            comboStudnet.Name = "comboStudnet";
            comboStudnet.Size = new Size(137, 23);
            comboStudnet.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(70, 75);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 11;
            label1.Text = "Student";
            // 
            // reportStudentQuestionAnswer
            // 
            reportStudentQuestionAnswer.Location = new Point(15, 120);
            reportStudentQuestionAnswer.Name = "ReportViewer";
            reportStudentQuestionAnswer.ServerReport.BearerToken = null;
            reportStudentQuestionAnswer.Size = new Size(650, 450);
            reportStudentQuestionAnswer.TabIndex = 0;
            // 
            // comboExamId
            // 
            comboExamId.FormattingEnabled = true;
            comboExamId.Location = new Point(149, 24);
            comboExamId.Name = "comboExamId";
            comboExamId.Size = new Size(137, 23);
            comboExamId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(67, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 14;
            label2.Text = "Exam Id";
            // 
            // btn_Exit
            // 
            btn_Exit.Image = (Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new Point(726, 1);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(35, 28);
            btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Exit.TabIndex = 18;
            btn_Exit.TabStop = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btnStudentQuestionAnswer
            // 
            btnStudentQuestionAnswer.BackColor = Color.DarkTurquoise;
            btnStudentQuestionAnswer.BackgroundColor = Color.DarkTurquoise;
            btnStudentQuestionAnswer.BorderColor = Color.White;
            btnStudentQuestionAnswer.BorderRadius = 20;
            btnStudentQuestionAnswer.BorderSize = 0;
            btnStudentQuestionAnswer.FlatAppearance.BorderSize = 0;
            btnStudentQuestionAnswer.FlatStyle = FlatStyle.Flat;
            btnStudentQuestionAnswer.Font = new Font("Microsoft Sans Serif", 10.5F);
            btnStudentQuestionAnswer.ForeColor = Color.White;
            btnStudentQuestionAnswer.Location = new Point(382, 58);
            btnStudentQuestionAnswer.Name = "btnStudentQuestionAnswer";
            btnStudentQuestionAnswer.Size = new Size(142, 40);
            btnStudentQuestionAnswer.TabIndex = 19;
            btnStudentQuestionAnswer.Text = "Get Data";
            btnStudentQuestionAnswer.TextColor = Color.White;
            btnStudentQuestionAnswer.UseVisualStyleBackColor = false;
            btnStudentQuestionAnswer.Click += btnStudentQuestionAnswer_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // StudentQuestionAnswersReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 596);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(btnStudentQuestionAnswer);
            Controls.Add(btn_Exit);
            Controls.Add(comboExamId);
            Controls.Add(label2);
            Controls.Add(reportStudentQuestionAnswer);
            Controls.Add(comboStudnet);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentQuestionAnswersReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Question Answers Report";
            Load += StudentQuestionAnswersReport_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboStudnet;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportStudentQuestionAnswer;
        private ComboBox comboExamId;
        private Label label2;
        private PictureBox btn_Exit;
        private CustomMaterialDesign.RButton btnStudentQuestionAnswer;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
    }
}