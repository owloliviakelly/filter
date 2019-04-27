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
    class Edgesel
    {
        public static void EdgeDetection(Bitmap img, float threshold)
        {
            Bitmap img1 = (Bitmap)img.Clone();//копия изображения, для анализа

            unsafe
            {
                //размеры сканируемого изображения
                int nWidth = img.Width - 1;
                int nHeight = img.Height - 1;

                for (int y = 3; y < nHeight - 3; y++)
                {
                    for (int x = 0; x < nWidth; x++)
                    {
                        //Яркость
                        // byte[] temp = new byte[3];
                        var p0 = ToGray(img1.GetPixel(x, y));//текущий пиксель временное значения 
                        var p1 = ToGray(img1.GetPixel(x, y + 3));//сверху пиксель временное значение для сравнения
                        var p2 = ToGray(img1.GetPixel(x, y - 3));//снизу пиксель временное значение

                        if (Math.Abs(p1 - p2) + Math.Abs(p1 - p0) > threshold)// Если сумма по модулю больше порогового значения
                        {
                            img.SetPixel(x, y, Color.White);
                            img.SetPixel(x, y + 3, Color.White);
                            img.SetPixel(x, y - 3, Color.White);
                        }
                        else
                        {
                            img.SetPixel(x, y, Color.Black);
                            img.SetPixel(x, y + 3, Color.Black);
                            img.SetPixel(x, y - 3, Color.Black);
                        }
                    }

                }
            }
        }
        public static void EdgeDetection2(Bitmap img, float threshold)
        {
            Bitmap img1 = (Bitmap)img.Clone();//копия изображения, для анализа

            unsafe
            {
                //размеры сканируемого изображения
                int nWidth = img.Width - 1;
                int nHeight = img.Height - 1;

                for (int y = 1; y < nHeight - 1; y++)
                {
                    for (int x = 0; x < nWidth; x++)
                    {
                        //Яркость
                        var p0 = ToGray(img1.GetPixel(x, y));//текущий пиксель временное значения 
                        var p1 = ToGray(img1.GetPixel(x, y + 1));//сверху пиксель временное значение для сравнения
                        var p2 = ToGray(img1.GetPixel(x, y - 1));//снизу пиксель временное значение

                        if (Math.Abs(p1 - p2) + Math.Abs(p1 - p0) > threshold)// Если сумма по модулю больше порогового значения
                        {
                            img.SetPixel(x, y, Color.White);
                            img.SetPixel(x, y + 1, Color.White);
                            img.SetPixel(x, y - 1, Color.White);
                        }
                        else
                        {
                            img.SetPixel(x, y, Color.Black);
                            img.SetPixel(x, y + 1, Color.Black);
                            img.SetPixel(x, y - 1, Color.Black);
                        }
                    }
                }
                for (int x = 1; x < nHeight - 1; x++)
                {
                    for (int y = 0; y < nWidth; y++)
                    {
                        //Яркость
                        // byte[] temp = new byte[3];
                        var p0 = ToGray(img1.GetPixel(x, y));//текущий пиксель временное значения 
                        var p1 = ToGray(img1.GetPixel(x + 1, y));//сверху пиксель временное значение для сравнения
                        var p2 = ToGray(img1.GetPixel(x - 1, y));//снизу пиксель временное значение

                        if (Math.Abs(p1 - p2) + Math.Abs(p1 - p0) > threshold)// Если сумма по модулю больше порогового значения
                        {
                            img.SetPixel(x, y, Color.White);
                            img.SetPixel(x + 1, y, Color.White);
                            img.SetPixel(x - 1, y, Color.White);
                        }
                        else
                        {
                            img.SetPixel(x, y, Color.Black);
                            img.SetPixel(x + 1, y, Color.Black);
                            img.SetPixel(x - 1, y, Color.Black);
                        }
                    }
                }
            }
        }

        static unsafe float ToGray(Color grayscale)
        {
            return grayscale.R * 0.3f + grayscale.G * 0.59f + grayscale.B * 0.11f;//colormatrix for gray
        }
    }
 }

