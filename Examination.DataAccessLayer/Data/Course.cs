using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Course
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public byte? Grade { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new List<InstructorCourse>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();
}
