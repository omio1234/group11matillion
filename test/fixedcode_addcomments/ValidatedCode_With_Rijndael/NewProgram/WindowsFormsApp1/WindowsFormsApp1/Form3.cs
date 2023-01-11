using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDecodeSteg : Form
    {
        public Image myImage;
        public frmDecodeSteg()
        {
            InitializeComponent();
        }

        private void pnlDragDropDeEncode_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            pictureBox1.ImageLocation = files[0];
            pnlDecryptResult.Visible = true;
            pnlDecoder.Visible = false;
            pnlDecryptResult.Dock = DockStyle.Fill;
        }

        private void pnlDragDropDeEncode_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string message = "";
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
                    pnlDecryptResult.Visible = true;
                    pnlDecoder.Visible = false;
                    pnlDecryptResult.Dock = DockStyle.Fill;
                }
                else
                {
                    MessageBox.Show("Invalid File Type. PNG file Type Only."); //Error message if selected image is not png
                }
            }
            Bitmap img = new Bitmap(pictureBox1.ImageLocation.ToString());

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        message += letter;
                    }
                }
            }
            if (message.StartsWith("?"))
            {
                message = "";
                message = "Image is not encrypted";
            }
            rtbDecrypt.Text = message;
            
        }

        private void frmDecodeSteg_Load(object sender, EventArgs e)
        {
            pnlDecoder.Dock = DockStyle.Fill;
            pnlDecoder.BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlDecryptResult.Visible = false;
            pnlDecoder.Visible = true;
            pnlDecoder.Dock = DockStyle.Fill;
        }
    }
}
