using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDMS
{
    public partial class SQLConnector
    {
        public void searchpatient()
        {
            string a = Console.ReadLine();
            string connectionString = "server=192.168.43.131;database=PDMS;uid=monty;pwd=pass1";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = String.Format("SELECT Name, Surname, Patient, PatientID FROM PDMS.patients WHERE Name = '{0}'", a);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetString("Name") + " " + myReader.GetString("Surname") + " " + myReader.GetString("PatientID"));
                }
            }
            finally
            {
                Console.WriteLine("Worked!");
                connection.Close();
            }
            Console.ReadLine();
        }
    }
}
