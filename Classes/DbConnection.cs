using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace HMSV2.Classes
{
    public class DbConnection
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=Hospital-Management-System.db");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sqlite_conn;
        }
    }
}
