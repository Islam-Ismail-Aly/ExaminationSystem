using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Department
{
    public int DeptId { get; set; }

    public string? Name { get; set; }

    public int? ManagerId { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual Instructor? Manager { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
