﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    public class Current
    {
        private static int role;
        public static Patient curpat = new Patient();
        private static string hexcid;
        
        public Current()
        {
            /*curpat.PatientID = 0;
            curpat.Name = "no Patient";
            curpat.Surname = "loaded";
            curpat.Date_of_birth = "empty pat obj was created right now";
            curpat.Socialsecurity = "no social security";
            curpat.Sex = true;
            curpat.Medication = "No meds";
            curpat.Weight = 1;
            curpat.Height = 1;
            role = 0;*/
        }

        public int Role { get => role; set => role = value; }
        public string Hexcid { get => hexcid; set => hexcid = value; }
        public void curpatids (int i) { curpat.PatientID = i; }
        public void curpatnames(string i) { curpat.Name = i; }
        public void curpatsurnames(string i) { curpat.Surname = i; }
        public void curpatsocials(string i) { curpat.Socialsecurity = i; }
        public void curpatdobs(string i) { curpat.Date_of_birth = i; }
        public void curpatsexs(bool i) { curpat.Sex = i; }
        public void curpatheis(float i) { curpat.Height = i; }
        public void curpatweis(float i) { curpat.Weight = i; }
        public void curpatcids(string i) { curpat.Ecardnumber = i; }


        public int curpatidg() { return curpat.PatientID; }
        public string curpatnameg() { return curpat.Name; }
        public string curpatsurnameg() {return curpat.Surname; }
        public string curpatsocialg() { return curpat.Socialsecurity; }
        public string curpatdobg() {return curpat.Date_of_birth; }
        public string curpatsexg() 
            { 
            if (curpat.Sex) 
            {return "m"; }
            else 
            { return "f"; }
            }
        public float curpatheig() { return curpat.Height; }
        public float curpatweig() { return curpat.Weight; }
        public string curpatcidg() { return curpat.Ecardnumber; }

        public bool usersamepatient()
        {
            if (hexcid==curpatcidg())
            {
                return true;
            }
            else
            {
                return false; 
            }

        }

    }
}
