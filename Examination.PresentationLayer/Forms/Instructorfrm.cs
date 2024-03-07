using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;
using Examination.PresentationLayer.Helpers;
using Examination.PresentationLayer.Reports;
using Microsoft.IdentityModel.Tokens;

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

                lblisCorrectTF.Visible = false;
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
                lblisCorrectTF.Visible = true;
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

            txtDateTime.Text = DateTime.UtcNow.AddHours(2).ToString();

            lblisCorrectTF.Visible = false;
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

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            if (!txtContent.Text.IsNullOrEmpty() && !comboQuestionType.Text.IsNullOrEmpty() && !comboCourse.Text.IsNullOrEmpty())
            {
                int courseId = (int)comboCourse.SelectedValue;

                int questionId = _questionService.AddQuestionData(txtContent.Text, comboQuestionType.Text, courseId, _instructor.InstructorId);

                if (comboQuestionType.Text == "MCQ")
                {
                    _questionService.AddAnswerData(txtAnswerA.Text, radioAnswerA.Checked, questionId);
                    _questionService.AddAnswerData(txtAnswerB.Text, radioAnswerB.Checked, questionId);
                    _questionService.AddAnswerData(txtAnswerC.Text, radioAnswerC.Checked, questionId);
                    _questionService.AddAnswerData(txtAnswerD.Text, radioAnswerD.Checked, questionId);
                }
                else
                {
                    _questionService.AddAnswerData("True", radioT.Checked, questionId);
                    _questionService.AddAnswerData("False", radioF.Checked, questionId);
                }

                _questionService.AddQuestionGradesData(questionId, 2);
                _questionService.AddQuestionGradesData(questionId, 3);

                MessageBox.Show("The data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all textboxs and comboxes
                ControlHelperManager.ClearControl(this.Controls);
            }
            else
            {
                MessageBox.Show("Please check input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInstructorCoursefrm_Click(object sender, EventArgs e)
        {
            InstructorCourseReport reportfrm = new InstructorCourseReport();
            reportfrm.ShowDialog();
        }

        private void btnStudentCourseGradesfrm_Click(object sender, EventArgs e)
        {
            StudentCourseGradeReport reportfrms = new StudentCourseGradeReport();
            reportfrms.ShowDialog();
        }

        private void btnCourseTopicfrm_Click(object sender, EventArgs e)
        {
            CourseTopicsReport reportfrm = new CourseTopicsReport();
            reportfrm.ShowDialog();
        }

        private void btnQuestionAnswerExam_Click(object sender, EventArgs e)
        {
            QuestionAnswersExamReport reportfrm = new QuestionAnswersExamReport();
            reportfrm.ShowDialog();
        }

        private void btnStudentQuestionAnswerExam_Click(object sender, EventArgs e)
        {
            StudentQuestionAnswersReport reportfrm = new StudentQuestionAnswersReport();
            reportfrm.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CustomHelperManager.ExitHelper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
