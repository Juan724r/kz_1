using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lab_1._1
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        private Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загружаем выбранное изображение
                    string imagePath = openFileDialog.FileName;
                    originalImage = Image.FromFile(imagePath);
                    bmp = new Bitmap(originalImage);

                    // Отображаем изображение в PictureBox с учетом масштабирования
                    pictureBox1.Image = originalImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // Отображаем гистограмму яркости
                    ShowBrightnessHistogram(originalImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void origBtn_Click(object sender, EventArgs e)
        {
            // Показываем оригинальное изображение
            pictureBox1.Image = originalImage;
        }

        private void ApplyColorMatrix(float[][] matrix)
        {
            if (originalImage != null)
            {
                Bitmap bmp = new Bitmap(originalImage.Width, originalImage.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (ImageAttributes attributes = new ImageAttributes())
                    {
                        ColorMatrix colorMatrix = new ColorMatrix(matrix);
                        attributes.SetColorMatrix(colorMatrix);

                        g.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                    0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
                    }
                }

                pictureBox1.Image = bmp;
                ShowBrightnessHistogram(bmp);
            }
        }

        private void blackWhiteBtn_Click(object sender, EventArgs e)
        {
            float[][] grayscaleMatrix = {
                new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            };
            ApplyColorMatrix(grayscaleMatrix);
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            float[][] redMatrix = {
                new float[] {1, 1, 1, 1, 1 },
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            };
            ApplyColorMatrix(redMatrix);
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            // Отображаем только зеленый канал
            float[][] greenMatrix = {
                new float[] {0, 0, 0, 0, 0},
                new float[] {1, 1, 1, 1, 1},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            };
            ApplyColorMatrix(greenMatrix);
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            // Отображаем только синий канал
            float[][] blueMatrix = {
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {1, 1, 1, 1, 1},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            };
            ApplyColorMatrix(blueMatrix);
        }

        private void ShowBrightnessHistogram(Image image)
        {
            if (image != null)
            {
                // Создаем новый Bitmap на основе изображения
                Bitmap bmp = new Bitmap(image);

                // Создаем массив для подсчета гистограммы яркости
                int[] histogram = new int[256];

                // Проходим по всем пикселям изображения и инкрементируем соответствующий элемент массива гистограммы
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);
                        int brightness = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        histogram[brightness]++;
                    }
                }

                // Нормализуем гистограмму, чтобы максимальное значение было равно высоте PictureBox
                int maxCount = histogram.Max();
                float scaleFactor = pictureBoxHistogram.Height / (float)maxCount;

                // Создаем новый Bitmap для отображения гистограммы
                Bitmap histogramBitmap = new Bitmap(pictureBoxHistogram.Width, pictureBoxHistogram.Height);

                // Рисуем гистограмму на Bitmap
                using (Graphics g = Graphics.FromImage(histogramBitmap))
                {
                    g.Clear(Color.White);
                    using (Pen pen = new Pen(Color.Black))
                    {
                        for (int i = 0; i < 256; i++)
                        {
                            int barHeight = (int)(histogram[i] * scaleFactor);
                            g.DrawLine(pen, i, pictureBoxHistogram.Height, i, pictureBoxHistogram.Height - barHeight);
                        }
                    }
                }

                // Отображаем гистограмму в PictureBox
                pictureBoxHistogram.Image = histogramBitmap;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmp != null)
            {
                int x = e.X;
                int y = e.Y;

                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                {
                    // a) Внешняя рамка квадратного окна W размера 11x11 вокруг пикселя p
                    DrawWindow(x, y);
                    // b) Координаты пикселя p и значения компонентов RGB в этой точке
                    Color pixelColor = bmp.GetPixel(x, y);
                    string pixelInfo = string.Format("Координаты: ({0}, {1})\nRGB: ({2}, {3}, {4})",
                                                      x, y, pixelColor.R, pixelColor.G, pixelColor.B);
                    labelPixelInfo.Text = pixelInfo;

                    // c) Интенсивность [R(p) + G(p) + B(p)] / 3 в точке p
                    int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    labelIntensity.Text = "Интенсивность: " + intensity.ToString();

                    // d) Среднее и стандартное отклонение
                    CalculateMeanAndStandardDeviation(x, y);
                }
            }
        }

        private void DrawWindow(int x, int y)
        {
            Graphics g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();



            int windowSize = 11;
            int startX = x - windowSize / 2;
            int startY = y - windowSize / 2;

            for (int i = startX; i < startX + windowSize; i++)
            {
                for (int j = startY; j < startY + windowSize; j++)
                {
                    if (i >= 0 && i < bmp.Width && j >= 0 && j < bmp.Height)
                    {
                        if (i == startX || i == startX + windowSize - 1 || j == startY || j == startY + windowSize - 1)
                        {
                            g.DrawRectangle(Pens.Red, i, j, 1, 1);
                        }
                    }
                }
            }
        }

        private void CalculateMeanAndStandardDeviation(int x, int y)
        {
            double mean = 0;
            double sum = 0;
            double sumSquaredDiff = 0;
            int windowSize = 11;
            int startX = x - windowSize / 2;
            int startY = y - windowSize / 2;

            for (int i = startX; i < startX + windowSize; i++)
            {
                for (int j = startY; j < startY + windowSize; j++)
                {
                    if (i >= 0 && i < bmp.Width && j >= 0 && j < bmp.Height)
                    {
                        Color pixelColor = bmp.GetPixel(i, j);
                        int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        sum += intensity;
                        sumSquaredDiff += intensity * intensity;
                    }
                }
            }

            int windowArea = windowSize * windowSize;
            mean = sum / windowArea;
            double variance = (sumSquaredDiff / windowArea) - (mean * mean);
            double standardDeviation = Math.Sqrt(variance);

            labelMean.Text = "Среднее: " + mean.ToString("F2");
            labelStandardDeviation.Text = "Стандартное отклонение: " + standardDeviation.ToString("F2");
        }


    }
}