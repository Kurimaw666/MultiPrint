using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParaPrint.Properties;

namespace ParaPrint
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            table_set_manualG.Checked = Settings.Default.manual_group;
            table_set_prevent_dup.Checked = Settings.Default.Setting_prevent_dup;
            Table_Set_autofill_g.Text = Settings.Default.Autofill_group;
           
        }

        public void sel(Panel pan,RadioButton button)
        {
            string name = button.AccessibleName;
            button.CheckedChanged += ( sender,  e) => Toggle(sender, e, pan, name);
        }

        private void Toggle(object sender, EventArgs e,Panel containers,string name)
        {

            if (((RadioButton)sender).Checked)
            {
                ((RadioButton)sender).Text = "▼ " + name;
                containers.Visible = true;
            }
            else
            {
                ((RadioButton)sender).Text = "▀ " + name;
                containers.Visible = false;
            }

        }
        

        private void savePreference(object sender, EventArgs e)
        {

            Settings.Default["Autofill_group"] = Table_Set_autofill_g.Text;
            Settings.Default["manual_group"] = table_set_manualG.Checked;
            Settings.Default["Setting_prevent_dup"] = table_set_prevent_dup.Checked;
            Debug.WriteLine(Settings.Default.Autofill_group + " / " + Settings.Default.manual_group+" / "+Settings.Default.Setting_prevent_dup);
            Settings.Default.Save();

        }

        private void Settings_form_Load(object sender, EventArgs e)
        {
            sel(TableSettings_panel, Table_settings_menu_bt);
            sel(PrintSettings_panel, Print_settings_menu_bt);
            
        }
    }
}
