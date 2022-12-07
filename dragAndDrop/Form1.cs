using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dragDrop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extension = System.IO.Path.GetExtension(files[0]);

            if (extension == "jpg") { 
                picBoxImage.ImageLocation = files[0];
            }
            else
            {
                picBoxImage.Hide();
                label1.Text = "Extension must be a jpg";
                label1.Text = "Drag and Drop";
            }
            

            string username = Environment.UserName;
            int nProcessors = Environment.ProcessorCount;
            OperatingSystem OS = Environment.OSVersion;
            DateTime now = DateTime.Now;
            System.IO.DriveInfo c = new System.IO.DriveInfo("C");
            long cDiskSpace = c.AvailableFreeSpace / (1024^3);

            label2.Text = "Username: " + username + "\n" + "Processor Count: " + nProcessors.ToString() + "\n" + OS.ToString() + "\n" +
                          "Date: " + now + "\n" + "Disk Space (GB): " + cDiskSpace;
        }

        private void picBoxImage_Click(object sender, EventArgs e)
        {
             
        }
    }
}
