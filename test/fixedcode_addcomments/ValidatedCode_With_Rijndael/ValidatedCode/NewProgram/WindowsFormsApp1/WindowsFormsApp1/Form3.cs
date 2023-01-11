using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using static System.Console;

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
            string message = "";
            pictureBox1.ImageLocation = files[0];
            pnlDecryptResult.Visible = true;
            pnlDecoder.Visible = false;
            pnlDecryptResult.Dock = DockStyle.Fill;

            Bitmap img = new Bitmap(pictureBox1.ImageLocation.ToString());
            Protection protection = new Protection();

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

            try
            {
                using (Rijndael r = Rijndael.Create())
                {
                    string encodeText = message;

                    byte[] encoded = protection.Encrypt(encodeText, r.Key, r.IV);
                    string eText = "";

                    foreach (var b in encoded)
                    {
                        eText += b.ToString() + ", ";
                    }

                    rtbDecrypt.Text = "Encoded:\n" + eText;
                    string decoded = protection.Decrypt(encoded, r.Key, r.IV);
                    rtbDecrypt.Text += "Decoded:\n" + decoded;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: ", err.Message);
            }
            // rtbDecrypt.Text = message;
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
            Protection protection = new Protection();

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

            try
            {
                using (Rijndael r = Rijndael.Create())
                {
                    string encodeText = message;

                    byte[] encoded = protection.Encrypt(encodeText, r.Key, r.IV);
                    string eText = "";

                    foreach (var b in encoded)
                    {
                        eText += b.ToString() + ", ";
                    }

                    rtbDecrypt.Text = "Encoded:\n" + eText;
                    string decoded = protection.Decrypt(encoded, r.Key, r.IV);
                    rtbDecrypt.Text += "Decoded:\n" + decoded;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: ", err.Message);
            }
           // rtbDecrypt.Text = message;
            
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

        class Protection
        {
            public byte[] Encrypt(string Text, byte[] Key, byte[] IV)
            {
                if (Text == null || Text.Length <= 0) throw new ArgumentNullException("Text");
                if (Key == null || Text.Length <= 0) throw new ArgumentNullException("Key");
                if (IV == null || Text.Length <= 0) throw new ArgumentNullException("IV");

                byte[] eData;

                // New instance of the Rijndael class
                // Generates a new Key and IV initialisation vector
                using (Rijndael r = Rijndael.Create())
                {
                    r.Key = Key;
                    r.IV = IV;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, r.CreateEncryptor(r.Key, r.IV), CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(Text);
                            }

                            eData = ms.ToArray();
                        }
                    }
                }
                // Returned the encrypted bytes from the memory stream
                return eData;
            }

            public string Decrypt(byte[] cText, byte[] Key, byte[] IV)
            {
                if (cText == null || cText.Length <= 0) throw new ArgumentNullException("cText");
                if (Key == null || Key.Length <= 0) throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

                string dData;

                using (Rijndael r = Rijndael.Create())
                {
                    r.Key = Key;
                    r.IV = IV;

                    using (MemoryStream ms = new MemoryStream(cText))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, r.CreateDecryptor(r.Key, r.IV), CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                // Read the decrypted bytes and palce them in a string
                                dData = sr.ReadToEnd();
                            }
                        }
                    }
                }
                return dData;
            }
        }
    }
}
