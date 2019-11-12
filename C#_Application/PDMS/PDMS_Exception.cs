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
