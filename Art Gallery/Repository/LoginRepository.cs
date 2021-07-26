using Art_Gallery.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class LoginRepository
    {
        DataAccess dataAccess;
        public LoginRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Validation(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `users` WHERE `full_name`='" + user.full_name + "' AND `password`='" + user.password + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int userType = 0;
            while (reader.Read())
            {
                userType = (int)reader["type"];
                if (userType == 0)
                {
                    return 0;
                }
                else if (userType == 1)
                {
                    return 1;
                }
                else if (userType == 2)
                {
                    return 2;
                }
            }
            return userType;
        }
    }

}
