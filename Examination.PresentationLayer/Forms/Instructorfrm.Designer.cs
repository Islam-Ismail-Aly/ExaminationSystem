namespace Examination.PresentationLayer.Forms
{
    partial class Instructorfrm
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
            tabControl1 = new TabControl();
            tabProfile = new TabPage();
            txtBranch = new TextBox();
            txtDepartment = new TextBox();
            txtUsername = new TextBox();
            txtInstructorName = new TextBox();
            dataGridCourses = new DataGridView();
            label9 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            tabAddQuestion = new TabPage();
            btn_AddQuestion = new Button();
            radioF = new RadioButton();
            radioT = new RadioButton();
            radioAnswerD = new RadioButton();
            radioAnswerC = new RadioButton();
            radioAnswerB = new RadioButton();
            radioAnswerA = new RadioButton();
            txtAnswerD = new TextBox();
            txtAnswerC = new TextBox();
            txtAnswerB = new TextBox();
            txtAnswerA = new TextBox();
            comboCourse = new ComboBox();
            comboQuestionType = new ComboBox();
            txtContent = new TextBox();
            label3 = new Label();
            lblAnsD = new Label();
            lblAnsC = new Label();
            lblAnsB = new Label();
            lblAnsA = new Label();
            lblisCorrect = new Label();
            label2 = new Label();
            label1 = new Label();
            tabReport = new TabPage();
            btnStudentDepartmentfrm = new Button();
            btnInstructorCoursefrm = new Button();
            tabControl1.SuspendLayout();
            tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCourses).BeginInit();
            tabAddQuestion.SuspendLayout();
            tabReport.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProfile);
            tabControl1.Controls.Add(tabAddQuestion);
            tabControl1.Controls.Add(tabReport);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(945, 407);
            tabControl1.TabIndex = 0;
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.MintCream;
            tabProfile.Controls.Add(txtBranch);
            tabProfile.Controls.Add(txtDepartment);
            tabProfile.Controls.Add(txtUsername);
            tabProfile.Controls.Add(txtInstructorName);
            tabProfile.Controls.Add(dataGridCourses);
            tabProfile.Controls.Add(label9);
            tabProfile.Controls.Add(label5);
            tabProfile.Controls.Add(label8);
            tabProfile.Controls.Add(label7);
            tabProfile.Controls.Add(label4);
            tabProfile.Location = new Point(4, 24);
            tabProfile.Name = "tabProfile";
            tabProfile.Padding = new Padding(3);
            tabProfile.Size = new Size(937, 379);
            tabProfile.TabIndex = 0;
            tabProfile.Text = "Profile";
            // 
            // txtBranch
            // 
            txtBranch.BackColor = Color.PowderBlue;
            txtBranch.Location = new Point(455, 19);
            txtBranch.Name = "txtBranch";
            txtBranch.ReadOnly = true;
            txtBranch.Size = new Size(153, 23);
            txtBranch.TabIndex = 10;
            txtBranch.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.PowderBlue;
            txtDepartment.Location = new Point(455, 61);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(153, 23);
            txtDepartment.TabIndex = 11;
            txtDepartment.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.PowderBlue;
            txtUsername.Location = new Point(106, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(153, 23);
            txtUsername.TabIndex = 13;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInstructorName
            // 
            txtInstructorName.BackColor = Color.PowderBlue;
            txtInstructorName.Location = new Point(106, 20);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.ReadOnly = true;
            txtInstructorName.Size = new Size(153, 23);
            txtInstructorName.TabIndex = 14;
            txtInstructorName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridCourses
            // 
            dataGridCourses.BackgroundColor = Color.PowderBlue;
            dataGridCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCourses.Location = new Point(106, 105);
            dataGridCourses.Name = "dataGridCourses";
            dataGridCourses.Size = new Size(153, 82);
            dataGridCourses.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(357, 19);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 3;
            label9.Text = "Branch :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(9, 105);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 4;
            label5.Text = "Courses :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(357, 61);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 5;
            label8.Text = "Department :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(9, 65);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 7;
            label7.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(9, 20);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 8;
            label4.Text = "Name :";
            // 
            // tabAddQuestion
            // 
            tabAddQuestion.BackColor = Color.MintCream;
            tabAddQuestion.Controls.Add(btn_AddQuestion);
            tabAddQuestion.Controls.Add(radioF);
            tabAddQuestion.Controls.Add(radioT);
            tabAddQuestion.Controls.Add(radioAnswerD);
            tabAddQuestion.Controls.Add(radioAnswerC);
            tabAddQuestion.Controls.Add(radioAnswerB);
            tabAddQuestion.Controls.Add(radioAnswerA);
            tabAddQuestion.Controls.Add(txtAnswerD);
            tabAddQuestion.Controls.Add(txtAnswerC);
            tabAddQuestion.Controls.Add(txtAnswerB);
            tabAddQuestion.Controls.Add(txtAnswerA);
            tabAddQuestion.Controls.Add(comboCourse);
            tabAddQuestion.Controls.Add(comboQuestionType);
            tabAddQuestion.Controls.Add(txtContent);
            tabAddQuestion.Controls.Add(label3);
            tabAddQuestion.Controls.Add(lblAnsD);
            tabAddQuestion.Controls.Add(lblAnsC);
            tabAddQuestion.Controls.Add(lblAnsB);
            tabAddQuestion.Controls.Add(lblAnsA);
            tabAddQuestion.Controls.Add(lblisCorrect);
            tabAddQuestion.Controls.Add(label2);
            tabAddQuestion.Controls.Add(label1);
            tabAddQuestion.Location = new Point(4, 24);
            tabAddQuestion.Name = "tabAddQuestion";
            tabAddQuestion.Padding = new Padding(3);
            tabAddQuestion.Size = new Size(937, 379);
            tabAddQuestion.TabIndex = 1;
            tabAddQuestion.Text = "Add Question";
            // 
            // btn_AddQuestion
            // 
            btn_AddQuestion.BackColor = Color.DeepSkyBlue;
            btn_AddQuestion.FlatAppearance.BorderSize = 0;
            btn_AddQuestion.FlatStyle = FlatStyle.Flat;
            btn_AddQuestion.Font = new Font("Segoe UI", 10F);
            btn_AddQuestion.ForeColor = Color.White;
            btn_AddQuestion.Location = new Point(18, 168);
            btn_AddQuestion.Name = "btn_AddQuestion";
            btn_AddQuestion.Size = new Size(138, 39);
            btn_AddQuestion.TabIndex = 6;
            btn_AddQuestion.Text = "Create";
            btn_AddQuestion.UseVisualStyleBackColor = false;
            btn_AddQuestion.Click += btn_AddQuestion_Click;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(651, 59);
            radioF.Name = "radioF";
            radioF.Size = new Size(31, 19);
            radioF.TabIndex = 5;
            radioF.TabStop = true;
            radioF.Text = "F";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioT
            // 
            radioT.AutoSize = true;
            radioT.Location = new Point(551, 59);
            radioT.Name = "radioT";
            radioT.Size = new Size(31, 19);
            radioT.TabIndex = 5;
            radioT.TabStop = true;
            radioT.Text = "T";
            radioT.UseVisualStyleBackColor = true;
            // 
            // radioAnswerD
            // 
            radioAnswerD.AutoSize = true;
            radioAnswerD.Location = new Point(805, 221);
            radioAnswerD.Name = "radioAnswerD";
            radioAnswerD.Size = new Size(14, 13);
            radioAnswerD.TabIndex = 4;
            radioAnswerD.TabStop = true;
            radioAnswerD.UseVisualStyleBackColor = true;
            // 
            // radioAnswerC
            // 
            radioAnswerC.AutoSize = true;
            radioAnswerC.Location = new Point(805, 178);
            radioAnswerC.Name = "radioAnswerC";
            radioAnswerC.Size = new Size(14, 13);
            radioAnswerC.TabIndex = 4;
            radioAnswerC.TabStop = true;
            radioAnswerC.UseVisualStyleBackColor = true;
            // 
            // radioAnswerB
            // 
            radioAnswerB.AutoSize = true;
            radioAnswerB.Location = new Point(805, 139);
            radioAnswerB.Name = "radioAnswerB";
            radioAnswerB.Size = new Size(14, 13);
            radioAnswerB.TabIndex = 4;
            radioAnswerB.TabStop = true;
            radioAnswerB.UseVisualStyleBackColor = true;
            // 
            // radioAnswerA
            // 
            radioAnswerA.AutoSize = true;
            radioAnswerA.Location = new Point(805, 97);
            radioAnswerA.Name = "radioAnswerA";
            radioAnswerA.Size = new Size(14, 13);
            radioAnswerA.TabIndex = 4;
            radioAnswerA.TabStop = true;
            radioAnswerA.UseVisualStyleBackColor = true;
            // 
            // txtAnswerD
            // 
            txtAnswerD.Location = new Point(615, 217);
            txtAnswerD.Name = "txtAnswerD";
            txtAnswerD.Size = new Size(153, 23);
            txtAnswerD.TabIndex = 3;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Location = new Point(615, 174);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(153, 23);
            txtAnswerC.TabIndex = 3;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Location = new Point(615, 135);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(153, 23);
            txtAnswerB.TabIndex = 3;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Location = new Point(615, 92);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(153, 23);
            txtAnswerA.TabIndex = 3;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(88, 100);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(121, 23);
            comboCourse.TabIndex = 2;
            // 
            // comboQuestionType
            // 
            comboQuestionType.FormattingEnabled = true;
            comboQuestionType.Location = new Point(615, 20);
            comboQuestionType.Name = "comboQuestionType";
            comboQuestionType.Size = new Size(121, 23);
            comboQuestionType.TabIndex = 2;
            comboQuestionType.SelectedIndexChanged += comboQuestionType_SelectedIndexChanged;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(141, 20);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(244, 47);
            txtContent.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Course :";
            // 
            // lblAnsD
            // 
            lblAnsD.AutoSize = true;
            lblAnsD.Location = new Point(512, 220);
            lblAnsD.Name = "lblAnsD";
            lblAnsD.Size = new Size(71, 15);
            lblAnsD.TabIndex = 0;
            lblAnsD.Text = "Answer (D) :";
            // 
            // lblAnsC
            // 
            lblAnsC.AutoSize = true;
            lblAnsC.Location = new Point(512, 177);
            lblAnsC.Name = "lblAnsC";
            lblAnsC.Size = new Size(71, 15);
            lblAnsC.TabIndex = 0;
            lblAnsC.Text = "Answer (C) :";
            // 
            // lblAnsB
            // 
            lblAnsB.AutoSize = true;
            lblAnsB.Location = new Point(512, 138);
            lblAnsB.Name = "lblAnsB";
            lblAnsB.Size = new Size(70, 15);
            lblAnsB.TabIndex = 0;
            lblAnsB.Text = "Answer (B) :";
            // 
            // lblAnsA
            // 
            lblAnsA.AutoSize = true;
            lblAnsA.Location = new Point(512, 95);
            lblAnsA.Name = "lblAnsA";
            lblAnsA.Size = new Size(71, 15);
            lblAnsA.TabIndex = 0;
            lblAnsA.Text = "Answer (A) :";
            // 
            // lblisCorrect
            // 
            lblisCorrect.AutoSize = true;
            lblisCorrect.Location = new Point(784, 63);
            lblisCorrect.Name = "lblisCorrect";
            lblisCorrect.Size = new Size(57, 15);
            lblisCorrect.TabIndex = 0;
            lblisCorrect.Text = "Is Correct";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 20);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 0;
            label2.Text = "Question Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Question Content :";
            // 
            // tabReport
            // 
            tabReport.BackColor = Color.MintCream;
            tabReport.Controls.Add(btnInstructorCoursefrm);
            tabReport.Controls.Add(btnStudentDepartmentfrm);
            tabReport.Location = new Point(4, 24);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(3);
            tabReport.Size = new Size(937, 379);
            tabReport.TabIndex = 2;
            tabReport.Text = "Reports";
            // 
            // btnStudentDepartmentfrm
            // 
            btnStudentDepartmentfrm.BackColor = Color.DeepSkyBlue;
            btnStudentDepartmentfrm.FlatAppearance.BorderSize = 0;
            btnStudentDepartmentfrm.FlatStyle = FlatStyle.Flat;
            btnStudentDepartmentfrm.Font = new Font("Segoe UI", 10F);
            btnStudentDepartmentfrm.ForeColor = Color.White;
            btnStudentDepartmentfrm.Location = new Point(6, 14);
            btnStudentDepartmentfrm.Name = "btnStudentDepartmentfrm";
            btnStudentDepartmentfrm.Size = new Size(193, 39);
            btnStudentDepartmentfrm.TabIndex = 7;
            btnStudentDepartmentfrm.Text = "Student Department Report";
            btnStudentDepartmentfrm.UseVisualStyleBackColor = false;
            btnStudentDepartmentfrm.Click += btnStudentDepartmentfrm_Click;
            // 
            // btnInstructorCoursefrm
            // 
            btnInstructorCoursefrm.BackColor = Color.CadetBlue;
            btnInstructorCoursefrm.FlatAppearance.BorderSize = 0;
            btnInstructorCoursefrm.FlatStyle = FlatStyle.Flat;
            btnInstructorCoursefrm.Font = new Font("Segoe UI", 10F);
            btnInstructorCoursefrm.ForeColor = Color.White;
            btnInstructorCoursefrm.Location = new Point(244, 14);
            btnInstructorCoursefrm.Name = "btnInstructorCoursefrm";
            btnInstructorCoursefrm.Size = new Size(193, 39);
            btnInstructorCoursefrm.TabIndex = 7;
            btnInstructorCoursefrm.Text = "Instructor Course Report";
            btnInstructorCoursefrm.UseVisualStyleBackColor = false;
            btnInstructorCoursefrm.Click += btnInstructorCoursefrm_Click;
            // 
            // Instructorfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 431);
            Controls.Add(tabControl1);
            Name = "Instructorfrm";
            ShowIcon = false;
            Text = "Instructor";
            Load += Instructorfrm_Load;
            tabControl1.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCourses).EndInit();
            tabAddQuestion.ResumeLayout(false);
            tabAddQuestion.PerformLayout();
            tabReport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProfile;
        private TabPage tabAddQuestion;
        private TextBox txtBranch;
        private TextBox txtDepartment;
        private TextBox txtUsername;
        private TextBox txtInstructorName;
        private DataGridView dataGridCourses;
        private Label label9;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboCourse;
        private ComboBox comboQuestionType;
        private TextBox txtContent;
        private Label label3;
        private TextBox txtAnswerD;
        private TextBox txtAnswerC;
        private TextBox txtAnswerB;
        private TextBox txtAnswerA;
        private Label lblAnsA;
        private Label lblAnsD;
        private Label lblAnsC;
        private Label lblAnsB;
        private RadioButton radioAnswerD;
        private RadioButton radioAnswerC;
        private RadioButton radioAnswerB;
        private RadioButton radioAnswerA;
        private Label lblisCorrect;
        private RadioButton radioF;
        private RadioButton radioT;
        private Button btn_AddQuestion;
        private TabPage tabReport;
        private Button btnStudentDepartmentfrm;
        private Button btnInstructorCoursefrm;
    }
}