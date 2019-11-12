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
    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        
        private void Save_Button_OnClick(object sender, EventArgs e)
        {
            /* implement when more fields of the UI are ready
         * 
            bool sex = false;
            if (Patient.malelist.Contains(this.textBox_gender.Text)) {sex = true; }
            // check if gender is male(true) or female (false)
            else if (Patient.femalelist.Contains(this.textBox_gender.Text)) { sex = false;}
  
            else{// throw some kind of exception
            return; }

            Patient patient = new Patient(0,this.textBox_name.Text,this.textBox_surname.Text,"","0000031",this.textBox_dateofbirth.Text,sex, 0f,0f,"0331");
            SQLConnector.SavePatient(patient);
            */
        }
    }
    }
