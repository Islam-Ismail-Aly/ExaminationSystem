using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Answer
{
    public int AnswerId { get; set; }

    public string? AnswerContent { get; set; }

    public bool? Correction { get; set; }

    public int? QuestionId { get; set; }

    public virtual Question? Question { get; set; }
}
