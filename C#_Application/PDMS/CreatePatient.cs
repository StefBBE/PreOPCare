using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMS
{
    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }


        private void dateofbirth_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) // only numbers, control and "." is allowed
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.Split('.')).Length > 2) // only  two dots are allowed in date
            {
                e.Handled = true;
            }
            
        }

        

        private void Save_Button_OnClick(object sender, EventArgs e)
        {

             
            try
            {
                string allowed_date_Format ="dd.MM.yyyy"; // see if date is entered correctly
                DateTime dateofbirthstring;

                bool validDate = DateTime.TryParseExact(
                    this.textBox_dateofbirth.Text,
                    allowed_date_Format,
                    DateTimeFormatInfo.InvariantInfo,
                    DateTimeStyles.None,
                    out dateofbirthstring);

                if (!validDate)
                {
                    throw new PDMS_Exception.InvalidDateException();
                }
                 

                bool sex = false;
                if (Patient.malelist.Contains(this.textBox_gender.Text)) { sex = true; }
                // check if gender is male(true) or female (false)
                else if (Patient.femalelist.Contains(this.textBox_gender.Text)) { sex = false; }

                else
                {
                    throw new PDMS_Exception.InvalidGenderException();
                }

                Patient patient = new Patient(0, this.textBox_name.Text, this.textBox_surname.Text, "", "0000031", this.textBox_dateofbirth.Text, sex, 0f, 0f, "0331");
                SQLConnector.SavePatient(patient);
            }

            catch (PDMS_Exception.InvalidGenderException)
            {
                PDMS_Exception.InvalidGenderException.ErrorMessage();
                return;
            }

            catch (PDMS_Exception.InvalidDateException)
            {
                PDMS_Exception.InvalidDateException.ErrorMessage();
                return;
            }







        }
    }
    }
