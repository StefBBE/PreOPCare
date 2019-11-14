using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
namespace PDMS
{
    public class ECGFunc
    {


      string ecgfile; // variable holding path to ecgfile
        int sampfrom, sampto; //variables giving details on what channels to display, and  from where to where to display
        string[] channels;

        public int Sampfrom

        {
            get { return sampfrom; }
            set
            {
                if (value > 0)
                {
                    sampfrom = value;
                }
                else { throw new System.ArgumentOutOfRangeException(); }
            }
        }

        public int Sampto
        {
            get { return sampto; }
            set
            {
                if (value > 0)
                {
                    sampto = value;
                }
                else { throw new System.ArgumentOutOfRangeException(); }
            }
        }




        public ECGFunc() // empty constructor
        {

        }
        public ECGFunc(string ecgfile, string[] channels, int sampfrom, int sampto) //constructor 
        {

            this.ecgfile = ecgfile;
            this.channels = channels;
            this.sampfrom = Sampfrom;
            this.sampto = Sampto;

        }





        public static void Display(ECGFunc ecg)
        {

            try
            {
                string fileName = "/Library/Frameworks/Python.framework/Versions/3.7/bin/wfdbscript.py";
                string arguments = string.Format("{0} {1} {2} {3}", ecg.ecgfile, String.Join(",", ecg.channels), ecg.sampfrom, ecg.sampto); // arguments to pass to the pythonscript
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo(fileName, arguments); //starting the pythonscript and handing over arguments 
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
            }
            catch (ArgumentOutOfRangeException e)
            {
                //What to do now?
                //set values  to zero? abort?
            }


        }

    }
}

