using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;
using Examination.PresentationLayer.Helpers;
using Microsoft.Reporting.WinForms;

namespace Examination.PresentationLayer.Forms
{
    public partial class InstructorCourseReport : Form
    {
        private readonly InstructorService _instructorService;
        private readonly InstructorCourseNameRepDataSet _dataSet;

        public InstructorCourseReport()
        {
            InitializeComponent();
            _instructorService = new InstructorService();
            _dataSet = new InstructorCourseNameRepDataSet();
        }

        private void InstructorCourseReport_Load(object sender, EventArgs e)
        {
            comboInstructor.DataSource = _instructorService.GetInstructors();
            comboInstructor.DisplayMember = "Name";
            comboInstructor.ValueMember = "InstructorId";
            comboInstructor.SelectedIndex = -1;
        }

        private void btnInstructorCourse_Click(object sender, EventArgs e)
        {

            using (var context = new ExaminationSystemContext())
            {
                var list = _instructorService.GetInstructorCourse((int)comboInstructor.SelectedValue).ToList();

                // Clear previous data
                _dataSet.InstructorCourseNameRep.Clear();

                foreach (var item in list)
                {
                    var row = _dataSet.InstructorCourseNameRep.NewInstructorCourseNameRepRow();

                    row.InstructorName = item.InstructorName;
                    row.CourseName = item.CourseName;
                    row.StudentCount = item.StudentCount;

                    _dataSet.InstructorCourseNameRep.AddInstructorCourseNameRepRow(row);
                }
            }

            reportInstructorCourse.LocalReport.DataSources.Clear();

            reportInstructorCourse.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["InstructorCourseNameRep"]));

            reportInstructorCourse.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.InstructorCourseReport.rdlc";

            reportInstructorCourse.RefreshReport();
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
