using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Collections;

namespace SteganografiaTestModificaPixel
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        public void loadImage()
        {
            
        }

        private void imageSelectionBTN_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.InitialDirectory = @"C:\Downloads";
            openFileDialog.Filter = "PNG (*.PNG)|*.PNG|JPG (*.JPG)|*.JPG";
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                CurrentImage.ImageLocation = openFileDialog.FileName;
                bitmap = new Bitmap(openFileDialog.FileName);
            }
        }

        private void hideTextBTN_Clicked(object sender, EventArgs e)
        {
            String text = TextToHide.Text;

            // Convert the message to a byte array
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(text);

            // Loop through the pixels in the image
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    // Get the pixel at the current position
                    Color pixel = bitmap.GetPixel(i, j);

                    // Change the least significant bit of the pixel's red value
                    // to the next bit in the message
                    int newRedValue = pixel.R;
                    newRedValue = (newRedValue & ~(1 << 7)) | ((messageBytes[i] & 1) << 7); // MSB
                    //newRedValue = (newRedValue & ~1) | (messageBytes[i] & 1); // LSB
                    Color newPixel = Color.FromArgb(newRedValue, pixel.G, pixel.B);
                    bitmap.SetPixel(j, i, newPixel);

                    // Shift the message bytes to the right by 1 bit
                    //messageBytes = messageBytes.Select(x => x >> 1).ToArray();
                }
            }

            // update open
            /*byte[] txtBytes = System.Text.Encoding.UTF8.GetBytes(text); // create array with ascii code of every letter in String
            //BitArray bitArray = new BitArray(txtBytes);
            String binaryText = "";
            for (int i=0; i<txtBytes.Length; i++)
            {
                binaryText += Convert.ToString(txtBytes[i], 2).PadLeft(8, '0');
            }

            Color px;
            int x = 0;
            int y = 0;

            for (int i=0; i < binaryText.Length; i++)
            {
                //for (int j=0; j<8; j++)
                //{
                if (x < bitmap.Width-1)
                {
                    x++;
                }
                else
                {
                    y++;
                    x = 0;
                }
                px = bitmap.GetPixel(x, y);*/
            // updated close

            //String red = Convert.ToString(px.R, 2).PadLeft(8, '0');
            //byte temp = px.R;

            /*byte[] newPxR = System.Text.Encoding.UTF8.GetBytes(Convert.ToString(px.R, 2).PadLeft(8, '0'));
            BitArray r = new BitArray(newPxR);

            if (r[0] != bitArray[i])
            {
                r[0] = bitArray[i];
            }*/

            // update open
            /*String binary = "";
            for (int k = 0; k < System.Text.Encoding.UTF8.GetBytes(Convert.ToString(px.R)).Length; k++)
            {
                binary += Convert.ToString(System.Text.Encoding.UTF8.GetBytes(Convert.ToString(px.R))[k], 2).PadLeft(8, '0');
            }
            String res = binary;
            //String[] resSplit = res.Split();
            String[] resSplit = res.Select(c => c.ToString()).ToArray();
            if (!resSplit[7].Equals(Convert.ToString(binaryText[i])))
            {
                resSplit[7] = Convert.ToString(binaryText[i]);
            }
            res = String.Join("", resSplit);

            byte[] red = Encoding.ASCII.GetBytes(res);
            //MessageBox.Show(Convert.ToString(red[0]));
            bitmap.SetPixel(x, y, Color.FromArgb(red[0], px.G, px.B, px.A));
            //}
        }*/
            //update closed
            /*for (int i = 0; i < txtBytes.Length; i++)
            {
                
                px = bitmap.GetPixel(i / bitmap.Width, i / bitmap.Height);
                bitmap.SetPixel(i / bitmap.Width, i / bitmap.Height, Color.FromArgb(px.R, px.G, px.B, px.A & 0xFC | txtBytes[i]));
            }*/
            bitmap.Save("abcd.png");
            MessageBox.Show("Fatto!");
        }
    }
}