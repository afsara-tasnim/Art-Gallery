using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class UsersService
    {
        UsersRepository usersRepo;

        public UsersService()
        {
            this.usersRepo = new UsersRepository();
        }
        public List<Users> GetAllInfoById(int id)
        {
            return usersRepo.GetAll(id);
        }
        public List<Users> GetAllInfo()
        {
            return usersRepo.GetAll();
        }
        public List<Users> GetAllInfoArtist()
        {
            return usersRepo.GetAllArtist();
        }
        public List<Users> GetAllInfoAdmin()
        {
            return usersRepo.GetAllAdmin();
        }
        public int GetId(string name)
        {
            var data = usersRepo.GetId(name);

            return data;
        }
        public int Gettype()
        {
            var data = usersRepo.Gettype();

            return data;
        }
        public int Gettype(int id)
        {
            var data = usersRepo.Gettype(id);

            return data;
        }
        public string GetPass(int id)
        {
            var data = usersRepo.GetPass(id);

            return data;
        }
        public string GetName(int id)
        {
            var data = usersRepo.GetName(id);

            return data;
        }
        public string GetEmail(int id)
        {
            var data = usersRepo.GetEmail(id);

            return data;
        }
        public string GetAddress(int id)
        {
            var data = usersRepo.GetAddress(id);

            return data;
        }
        public string GetStatus(int id)
        {
            var data = usersRepo.GetState(id);

            return data;
        }
        public string GetPhone(int id)
        {
            var data = usersRepo.GetPhone(id);

            return data;
        }
        public int UpdateName(string name, int id)
        {

            int result = usersRepo.UpdateName(new Users() { full_name = name, id = id });
            return result;
        }
        public int Updatestate(string name,int id)
        {

            int result = usersRepo.UpdateState(new Users() { status = name ,id=id});
            return result;
        }
        public int UpdatePassword(string pass, int id)
        {
            int result = usersRepo.UpdatePass(new Users() { password = pass, id = id });
            return result;
        }
        public int UpdatePhoneNumber(string number, int id)
        {
            int result = usersRepo.UpdatePhoneNumber(new Users() { phone_number = number, id = id });
            return result;
        }
        public int UpdateAddress(string address, int id)
        {
            int result = usersRepo.UpdatAddress(new Users() { address = address, id = id });
            return result;
        }
        public int UpdateEmail(string email, int id)
        {
            int result = usersRepo.UpdateEmail(new Users() { email = email, id = id });
            return result;
        }
        public int Remove(int id)
        {
            int result = usersRepo.Delete(id);
            return result;
        }
    }
}
