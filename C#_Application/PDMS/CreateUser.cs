using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMS
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

      

        private void Save_User_Button(object sender, EventArgs e)
        {
            try
            {
                // name, username, dob, username, password, ecard, idcard, role
                if (this.textBox_name.Text == "" || this.textBox_surname.Text == "")
                {
                    throw new PDMS_Exception.NoNameException();
                }

                if (!PDMS_Exception.ValidateDate(this.textBox_dateofbirth)) // is date entered correctly
                {
                    throw new PDMS_Exception.InvalidDateException();
                }

                if (this.textBox_username.Text == "" || this.textBox_password.Text == "")
                {
                    throw new PDMS_Exception.NoCredentialsException();
                }


                string ecardnumber = this.textBox_ecardnumber.Text; // check if 20 chars long
                if (ecardnumber.Length != 20)
                {
                    throw new PDMS_Exception.InvalidEcardFormatException();
                }

                string idcardnumber = this.textBox_idcardnumber.Text; //check if in right format
                if (idcardnumber.Length != 10)
                {
                    throw new PDMS_Exception.InvalidIdCardFormatException();
                }


                // check if 0-3/4
                int role = 0;
                if (this.textBox_role.Text != "1" && this.textBox_role.Text != "2" && this.textBox_role.Text != "3" && this.textBox_role.Text != "4") // maybe implement a dictionary? 
                {
                    throw new PDMS_Exception.InvalidRoleException();
                }
                else { role = Convert.ToInt16(this.textBox_role.Text); }





                User user = new User(0, role, this.textBox_name.Text, this.textBox_surname.Text, this.textBox_username.Text, this.textBox_password.Text, ecardnumber, idcardnumber, true);
                SQLConnector.SaveUser(user);
                MessageBox.Show("User Saved!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            catch (PDMS_Exception.InvalidIdCardFormatException)
            {
                PDMS_Exception.InvalidIdCardFormatException.ErrorMessage();
                return;
            }
            catch (PDMS_Exception.NoNameException)
            {
                PDMS_Exception.NoNameException.ErrorMessage();
                return;
            }
            catch (PDMS_Exception.InvalidRoleException)
            {
                PDMS_Exception.InvalidRoleException.ErrorMessage();
                return;
            }
            catch (PDMS_Exception.NoCredentialsException)
            {
                PDMS_Exception.NoCredentialsException.ErrorMessage();
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
    }
}
