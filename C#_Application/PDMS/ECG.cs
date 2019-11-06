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
        bool isMenu1PanelOpen = false;

        public ECG()
        {
            InitializeComponent();
        }

        private void ECG_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMenu1PanelOpen)
            {
                panel3.Height -= 20;
                if (panel3.Height == 10)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = false;
                }

            }
            else if (isMenu1PanelOpen)
            {
                panel3.Height += 20;
                if (panel3.Height == 120)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = true;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
