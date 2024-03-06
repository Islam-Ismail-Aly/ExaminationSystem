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
            btnQuestionAnswerExam = new Button();
            comboExamId = new ComboBox();
            label1 = new Label();
            reportQuestionAnswersExam = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnQuestionAnswerExam
            // 
            btnQuestionAnswerExam.BackColor = Color.DeepSkyBlue;
            btnQuestionAnswerExam.FlatAppearance.BorderSize = 0;
            btnQuestionAnswerExam.FlatStyle = FlatStyle.Flat;
            btnQuestionAnswerExam.Font = new Font("Segoe UI", 10F);
            btnQuestionAnswerExam.ForeColor = Color.White;
            btnQuestionAnswerExam.Location = new Point(280, 14);
            btnQuestionAnswerExam.Name = "btnQuestionAnswerExam";
            btnQuestionAnswerExam.Size = new Size(109, 30);
            btnQuestionAnswerExam.TabIndex = 13;
            btnQuestionAnswerExam.Text = "Get Data";
            btnQuestionAnswerExam.UseVisualStyleBackColor = false;
            btnQuestionAnswerExam.Click += btnQuestionAnswerExam_Click;
            // 
            // comboExamId
            // 
            comboExamId.FormattingEnabled = true;
            comboExamId.Location = new Point(81, 20);
            comboExamId.Name = "comboExamId";
            comboExamId.Size = new Size(116, 23);
            comboExamId.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 11;
            label1.Text = "Exam Id :";
            // 
            // reportQuestionAnswersExam
            // 
            reportQuestionAnswersExam.Location = new Point(15, 70);
            reportQuestionAnswersExam.Name = "ReportViewer";
            reportQuestionAnswersExam.ServerReport.BearerToken = null;
            reportQuestionAnswersExam.Size = new Size(650, 450);
            reportQuestionAnswersExam.TabIndex = 0;
            // 
            // QuestionAnswersExamReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 569);
            Controls.Add(reportQuestionAnswersExam);
            Controls.Add(btnQuestionAnswerExam);
            Controls.Add(comboExamId);
            Controls.Add(label1);
            Name = "QuestionAnswersExamReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Answers Exam Report";
            Load += QuestionAnswersExamReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuestionAnswerExam;
        private ComboBox comboExamId;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportQuestionAnswersExam;
    }
}