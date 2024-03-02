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
                    pictureBox1.Image = originalImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

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
                    // b) ���������� ������� p � �������� ����������� RGB � ���� �����
                    Color pixelColor = bmp.GetPixel(x, y);
                    string pixelInfo = string.Format("����������: ({0}, {1})\nRGB: ({2}, {3}, {4})",
                                                      x, y, pixelColor.R, pixelColor.G, pixelColor.B);
                    labelPixelInfo.Text = pixelInfo;

                    // c) ������������� [R(p) + G(p) + B(p)] / 3 � ����� p
                    int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    labelIntensity.Text = "�������������: " + intensity.ToString();

                    // d) ������� � ����������� ����������
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


    }
}