using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static Bitmap bmp;
        private Graphics g;
        private Graphics g2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "Image file|*.jpg;*.png;*.bmp;*.dcm" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Image image = Image.FromFile(ofd.FileName);


                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                bmp = new Bitmap(ofd.FileName);
                 
                pictureBox1.Image = bmp;
                //g = Graphics.FromImage(pictureBox1.Image);
            }
        }
                  
        private void saveUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap)pictureBox2.Image;
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;

                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
               
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;

                }

            }

        }

        // Обработчик события меню "медианный фильтр"
        private void median3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianFilter(3);
            // Преобразование изображения
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void median5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianFilter(5);
            // Преобразование изображения
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void median7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianFilter(7);
            // Преобразование изображения
            UseWaitCursor = true;
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            UseWaitCursor = false;
        }

        private void medianXY3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianXYFilter(3);
            // Преобразование изображения
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void medianXY5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianXYFilter(5);
            // Преобразование изображения
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void medianXY7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание объекта фильтра
            Filter f = new MedianXYFilter(7);
            // Преобразование изображения
            bmp = f.transform(bmp);
            // Отображение его на форме
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void edgeSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edgesel.EdgeDetection2(bmp, 45);
            pictureBox2.Image = bmp;
            g2 = Graphics.FromImage(pictureBox2.Image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edgesel.EdgeDetection(bmp, 10);
            pictureBox2.Image = bmp;
            g2 = Graphics.FromImage(pictureBox2.Image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
  }

