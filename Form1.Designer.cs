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
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            mirrorBtn = new Button();
            button13 = new Button();
            filterBtn = new Button();
            button15 = new Button();
            button16 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelRGB = new Label();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(14, 16);
            loadBtn.Margin = new Padding(3, 4, 3, 4);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(86, 31);
            loadBtn.TabIndex = 0;
            loadBtn.Text = "Загрузить";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(477, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 415);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // origBtn
            // 
            origBtn.Location = new Point(14, 55);
            origBtn.Margin = new Padding(3, 4, 3, 4);
            origBtn.Name = "origBtn";
            origBtn.Size = new Size(86, 31);
            origBtn.TabIndex = 3;
            origBtn.Text = "Оригинал";
            origBtn.UseVisualStyleBackColor = true;
            origBtn.Click += origBtn_Click;
            // 
            // blackWhiteBtn
            // 
            blackWhiteBtn.Location = new Point(106, 55);
            blackWhiteBtn.Margin = new Padding(3, 4, 3, 4);
            blackWhiteBtn.Name = "blackWhiteBtn";
            blackWhiteBtn.Size = new Size(86, 31);
            blackWhiteBtn.TabIndex = 4;
            blackWhiteBtn.Text = "ЧБ";
            blackWhiteBtn.UseVisualStyleBackColor = true;
            blackWhiteBtn.Click += blackWhiteBtn_Click;
            // 
            // redBtn
            // 
            redBtn.Location = new Point(199, 55);
            redBtn.Margin = new Padding(3, 4, 3, 4);
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(86, 31);
            redBtn.TabIndex = 5;
            redBtn.Text = "Красный";
            redBtn.UseVisualStyleBackColor = true;
            redBtn.Click += redBtn_Click;
            // 
            // greenBtn
            // 
            greenBtn.Location = new Point(384, 53);
            greenBtn.Margin = new Padding(3, 4, 3, 4);
            greenBtn.Name = "greenBtn";
            greenBtn.Size = new Size(86, 31);
            greenBtn.TabIndex = 6;
            greenBtn.Text = "Зеленый";
            greenBtn.UseVisualStyleBackColor = true;
            greenBtn.Click += greenBtn_Click;
            // 
            // blueBtn
            // 
            blueBtn.Location = new Point(291, 55);
            blueBtn.Margin = new Padding(3, 4, 3, 4);
            blueBtn.Name = "blueBtn";
            blueBtn.Size = new Size(86, 31);
            blueBtn.TabIndex = 7;
            blueBtn.Text = "Синий";
            blueBtn.UseVisualStyleBackColor = true;
            blueBtn.Click += blueBtn_Click;
            // 
            // pictureBoxHistogram
            // 
            pictureBoxHistogram.Location = new Point(477, 439);
            pictureBoxHistogram.Margin = new Padding(3, 4, 3, 4);
            pictureBoxHistogram.Name = "pictureBoxHistogram";
            pictureBoxHistogram.Size = new Size(402, 159);
            pictureBoxHistogram.TabIndex = 8;
            pictureBoxHistogram.TabStop = false;
            // 
            // labelPixelInfo
            // 
            labelPixelInfo.AutoSize = true;
            labelPixelInfo.Location = new Point(477, 601);
            labelPixelInfo.Name = "labelPixelInfo";
            labelPixelInfo.Size = new Size(99, 20);
            labelPixelInfo.TabIndex = 9;
            labelPixelInfo.Text = "Координаты:";
            // 
            // labelIntensity
            // 
            labelIntensity.AutoSize = true;
            labelIntensity.Location = new Point(477, 640);
            labelIntensity.Name = "labelIntensity";
            labelIntensity.Size = new Size(118, 20);
            labelIntensity.TabIndex = 10;
            labelIntensity.Text = "Интенсивность:";
            // 
            // labelMean
            // 
            labelMean.AutoSize = true;
            labelMean.Location = new Point(477, 660);
            labelMean.Name = "labelMean";
            labelMean.Size = new Size(71, 20);
            labelMean.TabIndex = 11;
            labelMean.Text = "Среднее:";
            // 
            // labelStandardDeviation
            // 
            labelStandardDeviation.AutoSize = true;
            labelStandardDeviation.Location = new Point(477, 680);
            labelStandardDeviation.Name = "labelStandardDeviation";
            labelStandardDeviation.Size = new Size(188, 20);
            labelStandardDeviation.TabIndex = 12;
            labelStandardDeviation.Text = "Стандартное отклоненин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 111);
            label1.Name = "label1";
            label1.Size = new Size(358, 20);
            label1.TabIndex = 13;
            label1.Text = "увеличение/уменьшение интенсивности яркости ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 220);
            label2.Name = "label2";
            label2.Size = new Size(504, 20);
            label2.TabIndex = 14;
            label2.Text = "увеличение/уменьшение интенсивности отдельных цветовых каналов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 444);
            label3.Name = "label3";
            label3.Size = new Size(376, 20);
            label3.TabIndex = 15;
            label3.Text = "повышение/снижение контрастности изображения;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 533);
            label4.Name = "label4";
            label4.Size = new Size(370, 20);
            label4.TabIndex = 16;
            label4.Text = "получение негатива яркости или цветовых каналов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(918, 111);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 17;
            label5.Text = "обмен цветовых каналов ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(918, 220);
            label6.Name = "label6";
            label6.Size = new Size(431, 20);
            label6.TabIndex = 18;
            label6.Text = "симметричное отображение изображения по горизонтали ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(918, 321);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 19;
            label7.Text = "удаление шума ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(918, 411);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 20;
            label8.Text = "пока хз";
            // 
            // button5
            // 
            button5.Location = new Point(182, 468);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(103, 39);
            button5.TabIndex = 26;
            button5.Text = "увеличить";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(59, 468);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(105, 39);
            button6.TabIndex = 25;
            button6.Text = "уменьшить";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(182, 557);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(87, 39);
            button7.TabIndex = 28;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(59, 557);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(87, 39);
            button8.TabIndex = 27;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1040, 135);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(87, 39);
            button9.TabIndex = 30;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(918, 135);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(87, 39);
            button10.TabIndex = 29;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // mirrorBtn
            // 
            mirrorBtn.Location = new Point(918, 244);
            mirrorBtn.Margin = new Padding(3, 4, 3, 4);
            mirrorBtn.Name = "mirrorBtn";
            mirrorBtn.Size = new Size(87, 39);
            mirrorBtn.TabIndex = 31;
            mirrorBtn.Text = "отразить";
            mirrorBtn.UseVisualStyleBackColor = true;
            mirrorBtn.Click += mirrorBtn_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1040, 345);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(87, 39);
            button13.TabIndex = 34;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(918, 345);
            filterBtn.Margin = new Padding(3, 4, 3, 4);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(87, 39);
            filterBtn.TabIndex = 33;
            filterBtn.Text = "button14";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // button15
            // 
            button15.Location = new Point(1040, 435);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new Size(87, 39);
            button15.TabIndex = 36;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(918, 435);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(87, 39);
            button16.TabIndex = 35;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 273);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 312);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 351);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 277);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 41;
            label9.Text = "красный";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 316);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 42;
            label10.Text = "зеленый";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 355);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 43;
            label11.Text = "синий";
            // 
            // labelRGB
            // 
            labelRGB.AutoSize = true;
            labelRGB.Location = new Point(477, 621);
            labelRGB.Name = "labelRGB";
            labelRGB.Size = new Size(40, 20);
            labelRGB.TabIndex = 44;
            labelRGB.Text = "RGB:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(19, 135);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 255;
            trackBar1.Minimum = -255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(303, 56);
            trackBar1.TabIndex = 46;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 708);
            Controls.Add(trackBar1);
            Controls.Add(labelRGB);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button13);
            Controls.Add(filterBtn);
            Controls.Add(mirrorBtn);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button mirrorBtn;
        private Button button13;
        private Button filterBtn;
        private Button button15;
        private Button button16;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelRGB;
        private TrackBar trackBar1;
    }
}