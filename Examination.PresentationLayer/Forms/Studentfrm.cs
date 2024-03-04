
using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;

namespace Examination.PresentationLayer.Forms
{
    public partial class Studentfrm : Form
    {
        private readonly StudentService _studentService;
        private readonly ExamService _examService;

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
        }

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            var list = _examService.GetExamQuestion(comboCourse.Text);

            ListQuestionMcq[] listMcq = new ListQuestionMcq[5];
            ListQuestionTF[] listTF = new ListQuestionTF[5];

            for (int i = 0; i < listMcq.Length; i++)
            {
                if (list[i].Type == "MCQ")
                {
                    listMcq[i] = new ListQuestionMcq();

                    listMcq[i].QuestionContent = list[i].QuestionContent.Trim();

                    var answerList = _examService.GetAnswers(list[i].QuestionId);

                    listMcq[i].AnswerA = answerList[0].AnswerContent.Trim();
                    listMcq[i].AnswerB = answerList[1].AnswerContent.Trim();
                    listMcq[i].AnswerC = answerList[2].AnswerContent.Trim();
                    listMcq[i].AnswerD = answerList[3].AnswerContent.Trim();

                    if (flowLayoutPanel.Controls.Count < 0)
                        flowLayoutPanel.Controls.Clear();
                    else
                        flowLayoutPanel.Controls.Add(listMcq[i]);

                    ListQuestionMcq.questionType = list[i].Type;
                }
                else
                {
                    listTF[i] = new ListQuestionTF();

                    listTF[i].QuestionContent = list[i].QuestionContent.Trim();

                    var answerList = _examService.GetAnswers(list[i].QuestionId);

                    listTF[i].AnswerT = answerList[0].AnswerContent.Trim();
                    listTF[i].AnswerF = answerList[1].AnswerContent.Trim();

                    if (flowLayoutPanel.Controls.Count < 0)
                        flowLayoutPanel.Controls.Clear();
                    else
                        flowLayoutPanel.Controls.Add(listTF[i]);

                    ListQuestionTF.questionType = list[i].Type;
                }
            }
        }
    }
}
