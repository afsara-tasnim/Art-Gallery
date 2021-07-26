using Art_Gallery.Entities;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class RecieveArtService
    {
        RecieveArtRepository reArtRepo;
        public RecieveArtService()
        {
            this.reArtRepo = new RecieveArtRepository();
        }
        public int AddArtwork(int d_id, int art_id,int buyerid, string collectdate, string address)
        {

            int result = reArtRepo.Insert(new ReciveArt() { d_id=d_id,art_id=art_id,buyerId=buyerid, collectdate=collectdate,address=address});
            return result;
        }
        public string GetStatus(int id)
        {
            var data = reArtRepo.GetArtStatus(id);

            return data;
        }
        public int GetID(int id)
        {
            var data = reArtRepo.GetID(id);

            return data;
        }
        public List<ReciveArt> GetAll()
        {
            return reArtRepo.GetAllInfo();
        }
        public int Upload(int id, string state)
        {

            int result = reArtRepo.Update(new ReciveArt() { art_id = id, art_Status = state });
            return result;
        }
        public int RemoveArt(int id)
        {
            int result = reArtRepo.Delete(id);
            return result;
        }
    }
}
