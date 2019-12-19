﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
namespace PDMS
{
    public partial class SQLConnector
    {
        static string connectionString = "server=127.0.0.1;database=PDMS;uid=root1;pwd=root1;";

        public static int LogIn(string username, string password) //returns integer containing role of the usern trying to og in. 0 means authentication failed
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                
                connection.Open();
                Console.WriteLine("Connection Open!");
                string query = String.Format("SELECT * FROM Users WHERE (Username=\'{0}\' AND Password=\'{1}\');", username, password);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();


                //int role  = Convert.ToInt16(cmd.ExecuteScalar());


                // rdr.Read();
                //int role = Convert.ToInt16(rdr[0]);
                // rdr.Close();
                int role = rdr.GetSByte("Role");
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

               
                string query = String.Format("INSERT INTO PDMS.Patients (Name,Surname,DateOfBirth,SocialSecurity,Sex,Medication,Height,Weight,EcardNumber) VALUES (\'{0}\',\'{1}\',\'{2}\',\'{3}\',{4},\'{5}\',\'{6}\',\'{7}\',\'{8}\')", patient.Name, patient.Surname, patient.Date_of_birth, patient.Socialsecurity, patient.Sex, patient.Medication, patient.Height, patient.Weight,patient.Ecardnumber);
              
                

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());
                throw e;

            }
        }

        public static void SaveUser(User user)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");

                string query = String.Format("INSERT INTO PDMS.users (Name,Surname,Username,Password,EcardNumber,IDCardNumber,Role,Permitted) VALUES (\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\',\'{6}\',{7})", user.Name, user.Surname, user.Username, user.Password, user.Ecardnumber, user.Idcardnumber, user.Role, user.Permitted);
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());
                throw e;

            }
        }

        public static List<string> GetECG_Name(Patient pat)
        {
            
            List<string> names = new List<string>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = String.Format("SELECT Name FROM PDMS.ECG WHERE (PatientID = {0})",pat.PatientID);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    names.Add(myReader.GetString("Name"));
                        
                }
            }
            finally
            {
                connection.Close();
            }


            return names;
        }

        public static string GetFilepath(String Name)
        {
            try
            {
                string filepath;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = String.Format("SELECT Filepath FROM PDMS.ECG WHERE (Name = '{0}')", Name);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                filepath = Convert.ToString(myReader[0]);
                
                connection.Close();
                return filepath;

            }
            catch
            {
                return null;
            }           
            


            
        }

        public static void SaveECG(String filepath)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
           
            try
            {
                connection.Open();
                Console.WriteLine("Connection Open!");

                string query = String.Format("INSERT INTO PDMS.ecg (Name,Filepath,PatientID) VALUES (\'{0}\',\'{1}\',{2})", filepath, filepath, lastID());

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection failed");
                Console.WriteLine(e.ToString());
                throw e;

            }

        }
        public static int lastID()
        {
            try
            {
                int id;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = String.Format("SELECT MAX(PatientID) FROM patients;");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                id = Convert.ToInt32(myReader[0]);

                connection.Close();
                return id;

            }
            catch
            {
                return 0;
            }
        }
        public static int GetIDFromSVN(Patient pat)
        {
            try
            {
                int id;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = String.Format("SELECT PatientID FROM PDMS.patients WHERE (SocialSecurity = '{0}')", pat.Socialsecurity);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                id = Convert.ToInt32(myReader[0]);

                connection.Close();
                return id;

            }
            catch
            {
                return 0;
            }
        }


    }
}
