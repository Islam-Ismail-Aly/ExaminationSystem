using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? DeptId { get; set; }

    public int? SuperId { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Department? Dept { get; set; }

    public virtual ICollection<Student> InverseSuper { get; set; } = new List<Student>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<StudentQuestionExam> StudentQuestionExams { get; set; } = new List<StudentQuestionExam>();

    public virtual Student? Super { get; set; }
}
