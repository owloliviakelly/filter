using System;
using System.Drawing;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    // ---- Базовый класс фильтра
    public class Filter
    {
        protected int N;    // Размерность ядра    
        protected int gap;  // "Радиус" ядра

        // Конструктор фильтра
        public Filter(int n)
        {
            N = n;          // Размерность ядра
            gap = N / 2;    // "Радиус" ядра
        }

        // Инициализатор границ
        int setBetween(int x, int lo, int hi)
        {
            if (x < lo) return lo;
            else if (x > hi) return hi;
            else return x;
        }

        // Процедура применеия фильтра
        public Bitmap transform(Bitmap source)
        {
            // Инициализация промежуточного массива пикселей для обработки
            Color[,] pixels = new Color[source.Height + 2 * gap, source.Width + 2 * gap];
            for (int i = 0; i < source.Height + 2 * gap; i++)
            {
                for (int k = 0; k < source.Width + 2 * gap; k++)
                {
                    int ii = setBetween(i - gap, 0, source.Height - 1);
                    int kk = setBetween(k - gap, 0, source.Width - 1);
                    pixels[i, k] = source.GetPixel(kk, ii);
                }
            }

            // Создание результирующего битмапа
            Bitmap result = new Bitmap(source);
            for (int i = 0; i < source.Height; i++)
            {
                for (int k = 0; k < source.Width; k++)
                {
                    result.SetPixel(k, i, calculate(pixels, i, k));
                }
            }
            return result;
        }

        // Процедура обработки одного пикселя - виртуальная
        virtual protected Color calculate(Color[,] pixels, int i, int k) {
                return pixels[i + gap, k + gap];
        }
    }

    // ---- Пустой фильтр - преобразования нет (тестовый)
    public class IdentFilter : Filter
    {
        public IdentFilter() : base(1)
        {
        }
    }

    // ---- Фильтр перевода в монохром (тестовый)
    public class MonoFilter : Filter
    {
        public MonoFilter() : base(1)
        {
        }
        override protected Color calculate(Color[,] pixels, int i, int k)
        {
            Color source = pixels[i + gap, k + gap];
            double xx = 0.299 * source.R + 0.587 * source.G + 0.114 * source.B;
            int x = (int) xx;
            if (x > 255) x = 255;
            return Color.FromArgb(x, x, x);
        }
    }

    // ---- Медианный фильтр
    public class MedianFilter : Filter
    {
        public MedianFilter(int n) : base(n)
        {
        }
        override protected Color calculate(Color[,] pixels, int i, int k)
        {
            // Массивы данных по каждому цвету для всего окна
            int[] r = new int[N * N];
            int[] g = new int[N * N];
            int[] b = new int[N * N];

            // Двойной цикл заполнения массивов
            for (int ii = 0; ii < N; ii++)
            {
                for (int kk = 0; kk < N; kk++)
                {
                    r[ii * N + kk] = pixels[i + ii, k + kk].R;
                    g[ii * N + kk] = pixels[i + ii, k + kk].G;
                    b[ii * N + kk] = pixels[i + ii, k + kk].B;
                }
            }

            // Сортировка массивов
            Array.Sort(r);
            Array.Sort(g);
            Array.Sort(b);

            // Выделение медиан
            int nn = N * N / 2;
            return Color.FromArgb(r[nn], g[nn], b[nn]);
        }
    }

    // ---- Медианный фильтр раздельно по координатам
    public class MedianXYFilter : Filter
    {
        public MedianXYFilter(int n) : base(n)
        {
        }
        override protected Color calculate(Color[,] pixels, int i, int k)
        {
            // Массивы данных по каждому цвету по вертикали
            int[] ry = new int[N];
            int[] gy = new int[N];
            int[] by = new int[N];

            // Двойной цикл заполнения массивов
            for (int ii = 0; ii < N; ii++)
            {
                // Массивы данных по каждому цвету по горизонтали
                int[] rx = new int[N];
                int[] gx = new int[N];
                int[] bx = new int[N];

                for (int kk = 0; kk < N; kk++)
                {
                    rx[kk] = pixels[i + ii, k + kk].R;
                    gx[kk] = pixels[i + ii, k + kk].G;
                    bx[kk] = pixels[i + ii, k + kk].B;
                }
                // Сортировка массивов
                Array.Sort(rx);
                Array.Sort(gx);
                Array.Sort(bx);
                // Выделение медиан по X
                ry[ii] = rx[gap];
                gy[ii] = gx[gap];
                by[ii] = bx[gap];
            }

            // Сортировка массивов
            Array.Sort(ry);
            Array.Sort(gy);
            Array.Sort(by);

            // Выделение медиан
            return Color.FromArgb(ry[gap], gy[gap], by[gap]);
        }
    }
}
