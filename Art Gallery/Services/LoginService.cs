using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class LoginService
    {
     
            LoginRepository loginRepo;
            public LoginService()
            {
                loginRepo = new LoginRepository();
            }

            public int LoginValidation(string username, string password)
            {
                return loginRepo.Validation(new Users() { full_name = username, password = password });
            }
        

    }
}
