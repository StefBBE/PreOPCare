using System;
using System.Collections.Generic;
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


    }
}
