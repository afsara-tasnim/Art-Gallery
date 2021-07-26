
using Art_Gallery.Entities;
using Art_Gallery.Interfaces;
using Art_Gallery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Services
{
    public class ArtworkService
    {
        IRepository<Artwork> repo;
        ArtworkRepository artRepo;
        public ArtworkService()
        {
            this.repo = new ArtworkRepository();
            this.artRepo = new ArtworkRepository();
        }
        public List<Artwork> GetArtById(int id)
        {
            var data = repo.Get(id);
            Artwork artwork = new Artwork();
            artwork.name = data.name;
            artwork.image = data.image;
            artwork.uploadDate = data.uploadDate;
            artwork.price = data.price;
            artwork.type = data.type;
            List<Artwork> list = new List<Artwork>();
            list.Add(artwork);
            return list;
        }
        public List<Artwork> GetAllArt()
        {
            return repo.GetAllEntity();
        }
        public List<Artwork> GetAllArtById(int id)
        {
            return repo.GetAll(id);
        }

        public int GetIdByName(string name)
        {
            var data = artRepo.GetIdByName(name);

            return data;
        }
        public int GetArtId(int id)
        {
            var data = artRepo.GetArtID(id);

            return data;
        }
        

        public int AddArtwork(string name, string uploaddate,int price, string type, byte[] image,int creator_id)
        {
            
            int result = repo.Insert(new Artwork() { name = name, uploadDate = uploaddate, price=price, type = type, image = image, creator_id=creator_id }) ;
            return result;
        }

        public int UploadArtwork(int id, string sold)
        {
           
            int result = repo.Update(new Artwork() { id = id, sold = sold });
            return result;
        }

        public int RemoveArt(int id)
        {
            int result = artRepo.Delete(id);
            return result;
        }
        public int RemoveArtbyUserID(int id)
        {
            int result = artRepo.DeleteByCreatorID(id);
            return result;
        }
    }
}
