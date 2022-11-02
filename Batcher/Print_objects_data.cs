using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPrint
{
    class Print_objects_data
    {
        public string printername;
        public string Groupname;

        public string GetName()
        {
            if (Groupname.Equals("-"))
            {
                Groupname = "none";
            }
            return this.Groupname;
        }
        public string getPname()
        {
            return this.printername;
        }


    }
}
