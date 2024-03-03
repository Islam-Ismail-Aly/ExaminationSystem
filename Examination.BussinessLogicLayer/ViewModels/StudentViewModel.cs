using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BussinessLogicLayer.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int DeptId { get; set; }
        public int SuperId { get; set; }
        public int BranchId { get; set; }
    }
}
