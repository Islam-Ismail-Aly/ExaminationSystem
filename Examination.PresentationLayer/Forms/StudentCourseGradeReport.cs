using Examination.BussinessLogicLayer.Services;
using Examination.PresentationLayer.Helpers;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination.PresentationLayer.Forms
{
    public partial class StudentCourseGradeReport : Form
    {
        private readonly StudentService _studentService;
        private readonly StudentGradeCourseRepDataSet _dataSet;

        public StudentCourseGradeReport()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _dataSet = new StudentGradeCourseRepDataSet();
        }

        private void StudentCourseGradeReport_Load(object sender, EventArgs e)
        {
            comboStudnet.DataSource = _studentService.GetStudents();
            comboStudnet.DisplayMember = "UserName";
            comboStudnet.ValueMember = "StudentId";
            comboStudnet.SelectedIndex = -1;
        }

        private void btnStudentDepartment_Click(object sender, EventArgs e)
        {
            var studentId = (int)comboStudnet.SelectedValue;

            var list = _studentService.GetCoursesGrade(studentId);

            // Clear previous data
            _dataSet.StudentGradeCourseRep.Clear();

            foreach (var item in list)
            {
                var row = _dataSet.StudentGradeCourseRep.NewStudentGradeCourseRepRow();

                row.Name = item.Name;
                row.Precent = item.Precent;

                _dataSet.StudentGradeCourseRep.AddStudentGradeCourseRepRow(row);
            }

            reportStudentCourseGrades.LocalReport.DataSources.Clear();
            reportStudentCourseGrades.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["StudentGradeCourseRep"]));
            reportStudentCourseGrades.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.StudentCourseGradesReport.rdlc";
            reportStudentCourseGrades.RefreshReport();
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
