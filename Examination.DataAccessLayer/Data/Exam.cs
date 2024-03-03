using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Exam
{
    public int ExamId { get; set; }

    public int? CourseId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public TimeOnly? Duration { get; set; }

    public byte? Degree { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<StudentQuestionExam> StudentQuestionExams { get; set; } = new List<StudentQuestionExam>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
