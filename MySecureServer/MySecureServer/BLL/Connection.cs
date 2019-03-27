using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecureServer.BLL
{
    class Connection
    {
        SQLiteConnection m_dbConnection;
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=securedb.db;");
            m_dbConnection.Open();
        }
    }
}
