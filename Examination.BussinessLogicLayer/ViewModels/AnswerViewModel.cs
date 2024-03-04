using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BussinessLogicLayer.ViewModels
{
    public class AnswerViewModel
    {
        public int AnswerId { get; set; }

        public string? AnswerContent { get; set; }

        public bool? Correction { get; set; }

        public int? QuestionId { get; set; }
    }
}
