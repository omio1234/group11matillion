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

            string username = Environment.UserName;
            int nProcessors = Environment.ProcessorCount;
            OperatingSystem OS = Environment.OSVersion;
            DateTime now = DateTime.Now;
            Double pc = (dInfo.AvailableFreeSpace / (float)dInfo.TotalSize) * 100;

            String sysInfoOut = "Username: " + username + "\n" + "Processor Count: " + nProcessors.ToString() + "\n" + OS.ToString() + "\n" +
            "Date " + now + "\n" + "Disk Free Space = " + dInfo.AvailableFreeSpace + " (" + pc.ToString("0.00") + "%)";

            label2.Text = sysInfoOut;

        }

        private void picBoxImage_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
