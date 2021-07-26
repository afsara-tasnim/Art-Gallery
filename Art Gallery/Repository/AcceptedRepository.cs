using Art_Gallery.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class AcceptedRepository
    {

        DataAccess dataAccess;
        public AcceptedRepository()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Accepted> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `accepted`";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Accepted> accList = new List<Accepted>();
            while (reader.Read())
            {
                Accepted acc = new Accepted();
                acc.id = Convert.ToInt32(reader["id"]);
                acc.artId = Convert.ToInt32(reader["art_id"]);

                acc.buyerId = Convert.ToInt32(reader["buyer"]);
                acc.seller = Convert.ToInt32(reader["seller"]);
               

                accList.Add(acc);
            }
            dataAccess.Dispose();
            return accList;
        }

        public int Insert(Accepted entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO `accepted`(`art_id`, `buyer`, `seller`) VALUES  ('" + entity.artId + "','" + entity.buyerId + "','" + entity.seller + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM `accepted` WHERE `art_id`='" + id + "'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

    }
}
