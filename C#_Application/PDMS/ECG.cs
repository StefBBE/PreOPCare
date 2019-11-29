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
        }

        

        private void ECG_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filename = "s0010_re";
            string channels = this.textBox_channels.Text;
            int from = Convert.ToInt32(this.textBox_start.Text);
            int to = Convert.ToInt32(this.textBox_end.Text);
            ECGFunc ecg = new ECGFunc(filename,channels,from,to);
            ECGFunc.Display(ecg);
        }
    }
}