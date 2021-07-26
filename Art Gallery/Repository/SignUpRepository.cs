using Art_Gallery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class SignUpRepository
    {
        DataAccess dataAccess;
        public SignUpRepository()
        {
            dataAccess = new DataAccess();
        }
        

        public int Register(Users user)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO `users`(`full_name`, `password`, `type`, `phone_number`, `email`, `address`) VALUES('" + user.full_name + "','" + user.password + "','" + user.type + "','"+user.phone_number+"','"+user.email+"','"+user.address+"')";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}

