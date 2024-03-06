using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BussinessLogicLayer.Services
{
    public class CourseService
    {
        private readonly ExaminationSystemContext _db;

        public CourseService()
        {
            _db = new ExaminationSystemContext();
        }

        public List<TopicsViewModel> GetCourseTopics(int CourseId)
        {
            var list = _db.Database.SqlQuery<TopicsViewModel>($"EXEC [CourseProcedure].[CourseTopicsRep] {CourseId}")
                                      .AsNoTracking()
                                      .ToList();

            return (List<TopicsViewModel>)list;
        }
    }
}
