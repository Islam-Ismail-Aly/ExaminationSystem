using Examination.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace Examination.BussinessLogicLayer.Services
{
    public class DepartmentService
    {
        private readonly ExaminationSystemContext _db;
        public DepartmentService()
        {
            _db = new ExaminationSystemContext();
        }


        public List<Department> GetDepartments()
        {
            return _db.Departments.AsNoTracking().ToList();
        }

        public List<Student> GetStudentsByDepartmentId(int departmentId)
        {
            #region another mapping solution
            //var studentViewModels = _db.Students
                                    //.FromSqlRaw("EXEC [DepartmentProcedure].[DepartmentStudentByIdRep] @DeptId", new SqlParameter("@DeptId", departmentId))
                                    //.Select(s => new StudentViewModel
                                    //{
                                    //    Id = s.Id,
                                    //    Name = s.Name,
                                    //})
                                    //.ToList();

                                    //            return studentViewModels;
            #endregion

            var list = _db.Students.FromSql($"EXEC [DepartmentProcedure].[DepartmentStudentByIdRep] {departmentId}")
                                   .AsNoTracking()
                                   .ToList();
            
            return list;
        }
    }
}
