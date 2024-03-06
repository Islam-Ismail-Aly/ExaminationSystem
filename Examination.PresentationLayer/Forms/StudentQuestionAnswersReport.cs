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

namespace Examination.PresentationLayer.Reports
{
    public partial class StudentQuestionAnswersReport : Form
    {
        private readonly StudentService _studentService;
        private readonly ExamService _examService;

        private readonly StudentQuestionWithAnswerExamDataSet _dataSet;
        public StudentQuestionAnswersReport()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _dataSet = new StudentQuestionWithAnswerExamDataSet();
            _examService = new ExamService();
        }

        private void StudentQuestionAnswersReport_Load(object sender, EventArgs e)
        {
            comboExamId.DataSource = _examService.GetExam();
            comboExamId.DisplayMember = "ExamId";
            comboExamId.ValueMember = "ExamId";
            comboExamId.SelectedIndex = -1;

            comboStudnet.DataSource = _studentService.GetStudents();
            comboStudnet.DisplayMember = "UserName";
            comboStudnet.ValueMember = "StudentId";
            comboStudnet.SelectedIndex = -1;

        }

        private void btnStudentQuestionAnswer_Click(object sender, EventArgs e)
        {
            var examId = (int)comboExamId.SelectedValue;
            var studentId = (int)comboStudnet.SelectedValue;

            var list = _examService.GetStudentQuestionAnswerExam(examId, studentId);

            // Clear previous data
            _dataSet.StudentQuestionWithAnswerExam.Clear();

            foreach (var item in list)
            {
                var row = _dataSet.StudentQuestionWithAnswerExam.NewStudentQuestionWithAnswerExamRow();

                row.Question = item.Question;

                _dataSet.StudentQuestionWithAnswerExam.AddStudentQuestionWithAnswerExamRow(row);
            }

            reportStudentQuestionAnswer.LocalReport.DataSources.Clear();
            reportStudentQuestionAnswer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["StudentQuestionWithAnswerExam"]));
            reportStudentQuestionAnswer.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.StudentQuestionAnswersReport.rdlc";
            reportStudentQuestionAnswer.RefreshReport();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CustomHelperManager.ExitHelper();
        }
    }
}
