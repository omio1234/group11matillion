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

namespace WindowsFormsApp1
{
    public partial class frmEncode : Form
    {
        public Image myImage;
        public string fileLocation;
        public frmEncode()
        {
            InitializeComponent();
        }

        private void pnlDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pictureBox1.ImageLocation = files[0];
            myImage = Image.FromFile(files[0]);
            pnlPreviewEncode.Visible = true;
            pnlSendReport.Visible = false;
            pnlPreviewEncode.Dock = DockStyle.Fill;
        }

        private void pnlDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void frmEncode_Load(object sender, EventArgs e)
        {
            pnlSendReport.Dock = DockStyle.Fill;
            pnlSendReport.BringToFront();
            frmDecodeSteg form2 = new frmDecodeSteg();
            form2.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.png) | *.png"; //When selecting, only filters out png files
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(dlg.FileName);
                if (extension == ".png") //Check to make sure the selected image is a png
                {
                    string fileName;
                    fileName = dlg.FileName;
                    pictureBox1.ImageLocation = fileName;
                    myImage = Image.FromFile(fileName);
                    pnlPreviewEncode.Visible = true;
                    pnlSendReport.Visible = false;
                    pnlPreviewEncode.Dock = DockStyle.Fill;
                }
                else
                {
                    MessageBox.Show("Invalid File Type. PNG file Type Only."); //Error message if selected image is not png
                }
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            this.Show();
            pnlPreviewEncode.Visible = true;
            pnlSendReport.Visible = false;
            pnlPreviewEncode.Dock = DockStyle.Fill;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlPreviewEncode.Visible = false;
            pnlSendReport.Visible = true;
            pnlSendReport.Dock = DockStyle.Fill;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(myImage);
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

            String sysInfoOut1 = "Processor Architecture: " + processorArch +
                                "\nProcessor Model: " + processorModel +
                                "\nProcessor Level: " + processorLevel +
                                "\nSystem Directory: " + sysDir +
                                "\nProcessor Count: " + nProcessors.ToString() +
                                "\nUsername: " + username +
                                "\n" + OS.ToString() +
                                "\nDate " + now + "\n";

            Console.WriteLine(sysInfoOut1);
            //RichTextBox1.Text = sysInfoOut;

            for (int i = 0; i < img.Width; i++) 
            {
                for (int j = 0; j < img.Height; j++) 
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < sysInfoOut1.Length)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(sysInfoOut1.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter : " + letter + " value: " + pixel.B);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, sysInfoOut1.Length));
                    }
                }
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png) | *.png;";
            //Edit this
            saveFile.InitialDirectory = @"C:\Users\omioc\Desktop\Demo";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                fileLocation = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = fileLocation;
                img.Save(fileLocation);
            }
            frmDecodeSteg form2 = new frmDecodeSteg();
            form2.Show();
            this.Hide();
        }


    }
}
