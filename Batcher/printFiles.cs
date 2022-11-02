using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaPrint
{
    class printFiles
    {

        public static string fileName;
        public static List<int> pSettings_data;

        public static bool getcolor(){
            int c = pSettings_data[0];
            bool result = false;

            if (c.Equals(0))
            {
                result = true;
            }
            return result;
        }

        public static PaperSize getsizes()
        {
            PaperSize s=null;
            int selected_item = pSettings_data[1];
            switch (selected_item)
            {
                case 0:
                    s = new PaperSize("", 210, 297);
                    break;
                case 1:
                    s = new PaperSize("", 216,279);
                    break;
                case 2:
                    s = new PaperSize("", 216,356);
                    break;
                case 3:
                    s = new PaperSize("", 216, 330);
                    break;
            }
            return s;
        }
        public static short getcopy()
        {
            int c = pSettings_data[2];
            short i = short.Parse(c.ToString());
            return i;
        }
        public static bool getlayout()
        {
            int c = pSettings_data[3];
            bool result = false;

            if (c.Equals(0))
            {
                result = true;
            }
            return result;
        }


        public static void print(string path , string Pname)
        {

            PrintDialog pd = new PrintDialog();


            ProcessStartInfo info = new ProcessStartInfo(path);
            info.Verb = "PrintTo";
            info.UseShellExecute = true;
            info.CreateNoWindow = true;
            //info.Arguments = pd.PrinterSettings.PrinterName = "\"" + Pname + "\"";
            info.Arguments = pd.PrinterSettings.PrinterName = string.Format("\"{0}\"", Pname);
            info.CreateNoWindow = false;
            Process.Start(info);
            
        }
    }
}
