using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class RequestService
    {
        RequestRepository requestRepository;

        public RequestService()
        {
            this.requestRepository= new RequestRepository();
        }
        public List<Request> GetAllReq(int id)
        {
            return requestRepository.GetAll(id);
        }
       
        public int AddRequest(int artId,int userId,int sellerId,string phone)
        {

            int result = requestRepository.Insert(new Request() { artid=artId,buyerId=userId,sellerId=sellerId,phoneNumber=phone  });
            return result;
        }
        public int RemoveArt(int id)
        {
            int result = requestRepository.Delete(id);
            return result;
        }
    }
}
