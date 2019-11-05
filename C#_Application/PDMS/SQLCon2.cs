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
        public Current LogInECard(int hexcid)
        {
            string connectionString = "server=192.168.43.131;database=PDMS;uid=monty;pwd=pass1";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");
                string query = String.Format("SELECT Role FROM Users WHERE EcardNumber=\'{0}\'", hexcid);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                int role = Convert.ToInt32(rdr[0]);
                rdr.Close();
                connection.Close();
                Current cur = new Current();
                cur.Hexcid = hexcid;
                cur.Role = role;
                return cur;

            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());
                Current cur = new Current();
                return cur;
            }
        }
    }
}
