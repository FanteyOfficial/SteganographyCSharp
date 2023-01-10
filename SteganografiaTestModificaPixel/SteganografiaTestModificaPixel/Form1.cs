using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace SteganografiaTestModificaPixel
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        String ext = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void imageSelectionBTN_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.InitialDirectory = @"C:\Downloads";
            openFileDialog.Filter = "PNG (*.PNG)|*.PNG|JPG (*.JPG)|*.JPG|BMP (*.BMP)|*.BMP|JPEG (*.JPEG)|*.JPEG";
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                CurrentImage.ImageLocation = openFileDialog.FileName;
                bitmap = new Bitmap(openFileDialog.FileName);
                if (openFileDialog.FileName.EndsWith(".png") || openFileDialog.FileName.EndsWith(".PNG")) {
                    bitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                }
                ext = Path.GetExtension(openFileDialog.FileName);
            }
        }

        private void hideTextBTN_Clicked(object sender, EventArgs e)
        {
            String text = TextToHide.Text;
            Color pixel;
            int x = -1, y = 0;

            // convert all string message in binary
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            //MessageBox.Show("" + bytes.Length);
            //for (int a=0; a<bytes.Length; a++) MessageBox.Show("" + bytes[a]);

            string textInBinary = "";
            foreach (byte b in bytes)
            {
                textInBinary += Convert.ToString(b, 2).PadLeft(8, '0');
            }
            //MessageBox.Show("" + textInBinary.Length);

            if (bitmap.Width * bitmap.Height < textInBinary.Length)
            {
                MessageBox.Show("Impossibile nascondere il messaggio nell'immagine!");
            }
            else
            {
                for (int i=0; i<textInBinary.Length; i++)
                {
                    // verify coordinates in bitmap
                    if (x < bitmap.Width-1)
                    {
                        x++;
                    }
                    else
                    {
                        x = 0;
                        y++;
                    }

                    // modify pixel
                    pixel = bitmap.GetPixel(x, y);
                    byte pixelValue;
                    pixelValue = pixel.R;
                    String pixelInBinary = "";
                    pixelInBinary = Convert.ToString(pixelValue, 2).PadLeft(8, '0');
                    String newColorBinary = "";

                    if (LSB_Mode.Checked)
                    {
                        newColorBinary = pixelInBinary.Substring(0, 6);
                        newColorBinary += textInBinary[i];
                    }
                    else if (MSB_Mode.Checked)
                    {
                        newColorBinary = pixelInBinary.Substring(1, 7);
                        newColorBinary = textInBinary[i] + newColorBinary;
                        //MessageBox.Show(newColorBinary, "Nuovo");
                        //MessageBox.Show(pixelInBinary, "Vecchio");
                    }

                    byte newColor;
                    newColor = Convert.ToByte(newColorBinary, 2);

                    bitmap.SetPixel(x, y, Color.FromArgb(newColor, pixel.G, pixel.B));
                }

                String finalChr = "00011000";
                // add final character
                for (int i=0; i<finalChr.Length; i++)
                {
                    if (x < bitmap.Width - 1)
                    {
                        x++;
                    }
                    else
                    {
                        x = 0;
                        y++;
                    }

                    pixel = bitmap.GetPixel(x, y);
                    byte pixelValue;
                    pixelValue = pixel.R;
                    String pixelInBinary = "";
                    pixelInBinary = Convert.ToString(pixelValue, 2).PadLeft(8, '0');
                    String newColorBinary = "";

                    if (LSB_Mode.Checked)
                    {
                        newColorBinary = pixelInBinary.Substring(0, 6);
                        newColorBinary += finalChr[i];
                    }
                    else if (MSB_Mode.Checked)
                    {
                        newColorBinary = pixelInBinary.Substring(1, 7);
                        // MessageBox.Show(newColorBinary);
                        newColorBinary = finalChr[i] + newColorBinary;
                    }

                    byte newColor;
                    newColor = Convert.ToByte(newColorBinary, 2);

                    bitmap.SetPixel(x, y, Color.FromArgb(newColor, pixel.G, pixel.B));
                }

                String filename = "abc";
                File.Delete(filename);

                CurrentImage.Image = bitmap;
                
                bitmap.Save("abc" + ext);
                CurrentImage.ImageLocation = "./abc" + ext;
                MessageBox.Show("Fatto!");
            }
        }

        private void DecodeTXT_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Inizio");
            String txt = "";
            Color pixel;
            String px = "";
            String specialChr = "00011000";
            for (int i=0; i<bitmap.Height; i++)
            {
                for (int j = 0; j<bitmap.Width; j++)
                {
                    pixel = bitmap.GetPixel(j, i);

                    if (LSB_Mode.Checked) px += Convert.ToString(pixel.R, 2).PadLeft(8, '0')[7];
                    else if (MSB_Mode.Checked) px += Convert.ToString(pixel.R, 2).PadLeft(8, '0')[0];

                    if (px.Equals(specialChr))
                    {
                        //MessageBox.Show("Fine");
                        TextToHide.Text = txt;
                        return;
                    }

                    if (px.Length == 8)
                    {
                        // MessageBox.Show("" + px.Length);
                        int n;
                        n = Convert.ToInt32(px, 2);
                        txt += Convert.ToChar(n);
                        px = "";
                    }
                }
            }
            //MessageBox.Show("Fine2");
            TextToHide.Text = txt;
            return;
        }
    }
}