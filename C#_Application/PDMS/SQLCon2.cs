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
        public List<Patient> searchpatient(string a, string b)
        {

           
            List<Patient> Patlist = new List<Patient>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = String.Format("SELECT * FROM PDMS.patients WHERE (Surname = '{0}' AND Name = '{1}')", b, a);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Patient bufpat = new Patient(myReader.GetInt32("PatientID"), myReader.GetString("Name"), myReader.GetString("Surname"), myReader.GetString("Medication"), myReader.GetString("SocialSecurity"), myReader.GetString("DateOfBirth"), myReader.GetBoolean("Sex"), myReader.GetFloat("Height"), myReader.GetFloat("Weight"), myReader.GetString("ECardNumber"));
                    Patlist.Add(bufpat);
                }
            }
            finally
            {
                connection.Close();
            }
            return Patlist;

        }

        public Current LogInECard(string hexcid)
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
