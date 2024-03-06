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
            btnStudentQuestionAnswer = new Button();
            comboStudnet = new ComboBox();
            label1 = new Label();
            reportStudentQuestionAnswer = new Microsoft.Reporting.WinForms.ReportViewer();
            comboExamId = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStudentQuestionAnswer
            // 
            btnStudentQuestionAnswer.BackColor = Color.DeepSkyBlue;
            btnStudentQuestionAnswer.FlatAppearance.BorderSize = 0;
            btnStudentQuestionAnswer.FlatStyle = FlatStyle.Flat;
            btnStudentQuestionAnswer.Font = new Font("Segoe UI", 10F);
            btnStudentQuestionAnswer.ForeColor = Color.White;
            btnStudentQuestionAnswer.Location = new Point(305, 61);
            btnStudentQuestionAnswer.Name = "btnStudentQuestionAnswer";
            btnStudentQuestionAnswer.Size = new Size(109, 35);
            btnStudentQuestionAnswer.TabIndex = 13;
            btnStudentQuestionAnswer.Text = "Get Data";
            btnStudentQuestionAnswer.UseVisualStyleBackColor = false;
            btnStudentQuestionAnswer.Click += btnStudentQuestionAnswer_Click;
            // 
            // comboStudnet
            // 
            comboStudnet.FormattingEnabled = true;
            comboStudnet.Location = new Point(82, 73);
            comboStudnet.Name = "comboStudnet";
            comboStudnet.Size = new Size(137, 23);
            comboStudnet.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 11;
            label1.Text = "Student :";
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
            comboExamId.Location = new Point(82, 19);
            comboExamId.Name = "comboExamId";
            comboExamId.Size = new Size(137, 23);
            comboExamId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 14;
            label2.Text = "Exam Id :";
            // 
            // StudentQuestionAnswersReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(763, 596);
            Controls.Add(comboExamId);
            Controls.Add(label2);
            Controls.Add(reportStudentQuestionAnswer);
            Controls.Add(btnStudentQuestionAnswer);
            Controls.Add(comboStudnet);
            Controls.Add(label1);
            Name = "StudentQuestionAnswersReport";
            ShowIcon = false;
            Text = "Student Question Answers Report";
            Load += StudentQuestionAnswersReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentQuestionAnswer;
        private ComboBox comboStudnet;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportStudentQuestionAnswer;
        private ComboBox comboExamId;
        private Label label2;
    }
}