using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    public class Current
    {
        private int role;
        public Patient curpat = new Patient();
        private int hexcid;

        public int Role { get => role; set => role = value; }
        public int Hexcid { get => hexcid; set => hexcid = value; }
        public void curpatid (int i) { curpat.PatientID = i; }
        public void curpatname(string i) { curpat.Name = i; }
        public void curpatsurname(string i) { curpat.Surname = i; }
        public void curpatsocial(string i) { curpat.Socialsecurity = i; }
        public void curpatdob(string i) { curpat.Date_of_birth = i; }
        public void curpatsex(bool i) { curpat.Sex = i; }
        public void curpathei(float i) { curpat.Height = i; }
        public void curpatwei(float i) { curpat.Weight = i; }

    }
}
