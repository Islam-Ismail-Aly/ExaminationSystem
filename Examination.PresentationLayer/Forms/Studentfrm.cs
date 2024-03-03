
using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;

namespace Examination.PresentationLayer.Forms
{
    public partial class Studentfrm : Form
    {
        private readonly StudentService _studentService;
        private readonly Student _student;

        public Studentfrm(Student student)
        {
            InitializeComponent();
            _student = student;
            _studentService = new StudentService();
        }

        private void Studentfrm_Load(object sender, EventArgs e)
        {
            comboCourse.DataSource = _studentService.GetCourses();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";
            comboCourse.SelectedIndex = -1;

            /////////////////////////////////////////////////////////

            txtStudentName.Text = _student.Fname + " " + _student.Lname;
            txtUsername.Text = _student.UserName;
            txtDepartment.Text = _studentService.GetDepartment(_student.DeptId);
            txtBranch.Text = _studentService.GetBranch(_student.BranchId);
            txtSupervisor.Text = _studentService.GetSupervisor(_student.SuperId);

            var list = _studentService.GetCourses(_student.StudentId);

            dataGridCourses.DataSource = list;

            dataGridCourses.Columns["CourseId"].Visible = false;
            dataGridCourses.Columns["Grade"].Visible = false;
            dataGridCourses.Columns["Exams"].Visible = false;
            dataGridCourses.Columns["Questions"].Visible = false;
            dataGridCourses.Columns["StudentCourses"].Visible = false;
            dataGridCourses.Columns["Topics"].Visible = false;
            dataGridCourses.Columns["Instructors"].Visible = false;
        }
    }
}
