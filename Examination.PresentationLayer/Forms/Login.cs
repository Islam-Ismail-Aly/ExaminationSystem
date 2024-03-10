using Examination.DataAccessLayer.Data;
using Examination.PresentationLayer.Helpers;
using Microsoft.IdentityModel.Tokens;

namespace Examination.PresentationLayer.Forms
{
    public partial class Login : Form
    {
        private readonly ExaminationSystemContext _db;
        private bool passwordVisible = false;
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
            btn_showPassword.Visible = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (radioStudent.Checked && !radioInstructor.Checked)
            {
                var student = _db.Students.FirstOrDefault(s => s.UserName == txt_Username.Text && s.Password == txt_Password.Text);
                if (student != null)
                {
                    Studentfrm studentfrm = new Studentfrm(student);
                    this.Hide();
                    studentfrm.FormClosed += (s, args) => this.Close();
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
                    this.Hide();
                    instructorfrm.FormClosed += (s, args) => this.Close();
                    instructorfrm.Show();
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

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !passwordVisible;
            passwordVisible = !passwordVisible;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (txt_Password.Text.IsNullOrEmpty())
            {
                btn_showPassword.Visible = false;
            }
            else
            {
                btn_showPassword.Visible = true;
            }
        }
    }
}
