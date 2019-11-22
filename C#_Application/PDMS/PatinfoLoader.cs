using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls.Primitives;

namespace PDMS
{
    class PatinfoLoader
    {
        // Current cur;
        bool brk=false;

        public PatinfoLoader(Current cur)
        {


            while (cur.curpatidg() == 0 & !brk)
            {
                /*
                Popup popup = new Popup();
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    Console.WriteLine("You clicked OK");
                }
                else if (dialogresult == DialogResult.Cancel)
                {
                    Console.WriteLine("You clicked either Cancel or X button in the top right corner");
                }
                popup.Dispose();*/
            }



            if (cur.curpatidg()==0)
            {
                //popupwindow
            }
        }

        public void ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            //return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public bool perm()
        {
            if (cur.Hexcid == cur.curpat.Ecardnumber || cur.Role != 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
