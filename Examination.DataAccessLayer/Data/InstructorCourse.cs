using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class InstructorCourse
{
    public int CourseId { get; set; }

    public int InstructorId { get; set; }

    public int? WorkingHours { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;
}
