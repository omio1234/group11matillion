using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            picBoxImage.ImageLocation = files[0];
            DriveInfo dInfo = new DriveInfo("C");

            OperatingSystem OS = Environment.OSVersion;
            string processorArch = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            string processorModel = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            string processorLevel = Environment.GetEnvironmentVariable("PROCESSOR_LEVEL");
            string sysDir = Environment.SystemDirectory;
            int nProcessors = Environment.ProcessorCount;
            string userDomName = Environment.UserDomainName;
            string username = Environment.UserName;
            DateTime now = DateTime.Now;
            //Double pc = (dInfo.AvailableFreeSpace / (float)dInfo.TotalSize) * 100;

            String sysInfoOut = "Processor Architecture: " + processorArch +
                                "\nProcessor Model: " + processorModel +
                                "\nProcessor Level: " + processorLevel +
                                "\nSystem Directory: " + sysDir +
                                "\nProcessor Count: " + nProcessors.ToString() +
                                "\nUser Domain Name : " + userDomName +
                                "\nUsername: " + username +
                                "\n" + OS.ToString() +
                                "\nDate " + now + "\n" +
                                "\nLogical Drives = \n";

            foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
            {
                try
                {
                    sysInfoOut += "\nDrive: " + DriveInfo1.Name +
                        "\nVolume Label: " + DriveInfo1.VolumeLabel +
                        "\nDrive Type: " + DriveInfo1.DriveType +
                        "\nDrive Format: " + DriveInfo1.DriveFormat +
                        "\nTotal Size: " + DriveInfo1.TotalSize +
                        "\nAvailable Free Space: " + DriveInfo1.AvailableFreeSpace + "\n";

                }
                catch
                {
                }
            }

            RichTextBox1.Text = sysInfoOut;


        }

        private void picBoxImage_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
