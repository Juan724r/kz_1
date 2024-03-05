using System.CodeDom.Compiler;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace lab_1._1
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        private Bitmap bmp;
        private bool filtered = false;
        Image currImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            // ��������� ���������� ���� ������ �����
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "����������� (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|��� ����� (*.*)|*.*";
            openFileDialog.Title = "�������� �����������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ��������� ��������� �����������
                    string imagePath = openFileDialog.FileName;
                    originalImage = Image.FromFile(imagePath);
                    bmp = new Bitmap(originalImage);

                    // ���������� ����������� � PictureBox � ������ ���������������
                    //pictureBox1.Dock = DockStyle.Fill;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    ResizeImage(originalImage);
                    //pictureBox1.Image = originalImage;

                    //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // ���������� ����������� �������
                    ShowBrightnessHistogram(originalImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ �������� �����������: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void origBtn_Click(object sender, EventArgs e)
        {
            // ���������� ������������ �����������
            pictureBox1.Image = bmp;
            trackBar1.Value = 0;
        }

        private void ApplyColorMatrix(float[][] matrix)
        {
            if (originalImage != null)
            {
                Bitmap bmp = new Bitmap(this.bmp.Width, this.bmp.Height);

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
            // ���������� ������ ������� �����
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
            // ���������� ������ ����� �����
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
                // ������� ����� Bitmap �� ������ �����������
                Bitmap bmp = new Bitmap(image);

                // ������� ������ ��� �������� ����������� �������
                int[] histogram = new int[256];

                // �������� �� ���� �������� ����������� � �������������� ��������������� ������� ������� �����������
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);
                        int brightness = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        histogram[brightness]++;
                    }
                }

                // ����������� �����������, ����� ������������ �������� ���� ����� ������ PictureBox
                int maxCount = histogram.Max();
                float scaleFactor = pictureBoxHistogram.Height / (float)maxCount;

                // ������� ����� Bitmap ��� ����������� �����������
                Bitmap histogramBitmap = new Bitmap(pictureBoxHistogram.Width, pictureBoxHistogram.Height);

                // ������ ����������� �� Bitmap
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

                // ���������� ����������� � PictureBox
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
                    // a) ������� ����� ����������� ���� W ������� 11x11 ������ ������� p
                    DrawWindow(x, y);

                    // b) ���������� ������� p
                    Color pixelColor = bmp.GetPixel(x, y);
                    string pixelInfo = string.Format("����������: ({0}, {1})", x, y);
                    labelPixelInfo.Text = pixelInfo;

                    // c) �������� ����������� RGB � ���� �����
                    string rgbInfo = string.Format("RGB: ({0}, {1}, {2})", pixelColor.R, pixelColor.G, pixelColor.B);
                    labelRGB.Text = rgbInfo;

                    // d) ������������� [R(p) + G(p) + B(p)] / 3 � ����� p
                    int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    labelIntensity.Text = "�������������: " + intensity.ToString();

                    // e) ������� � ����������� ����������
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

            labelMean.Text = "�������: " + mean.ToString("F2");
            labelStandardDeviation.Text = "����������� ����������: " + standardDeviation.ToString("F2");
        }

        private void ResizeImage(Image originalImage)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            bmp = new Bitmap(originalImage, new Size(width, height));
            pictureBox1.Image = bmp;
        }

        private void BrightnessControl(Bitmap image, int power)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    int newRed = Math.Max(0, Math.Min(255, pixelColor.R + power));
                    int newGreen = Math.Max(0, Math.Min(255, pixelColor.G + power));
                    int newBlue = Math.Max(0, Math.Min(255, pixelColor.B + power));

                    image.SetPixel(i, j, Color.FromArgb(newRed, newGreen, newBlue));

                    pictureBox1.Image = image;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int power = trackBar1.Value;
            Bitmap tempBmp = new Bitmap(bmp);
            BrightnessControl(tempBmp, power);
        }

        public Color[][] GetBitMapColorMatrix(Bitmap bitmap)
        {

            int hight = bitmap.Height;
            int width = bitmap.Width;

            Color[][] colorMatrix = new Color[width][];
            for (int i = 0; i < width; i++)
            {
                colorMatrix[i] = new Color[hight];
                for (int j = 0; j < hight; j++)
                {
                    colorMatrix[i][j] = bitmap.GetPixel(i, j);
                }
            }
            return colorMatrix;
        }

        public Bitmap GetBitmapFromColorMatrix(Color[][] colorMatrix)
        {
            int width = colorMatrix.Length;
            int height = colorMatrix[0].Length;

            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bitmap.SetPixel(i, j, colorMatrix[i][j]);
                }
            }

            return bitmap;
        }

        public Bitmap GetReversedBitmapFromColorMatrix(Color[][] colorMatrix)
        {
            int width = colorMatrix.Length;
            int height = colorMatrix[0].Length;

            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bitmap.SetPixel(width - i - 1, j, colorMatrix[i][j]);
                }
            }

            return bitmap;
        }

        private void mirrorBtn_Click(object sender, EventArgs e)
        {
            Bitmap bt = (Bitmap)pictureBox1.Image;
            Color[][] cl = GetBitMapColorMatrix(bt);
            pictureBox1.Image = GetReversedBitmapFromColorMatrix(cl);
        }

        public Color[][] ApplyMedianFilter(Color[][] colorMatrix, int filterSize)
        {
            int width = colorMatrix.Length;
            int height = colorMatrix[0].Length;
            Color[][] result = new Color[width][];

            // ������ �� ������� ������� �����������
            for (int x = 0; x < width; x++)
            {
                result[x] = new Color[height];
                for (int y = 0; y < height; y++)
                {
                    // �������� ������� ��� �������� �������� ������ � ����������� �������
                    List<Color> neighborhoodColors = new List<Color>();

                    // ������ �� ����������� �������
                    for (int i = -filterSize / 2; i <= filterSize / 2; i++)
                    {
                        for (int j = -filterSize / 2; j <= filterSize / 2; j++)
                        {
                            int neighborX = x + i;
                            int neighborY = y + j;

                            // �������� ������ �����������
                            if (neighborX >= 0 && neighborX < width && neighborY >= 0 && neighborY < height)
                            {
                                neighborhoodColors.Add(colorMatrix[neighborX][neighborY]);
                            }
                        }
                    }

                    // ���������� ������� ������ �����������
                    neighborhoodColors.Sort((c1, c2) => c1.GetBrightness().CompareTo(c2.GetBrightness()));

                    // ����� ���������� �����
                    Color medianColor = neighborhoodColors[neighborhoodColors.Count / 2];

                    // ��������� ����� ������� � ��������� ���� �����������
                    result[x][y] = medianColor;
                }
            }

            return result;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (!filtered)
            {
                currImage = pictureBox1.Image;
                Bitmap bt = (Bitmap)pictureBox1.Image;
                Color[][] cl = GetBitMapColorMatrix(bt);
                Color[][] filteredMatrix = ApplyMedianFilter(cl, 5);
                Bitmap res = GetBitmapFromColorMatrix(filteredMatrix);
                pictureBox1.Image = res;
                filtered = true;
            }
            else
            {
                pictureBox1.Image = currImage; 
                filtered = false;
            }
            
        }
    }
}