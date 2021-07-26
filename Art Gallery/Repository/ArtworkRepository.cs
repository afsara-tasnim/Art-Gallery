using Art_Gallery.Entities;
using Art_Gallery.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class ArtworkRepository: IRepository<Artwork>
    {
        DataAccess dataAccess;
        public ArtworkRepository()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Artwork> GetAll(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `artwork` WHERE `creator_id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Artwork> artList = new List<Artwork>();
            while (reader.Read())
            {
                Artwork artwork = new Artwork();
                artwork.id = Convert.ToInt32(reader["id"]);
                artwork.name= reader["name"].ToString();
                artwork.uploadDate= reader["date"].ToString();
                artwork.creator_id= Convert.ToInt32(reader["creator_id"]);
                artwork.type= reader["type"].ToString();
                artwork.sold = reader["Sold"].ToString();
                artwork.price = Convert.ToInt32(reader["price"]);
                artList.Add(artwork);
            }
            dataAccess.Dispose();
            return artList;
        }
        public List<Artwork> GetAllEntity()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `artwork`";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Artwork> artList = new List<Artwork>();
            while (reader.Read())
            {
                Artwork artwork = new Artwork();
                artwork.id = Convert.ToInt32(reader["id"]);
                artwork.name = reader["name"].ToString();
                artwork.uploadDate = reader["date"].ToString();
                artwork.type = reader["type"].ToString();
                artwork.sold = reader["Sold"].ToString();
                artwork.price = Convert.ToInt32(reader["price"]);
                artwork.creator_id = Convert.ToInt32(reader["creator_id"]);
                artList.Add(artwork);

            }
            dataAccess.Dispose();
            return artList;
        }

        public int GetIdByName(string name)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `id` FROM `artwork` WHERE `name`='" + name + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while(reader.Read())
            {
                 result = Convert.ToInt32(reader["id"]);
            }
            

            dataAccess.Dispose();
            return result;

        }
        public int GetArtID(int id)
        { 
            dataAccess = new DataAccess();
            string sql = "SELECT `id` FROM `artwork` WHERE `creator_id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt32(reader["id"]);
            }


            dataAccess.Dispose();
            return result;
        }
       
        public Artwork Get(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `artwork` WHERE `creator_id`='"+id+"'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            Artwork artwork = new Artwork();
            while (reader.Read())
            {

                artwork.id = Convert.ToInt32(reader["id"]);
                artwork.name = reader["name"].ToString();
                artwork.uploadDate = reader["date"].ToString();
                artwork.creator_id = Convert.ToInt32(reader["creator_id"]);
                artwork.type = reader["type"].ToString();
                artwork.sold = reader["sold"].ToString();
                artwork.price= Convert.ToInt32(reader["price"]);
            }
            

            dataAccess.Dispose();
            return artwork;
        }



        public int Insert(Artwork entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO `artwork`(`name`, `date`, `type`, `image`, `price`,`Sold`,`creator_id`) VALUES ('" + entity.name + "','"+entity.uploadDate+"','"+entity.type+"','"+entity.image+"','"+entity.price+"','No','"+entity.creator_id+"')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(Artwork entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `artwork` SET `Sold`='" + entity.sold + "' WHERE `id`='" + entity.id +"'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM `artwork` WHERE `id`='"+id+"'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int DeleteByCreatorID(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM `artwork` WHERE `creator_id`='" + id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
