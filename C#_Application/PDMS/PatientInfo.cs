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
    public partial class PatientInfo : Form
    {
        ReadCard rc = new ReadCard();

        public PatientInfo(Current cur)
        {
            //test code
            //this.cur = cur;
            //while (cur.curpatnameg() == "no Patient")
            //{
            bool brk = false;
            while ((cur.curpatnameg() == "no Patient"|| cur.curpatnameg() == "") && !brk) 
            {
                cur.curpat = rc.readpatient();
                if (cur.curpatnameg() == "no Patient" || cur.curpatnameg() == "")
                {
                    const string message ="Card can't be read. Try again (Yes) or Cancel (No)";
                    const string caption = "Ecard Problem";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        brk=true;
                    }
                }
            }
            
          
            
            //}
            //end test code

            InitializeComponent();
            textBox1.Text = cur.curpat.Name;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox1.ReadOnly = true;
            textBox7.Text = cur.curpat.Surname;
            textBox7.ForeColor = System.Drawing.Color.Black;
            textBox7.ReadOnly = true;
            textBox11.Text = cur.curpat.Date_of_birth;
            textBox11.ForeColor = System.Drawing.Color.Black;
            textBox11.ReadOnly = true;
            textBox10.Text = cur.curpat.Socialsecurity;
            textBox10.ForeColor = System.Drawing.Color.Black;
            textBox10.ReadOnly = true;
            textBox6.Text = cur.curpatsexg();
            textBox6.ForeColor = System.Drawing.Color.Black;
            textBox6.ReadOnly = true;
            textBox9.Text = cur.curpat.Medication;
            textBox9.ForeColor = System.Drawing.Color.Black;
            textBox9.ReadOnly = true;
            textBox3.Text = cur.curpat.Height.ToString("R");
            textBox3.ForeColor = System.Drawing.Color.Black;
            textBox3.ReadOnly = true;
            textBox2.Text = cur.curpat.Weight.ToString("R");
            textBox2.ForeColor = System.Drawing.Color.Black;
            textBox2.ReadOnly = true;

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void OpenFormInPatientInfo(Object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ECG_Display_OnClick(object sender, EventArgs e)
        {
            
            // ECG fenster �ffnen?

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
