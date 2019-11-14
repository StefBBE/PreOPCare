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
        public PatientInfo()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPatientInfo(new ECG());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
