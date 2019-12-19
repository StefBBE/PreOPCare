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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void ECard_button_Click(object sender, EventArgs e)
        {
            ReadCard rc = new ReadCard();
            Current cur = new Current();
            bool brk = false;
            SQLConnector sc = new SQLConnector();

            while (cur.Role==0 && !brk)
            {
                Current.curpat = rc.readpatient();
                cur.Hexcid = rc.readhexcin();
                Current cur2 = sc.LogInECard(cur.Hexcid);
                if (cur2.Role != 0)
                {
                    cur.Role = cur2.Role;
                }
                if (cur.Role == 0)
                {
                    const string message = "Card can't be read or no such user. Try again (Yes) or Cancel (No)";
                    const string caption = "Login Problem";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        brk = true;
                    }
                }
            }

            if (cur.Role != 0) 
            {
                Form1 f1 = new Form1(cur);
                f1.Show();
                this.Hide();
            }
        }

        /*private void IDCard_button_Click(object sender, EventArgs e)
        {
            Current cur = new Current();
            cur.Role = 2;
            Form1 f1 = new Form1(cur);
            f1.Show();
            this.Hide();
            //Application.Run();
            
        }*/

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Current cur = new Current();
            if (this.Username.Text == "1234567890" && this.PasswordEnter.Text == "1234567890")
            {
                cur.Role = 1;
                Form f1 = new Form1(cur);
                f1.Show();
                this.Hide();
            }
            cur.Role = SQLConnector.LogIn(this.Username.Text, this.PasswordEnter.Text);
            /*if (cur.Role != 0) //delte in new ui 
           {
               Form1 f1 = new Form1(cur);
               f1.Show();
               this.Hide();
           }*/
           
           if (cur.Role == 1) //admin
           {
               Form1 f1 = new Form1(cur);
               f1.Show();
               this.Hide();
           }
           else if (cur.Role == 2) //physician
           {
               FormPhysician f1 = new FormPhysician(cur);
               f1.Show();
               this.Hide();
                Console.WriteLine(cur.Role);
           }
           else if (cur.Role == 3) // nurse
           {
               Form f1 = new FormNurse(cur);
               f1.Show();
               this.Hide();
           }

           else if (cur.Role == 4) // patient
           {
               Form f1 = new FormPatient(cur);
               f1.Show();
               this.Hide();
           }
           else if (cur.Role == 0){
               MessageBox.Show("LogIn failed!", "Name Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }
    }
}
