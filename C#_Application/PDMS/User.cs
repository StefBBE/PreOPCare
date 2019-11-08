using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    public class User
    {
        int userID, role;
        string name, surname, username, password, ecardnumber, idcardnumber;
        bool permitted;

        public User()
        {
        }

        public User(int userID, int role, string name, string surname, string username, string password, string ecardnumber, string idcardnumber, bool permitted)
        {
            UserID = userID;
            Role = role;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Ecardnumber = ecardnumber;
            Idcardnumber = idcardnumber;
            Permitted = permitted;

        }


        public int UserID { get => userID; set => userID = value; }
        public int Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Ecardnumber { get => ecardnumber; set => ecardnumber = value; }
        public string Idcardnumber { get => idcardnumber; set => idcardnumber = value; }
        public bool Permitted { get => permitted; set => permitted = value; }
    }
}
