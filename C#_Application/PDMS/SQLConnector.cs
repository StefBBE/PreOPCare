using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace PDMS
{
    public static class SQLConnector
    {
        static string connectionString = "server=192.168.64.2;database=PDMS;uid=test;pwd=;";

        public static int LogIn(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");
                string query = String.Format("SELECT Role FROM Users WHERE Username=\'{0}\' AND Password=\'{1}\'", username, password);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int role = Convert.ToInt32(rdr[0]);
                rdr.Close();
                connection.Close();
                return role;

            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());
                return 0;

            }




        }
    }
}
