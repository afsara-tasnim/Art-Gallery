using Art_Gallery.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class UsersRepository
    {
        DataAccess dataAccess;

        public UsersRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Users> GetAll(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Users> userList = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users();
                users.id = Convert.ToInt32(reader["id"]);
                users.full_name = reader["full_name"].ToString();
                users.email = reader["email"].ToString();
                users.address= reader["address"].ToString();
                users.type = Convert.ToInt32(reader["type"]);
                users.phone_number = reader["phone_number"].ToString();
                users.status = reader["status"].ToString();

                userList.Add(users);
            }
            dataAccess.Dispose();
            return userList;
        }
        public List<Users> GetAllArtist()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `users` WHERE `type`= 1";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Users> userList = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users();
                users.id = Convert.ToInt32(reader["id"]);
                users.full_name = reader["full_name"].ToString();
                users.email = reader["email"].ToString();
                users.address = reader["address"].ToString();
                users.type = Convert.ToInt32(reader["type"]);
                users.phone_number = reader["phone_number"].ToString();
                users.status = reader["status"].ToString();
                userList.Add(users);
            }
            dataAccess.Dispose();
            return userList;
        }
        public List<Users> GetAllAdmin()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `users` WHERE `type`= 3";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Users> userList = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users();
                users.id = Convert.ToInt32(reader["id"]);
                users.full_name = reader["full_name"].ToString();
                users.email = reader["email"].ToString();
                users.address = reader["address"].ToString();
                users.type = Convert.ToInt32(reader["type"]);
                users.phone_number = reader["phone_number"].ToString();
                users.status= reader["status"].ToString();
                userList.Add(users);
            }
            dataAccess.Dispose();
            return userList;
        }
        public List<Users> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `users`";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Users> userList = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users();
                users.id = Convert.ToInt32(reader["id"]);
                users.full_name = reader["full_name"].ToString();
                users.email = reader["email"].ToString();
                users.address = reader["address"].ToString();
                users.phone_number = reader["phone_number"].ToString();
                users.status = reader["status"].ToString();
                userList.Add(users);
            }
            dataAccess.Dispose();
            return userList;
        }
        public int GetId(string name)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `id` FROM `users` WHERE `full_name`='" + name + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt32(reader["id"]);
            }

            dataAccess.Dispose();
            return result;



        }
        public int Gettype()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `type` FROM `users`";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt32(reader["type"]);
            }

            dataAccess.Dispose();
            return result;



        }
        public int Gettype(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `type` FROM `users` WHERE  `id`='" + id + "' ";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt32(reader["type"]);
            }

            dataAccess.Dispose();
            return result;



        }
        public string GetName(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `full_name` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["full_name"].ToString();
            }

            dataAccess.Dispose();
            return result;
        }

        public string GetPass(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `password` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["password"].ToString();
            }

            dataAccess.Dispose();
            return result;
        }
        public string GetEmail(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `email` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["email"].ToString();
            }

            dataAccess.Dispose();
            return result;



        }
        public string GetPhone(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `phone_number` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["phone_number"].ToString();
            }

            dataAccess.Dispose();
            return result;



        }
        public string GetAddress(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `address` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["address"].ToString();
            }

            dataAccess.Dispose();
            return result;



        }
        public string GetState(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `status` FROM `users` WHERE `id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["status"].ToString();
            }

            dataAccess.Dispose();
            return result;



        }
        public int UpdateName(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `full_name`='" + user.full_name + "' WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateState(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `status`='" + user.status + "'WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdatePhoneNumber(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `phone_number`='" + user.phone_number + "' WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdatePass(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `password`='" + user.password + "' WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdatAddress(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `address`='" + user.address + "' WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateEmail(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `users` SET `email`='" + user.email + "' WHERE `id`='" + user.id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql1 = "DELETE FROM `users` WHERE `id`='"+ id +"'";
            int result1 = dataAccess.ExecuteQuery(sql1);
            dataAccess.Dispose();
            return result1;
        }
    }
}
