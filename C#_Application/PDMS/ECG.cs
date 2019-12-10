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
    public partial class ECG : Form
    {
        
        public ECG()
	{
            
            InitializeComponent();
            Patient testpat = new Patient(1, "blödmann", "asdf", "asdf", "asdf", "asd", true, 3f, 4f, "asdf");
            List<String> names = SQLConnector.GetECG_Name(testpat); //Current.currpat??
            foreach (String name in names)
            {
                this.comboBox1.Items.Add(name);
            }
        }

        

        private void ECG_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string filename = SQLConnector.GetFilepath(this.comboBox1.SelectedItem.ToString());
            string channels = this.textBox_channels.Text;
            int from = Convert.ToInt32(this.textBox_start.Text);
            int to = Convert.ToInt32(this.textBox_end.Text);
            ECGFunc ecg = new ECGFunc(filename,channels,from,to);
            Console.WriteLine(filename + channels + from + to);
            ECGFunc.Display(ecg);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}