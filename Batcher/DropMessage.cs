using ParaPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaPrint
{
    public partial class dropMessage : Form
    {
        public dropMessage()
        {
            InitializeComponent();
            dialog_CB_Group_choices.Text = "-";
            manualG_Settings.Checked = Settings.Default.manual_group;
            dialog_CB_Group_choices.Text = Settings.Default.Autofill_group;

        }


    }
}
