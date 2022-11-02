using ParaPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaPrint
{
    public partial class PrinterSettings_Dialog : Form
    {
        public PrinterSettings_Dialog()
        {
            InitializeComponent();

            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.AutoScrollMargin = new Size(0, 0);
            flowLayoutPanel1.AutoScroll = true;
            foreach (string name in Settings.Default.ListofGroups)
            {
                Groups_Override_list.Items.Add(name);
                Default_Group_list.Items.Add(name);
            }

        }

        private void PrinterSettings_Dialog_Load(object sender, EventArgs e)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
               destination_CB.Items.Add(printer);
               destination_CB.SelectedIndex = 0;
            }
            layout_CB.SelectedIndex = 0;
            color_CB.SelectedIndex = 0;
            page_CB.SelectedIndex = 0;
            Groups_Override_list.SelectedIndex = 0;
            Default_Group_list.SelectedIndex = 0;
            this.Size = new Size(601, 412);
            panel3.Size = new Size(558, 34);
            Note_Lb.Text = "Note: " +
                          "\nThis settings are Overriding the Settings of all " +
                          "\n documents inside the table Accourding to thier groups.";
            label12.Text = "Note: " + 
                            "\n This settings set a to set printer each group" +
                            "\n Without overriding a Documents inside the table";
            infosettings(update_override, Override_box, Groups_Override_list, treeView1);
            infosettings(Update_default, def_box, Default_Group_list, treeView2);

        }

        private void ChangeValue(object sender, EventArgs e)
        {
            Control parent = page_CB.Parent;

            if (page_CB.SelectedIndex == 1)
            {

                parent.Size = new Size(372, 141);
            }
            else { 

                parent.Size = new Size(372, 106);
            }
        }
      

        private void toggle_click(object sender, EventArgs e)
        {
            if(More_settings_Bt.Tag == null)
            {
                More_settings_Bt.Tag = "selected";
                More_settings_Bt.Text = "▼";
                panel3.Size = new Size(558, 66); 
                this.Size = new Size(601, 490);
                Override_box.Checked = false;
                Override_box.CheckedChanged += (sender2, e2) => override_check(sender2, e2);

                def_box.Checked = false;
                def_box.CheckedChanged += (sender2, e2) => Deaf(sender2, e2);

            }
            else{
                More_settings_Bt.Tag = null;
                More_settings_Bt.Text = "▀";
                panel3.Size = new Size(558,34);
                this.Size = new Size(601 ,412);
            }
        }
       
        #region "MORE_SETTINGS"_settings
       
        List<string> Addednodes = new List<string>();
        

        //============================= Adding new Parameter for Event
        public void infosettings(Button button,CheckBox box, ComboBox groupname,TreeView display)
        {
            button.Click += (sender, e) => setSettings(sender, e, box,groupname,display);

        }



        //================================ The Event

        private void setSettings(object sender, EventArgs e, CheckBox box, ComboBox groupname, TreeView display)
        {
            
            int index = 0;
           
           

            bool added = true;
            
            //Group Name
            string group_name = groupname.Text;

            
                TreeNode node;


                if (group_name.Equals("-") || group_name.Equals(""))
                {
                    group_name = "none";
                }

            if (added)
            {
                node = display.Nodes.Add(group_name);
                Addednodes.Add(group_name);
                node.ForeColor = Color.White;
                node.BackColor = Color.Maroon;
                //Add Sub Node
                

                TreeNode PS = node.Nodes.Add("Print Settings");
                TreeNode Files = node.Nodes.Add("Document Names");
                //Add Sub node in a Subnode
                if (box.AccessibleName.Equals("override"))
                {
                    TreeNode over = PS.Nodes.Add("Override");

                    
                    over.Nodes.Add("Name: " + destination_CB.Text);
                    over.Nodes.Add("Size: " + Size_Cb.Text);
                    over.Nodes.Add("Color: " + color_CB.Text);
                    over.Nodes.Add("Copy: " + Copy_count.Value);
                    over.Nodes.Add("Layout: " + layout_CB.Text);
                }else{
                    TreeNode over = PS.Nodes.Add("Default");
                   
                    over.Nodes.Add("Name: " + destination_CB.Text);
                }
                for (int i = 0; i < 5; i++)
                {
                    Files.Nodes.Add("fileNames: " + i);
                }

                node.ExpandAll();
            }
        }
        #endregion

        #region override_checkbox_settings

        /*
         * This Area is for Overriding Printing Settings
         * 
         */
        private void override_check(object sender, EventArgs e)
        {
            if (Override_box.Checked || Override_box.CheckState.Equals(CheckState.Checked))
            {
                panel6.Visible = true;
                def_box.Visible = false;
                panel3.Size = new Size(558, 528);
                this.Size = new Size(601, 560);
                Override_box.Size = new Size(545, 26);
                Override_box.BackColor =Color.FromArgb(15, 18, 23);
            }
            else
            {
                panel6.Visible = false;
                def_box.Visible = true;
               panel3.Size = new Size(558, 66); 
                this.Size = new Size(601, 460);
                Override_box.BackColor = Color.Transparent;
                Override_box.Size = new Size(240, 17);
            }
        }
        #endregion
        #region default_check_box_settings
        /*
        * This Area is for Settings Printer group
        * 
        */
        private void Deaf(object sender, EventArgs e)
        {
            if (def_box.Checked|| def_box.CheckState.Equals(CheckState.Checked))
            {
                panel7.Visible = true;
                Override_box.Visible = false;
                panel3.Size = new Size(558, 528);
                this.Size = new Size(601, 549);
                def_box.Size = new Size(545, 26);
                def_box.BackColor = Color.FromArgb(15, 18, 23);
            }
            else
            {
                panel7.Visible = false;
                Override_box.Visible = true;
                def_box.Size = new Size(136, 17);
                def_box.BackColor = Color.Transparent;
                panel3.Size = new Size(558, 66);
                this.Size = new Size(601, 430);
            }
        }



        #endregion
    }
}
