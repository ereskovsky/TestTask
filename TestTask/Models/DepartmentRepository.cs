using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class DepartmentRepository
    {
        private static DepartmentRepository repo = new DepartmentRepository();
        public static DepartmentRepository Current { get { return repo; } }
        private static List<Department> data = new List<Department>
        {
            new Department { ID = 1, Title = "IT Department"},
            new Department { ID = 2, Title = "Marketing"},
        };
        public List<Department> GetDeps()
        {
            return data;
        }
        public static Department GetDep(int id)
        {
            Department d =  data.Find(x=>x.ID == id);
            return d;
        }
    }
}