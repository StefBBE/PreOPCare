using System;
namespace PDMS
{
    public class Patient
    {
        int patientID;
        string name, surname, medication, socialsecurity,date_of_birth,ecardnumber;
        bool sex;
        float height, weight;



        public Patient()
        {
        }

        public Patient(int patientID, string name, string surname, string medication, string socialsecurity, string date_of_birth, bool sex, float height, float weight, string ecardnumber)
        {
            PatientID = patientID;
            Name = name;
            Surname = surname;
            Medication = medication;
            Socialsecurity = socialsecurity;
            Date_of_birth = date_of_birth;
            Sex = sex;
            Height = height;
            Weight = weight;
            PatientID = patientID;
            Sex = sex;
            Height = height;
            Weight = weight;
            Name = name;
            Surname = surname;
            Medication = medication;
            Socialsecurity = socialsecurity;
            Date_of_birth = date_of_birth;
            Ecardnumber = ecardnumber;
        }

        public int PatientID { get => patientID; set => patientID = value; }
        public bool Sex { get => sex; set => sex = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Medication { get => medication; set => medication = value; }
        public string Socialsecurity { get => socialsecurity; set => socialsecurity = value; }
        public string Date_of_birth { get => date_of_birth; set => date_of_birth = value; }
        public string Ecardnumber { get => ecardnumber; set => ecardnumber = value; }
    }
}
