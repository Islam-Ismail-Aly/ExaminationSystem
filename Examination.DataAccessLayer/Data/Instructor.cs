using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public string? Name { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public decimal? Salary { get; set; }

    public int? DeptId { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual Department? Dept { get; set; }

    public virtual ICollection<InstructorCourse> InstructorCourses { get; set; } = new List<InstructorCourse>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
