using Examination.DataAccessLayer.Data;
using Examination.PresentationLayer.Helpers;

namespace Examination.PresentationLayer.Forms
{
    public partial class Login : Form
    {
        private readonly ExaminationSystemContext _db;
        public Login()
        {
            InitializeComponent();
            _db = new ExaminationSystemContext();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CustomHelperManager.ExitHelper();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (radioStudent.Checked && !radioInstructor.Checked)
            {
                var student = _db.Students.FirstOrDefault(s => s.UserName == txt_Username.Text && s.Password == txt_Password.Text);
                if (student != null)
                {
                    Studentfrm studentfrm = new Studentfrm(student);
                    studentfrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or password Invalid \n Please check username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (radioInstructor.Checked && !radioStudent.Checked)
            {
                var instructor = _db.Instructors.FirstOrDefault(s => s.UserName == txt_Username.Text && s.Password == txt_Password.Text);
                if (instructor != null)
                {
                    Instructorfrm instructorfrm = new Instructorfrm(instructor);
                    instructorfrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or password Invalid \n Please check username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please check as Student or Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
