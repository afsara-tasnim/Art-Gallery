using Art_Gallery.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class RequestRepository
    {
        DataAccess dataAccess;
        public RequestRepository()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Request> GetAll(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `request` WHERE `sellerId`='" + id + "'";
            MySqlDataReader reader = dataAccess.GetMySqlData(sql);
            List<Request> reqList = new List<Request>();
            while (reader.Read())
            {
                Request request = new Request();
                request.id = Convert.ToInt32(reader["id"]);
                request.artid = Convert.ToInt32(reader["artId"]);
               
                request.buyerId = Convert.ToInt32(reader["buyerId"]);
                request.sellerId= Convert.ToInt32(reader["sellerId"]);
                request.phoneNumber= reader["Phone Number"].ToString();

                reqList.Add(request);
            }
            dataAccess.Dispose();
            return reqList;
        }
        
        public int Insert(Request entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO `request`(`artId`, `buyerId`, `sellerId`, `Phone number`) VALUES ('" + entity.artid+ "','" + entity.buyerId + "','"+entity.sellerId+"','"+entity.phoneNumber+"')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql1 = "DELETE FROM `request` WHERE `artId`='" + id + "'";
            int result1 = dataAccess.ExecuteQuery(sql1);
            dataAccess.Dispose();
            return result1;
        }
    }
}
