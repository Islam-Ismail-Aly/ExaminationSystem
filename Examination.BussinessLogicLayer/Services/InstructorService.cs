
using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Examination.BussinessLogicLayer.Services
{
    public class InstructorService
    {
        private readonly ExaminationSystemContext _db;
        public InstructorService()
        {
            _db = new ExaminationSystemContext();
        }

        public List<Course> GetCourses(int instructorId)
        {
            var list = _db.Courses.Where(c =>
                        (_db.InstructorCourses.Where(c => c.InstructorId == instructorId)
                        .Select(c => c.CourseId).ToList()).Contains(c.CourseId)).ToList();
            return (List<Course>)list;
        }

        public string GetDepartment(int? DeptId)
        {
            return _db.Departments.FirstOrDefault(d => d.DeptId == DeptId).Name;
        }
        public string GetBranch(int? BranchId)
        {
            return _db.Branches.FirstOrDefault(d => d.BranchId == BranchId).Name;
        }

        public List<Instructor> GetInstructors()
        {
            return _db.Instructors.AsNoTracking().ToList();
        }

        public List<InstructorCourseViewModel> GetInstructorCourse(int InstructorId)
        {
            var list = _db.Database.SqlQuery<InstructorCourseViewModel>($"EXEC [InstructorProcedure].[InstructorCourseNameRep] {InstructorId}")
                                      .AsNoTracking()
                                      .ToList();

            return (List<InstructorCourseViewModel>)list;
        }

    }
}
