using Examination.BussinessLogicLayer.Services;
using Examination.PresentationLayer.Helpers;
using Microsoft.Reporting.WinForms;

namespace Examination.PresentationLayer.Forms
{
    public partial class QuestionAnswersExamReport : Form
    {
        private readonly ExamService _examService;
        private readonly QuestionAnswersByExamIdRepDataSet _dataSet;
        public QuestionAnswersExamReport()
        {
            InitializeComponent();
            _examService = new ExamService();
            _dataSet = new QuestionAnswersByExamIdRepDataSet();
        }

        private void QuestionAnswersExamReport_Load(object sender, EventArgs e)
        {
            comboExamId.DataSource = _examService.GetExam();
            comboExamId.DisplayMember = "ExamId";
            comboExamId.ValueMember = "ExamId";
            comboExamId.SelectedIndex = -1;
        }

        private void btnQuestionAnswerExam_Click(object sender, EventArgs e)
        {
            int examId = (int)comboExamId.SelectedValue;

            var list = _examService.GetQuestionAnswerExam(examId);

            // Clear previous data
            _dataSet.QuestionAnswersByExamIdRep.Clear();

            foreach (var item in list)
            {
                var row = _dataSet.QuestionAnswersByExamIdRep.NewQuestionAnswersByExamIdRepRow();

                row.Question = item.Question;

                _dataSet.QuestionAnswersByExamIdRep.AddQuestionAnswersByExamIdRepRow(row);
            }

            reportQuestionAnswersExam.LocalReport.DataSources.Clear();
            reportQuestionAnswersExam.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _dataSet.Tables["QuestionAnswersByExamIdRep"]));
            reportQuestionAnswersExam.LocalReport.ReportEmbeddedResource = "Examination.PresentationLayer.Reports.QuestionsExamReport.rdlc";
            reportQuestionAnswersExam.RefreshReport();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            CustomHelperManager.ExitHelper();
        }
    }
}
