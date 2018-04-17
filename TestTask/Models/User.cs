using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int DepartmentID { get; set; }
        public string DepName { get { return DepartmentRepository.GetDep(DepartmentID).Title; } }

    }
}