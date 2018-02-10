using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ImgToAsciiArt
{
    public partial class Form1 : Form
    {
        private Bitmap target_img = null;
        private string saveLocation = null;
        private string pixels = " .\"*#JEDX";
        

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Open_Image_Bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                target_img = new Bitmap(openFileDialog1.FileName);
            }

            this.pictureBox1.Image = target_img;
            this.textBox2.Text = target_img.Width.ToString();

        }

        private void Save_Path_Bt_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Text|*.txt";

            if (SaveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                saveLocation = SaveFileDialog1.FileName;
            }

            this.textBox1.Text = saveLocation;
        }

        private void Start_Bt_Click(object sender, EventArgs e)
        {
            int _size = 0;
            int _interval;

            if (target_img == null || saveLocation == null || !int.TryParse(Size_Tb.Text,out _size))
            { 
                MessageBox.Show("尚未選取圖片 或 儲存路徑 或 Size大小");
            }
            else
            {
                if (_size >= target_img.Width)
                {
                    MessageBox.Show("Size太大");
                }
                else
                {
                    using (StreamWriter Writer = new StreamWriter(saveLocation))
                    {
                        _interval = target_img.Width / _size;
                        for (int y = 0; y < target_img.Height; y = y + _interval)
                        {
                            for (int x = 0; x < target_img.Width; x = x + _interval)
                            {
                                Color color = target_img.GetPixel(x, y);
                                double brightness = Brightness(color);
                                double idx = brightness / 255 * (pixels.Length - 1);
                                char _char = pixels[(int)Math.Round(idx)];
                                Writer.Write(_char);
                            }
                            Writer.WriteLine();
                        }
                    }
                }
            }
        }

        private static double Brightness(Color c)
        {
            return Math.Sqrt(
                c.R * c.R * .241 +
                c.G * c.G * .691 +
                c.B * c.B * .068
                );
        }
    }
}
