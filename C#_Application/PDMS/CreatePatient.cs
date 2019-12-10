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
                // check for empty field!!
                if (this.textBox_name.Text == "" || this.textBox_surname.Text == "")
                {
                    throw new PDMS_Exception.NoNameException();
                }

                if (!PDMS_Exception.ValidateDate(this.textBox_dateofbirth)) // is date entered correctly
                {
                    throw new PDMS_Exception.InvalidDateException();
                }

                // check if gender is male(true) or female (false)
                bool sex = false;
                if (Patient.malelist.Contains(this.textBox_gender.Text)) { sex = true; }
                else if (Patient.femalelist.Contains(this.textBox_gender.Text)) { sex = false; }
                else { throw new PDMS_Exception.InvalidGenderException(); }
                

                if (textBox_socialsecum.Text.Length != 10)
                {
                    throw new PDMS_Exception.InvalidIdSocialSecurity();
                }
                if (textBox_ecardnumber.Text.Length != 20)
                {
                    throw new PDMS_Exception.InvalidEcardFormatException();
                }

                // add exceptions for heigth and weight!!
                // add exceptions for heigth and weight!!
                // add exceptions for heigth and weight!!
                float weight = Convert.ToSingle(this.textBox_weight.Text);
                float height = Convert.ToSingle(this.textBox_height.Text);


                HexConverter hc = new HexConverter();
                string hmycin = hc.converter(textBox_ecardnumber.Text);
                string social = this.textBox_socialsecum.Text;
                Patient patient = new Patient(0, this.textBox_name.Text, this.textBox_surname.Text, "", social, this.textBox_dateofbirth.Text, sex, height, weight, hmycin);
                SQLConnector.SavePatient(patient);
                MessageBox.Show("Patient Saved!", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            catch (PDMS_Exception.InvalidEcardFormatException)
            {
                PDMS_Exception.InvalidEcardFormatException.ErrorMessage();
                return;
            }
            catch (PDMS_Exception.InvalidIdSocialSecurity)
            {
                PDMS_Exception.InvalidIdSocialSecurity.ErrorMessage();
                return;
            }

            catch (PDMS_Exception.NoNameException)
            {
                PDMS_Exception.NoNameException.ErrorMessage();
                return;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                //show custom message?
                /*
                if (ex.Message.StartsWith("Duplicate"))
                {
                    MessageBox.Show("Entry already exists in database!", "SQL Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                //sql message
                MessageBox.Show(ex.Message, "SQL Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Current cur = new Current();
            ReadCard rc = new ReadCard();
            Current.curpat = rc.readpatient();
            textBox_name.Text = Current.curpat.Name;
            textBox_name.ForeColor = System.Drawing.Color.Black;
            textBox_name.ReadOnly = true;
            textBox_surname.Text = Current.curpat.Surname;
            textBox_dateofbirth.Text = Current.curpat.Date_of_birth;
            textBox_gender.Text = cur.curpatsexg();
            textBox_medication.Text = Current.curpat.Medication;
            textBox_socialsecum.Text = Current.curpat.Socialsecurity;
            textBox_height.Text = Convert.ToString(Current.curpat.Height);
            textBox_weight.Text = Convert.ToString(Current.curpat.Weight);
            textBox_ecardnumber.Text = Convert.ToString(Current.curpat.Ecardnumber);
        }
    }
    }
