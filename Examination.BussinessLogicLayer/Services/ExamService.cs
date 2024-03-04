using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Examination.BussinessLogicLayer.Services
{
    public class ExamService
    {
        private readonly ExaminationSystemContext _db;

        public ExamService()
        {
            _db = new ExaminationSystemContext();
        }

        public List<ExamQuestionViewModel> GetExamQuestion(string CourseName)
        {
            var list = _db.Database.SqlQuery<ExamQuestionViewModel>($"EXEC [ExamProcedure].[CreateExam] {CourseName}")
                                   .AsNoTracking()
                                   .ToList();

            return list;
        }

        public List<Answer> GetAnswers(int QuestionId)
        {
            var list = _db.Answers.Where(a=>a.QuestionId == QuestionId).AsNoTracking().ToList();
            return list;
        }
    }
}
