using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class UserController
    {
        static Database db = new Database();
        public static User AuthenticateUser(string username, string password)
        {
            return db.Users.AutheticateUser(username, password);
        }
        public static bool AddUser(dynamic user)
        {
            User u = new User();
            u.Name = user.Name;
            u.Password = user.Password;
            u.Username = user.Username;
            u.Email = user.Email;
            u.Type = user.Type;

            return db.Users.AddUser(u);
        }
        public static User GetUser(string username)
        {
            return db.Users.GetUser(username);
        }
        public static bool UpdateUser(dynamic user)
        {
            User u = new User();
            u.Username = user.Username;
            u.Name = user.Name;
            return db.Users.UpdateUser(u);
        }

        public static bool DeleteUser(string username)
        {
            return db.Users.DeleteUser(username);
        }

        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }

    }
}
