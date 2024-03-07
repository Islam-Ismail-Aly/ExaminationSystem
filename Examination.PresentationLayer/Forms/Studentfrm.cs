
using Examination.BussinessLogicLayer.Services;
using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using Examination.PresentationLayer.Helpers;

namespace Examination.PresentationLayer.Forms
{
    public partial class Studentfrm : Form
    {
        private readonly StudentService _studentService;
        private readonly ExamService _examService;

        List<ExamQuestionViewModel> listQuestion;
        List<AnswerViewModel> answerList;
        List<AnswerViewModel> selectedAnswer = new List<AnswerViewModel>();

        List<int>? finalResult = new List<int>();

        ListQuestionMcq[]? listMcq = new ListQuestionMcq[5];
        ListQuestionTF[]? listTF = new ListQuestionTF[5];

        private readonly Student _student;

        public Studentfrm(Student student)
        {
            InitializeComponent();
            _student = student;
            _studentService = new StudentService();
            _examService = new ExamService();
        }

        private void Studentfrm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = _student.Fname + " " + _student.Lname;

            txtUsername.Text = _student.UserName;

            txtDepartment.Text = _studentService.GetDepartment(_student.DeptId);

            txtBranch.Text = _studentService.GetBranch(_student.BranchId);

            txtSupervisor.Text = _studentService.GetSupervisor(_student.SuperId);


            var list = _studentService.GetCourses(_student.StudentId);

            var listGrade = _studentService.GetCoursesGrade(_student.StudentId);

            dataGridCourseGrades.DataSource = listGrade;

            comboCourse.DataSource = list;
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";
            comboCourse.SelectedIndex = -1;

            dataGridCourses.DataSource = list;

            dataGridCourses.Columns["CourseId"].Visible = false;
            dataGridCourses.Columns["Grade"].Visible = false;
            dataGridCourses.Columns["Exams"].Visible = false;
            dataGridCourses.Columns["Questions"].Visible = false;
            dataGridCourses.Columns["StudentCourses"].Visible = false;
            dataGridCourses.Columns["Topics"].Visible = false;
            dataGridCourses.Columns["InstructorCourses"].Visible = false;
            btnSubmit.Visible = false;

            txtDateTime.Text = DateTime.UtcNow.AddHours(2).ToString();
        }

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            if (comboCourse.SelectedValue != null)
            {
                flowLayoutPanel.Controls.Clear();

                listQuestion = _examService.GetExamQuestion(comboCourse.Text);

                for (int i = 0; i < listMcq.Length; i++)
                {
                    if (listQuestion[i].Type == "MCQ")
                    {
                        listMcq[i] = new ListQuestionMcq();

                        listMcq[i].QuestionContent = listQuestion[i].QuestionContent.Trim();

                        answerList = _examService.GetAnswers(listQuestion[i].QuestionId);

                        listMcq[i].AnswerA = answerList[0].AnswerContent.Trim();
                        listMcq[i].AnswerB = answerList[1].AnswerContent.Trim();
                        listMcq[i].AnswerC = answerList[2].AnswerContent.Trim();
                        listMcq[i].AnswerD = answerList[3].AnswerContent.Trim();

                        listMcq[i].Answers = answerList;

                        //listMcq[i].rad

                        if (flowLayoutPanel.Controls.Count < 0)
                            flowLayoutPanel.Controls.Clear();
                        else
                            flowLayoutPanel.Controls.Add(listMcq[i]);

                        listMcq[i].RadioButtons.Add(listMcq[i].radioA);
                        listMcq[i].RadioButtons.Add(listMcq[i].radioB);
                        listMcq[i].RadioButtons.Add(listMcq[i].radioC);
                        listMcq[i].RadioButtons.Add(listMcq[i].radioD);

                    }
                    else
                    {
                        listTF[i] = new ListQuestionTF();

                        listTF[i].QuestionContent = listQuestion[i].QuestionContent.Trim();

                        var answerList = _examService.GetAnswers(listQuestion[i].QuestionId);

                        listTF[i].AnswerT = answerList[0].AnswerContent.Trim();
                        listTF[i].AnswerF = answerList[1].AnswerContent.Trim();

                        listTF[i].Answers = answerList;

                        if (flowLayoutPanel.Controls.Count < 0)
                            flowLayoutPanel.Controls.Clear();
                        else
                            flowLayoutPanel.Controls.Add(listTF[i]);

                        listTF[i].RadioButtons.Add(listTF[i].radioT);
                        listTF[i].RadioButtons.Add(listTF[i].radioF);
                    }
                }
                btnSubmit.Visible = true;
            }
            else
            {
                MessageBox.Show("Please check course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listMcq.Length; i++)
            {
                if (listMcq[i] != null)
                {
                    finalResult.Add(listMcq[i].GetCorrection());
                    selectedAnswer.Add(listMcq[i].SelectedAnswer);
                }
            }

            for (int i = 0; i < listTF.Length; i++)
            {
                if (listTF[i] != null)
                {
                    finalResult.Add(listTF[i].GetCorrection());
                    selectedAnswer.Add(listTF[i].SelectedAnswer);
                }
            }

            int examId = _examService.InsertExam((int)comboCourse.SelectedValue, DateTime.Now, DateTime.Now.AddMinutes(30), 10);

            _examService.InsertQuestionExam(listQuestion, examId);

            _examService.InsertStudentQuestionExam(_student.StudentId, examId, selectedAnswer);

            float sum = (float)(finalResult.Sum());

            int finalGrade = (int)((sum / 5) * 100);

            _examService.InsertStudentCourse(_student.StudentId, (int)comboCourse.SelectedValue, finalGrade);

            MessageBox.Show($"Your Result is: {finalResult.Sum() * 3}", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            flowLayoutPanel.Controls.Clear();

            btnSubmit.Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CustomHelperManager.ExitHelper();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
