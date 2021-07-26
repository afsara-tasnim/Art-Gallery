using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class SignUpService
    {

        SignUpRepository signuprepo;
        public SignUpService()
        {
            signuprepo = new SignUpRepository();
        }
        public int UserRegistration(string name, string pass, int type, string phoneNumber,string email,string address)
        {
            return signuprepo.Register(new Users() { full_name = name, password = pass, type=type, phone_number = phoneNumber, email = email, address =address });
        }
    }
}
