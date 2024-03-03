using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? QuestionContent { get; set; }

    public string? Type { get; set; }

    public int? CourseId { get; set; }

    public int? InstructorId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Course? Course { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual ICollection<QuestionGrade> QuestionGrades { get; set; } = new List<QuestionGrade>();

    public virtual ICollection<StudentQuestionExam> StudentQuestionExams { get; set; } = new List<StudentQuestionExam>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
