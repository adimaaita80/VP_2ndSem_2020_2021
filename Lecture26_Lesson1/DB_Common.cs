using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lecture26_Lesson1
{
    public static class DB_Common
    {
        static string connectionString = "server= DESKTOP-BKKL4I9\\SQLEXPRESS; database= VP_Lect24; integrated security= SSPI;";

        public static SqlConnection connection = new SqlConnection(connectionString);

        public static void OpenConnection()
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

    }
}
