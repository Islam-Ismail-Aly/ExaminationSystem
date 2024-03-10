using Examination.BussinessLogicLayer.Services;
using Examination.DataAccessLayer.Data;
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
    public partial class CourseTopicsReport : Form
    {
        private readonly StudentService _studentService;
        private readonly CourseService _courseService;
        private readonly CourseTopicsRepDataSet _dataSet;
        public CourseTopicsReport()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _courseService = new CourseService();
            _dataSet = new CourseTopicsRepDataSet();
        }

        private void CourseTopicsReport_Load(object sender, EventArgs e)
        {
            comboCourse.DataSource = _studentService.GetCourses();
            comboCourse.DisplayMember = "Name";
            comboCourse.ValueMember = "CourseId";
            comboCourse.SelectedIndex = -1;
        }

        private void btnCourseTopics_Click(object sender, EventArgs e)
        {
            var courseId = (int)comboCourse.SelectedValue;

            var listTopics = _courseService.GetCourseTopics(courseId);

            _dataSet.CourseTopicsRep.Clear();

            foreach (var item in listTopics)
            {
                var row = _dataSet.CourseTopicsRep.NewCourseTopicsRepRow();

                row.Name = item.Name;

                _dataSet.CourseTopicsRep.AddCourseTopicsRepRow(row);
            }

            reportCourseTopics.LocalReport.DataSources.Clear();
            reportCourseTopics.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["CourseTopicsRep"]));
            reportCourseTopics.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.CourseTopicsReport.rdlc";
            reportCourseTopics.RefreshReport();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
