using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;

namespace Examination.PresentationLayer.Forms
{
    public partial class Instructorfrm : Form
    {
        private readonly InstructorService _instructorService;
        private readonly QuestionService _questionService;
        private readonly StudentService _studentService;

        private readonly Instructor _instructor;

        private static string questionType = string.Empty;

        public Instructorfrm(Instructor instructor)
        {
            InitializeComponent();
            _instructorService = new InstructorService();
            _questionService = new QuestionService();
            _studentService = new StudentService();
            _instructor = instructor;
        }

        private void HideOrShowControl()
        {
            if (comboQuestionType.Text == "MCQ")
            {
                txtAnswerA.Visible = true;
                txtAnswerB.Visible = true;
                txtAnswerC.Visible = true;
                txtAnswerD.Visible = true;

                radioAnswerA.Visible = true;
                radioAnswerB.Visible = true;
                radioAnswerC.Visible = true;
                radioAnswerD.Visible = true;

                lblAnsA.Visible = true;
                lblAnsB.Visible = true;
                lblAnsC.Visible = true;
                lblAnsD.Visible = true;

                lblisCorrect.Visible = true;
            }
            else if (comboQuestionType.Text != "MCQ")
            {
                txtAnswerA.Visible = false;
                txtAnswerB.Visible = false;
                txtAnswerC.Visible = false;
                txtAnswerD.Visible = false;

                radioAnswerA.Visible = false;
                radioAnswerB.Visible = false;
                radioAnswerC.Visible = false;
                radioAnswerD.Visible = false;

                lblAnsA.Visible = false;
                lblAnsB.Visible = false;
                lblAnsC.Visible = false;
                lblAnsD.Visible = false;

                lblisCorrect.Visible = false;
            }

            if (comboQuestionType.Text == "T/F")
            {
                radioT.Visible = true;
                radioF.Visible = true;

            }
            else if (comboQuestionType.Text != "T/F")
            {
                radioT.Visible = false;
                radioF.Visible = false;
            }
        }

        private void Instructorfrm_Load(object sender, EventArgs e)
        {
            txtInstructorName.Text = _instructor.Name;
            txtUsername.Text = _instructor.UserName;
            txtDepartment.Text = _instructorService.GetDepartment(_instructor.DeptId);
            txtBranch.Text = _instructorService.GetBranch(_instructor.BranchId);

            var list = _instructorService.GetCourses(_instructor.InstructorId);

            dataGridCourses.DataSource = list;

            dataGridCourses.Columns["CourseId"].Visible = false;
            dataGridCourses.Columns["Grade"].Visible = false;
            dataGridCourses.Columns["Exams"].Visible = false;
            dataGridCourses.Columns["Questions"].Visible = false;
            dataGridCourses.Columns["StudentCourses"].Visible = false;
            dataGridCourses.Columns["Topics"].Visible = false;
            dataGridCourses.Columns["InstructorCourses"].Visible = false;

            comboQuestionType.DataSource = _questionService.GetQuestionType();
            comboQuestionType.SelectedIndex = -1;

            comboCourse.DataSource = _studentService.GetCourses();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";
            comboCourse.SelectedIndex = -1;

        }

        private void comboQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideOrShowControl();
        }

        private void btnStudentDepartmentfrm_Click(object sender, EventArgs e)
        {
            StudentDepartmentReport report = new StudentDepartmentReport();
            report.ShowDialog();
        }
    }
}
