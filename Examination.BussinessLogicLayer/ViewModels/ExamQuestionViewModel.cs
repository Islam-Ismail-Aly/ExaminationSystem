using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BussinessLogicLayer.ViewModels
{
    public class ExamQuestionViewModel
    {
        public string QuestionContent { get; set; }
        public string Type { get; set; }
        public Guid RandomId { get; set; }
        public int QuestionId { get; set; }
    }
}
