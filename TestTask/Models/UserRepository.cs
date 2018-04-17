using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class UserRepository
    {
        private static UserRepository repo = new UserRepository();
        public static UserRepository Current { get { return repo; } }
        private List<User> data = new List<User>
        {
            new User { ID = 1, UserName = "jhony81", DepartmentID = 1},
            new User { ID = 2, UserName = "missmary", DepartmentID = 2},
            new User { ID = 3, UserName = "jiijames", DepartmentID = 1}
        };

        public List<User> GetUsers()
        {
            return data;
        }

        public User GetSingleUser(int id)
        {
            User u = data.Find(x => x.ID == id);
            return u;
        }

        public User AddUser(User u)
        {
            u.ID = data.Count + 1;
            data.Add(u);
            return u;
        }
        public void DeleteUser(int id)
        {
            User user = GetSingleUser(id);
            if (user != null)
                data.Remove(user);
        }
        public string UpdateUser(User u)
        {
            User user = GetSingleUser(u.ID);
            if (user != null)
            {
                user.UserName = u.UserName;
                user.DepartmentID = u.DepartmentID;
                return "Update succesfull";
            }
            return "No such user found. Update failed";
        }

    }
}