using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Branch
{
    public int BranchId { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
