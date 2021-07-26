using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class AcceptedService
    {
        AcceptedRepository accepted;

        public AcceptedService()
        {
            this.accepted= new AcceptedRepository();
        }
        public List<Accepted> GetAllReq()
        {
            return accepted.GetAll();
        }

        public int Add(int artId, int userId, int sellerId)
        {

            int result = accepted.Insert(new Accepted() { artId = artId, buyerId = userId, seller = sellerId });
            return result;
        }
        public int Remove(int id)
        {
            int result = accepted.Delete(id);
            return result;
        }
    }
}
