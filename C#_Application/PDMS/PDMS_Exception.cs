using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMS
{
    public class PDMS_Exception : Exception
    {

      

        public class InvalidGenderException : PDMS_Exception
        {
            
            public InvalidGenderException()
            {
                
            }

            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid gender entered", "Gender Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class InvalidDateException : PDMS_Exception
        {
            public InvalidDateException()
            {
            }

            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid Date entered", "Date Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class NoNameException : PDMS_Exception
        {
            public NoNameException()
            {
            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Please Enter the full name", "Name Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class InvalidWeightException : PDMS_Exception
        {
            public InvalidWeightException()
            {
            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Please Enter a correct weight", "Weight Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class InvalidHeightException : PDMS_Exception
        {
            public InvalidHeightException()
            {
            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Please Enter a correct height", "Height Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public class NoCredentialsException : PDMS_Exception
        {
            public NoCredentialsException()
            {
            }

            public static void ErrorMessage()
            {
                MessageBox.Show("Please Enter full credentials. Username of password missing!", "Credentials Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class InvalidEcardFormatException : PDMS_Exception
        {
            public InvalidEcardFormatException()
            {

            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid Ecard-Number Format. Ecard-Number has 20 digits!", "Ecard Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class InvalidIdCardFormatException : PDMS_Exception
        {
            public InvalidIdCardFormatException()
            {
               
            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid IDcard-Number Format. IDcard-Number has 10 digits!", "IDcard Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class InvalidIdSocialSecurity : PDMS_Exception
        {
            public InvalidIdSocialSecurity()
            {

            }
            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid Social Security Number Format. Number has 10 digits!", "Social security Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class InvalidRoleException : PDMS_Exception
        {
            public InvalidRoleException()
            {
            }

            public static void ErrorMessage()
            {
                MessageBox.Show("Invalid Role. Possible Roles: Admin(1),Physician(2),Nurse(3), Patient(4)", "Role Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool ValidateDate (TextBox textbox)
        {
            string allowed_date_Format = "dd.MM.yyyy"; // see if date is entered correctly
            DateTime dateofbirthstring;

            bool validDate = DateTime.TryParseExact(
               textbox.Text,
                allowed_date_Format,
                DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None,
                out dateofbirthstring);
            return validDate;
        }


    }
}
