using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CalderaCore.DB
{
    public class DBCore
    {
        MySqlConnection m_Connection;

        
        public DBCore()
        {
            m_Connection = new MySqlConnection(GetDefaultConnectionString());
        }

        public DBCore(String connectionString)
        {
            m_Connection = new MySqlConnection(connectionString);
        }

        private String GetDefaultConnectionString()
        {
            String server = "localhost";
            String database = "spacejam";
            String uid = "root";
            String password = "jagsac";

            return String.Format("server={0};DATABASE={1};UID={2};password={3};", server, database, uid, password);
        }

        private bool OpenConnection()
        {
            try
            {
                m_Connection.Open();
                return true;
            }
            catch (MySqlException connectException)
            {
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                m_Connection.Close();
                return true;
            }
            catch (MySqlException closeException)
            {
                return false;
            };
        }

        public DataTable ExecuteQuery(String query)
        {
            DataTable returnTable = null;

            if (!OpenConnection())
            {
                return null;
            }
            MySqlCommand queryCommand = new MySqlCommand(query, m_Connection);
            try
            {
                MySqlDataReader reader = queryCommand.ExecuteReader();
                returnTable = new DataTable();
                returnTable.Load(reader);
                CloseConnection();
            }
            catch (MySqlException queryException)
            {
                return null;
            }
            return returnTable;

        }

        public int ExecuteInsertQuery(String query)
        {
            int returnValue = -1;
            if (!OpenConnection())
            {
                return returnValue;
            }
            MySqlCommand queryCommand = new MySqlCommand(query, m_Connection);
            try
            {
                int results = queryCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (MySqlException nqEx)
            {
                string message = nqEx.Message;
            }
            return returnValue;
        }

        public int ExecuteScalar(String query)
        {
            int returnValue = -1;
            if (!OpenConnection())
            {
                return returnValue;
            }
            MySqlCommand queryCommand = new MySqlCommand(query, m_Connection);
            try
            {
                String result = queryCommand.ExecuteScalar().ToString();
                if (result != String.Empty)
                {
                    returnValue = Int32.Parse(result);
                }
                CloseConnection();
            }
            catch (MySqlException nqEx)
            {

            }
            return returnValue;
        }



        
    }
}
