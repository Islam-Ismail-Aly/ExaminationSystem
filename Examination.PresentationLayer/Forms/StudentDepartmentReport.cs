using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Examination.PresentationLayer.Forms
{
    public partial class StudentDepartmentReport : Form
    {
        private readonly DepartmentService _departmentService;
        private readonly ExaminationSystemDataSet _dataSet;
        public StudentDepartmentReport()
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            _dataSet = new ExaminationSystemDataSet();
        }

        private void StudentDepartmentReport_Load(object sender, EventArgs e)
        {
            comboDepartment.DataSource = _departmentService.GetDepartments();
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "DeptId";
            comboDepartment.SelectedIndex = -1;
        }

        private void btnStudentDepartment_Click(object sender, EventArgs e)
        {
            int departmentId = (int)comboDepartment.SelectedValue;

            using (var context = new ExaminationSystemContext())
            {
                var students = _departmentService.GetStudentsByDepartmentId(departmentId).ToList();

                // Clear previous data
                _dataSet.DepartmentStudentByIdRep.Clear();

                foreach (var student in students)
                {
                    var row = _dataSet.DepartmentStudentByIdRep.NewDepartmentStudentByIdRepRow();
                    row.StudentId = student.StudentId;
                    row.Fname = student.Fname;
                    row.Lname = student.Lname;
                    row.UserName = student.UserName;

                    // Add more properties as needed
                    _dataSet.DepartmentStudentByIdRep.AddDepartmentStudentByIdRepRow(row);
                }
            }

            // Set the dataset as a data source for the report
            reportViewerStudentDepartment.LocalReport.DataSources.Clear();

            reportViewerStudentDepartment.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["DepartmentStudentByIdRep"]));

            // Set the report path
            reportViewerStudentDepartment.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.StudentDepartmentReport.rdlc";

            // Refresh the report viewer
            reportViewerStudentDepartment.RefreshReport();
        }
    }
}
