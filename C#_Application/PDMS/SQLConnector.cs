﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace PDMS
{
    public partial class SQLConnector
    {
        static string connectionString = "server=127.0.0.1;database=PDMS;uid=root1;pwd=root1;";

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

        public static void SavePatient(Patient patient)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");
                string query = String.Format("INSERT INTO PDMS.Patients (Name,Surname,DateOfBirth,SocialSecurity,Sex,Medication,Height,Weight,EcardNumber) VALUES (\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\',\'{6}\',\'{7}\',\'{8}\')", patient.Name, patient.Surname, patient.Date_of_birth, patient.Socialsecurity, patient.Sex, patient.Medication, patient.Height, patient.Weight,patient.Ecardnumber);
                //string query = "INSERT INTO PDMS.Patients (Name,Surname,DateOfBirth,SocialSecurity,Sex,Medication) VALUES ('Hans','Patientenberger','1994-08-08','4916080894',1,'There is some medication recommended for this Patient:, Warfarin,Aspirin')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());

            }
        }

        public static void SaveUser(User user)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");

                string query = String.Format("INSERT INTO PDMS.users (Name,Surname,Username,Password,EcardNumber,IDCardNumber,Role,Permitted) VALUES (\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\',\'{6}\',\'{7}\')", user.Name, user.Surname, user.Username, user.Password, user.Ecardnumber, user.Idcardnumber, user.Role, user.Permitted);
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());

            }
        }


    }
}
