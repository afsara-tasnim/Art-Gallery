using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Repository
{
    public class DataAccess
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public DataAccess()
        {
            this.connection = new MySqlConnection("datasource = localhost;username=root;password=; database= art gallery;");
            this.connection.Open();
        }
        public MySqlDataReader GetMySqlData(string sql)
        {
            this.command = new MySqlCommand(sql, this.connection);
            return this.command.ExecuteReader();

        }

        public int ExecuteQuery(string sql)
        {
            this.command = new MySqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }
        
        public void Dispose()
        {
            this.connection.Close();
        }



    }
}

