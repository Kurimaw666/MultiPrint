using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaPrint
{
    class Functions
    {

        public static void Printfiles(string filepaths, String printer, CheckedListBox check_list)
        {

            PrintDialog pd = new PrintDialog();
            ProcessStartInfo info = new ProcessStartInfo(filepaths);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.Verb = "PrintTo";
            info.Arguments = pd.PrinterSettings.PrinterName = "\"" + printer + "\"";
            info.CreateNoWindow = false;
            Process.Start(info);

        }
 
    }
}
