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
using ParaPrint.Properties;
namespace ParaPrint
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Group_CB.Text = "-";


        }

        private new void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private new void DragDrop(object sender, DragEventArgs e)
        {
            // Variables

            string selectedItem;
            String[] Extentionfiles = { ".docx", ".doc", ".pdf" };
            
           
            dropMessage d = new dropMessage();

            bool Check = false;
            
            //if you check the Manual Group
            if (Settings.Default.manual_group)
            {
                Check = true;
            }
            else
            {
                d.ShowDialog();
            }
            // Dialog Box Show
            if (Check|| d.DialogResult == DialogResult.OK)       
            {
                Settings.Default["manual_group"] = d.manualG_Settings.Checked;
                

                
                Table_empty.Visible = false;
                selectedItem = d.dialog_CB_Group_choices.SelectedItem.ToString();
                Settings.Default["Autofill_group"] = selectedItem;



                //Take droppped items
                string[] dropfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                //loop thur all dropped items
                foreach (string file in dropfiles)
                {
                    //Extension can you want to filter out
                    string path = DragDrop_class.getFilePath(file);
                    string ext_ = DragDrop_class.checkFileExtension(path);
                    string name = DragDrop_class.getname(path);                 
                        foreach (string ext_item in Extentionfiles)
                        {
                            if (ext_ == ext_item)
                            {
                                var index = this.InfoTable.Rows.Add();
                                select_table_LB.Text = "Files: " + (InfoTable.RowCount - 1);
                                DragDrop_class.Drag_and_Drop_items(index, InfoTable, name, ext_, selectedItem, path);
                            }
                        }
                    // Delete Duplicate info
                    if (Settings.Default.Setting_prevent_dup) {
                        DragDrop_class.Prevent_dup(InfoTable, name, selectedItem);
                    }
                   
                }
                Check = false;
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
           
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                names.Add(printer);
                Printer_CB.Items.Add(printer);
                Printer_CB.SelectedIndex = 0;

            } 
                Settings.Default["ListofPrinter"] = names;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Dialog diaglog = new About_Dialog();
            diaglog.ShowDialog();
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_form settingsform = new Settings_form();
            settingsform.Show();
        }

        private void Setup_Printer_bt_Click(object sender, EventArgs e)
        {
           
                PrinterSettings_Dialog printer_Setup = new PrinterSettings_Dialog();
                printer_Setup.ShowDialog();
            

        }

        private void Print_override(object sender, EventArgs e)
        {
            if (override_buttombox.Checked)
            {
                color_CB.SelectedIndex = 0;
                layout_CB.SelectedIndex = 0;
                Size_Cb.SelectedIndex = 0;
                _printOverride_panel.Enabled = true;
            }
            else
            {
                _printOverride_panel.Enabled = false;
            }
        }

        private void Print(object sender, EventArgs e)
        {


            string pname="";
            string gname="";
            bool isoverride=false;
            string path="";
            bool isnotgroup = false;
            List<int> pSettings_data = new List<int>();

            if (InfoTable.Rows.Count > 0) //if their is a row or data in a table
            {
                Debug.WriteLine("RowCount is great than 0 <"+ InfoTable.RowCount);

                if (Group_CB.Text.Equals("-"))
                {
                    isnotgroup = true;
                }
                if (override_buttombox.Checked)
                { //set value in LIST if the check box is checked
                    int copycount = int.Parse(Copy_count.Value.ToString());
                    int[] PrintSettings = {
                        color_CB.SelectedIndex,
                        Size_Cb.SelectedIndex,
                        copycount,
                        layout_CB.SelectedIndex};
                    pSettings_data.AddRange(PrintSettings);
                    Debug.WriteLine("data:"+pSettings_data[0]);
                    printFiles.pSettings_data = pSettings_data;
                    isoverride = override_buttombox.Checked;
                }
                pname = Printer_CB.Text;
                gname = Group_CB.Text;
                //Selected group name in every Rows
                for (int rows = 0; rows < InfoTable.Rows.Count; rows++)
                {
                    string selgroup;
                    selgroup = InfoTable.Rows[rows].Cells[4].Value.ToString();
                    path = InfoTable.Rows[rows].Cells[5].Value.ToString();
                    string file_name = printFiles.fileName = InfoTable.Rows[rows].Cells[2].Value.ToString();
                    if (isnotgroup||selgroup.Equals(gname))
                    {
                        if (isoverride)
                        {   //This thing are under Process
                          PrintDocument pdoc = new PrintDocument();
                            pdoc.DefaultPageSettings.PrinterSettings.PrinterName = pname;
                            pdoc.DefaultPageSettings.Color = printFiles.getcolor();
                            pdoc.DefaultPageSettings.PaperSize = printFiles.getsizes();
                            pdoc.DefaultPageSettings.PrinterSettings.Copies = printFiles.getcopy();
                        }

                        printFiles.print(path, pname);
                    }

                }


            }
            else
            {
                MessageBox.Show("No Files in the table");
                Debug.WriteLine("RowCount is: " + InfoTable.RowCount);
            }

         



            //List<Print_objects_data> pData = new List<Print_objects_data>();

            //pData.Add(new Print_objects_data());
            //pData[0].printername = Printer_CB.Text;
            //pData[0].Groupname = Group_CB.Text;


            //foreach(Print_objects_data data in pData)
            //{
            //    Debug.WriteLine(data.GetName() + "/" + data.getPname());
            //}
        }
    }
   
}
