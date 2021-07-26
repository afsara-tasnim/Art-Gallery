using Art_Gallery.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class RecieveArtRepository
    {
        DataAccess dataAccess;
        public RecieveArtRepository()
        {
            this.dataAccess = new DataAccess();
        }
       
        public List<ReciveArt> GetAllInfo()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `received art`";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<ReciveArt> art = new List<ReciveArt>();
            while (reader.Read())
            {
                ReciveArt artRecived = new ReciveArt();
                artRecived.id = Convert.ToInt32(reader["id"]);
                artRecived.art_id = Convert.ToInt32(reader["art_id"]);
                artRecived.buyerId = Convert.ToInt32(reader["buyerId"]);
                artRecived.art_Status = reader["art_status"].ToString();
                artRecived.d_id= Convert.ToInt32(reader["d_id"]);
                artRecived.address = reader["address"].ToString();
                
                artRecived.collectdate = reader["Collect date"].ToString();
                art.Add(artRecived);
            }
            dataAccess.Dispose();
            return art;
        }
        public string GetArtStatus(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `art_Status` FROM `received art` WHERE `art_id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            string result = "";
            while (reader.Read())
            {
                result = reader["art_Status"].ToString();
            }

            dataAccess.Dispose();
            return result;
        }
        public int GetID(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT `id` FROM `received art` WHERE `art_id`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            int result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt32(reader["id"]);
            }

            dataAccess.Dispose();
            return result;
        }
        public int Insert(ReciveArt entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO `received art`(`d_id`, `art_id`,`buyerId`, `art_Status`, `address`, `Collect date`) VALUES ('" + entity.d_id + "','" + entity.art_id + "','"+entity.buyerId+"','Pending','" + entity.address + "','" + entity.collectdate + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Update(ReciveArt entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE `received art` SET `art_Status`='" + entity.art_Status + "' WHERE `art_id`='" + entity.art_id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql1 = "DELETE FROM `received art` WHERE `id`='" + id + "'";
            int result1 = dataAccess.ExecuteQuery(sql1);
            dataAccess.Dispose();
            return result1;
        }
    }
}
