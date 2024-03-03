using System;
using System.Collections.Generic;

namespace Examination.DataAccessLayer.Data;

public partial class Topic
{
    public int TopicId { get; set; }

    public string? Name { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
