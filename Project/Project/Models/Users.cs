using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Users
    {
        SqlConnection conn;
        public Users()
        {
        }
        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddUser(User user)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Users VALUES ('{0}','{1}','{2}','{3}','{4}')",  user.Username, user.Password, user.Name, user.Email, user.Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public User AutheticateUser(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}'AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
                user.Email = reader.GetString(reader.GetOrdinal("Email"));
                user.Type = reader.GetString(reader.GetOrdinal("Type"));
            }
            conn.Close();
            return user;

        }
        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Email = reader.GetString(reader.GetOrdinal("Email"));
                user.Type = reader.GetString(reader.GetOrdinal("Type"));

                users.Add(user);
            }
            conn.Close();
            return users;
        }
        public User GetUser(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }
        public bool UpdateUser(User user)
        {
            conn.Open();
            string query = String.Format("UPDATE Users SET Name='{0}' WHERE Username='{1}'", user.Name, user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteUser(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Users WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
