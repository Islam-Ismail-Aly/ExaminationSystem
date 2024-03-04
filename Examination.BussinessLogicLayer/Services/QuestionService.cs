using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Examination.BussinessLogicLayer.Services
{
    public class QuestionService
    {
        private readonly ExaminationSystemContext _db;
        public QuestionService()
        {
            _db = new ExaminationSystemContext();
        }

        public List<string> GetQuestionType()
        {
            var list = _db.Questions.Select(q => q.Type).Distinct().ToList();
            return (List<string>)list;
        }

        public int AddQuestionData(string questionContent, string type, int courseId, int instructorId)
        {
            _db.Database.ExecuteSql($"EXEC [QuestionProcedure].[InsertQuestion] {questionContent}, {type}, {courseId}, {instructorId}");

            int lastId = _db.Questions.Select(q => q.QuestionId).Max();

            return lastId;
        }

        public void AddAnswerData(string answerContent, bool correction, int questionId)
        {
           _db.Database.ExecuteSql($"EXEC [AnswerProcedure].[InsertAnswer] {answerContent}, {correction}, {questionId}");
        }

        public void AddQuestionGradesData(int questionId, int grade )
        {
            _db.Database.ExecuteSql($"EXEC [QuestionProcedure].[InsertQuestion_Grades] {questionId}, {grade}");
        }
    }
}
