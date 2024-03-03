using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class StudentQuestionExam
{
    public int QuestionId { get; set; }

    public int StudentId { get; set; }

    public int ExamId { get; set; }

    public bool? Answer { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
