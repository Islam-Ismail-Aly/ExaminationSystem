using Examination.DataAccessLayer.Data;

namespace Examination.BussinessLogicLayer.Services
{
    public class QuestionService
    {
        private readonly ExaminationSystemContext _db;
        public QuestionService()
        {
            _db = new ExaminationSystemContext();
        }

        public  List<string> GetQuestionType()
        {
            var list = _db.Questions.Select(q=>q.Type).Distinct().ToList();
            return (List<string>)list;
        }
    }
}
