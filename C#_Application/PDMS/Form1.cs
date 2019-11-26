using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PDMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //test code
        Current cur = new Current();
        //end test code


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (VerticalMenu.Width == 250)
            {
                VerticalMenu.Width = 70;
            }
            else VerticalMenu.Width = 250;

        }

        private void OpenFormInPanel(Object Formhijo)
        {
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(fh);
            this.ContainerPanel.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new PatientInfo(cur));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new CreatePatient());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new SearchPatient());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new CreateUser());
        }
        private void VerticalMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
  
