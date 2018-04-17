using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class WebController : ApiController
    {
        // GET: Web
        private UserRepository repo = UserRepository.Current;

        public List<User> GetAllUsers()
        {
            return repo.GetUsers();
        }

        public User GetReservation(int id)
        {
            return repo.GetSingleUser(id);
        }
        [System.Web.Http.HttpPost]
        public User CreateUser(User u)
        {
            return repo.AddUser(u);
        }
        [System.Web.Http.HttpPut]
        public string UpdateUser(User u)
        {
            return repo.UpdateUser(u);
        }
        [System.Web.Http.HttpDelete]
        public void DeleteUser(int id)
        {
            repo.DeleteUser(id);
        }
    }
}