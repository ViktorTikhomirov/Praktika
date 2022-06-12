using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Praktika
{
    internal class DataBaseHandler
    {
        private MySqlConnection connection;
        public DataBaseHandler()
        {
            connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=autoparkingdatabase");
        }
        public bool Connect()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }        
        }
        public bool Close()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
