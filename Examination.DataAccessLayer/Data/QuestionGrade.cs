using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class QuestionGrade
{
    public int QuestionId { get; set; }

    public string Grade { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
