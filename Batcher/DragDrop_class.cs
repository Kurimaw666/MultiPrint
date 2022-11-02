using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using ParaPrint.Properties;

namespace ParaPrint
{
    class DragDrop_class
    {
        public static string getFilePath(string file)
        {

            return Path.GetFullPath(file);
        }
        public static string checkFileExtension(string Ext)
        {
            return Path.GetExtension(Ext);
        }

        public static string getname(string name)
        {
            return Path.GetFileName(name);
        }


        public static TreeView Groupings_view(TreeView viewer,DataGridView table)
        {
            //Get Table

            //Get Groups

            //For Loop to get each Groups

            //Get Printer Name

            foreach (string printer in Settings.Default.ListofPrinter)
            {

            }

                //Get File Names




                return viewer;
        }


        public static void Drag_and_Drop_items(int index,DataGridView table,string name,string format,string filegroup, string Path)
        {
         //#################### ICON ####################
            Image i;
            Image imgformat = null;
            int size=20;
            if (format == ".docx")
            {
                i = Properties.Resources.docx;
                 imgformat = resizeImage(i, new Size(size, size));

            }
           else if (format == ".doc")
            {
                i = Properties.Resources.doc;
                 imgformat = resizeImage(i, new Size(size, size));
            }
            else if (format == ".pdf")
            {
                i = Properties.Resources.pdf;
                imgformat = resizeImage(i, new Size(size, size));
            }


                table.Rows[index].Cells[0].Value = index + 1;
                table.Rows[index].Cells[1].Value = imgformat;
                table.Rows[index].Cells[2].Value = name;
                table.Rows[index].Cells[3].Value = format;
                table.Rows[index].Cells[4].Value = filegroup;
                table.Rows[index].Cells[5].Value = Path;
                table.Rows[index].Cells[6].Value = "0%";

            
            
        }


        public static void Prevent_dup(DataGridView table,string name,string Group)
        {
            while (0 <= table.Rows.Count)
            {

                for (int currentRow = 1; currentRow <= table.Rows.Count - 1; currentRow++)
                {

                    for (int j = 0; j < currentRow; j++)
                    {
                        string selected_name = table.Rows[j].Cells[2].Value.ToString();
                        string selected_Group = table.Rows[j].Cells[4].Value.ToString();

                        if (name == selected_name && selected_Group == Group && currentRow != j)
                        {
                            table.Rows.RemoveAt(j);
                            for (int y = 0; y < table.Rows.Count; y++)
                            {
                                DataGridViewRow UpdateNumbes = table.Rows[y];
                                UpdateNumbes.Cells[0].Value = y + 1;
                              
                            }

                        }
                        
                       
                    }
                }
                break;
            }
        }
        // Resize by  Ish Bandhu  Ish Bandhu Updated date Feb 01, 2021
        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }




    }

}
