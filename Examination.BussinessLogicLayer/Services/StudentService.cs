

using Examination.BussinessLogicLayer.ViewModels;
using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Examination.BussinessLogicLayer.Services
{
    public class StudentService
    {
        private readonly ExaminationSystemContext _db;
        public StudentService()
        {
            _db = new ExaminationSystemContext();
        }

        public List<Course> GetCourses()
        {
            return _db.Courses.AsNoTracking().ToList();
        }
        public List<Course> GetCourses(int studentId)
        {
            var list = _db.Courses.Where(c =>
                        (_db.StudentCourses.Where(c => c.StudentId == studentId)
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

        public string GetSupervisor(int? SupervisorId)
        {
            return _db.Students.Where(s => s.StudentId == SupervisorId).Select(s => s.Fname + " " + s.Lname).FirstOrDefault().ToString();
        }

        public List<Student> GetStudents()
        {
            return _db.Students.AsNoTracking().ToList();
        }

        public List<StudentCourseGradeViewModel> GetCoursesGrade(int StudentId)
        {
            var list = _db.Database.SqlQuery<StudentCourseGradeViewModel>($"EXEC [StudentProcedure].[StudentGradeCourseRep] {StudentId}")
                                      .AsNoTracking()
                                      .ToList();

            return (List<StudentCourseGradeViewModel>)list;
        }
    }
}
