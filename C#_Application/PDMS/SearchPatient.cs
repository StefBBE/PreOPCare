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
    public partial class SearchPatient : Form
    {
        List<Patient> patlist = new List<Patient>();
        Current cur = new Current();
        public SearchPatient(Current cur)
        {
            InitializeComponent();
            this.cur = cur;
        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            SQLConnector sq = new SQLConnector();
            String str = txt_search.Text;
            String[] spearator = { " " };
            int count = 2;
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);
            if (strlist.Length == 2)
            {
                patlist = sq.searchpatient(strlist[0], strlist[1]);
                List<string> Liste = new List<string>();
                foreach (Patient pat in patlist)
                {
                    Liste.Add(String.Format("{0} {1}, {2}", pat.Name, pat.Surname, pat.Date_of_birth));
                }
                object[] array = Liste.ToArray<object>();
                this.listBox1.Items.AddRange(array);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter Prename and Surname, seperated by a whitespace");
            }
        }

        private void loadpatbut_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem!=null)
            {
                String str = listBox1.SelectedItem.ToString();
                String[] spearator = { " ",", " };
                int count = 3;
                String[] strlist = str.Split(spearator, count,
                       StringSplitOptions.RemoveEmptyEntries);
                foreach (Patient pat in patlist)
                {

                    /*string message = strlist[1];
                    string caption = strlist[0];
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);*/
                    if (pat.Name==strlist[0] && pat.Surname ==strlist[1] && pat.Date_of_birth == strlist[2])
                    {
                        Current.curpat = pat;
                        MessageBox.Show("Patient loaded");
                        Current.patinfo = true;
                    }
                }
            }
            
        }
        
    }
}
