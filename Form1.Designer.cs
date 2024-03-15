namespace lab_1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadBtn = new Button();
            pictureBox1 = new PictureBox();
            origBtn = new Button();
            blackWhiteBtn = new Button();
            redBtn = new Button();
            greenBtn = new Button();
            blueBtn = new Button();
            pictureBoxHistogram = new PictureBox();
            labelPixelInfo = new Label();
            labelIntensity = new Label();
            labelMean = new Label();
            labelStandardDeviation = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button8 = new Button();
            button10 = new Button();
            mirrorBtn = new Button();
            filterBtn = new Button();
            button16 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelRGB = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(12, 12);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(75, 23);
            loadBtn.TabIndex = 0;
            loadBtn.Text = "Загрузить";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 311);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // origBtn
            // 
            origBtn.Location = new Point(12, 41);
            origBtn.Name = "origBtn";
            origBtn.Size = new Size(75, 23);
            origBtn.TabIndex = 3;
            origBtn.Text = "Оригинал";
            origBtn.UseVisualStyleBackColor = true;
            origBtn.Click += origBtn_Click;
            // 
            // blackWhiteBtn
            // 
            blackWhiteBtn.Location = new Point(93, 41);
            blackWhiteBtn.Name = "blackWhiteBtn";
            blackWhiteBtn.Size = new Size(75, 23);
            blackWhiteBtn.TabIndex = 4;
            blackWhiteBtn.Text = "ЧБ";
            blackWhiteBtn.UseVisualStyleBackColor = true;
            blackWhiteBtn.Click += blackWhiteBtn_Click;
            // 
            // redBtn
            // 
            redBtn.Location = new Point(174, 41);
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(75, 23);
            redBtn.TabIndex = 5;
            redBtn.Text = "Красный";
            redBtn.UseVisualStyleBackColor = true;
            redBtn.Click += redBtn_Click;
            // 
            // greenBtn
            // 
            greenBtn.Location = new Point(336, 40);
            greenBtn.Name = "greenBtn";
            greenBtn.Size = new Size(75, 23);
            greenBtn.TabIndex = 6;
            greenBtn.Text = "Зеленый";
            greenBtn.UseVisualStyleBackColor = true;
            greenBtn.Click += greenBtn_Click;
            // 
            // blueBtn
            // 
            blueBtn.Location = new Point(255, 41);
            blueBtn.Name = "blueBtn";
            blueBtn.Size = new Size(75, 23);
            blueBtn.TabIndex = 7;
            blueBtn.Text = "Синий";
            blueBtn.UseVisualStyleBackColor = true;
            blueBtn.Click += blueBtn_Click;
            // 
            // pictureBoxHistogram
            // 
            pictureBoxHistogram.Location = new Point(417, 329);
            pictureBoxHistogram.Name = "pictureBoxHistogram";
            pictureBoxHistogram.Size = new Size(352, 119);
            pictureBoxHistogram.TabIndex = 8;
            pictureBoxHistogram.TabStop = false;
            // 
            // labelPixelInfo
            // 
            labelPixelInfo.AutoSize = true;
            labelPixelInfo.Location = new Point(417, 451);
            labelPixelInfo.Name = "labelPixelInfo";
            labelPixelInfo.Size = new Size(78, 15);
            labelPixelInfo.TabIndex = 9;
            labelPixelInfo.Text = "Координаты:";
            // 
            // labelIntensity
            // 
            labelIntensity.AutoSize = true;
            labelIntensity.Location = new Point(417, 480);
            labelIntensity.Name = "labelIntensity";
            labelIntensity.Size = new Size(94, 15);
            labelIntensity.TabIndex = 10;
            labelIntensity.Text = "Интенсивность:";
            // 
            // labelMean
            // 
            labelMean.AutoSize = true;
            labelMean.Location = new Point(417, 495);
            labelMean.Name = "labelMean";
            labelMean.Size = new Size(56, 15);
            labelMean.TabIndex = 11;
            labelMean.Text = "Среднее:";
            // 
            // labelStandardDeviation
            // 
            labelStandardDeviation.AutoSize = true;
            labelStandardDeviation.Location = new Point(417, 510);
            labelStandardDeviation.Name = "labelStandardDeviation";
            labelStandardDeviation.Size = new Size(149, 15);
            labelStandardDeviation.TabIndex = 12;
            labelStandardDeviation.Text = "Стандартное отклоненин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(284, 15);
            label1.TabIndex = 13;
            label1.Text = "увеличение/уменьшение интенсивности яркости ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(399, 15);
            label2.TabIndex = 14;
            label2.Text = "увеличение/уменьшение интенсивности отдельных цветовых каналов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 333);
            label3.Name = "label3";
            label3.Size = new Size(297, 15);
            label3.TabIndex = 15;
            label3.Text = "повышение/снижение контрастности изображения;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 400);
            label4.Name = "label4";
            label4.Size = new Size(292, 15);
            label4.TabIndex = 16;
            label4.Text = "получение негатива яркости или цветовых каналов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(803, 83);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 17;
            label5.Text = "обмен цветовых каналов ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(803, 165);
            label6.Name = "label6";
            label6.Size = new Size(337, 15);
            label6.TabIndex = 18;
            label6.Text = "симметричное отображение изображения по горизонтали ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(803, 241);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 19;
            label7.Text = "удаление шума ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(803, 308);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 20;
            label8.Text = "Поворот на 90 гр";
            // 
            // button8
            // 
            button8.Location = new Point(12, 419);
            button8.Name = "button8";
            button8.Size = new Size(76, 29);
            button8.TabIndex = 27;
            button8.Text = "Негатив";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.Location = new Point(803, 101);
            button10.Name = "button10";
            button10.Size = new Size(139, 29);
            button10.TabIndex = 29;
            button10.Text = "Красный-зеленый";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // mirrorBtn
            // 
            mirrorBtn.Location = new Point(803, 183);
            mirrorBtn.Name = "mirrorBtn";
            mirrorBtn.Size = new Size(76, 29);
            mirrorBtn.TabIndex = 31;
            mirrorBtn.Text = "отразить";
            mirrorBtn.UseVisualStyleBackColor = true;
            mirrorBtn.Click += mirrorBtn_Click;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(803, 259);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(76, 29);
            filterBtn.TabIndex = 33;
            filterBtn.Text = "Фильтр";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // button16
            // 
            button16.Location = new Point(803, 326);
            button16.Name = "button16";
            button16.Size = new Size(76, 29);
            button16.TabIndex = 35;
            button16.Text = "Поворот";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 208);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 41;
            label9.Text = "красный";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 237);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 42;
            label10.Text = "зеленый";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 266);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 43;
            label11.Text = "синий";
            // 
            // labelRGB
            // 
            labelRGB.AutoSize = true;
            labelRGB.Location = new Point(417, 466);
            labelRGB.Name = "labelRGB";
            labelRGB.Size = new Size(32, 15);
            labelRGB.TabIndex = 44;
            labelRGB.Text = "RGB:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(17, 101);
            trackBar1.Maximum = 255;
            trackBar1.Minimum = -255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(265, 45);
            trackBar1.TabIndex = 46;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(17, 355);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(265, 45);
            trackBar2.TabIndex = 47;
            trackBar2.Value = 50;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(323, 363);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 48;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 531);
            Controls.Add(label12);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(labelRGB);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button16);
            Controls.Add(filterBtn);
            Controls.Add(mirrorBtn);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelStandardDeviation);
            Controls.Add(labelMean);
            Controls.Add(labelIntensity);
            Controls.Add(labelPixelInfo);
            Controls.Add(pictureBoxHistogram);
            Controls.Add(blueBtn);
            Controls.Add(greenBtn);
            Controls.Add(redBtn);
            Controls.Add(blackWhiteBtn);
            Controls.Add(origBtn);
            Controls.Add(pictureBox1);
            Controls.Add(loadBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadBtn;
        private PictureBox pictureBox1;
        private Button origBtn;
        private Button blackWhiteBtn;
        private Button redBtn;
        private Button greenBtn;
        private Button blueBtn;
        private PictureBox pictureBoxHistogram;
        private Label labelPixelInfo;
        private Label labelIntensity;
        private Label labelMean;
        private Label labelStandardDeviation;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button8;
        private Button button10;
        private Button mirrorBtn;
        private Button filterBtn;
        private Button button16;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelRGB;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label12;
    }
}