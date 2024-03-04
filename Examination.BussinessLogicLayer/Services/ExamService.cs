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

        public List<AnswerViewModel> GetAnswers(int QuestionId)
        {
            //var list = _db.Answers.Where(a => a.QuestionId == QuestionId).AsNoTracking().ToList();
            var list = _db.Database.SqlQuery<AnswerViewModel>($"select * from [dbo].[Answer] where questionId = {QuestionId} ")
                                   .AsNoTracking().ToList();
            return list;
        }

        public int InsertExam(int CourseId, DateTime startTime, DateTime endTime, int degree)
        {
            var list = _db.Database.ExecuteSql($"EXEC [ExamProcedure].[InsertExam] {CourseId}, {startTime}, {endTime}, {degree}");

            int lastId = _db.Exams.Select(q => q.ExamId).Max();

            return lastId;
        }

        public void InsertQuestionExam(List<ExamQuestionViewModel> Questions, int ExamId)
        {
            foreach (var item in Questions)
            {
                _db.Database.ExecuteSql($"EXEC [ExamProcedure].[InsertQuestion_Exam] {item.QuestionId}, {ExamId}");

            }
        }

        public void InsertStudentQuestionExam(int StudentId, int ExamId, List<AnswerViewModel> answers)
        {
            foreach (var item in answers)
            {
                _db.Database.ExecuteSql($"EXEC [ExamProcedure].[InsertStudent_Question_Exam] {item.QuestionId}, {StudentId}, {ExamId}, {item.Correction}");
            }
        }

        public void InsertStudentCourse(int CourseId, int StudentId, int Grade)
        {
            _db.Database.ExecuteSql($"EXEC [StudentProcedure].[InsertStudent_Course_Grade] {CourseId}, {StudentId}, {Grade}");
        }
    }
}
