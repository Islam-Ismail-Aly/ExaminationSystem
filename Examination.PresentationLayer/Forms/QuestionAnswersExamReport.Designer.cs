namespace Examination.PresentationLayer.Forms
{
    partial class QuestionAnswersExamReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAnswersExamReport));
            comboExamId = new ComboBox();
            label1 = new Label();
            reportQuestionAnswersExam = new Microsoft.Reporting.WinForms.ReportViewer();
            btn_Exit = new PictureBox();
            btnQuestionAnswerExam = new CustomMaterialDesign.RButton();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // comboExamId
            // 
            comboExamId.FormattingEnabled = true;
            comboExamId.Location = new Point(139, 23);
            comboExamId.Name = "comboExamId";
            comboExamId.Size = new Size(116, 23);
            comboExamId.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(62, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 11;
            label1.Text = "Exam Id";
            // 
            // reportQuestionAnswersExam
            // 
            reportQuestionAnswersExam.Location = new Point(15, 70);
            reportQuestionAnswersExam.Name = "ReportViewer";
            reportQuestionAnswersExam.ServerReport.BearerToken = null;
            reportQuestionAnswersExam.Size = new Size(650, 450);
            reportQuestionAnswersExam.TabIndex = 0;
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
            // btnQuestionAnswerExam
            // 
            btnQuestionAnswerExam.BackColor = Color.DarkTurquoise;
            btnQuestionAnswerExam.BackgroundColor = Color.DarkTurquoise;
            btnQuestionAnswerExam.BorderColor = Color.White;
            btnQuestionAnswerExam.BorderRadius = 20;
            btnQuestionAnswerExam.BorderSize = 0;
            btnQuestionAnswerExam.FlatAppearance.BorderSize = 0;
            btnQuestionAnswerExam.FlatStyle = FlatStyle.Flat;
            btnQuestionAnswerExam.Font = new Font("Microsoft Sans Serif", 10.5F);
            btnQuestionAnswerExam.ForeColor = Color.White;
            btnQuestionAnswerExam.Location = new Point(334, 12);
            btnQuestionAnswerExam.Name = "btnQuestionAnswerExam";
            btnQuestionAnswerExam.Size = new Size(142, 40);
            btnQuestionAnswerExam.TabIndex = 20;
            btnQuestionAnswerExam.Text = "Get Data";
            btnQuestionAnswerExam.TextColor = Color.White;
            btnQuestionAnswerExam.UseVisualStyleBackColor = false;
            btnQuestionAnswerExam.Click += btnQuestionAnswerExam_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // QuestionAnswersExamReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(pictureBox6);
            Controls.Add(btnQuestionAnswerExam);
            Controls.Add(btn_Exit);
            Controls.Add(reportQuestionAnswersExam);
            Controls.Add(comboExamId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionAnswersExamReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Answers Exam Report";
            Load += QuestionAnswersExamReport_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboExamId;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportQuestionAnswersExam;
        private PictureBox btn_Exit;
        private CustomMaterialDesign.RButton btnQuestionAnswerExam;
        private PictureBox pictureBox6;
    }
}