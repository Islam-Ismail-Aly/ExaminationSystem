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
            btnStudentQuestionAnswerExam = new Button();
            btnQuestionAnswerExam = new Button();
            btnCourseTopicfrm = new Button();
            btnInstructorCoursefrm = new Button();
            btnStudentCourseGradesfrm = new Button();
            btnStudentDepartmentfrm = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tabControl1.SuspendLayout();
            tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCourses).BeginInit();
            tabAddQuestion.SuspendLayout();
            tabReport.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProfile);
            tabControl1.Controls.Add(tabAddQuestion);
            tabControl1.Controls.Add(tabReport);
            tabControl1.Font = new Font("Segoe UI", 3.5F, FontStyle.Bold, GraphicsUnit.Millimeter);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Margin = new Padding(5, 6, 5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(990, 575);
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
            tabProfile.Location = new Point(4, 26);
            tabProfile.Margin = new Padding(5, 6, 5, 6);
            tabProfile.Name = "tabProfile";
            tabProfile.Padding = new Padding(5, 6, 5, 6);
            tabProfile.Size = new Size(982, 545);
            tabProfile.TabIndex = 0;
            tabProfile.Text = "Profile";
            // 
            // txtBranch
            // 
            txtBranch.BackColor = Color.PowderBlue;
            txtBranch.Location = new Point(562, 29);
            txtBranch.Margin = new Padding(5, 6, 5, 6);
            txtBranch.Name = "txtBranch";
            txtBranch.ReadOnly = true;
            txtBranch.Size = new Size(197, 25);
            txtBranch.TabIndex = 10;
            txtBranch.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.PowderBlue;
            txtDepartment.Location = new Point(562, 92);
            txtDepartment.Margin = new Padding(5, 6, 5, 6);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(197, 25);
            txtDepartment.TabIndex = 11;
            txtDepartment.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.PowderBlue;
            txtUsername.Location = new Point(135, 98);
            txtUsername.Margin = new Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(197, 25);
            txtUsername.TabIndex = 13;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInstructorName
            // 
            txtInstructorName.BackColor = Color.PowderBlue;
            txtInstructorName.Location = new Point(135, 29);
            txtInstructorName.Margin = new Padding(5, 6, 5, 6);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.ReadOnly = true;
            txtInstructorName.Size = new Size(197, 25);
            txtInstructorName.TabIndex = 14;
            txtInstructorName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridCourses
            // 
            dataGridCourses.BackgroundColor = Color.PowderBlue;
            dataGridCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCourses.Location = new Point(135, 161);
            dataGridCourses.Margin = new Padding(5, 6, 5, 6);
            dataGridCourses.Name = "dataGridCourses";
            dataGridCourses.Size = new Size(243, 94);
            dataGridCourses.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(436, 29);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 3;
            label9.Text = "Branch :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(13, 161);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 4;
            label5.Text = "Courses :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(436, 92);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 5;
            label8.Text = "Department :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(13, 98);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 7;
            label7.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(13, 29);
            label4.Margin = new Padding(5, 0, 5, 0);
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
            tabAddQuestion.Location = new Point(4, 26);
            tabAddQuestion.Margin = new Padding(5, 6, 5, 6);
            tabAddQuestion.Name = "tabAddQuestion";
            tabAddQuestion.Padding = new Padding(5, 6, 5, 6);
            tabAddQuestion.Size = new Size(982, 545);
            tabAddQuestion.TabIndex = 1;
            tabAddQuestion.Text = "Add Question";
            // 
            // btn_AddQuestion
            // 
            btn_AddQuestion.BackColor = Color.DeepSkyBlue;
            btn_AddQuestion.FlatAppearance.BorderSize = 0;
            btn_AddQuestion.FlatStyle = FlatStyle.Flat;
            btn_AddQuestion.Font = new Font("Segoe UI", 11F);
            btn_AddQuestion.ForeColor = Color.White;
            btn_AddQuestion.Location = new Point(36, 223);
            btn_AddQuestion.Margin = new Padding(5, 6, 5, 6);
            btn_AddQuestion.Name = "btn_AddQuestion";
            btn_AddQuestion.Size = new Size(126, 37);
            btn_AddQuestion.TabIndex = 6;
            btn_AddQuestion.Text = "Create";
            btn_AddQuestion.UseVisualStyleBackColor = false;
            btn_AddQuestion.Click += btn_AddQuestion_Click;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(675, 70);
            radioF.Margin = new Padding(5, 6, 5, 6);
            radioF.Name = "radioF";
            radioF.Size = new Size(34, 23);
            radioF.TabIndex = 5;
            radioF.TabStop = true;
            radioF.Text = "F";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioT
            // 
            radioT.AutoSize = true;
            radioT.Location = new Point(620, 69);
            radioT.Margin = new Padding(5, 6, 5, 6);
            radioT.Name = "radioT";
            radioT.Size = new Size(35, 23);
            radioT.TabIndex = 5;
            radioT.TabStop = true;
            radioT.Text = "T";
            radioT.UseVisualStyleBackColor = true;
            // 
            // radioAnswerD
            // 
            radioAnswerD.AutoSize = true;
            radioAnswerD.Location = new Point(615, 351);
            radioAnswerD.Margin = new Padding(5, 6, 5, 6);
            radioAnswerD.Name = "radioAnswerD";
            radioAnswerD.Size = new Size(14, 13);
            radioAnswerD.TabIndex = 4;
            radioAnswerD.TabStop = true;
            radioAnswerD.UseVisualStyleBackColor = true;
            // 
            // radioAnswerC
            // 
            radioAnswerC.AutoSize = true;
            radioAnswerC.Location = new Point(615, 287);
            radioAnswerC.Margin = new Padding(5, 6, 5, 6);
            radioAnswerC.Name = "radioAnswerC";
            radioAnswerC.Size = new Size(14, 13);
            radioAnswerC.TabIndex = 4;
            radioAnswerC.TabStop = true;
            radioAnswerC.UseVisualStyleBackColor = true;
            // 
            // radioAnswerB
            // 
            radioAnswerB.AutoSize = true;
            radioAnswerB.Location = new Point(615, 229);
            radioAnswerB.Margin = new Padding(5, 6, 5, 6);
            radioAnswerB.Name = "radioAnswerB";
            radioAnswerB.Size = new Size(14, 13);
            radioAnswerB.TabIndex = 4;
            radioAnswerB.TabStop = true;
            radioAnswerB.UseVisualStyleBackColor = true;
            // 
            // radioAnswerA
            // 
            radioAnswerA.AutoSize = true;
            radioAnswerA.Location = new Point(615, 168);
            radioAnswerA.Margin = new Padding(5, 6, 5, 6);
            radioAnswerA.Name = "radioAnswerA";
            radioAnswerA.Size = new Size(14, 13);
            radioAnswerA.TabIndex = 4;
            radioAnswerA.TabStop = true;
            radioAnswerA.UseVisualStyleBackColor = true;
            // 
            // txtAnswerD
            // 
            txtAnswerD.Location = new Point(754, 345);
            txtAnswerD.Margin = new Padding(5, 6, 5, 6);
            txtAnswerD.Name = "txtAnswerD";
            txtAnswerD.Size = new Size(197, 25);
            txtAnswerD.TabIndex = 3;
            // 
            // txtAnswerC
            // 
            txtAnswerC.Location = new Point(754, 280);
            txtAnswerC.Margin = new Padding(5, 6, 5, 6);
            txtAnswerC.Name = "txtAnswerC";
            txtAnswerC.Size = new Size(197, 25);
            txtAnswerC.TabIndex = 3;
            // 
            // txtAnswerB
            // 
            txtAnswerB.Location = new Point(754, 223);
            txtAnswerB.Margin = new Padding(5, 6, 5, 6);
            txtAnswerB.Name = "txtAnswerB";
            txtAnswerB.Size = new Size(197, 25);
            txtAnswerB.TabIndex = 3;
            // 
            // txtAnswerA
            // 
            txtAnswerA.Location = new Point(754, 158);
            txtAnswerA.Margin = new Padding(5, 6, 5, 6);
            txtAnswerA.Name = "txtAnswerA";
            txtAnswerA.Size = new Size(197, 25);
            txtAnswerA.TabIndex = 3;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(113, 140);
            comboCourse.Margin = new Padding(5, 6, 5, 6);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(153, 25);
            comboCourse.TabIndex = 2;
            // 
            // comboQuestionType
            // 
            comboQuestionType.FormattingEnabled = true;
            comboQuestionType.Location = new Point(743, 29);
            comboQuestionType.Margin = new Padding(5, 6, 5, 6);
            comboQuestionType.Name = "comboQuestionType";
            comboQuestionType.Size = new Size(153, 25);
            comboQuestionType.TabIndex = 2;
            comboQuestionType.SelectedIndexChanged += comboQuestionType_SelectedIndexChanged;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(172, 29);
            txtContent.Margin = new Padding(5, 6, 5, 6);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(315, 67);
            txtContent.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 0;
            label3.Text = "Course :";
            // 
            // lblAnsD
            // 
            lblAnsD.AutoSize = true;
            lblAnsD.Location = new Point(639, 347);
            lblAnsD.Margin = new Padding(5, 0, 5, 0);
            lblAnsD.Name = "lblAnsD";
            lblAnsD.Size = new Size(90, 19);
            lblAnsD.TabIndex = 0;
            lblAnsD.Text = "Answer (D) :";
            // 
            // lblAnsC
            // 
            lblAnsC.AutoSize = true;
            lblAnsC.Location = new Point(639, 283);
            lblAnsC.Margin = new Padding(5, 0, 5, 0);
            lblAnsC.Name = "lblAnsC";
            lblAnsC.Size = new Size(89, 19);
            lblAnsC.TabIndex = 0;
            lblAnsC.Text = "Answer (C) :";
            // 
            // lblAnsB
            // 
            lblAnsB.AutoSize = true;
            lblAnsB.Location = new Point(639, 225);
            lblAnsB.Margin = new Padding(5, 0, 5, 0);
            lblAnsB.Name = "lblAnsB";
            lblAnsB.Size = new Size(89, 19);
            lblAnsB.TabIndex = 0;
            lblAnsB.Text = "Answer (B) :";
            // 
            // lblAnsA
            // 
            lblAnsA.AutoSize = true;
            lblAnsA.Location = new Point(639, 162);
            lblAnsA.Margin = new Padding(5, 0, 5, 0);
            lblAnsA.Name = "lblAnsA";
            lblAnsA.Size = new Size(90, 19);
            lblAnsA.TabIndex = 0;
            lblAnsA.Text = "Answer (A) :";
            // 
            // lblisCorrect
            // 
            lblisCorrect.AutoSize = true;
            lblisCorrect.Location = new Point(615, 120);
            lblisCorrect.Margin = new Padding(5, 0, 5, 0);
            lblisCorrect.Name = "lblisCorrect";
            lblisCorrect.Size = new Size(73, 19);
            lblisCorrect.TabIndex = 0;
            lblisCorrect.Text = "Is Correct";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 29);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 0;
            label2.Text = "Question Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 0;
            label1.Text = "Question Content :";
            // 
            // tabReport
            // 
            tabReport.BackColor = Color.MintCream;
            tabReport.Controls.Add(groupBox2);
            tabReport.Controls.Add(groupBox1);
            tabReport.Location = new Point(4, 26);
            tabReport.Margin = new Padding(5, 6, 5, 6);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(5, 6, 5, 6);
            tabReport.Size = new Size(982, 545);
            tabReport.TabIndex = 2;
            tabReport.Text = "Reports";
            // 
            // btnStudentQuestionAnswerExam
            // 
            btnStudentQuestionAnswerExam.BackColor = Color.SlateBlue;
            btnStudentQuestionAnswerExam.FlatAppearance.BorderSize = 0;
            btnStudentQuestionAnswerExam.FlatStyle = FlatStyle.Flat;
            btnStudentQuestionAnswerExam.Font = new Font("Segoe UI", 10F);
            btnStudentQuestionAnswerExam.ForeColor = Color.White;
            btnStudentQuestionAnswerExam.Location = new Point(323, 39);
            btnStudentQuestionAnswerExam.Margin = new Padding(5, 6, 5, 6);
            btnStudentQuestionAnswerExam.Name = "btnStudentQuestionAnswerExam";
            btnStudentQuestionAnswerExam.Size = new Size(210, 51);
            btnStudentQuestionAnswerExam.TabIndex = 7;
            btnStudentQuestionAnswerExam.Text = "Student Question Answer Exam Report";
            btnStudentQuestionAnswerExam.UseVisualStyleBackColor = false;
            btnStudentQuestionAnswerExam.Click += btnStudentQuestionAnswerExam_Click;
            // 
            // btnQuestionAnswerExam
            // 
            btnQuestionAnswerExam.BackColor = Color.SlateBlue;
            btnQuestionAnswerExam.FlatAppearance.BorderSize = 0;
            btnQuestionAnswerExam.FlatStyle = FlatStyle.Flat;
            btnQuestionAnswerExam.Font = new Font("Segoe UI", 10F);
            btnQuestionAnswerExam.ForeColor = Color.White;
            btnQuestionAnswerExam.Location = new Point(43, 39);
            btnQuestionAnswerExam.Margin = new Padding(5, 6, 5, 6);
            btnQuestionAnswerExam.Name = "btnQuestionAnswerExam";
            btnQuestionAnswerExam.Size = new Size(210, 51);
            btnQuestionAnswerExam.TabIndex = 7;
            btnQuestionAnswerExam.Text = "Question Answer Exam Report";
            btnQuestionAnswerExam.UseVisualStyleBackColor = false;
            btnQuestionAnswerExam.Click += btnQuestionAnswerExam_Click;
            // 
            // btnCourseTopicfrm
            // 
            btnCourseTopicfrm.BackColor = Color.CadetBlue;
            btnCourseTopicfrm.FlatAppearance.BorderSize = 0;
            btnCourseTopicfrm.FlatStyle = FlatStyle.Flat;
            btnCourseTopicfrm.Font = new Font("Segoe UI", 10F);
            btnCourseTopicfrm.ForeColor = Color.White;
            btnCourseTopicfrm.Location = new Point(609, 49);
            btnCourseTopicfrm.Margin = new Padding(5, 6, 5, 6);
            btnCourseTopicfrm.Name = "btnCourseTopicfrm";
            btnCourseTopicfrm.Size = new Size(201, 51);
            btnCourseTopicfrm.TabIndex = 7;
            btnCourseTopicfrm.Text = "Course Topic Report";
            btnCourseTopicfrm.UseVisualStyleBackColor = false;
            btnCourseTopicfrm.Click += btnCourseTopicfrm_Click;
            // 
            // btnInstructorCoursefrm
            // 
            btnInstructorCoursefrm.BackColor = Color.CadetBlue;
            btnInstructorCoursefrm.FlatAppearance.BorderSize = 0;
            btnInstructorCoursefrm.FlatStyle = FlatStyle.Flat;
            btnInstructorCoursefrm.Font = new Font("Segoe UI", 10F);
            btnInstructorCoursefrm.ForeColor = Color.White;
            btnInstructorCoursefrm.Location = new Point(609, 39);
            btnInstructorCoursefrm.Margin = new Padding(5, 6, 5, 6);
            btnInstructorCoursefrm.Name = "btnInstructorCoursefrm";
            btnInstructorCoursefrm.Size = new Size(201, 51);
            btnInstructorCoursefrm.TabIndex = 7;
            btnInstructorCoursefrm.Text = "Instructor Course Report";
            btnInstructorCoursefrm.UseVisualStyleBackColor = false;
            btnInstructorCoursefrm.Click += btnInstructorCoursefrm_Click;
            // 
            // btnStudentCourseGradesfrm
            // 
            btnStudentCourseGradesfrm.BackColor = SystemColors.MenuHighlight;
            btnStudentCourseGradesfrm.FlatAppearance.BorderSize = 0;
            btnStudentCourseGradesfrm.FlatStyle = FlatStyle.Flat;
            btnStudentCourseGradesfrm.Font = new Font("Segoe UI", 10F);
            btnStudentCourseGradesfrm.ForeColor = Color.White;
            btnStudentCourseGradesfrm.Location = new Point(323, 49);
            btnStudentCourseGradesfrm.Margin = new Padding(5, 6, 5, 6);
            btnStudentCourseGradesfrm.Name = "btnStudentCourseGradesfrm";
            btnStudentCourseGradesfrm.Size = new Size(201, 51);
            btnStudentCourseGradesfrm.TabIndex = 7;
            btnStudentCourseGradesfrm.Text = "Student Course Grades Report";
            btnStudentCourseGradesfrm.UseVisualStyleBackColor = false;
            btnStudentCourseGradesfrm.Click += btnStudentCourseGradesfrm_Click;
            // 
            // btnStudentDepartmentfrm
            // 
            btnStudentDepartmentfrm.BackColor = SystemColors.MenuHighlight;
            btnStudentDepartmentfrm.FlatAppearance.BorderSize = 0;
            btnStudentDepartmentfrm.FlatStyle = FlatStyle.Flat;
            btnStudentDepartmentfrm.Font = new Font("Segoe UI", 10F);
            btnStudentDepartmentfrm.ForeColor = Color.White;
            btnStudentDepartmentfrm.Location = new Point(43, 49);
            btnStudentDepartmentfrm.Margin = new Padding(5, 6, 5, 6);
            btnStudentDepartmentfrm.Name = "btnStudentDepartmentfrm";
            btnStudentDepartmentfrm.Size = new Size(201, 51);
            btnStudentDepartmentfrm.TabIndex = 7;
            btnStudentDepartmentfrm.Text = "Student Department Report";
            btnStudentDepartmentfrm.UseVisualStyleBackColor = false;
            btnStudentDepartmentfrm.Click += btnStudentDepartmentfrm_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(btnStudentDepartmentfrm);
            groupBox1.Controls.Add(btnStudentCourseGradesfrm);
            groupBox1.Controls.Add(btnCourseTopicfrm);
            groupBox1.Location = new Point(10, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 137);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student | Department | Course Reports ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(btnQuestionAnswerExam);
            groupBox2.Controls.Add(btnInstructorCoursefrm);
            groupBox2.Controls.Add(btnStudentQuestionAnswerExam);
            groupBox2.Location = new Point(10, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(856, 132);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Exam | Question | Instructor Reports ";
            // 
            // Instructorfrm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 579);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 4.5F, FontStyle.Regular, GraphicsUnit.Millimeter);
            Margin = new Padding(5, 6, 5, 6);
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
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private Button btnStudentCourseGradesfrm;
        private Button btnCourseTopicfrm;
        private Button btnQuestionAnswerExam;
        private Button btnStudentQuestionAnswerExam;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}