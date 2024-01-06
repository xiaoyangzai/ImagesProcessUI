namespace ImageCenter
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
            load_status = new Label();
            console = new RichTextBox();
            selectDllPath = new OpenFileDialog();
            selectImage = new Button();
            selectTarget = new Button();
            openImage = new OpenFileDialog();
            openTarget = new OpenFileDialog();
            inputImage = new PictureBox();
            templateImage = new PictureBox();
            resultImage = new PictureBox();
            buttonRotateDegree = new Button();
            buttonMatcher = new Button();
            buttonFocusQuality = new Button();
            buttonBrightQuality = new Button();
            buttonCutLineDetection = new Button();
            buttonCutTraceValidate = new Button();
            buttonPixelMeasure = new Button();
            maxValue = new NumericUpDown();
            label1 = new Label();
            startPosition = new NumericUpDown();
            label2 = new Label();
            adjustStep = new NumericUpDown();
            label3 = new Label();
            saveReusltImage = new Button();
            cutCenterLocY = new NumericUpDown();
            label4 = new Label();
            cutLineWidth = new NumericUpDown();
            label5 = new Label();
            cutCenterValidate = new Button();
            retryTimes = new NumericUpDown();
            detectLowCrossroad = new Button();
            detectHighCrossroad = new Button();
            checkGrainExist = new Button();
            label6 = new Label();
            cutCenterLocX = new NumericUpDown();
            CheckifCutTrace = new Button();
            edgeDetection = new Button();
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adjustStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutCenterLocY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retryTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutCenterLocX).BeginInit();
            SuspendLayout();
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(-6, 656);
            load_status.Margin = new Padding(4, 0, 4, 0);
            load_status.Name = "load_status";
            load_status.Size = new Size(64, 25);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(66, 653);
            console.Name = "console";
            console.Size = new Size(564, 314);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(194, 562);
            selectImage.Margin = new Padding(4, 4, 4, 4);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(231, 57);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(760, 564);
            selectTarget.Margin = new Padding(4, 4, 4, 4);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(231, 54);
            selectTarget.TabIndex = 5;
            selectTarget.Text = "Select tempalte image...";
            selectTarget.UseVisualStyleBackColor = true;
            selectTarget.Click += selectTarget_Click;
            // 
            // openImage
            // 
            openImage.FileName = "openFileDialog1";
            // 
            // openTarget
            // 
            openTarget.FileName = "openFileDialog1";
            // 
            // inputImage
            // 
            inputImage.Location = new Point(40, 37);
            inputImage.Margin = new Padding(4, 4, 4, 4);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(589, 498);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(796, 384);
            templateImage.Margin = new Padding(4, 4, 4, 4);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(186, 152);
            templateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(1122, 37);
            resultImage.Margin = new Padding(4, 4, 4, 4);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(651, 498);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(691, 735);
            buttonRotateDegree.Margin = new Padding(4, 4, 4, 4);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(184, 57);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonMatcher
            // 
            buttonMatcher.Location = new Point(691, 824);
            buttonMatcher.Margin = new Padding(4, 4, 4, 4);
            buttonMatcher.Name = "buttonMatcher";
            buttonMatcher.Size = new Size(184, 57);
            buttonMatcher.TabIndex = 12;
            buttonMatcher.Text = "ImageMatcher";
            buttonMatcher.UseVisualStyleBackColor = true;
            buttonMatcher.Click += buttonMatcher_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(691, 912);
            buttonFocusQuality.Margin = new Padding(4, 4, 4, 4);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(184, 57);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(905, 912);
            buttonBrightQuality.Margin = new Padding(4, 4, 4, 4);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(181, 57);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(1345, 900);
            buttonCutLineDetection.Margin = new Padding(4, 4, 4, 4);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(181, 57);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "CutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(1345, 735);
            buttonCutTraceValidate.Margin = new Padding(4, 4, 4, 4);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(181, 57);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "CutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(905, 817);
            buttonPixelMeasure.Margin = new Padding(4, 4, 4, 4);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(181, 57);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(854, 987);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(69, 31);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 990);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(1073, 987);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(57, 31);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(953, 990);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // adjustStep
            // 
            adjustStep.Location = new Point(1246, 987);
            adjustStep.Margin = new Padding(4, 4, 4, 4);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(52, 31);
            adjustStep.TabIndex = 22;
            adjustStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1163, 990);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 23;
            label3.Text = "搜索Step";
            // 
            // saveReusltImage
            // 
            saveReusltImage.Location = new Point(1359, 565);
            saveReusltImage.Margin = new Padding(4, 4, 4, 4);
            saveReusltImage.Name = "saveReusltImage";
            saveReusltImage.Size = new Size(231, 54);
            saveReusltImage.TabIndex = 24;
            saveReusltImage.Text = "save";
            saveReusltImage.UseVisualStyleBackColor = true;
            saveReusltImage.Click += saveReusltImage_Click;
            // 
            // cutCenterLocY
            // 
            cutCenterLocY.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocY.Location = new Point(1458, 799);
            cutCenterLocY.Margin = new Padding(4, 4, 4, 4);
            cutCenterLocY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocY.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            cutCenterLocY.Name = "cutCenterLocY";
            cutCenterLocY.Size = new Size(68, 31);
            cutCenterLocY.TabIndex = 25;
            cutCenterLocY.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocY.ValueChanged += cutCenterLocY_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1345, 801);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 26;
            label4.Text = "切割道中心Y";
            // 
            // cutLineWidth
            // 
            cutLineWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            cutLineWidth.Location = new Point(1458, 861);
            cutLineWidth.Margin = new Padding(4, 4, 4, 4);
            cutLineWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cutLineWidth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.Name = "cutLineWidth";
            cutLineWidth.Size = new Size(68, 31);
            cutLineWidth.TabIndex = 27;
            cutLineWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.ValueChanged += cutLineWidth_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1345, 863);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 28;
            label5.Text = "切割道宽度";
            // 
            // cutCenterValidate
            // 
            cutCenterValidate.Location = new Point(1122, 910);
            cutCenterValidate.Margin = new Padding(4, 4, 4, 4);
            cutCenterValidate.Name = "cutCenterValidate";
            cutCenterValidate.Size = new Size(106, 57);
            cutCenterValidate.TabIndex = 29;
            cutCenterValidate.Text = "CutCenterValidate";
            cutCenterValidate.UseVisualStyleBackColor = true;
            cutCenterValidate.Click += cutCenterValidate_Click;
            // 
            // retryTimes
            // 
            retryTimes.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            retryTimes.Location = new Point(1235, 927);
            retryTimes.Margin = new Padding(4, 4, 4, 4);
            retryTimes.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            retryTimes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryTimes.Name = "retryTimes";
            retryTimes.Size = new Size(68, 31);
            retryTimes.TabIndex = 30;
            retryTimes.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // detectLowCrossroad
            // 
            detectLowCrossroad.Location = new Point(905, 735);
            detectLowCrossroad.Margin = new Padding(4, 4, 4, 4);
            detectLowCrossroad.Name = "detectLowCrossroad";
            detectLowCrossroad.Size = new Size(181, 57);
            detectLowCrossroad.TabIndex = 31;
            detectLowCrossroad.Text = "LowCrossroad";
            detectLowCrossroad.UseVisualStyleBackColor = true;
            detectLowCrossroad.Click += detectLowCrossroad_Click;
            // 
            // detectHighCrossroad
            // 
            detectHighCrossroad.Location = new Point(1122, 735);
            detectHighCrossroad.Margin = new Padding(4, 4, 4, 4);
            detectHighCrossroad.Name = "detectHighCrossroad";
            detectHighCrossroad.Size = new Size(181, 57);
            detectHighCrossroad.TabIndex = 32;
            detectHighCrossroad.Text = "HighCrossroad";
            detectHighCrossroad.UseVisualStyleBackColor = true;
            detectHighCrossroad.Click += detectHighCrossroad_Click;
            // 
            // checkGrainExist
            // 
            checkGrainExist.Location = new Point(1122, 823);
            checkGrainExist.Margin = new Padding(4, 4, 4, 4);
            checkGrainExist.Name = "checkGrainExist";
            checkGrainExist.Size = new Size(181, 52);
            checkGrainExist.TabIndex = 33;
            checkGrainExist.Text = "IfHasGrain";
            checkGrainExist.UseVisualStyleBackColor = true;
            checkGrainExist.Click += checkGrainExist_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1345, 835);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 35;
            label6.Text = "切割道中心X";
            // 
            // cutCenterLocX
            // 
            cutCenterLocX.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocX.Location = new Point(1458, 833);
            cutCenterLocX.Margin = new Padding(4, 4, 4, 4);
            cutCenterLocX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocX.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            cutCenterLocX.Name = "cutCenterLocX";
            cutCenterLocX.Size = new Size(68, 31);
            cutCenterLocX.TabIndex = 34;
            cutCenterLocX.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocX.ValueChanged += cutCenterLocX_ValueChanged;
            // 
            // CheckifCutTrace
            // 
            CheckifCutTrace.Location = new Point(1345, 960);
            CheckifCutTrace.Margin = new Padding(4, 4, 4, 4);
            CheckifCutTrace.Name = "CheckifCutTrace";
            CheckifCutTrace.Size = new Size(181, 57);
            CheckifCutTrace.TabIndex = 36;
            CheckifCutTrace.Text = "CheckifCutTrace";
            CheckifCutTrace.UseVisualStyleBackColor = true;
            CheckifCutTrace.Click += CheckifCutTrace_Click;
            // 
            // edgeDetection
            // 
            edgeDetection.Location = new Point(1558, 735);
            edgeDetection.Margin = new Padding(4, 4, 4, 4);
            edgeDetection.Name = "edgeDetection";
            edgeDetection.Size = new Size(181, 57);
            edgeDetection.TabIndex = 37;
            edgeDetection.Text = "ChipEdgeDetect";
            edgeDetection.UseVisualStyleBackColor = true;
            edgeDetection.Click += edgeDetection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1374, 944);
            Controls.Add(edgeDetection);
            Controls.Add(CheckifCutTrace);
            Controls.Add(label6);
            Controls.Add(cutCenterLocX);
            Controls.Add(checkGrainExist);
            Controls.Add(detectHighCrossroad);
            Controls.Add(detectLowCrossroad);
            Controls.Add(retryTimes);
            Controls.Add(cutCenterValidate);
            Controls.Add(label5);
            Controls.Add(cutLineWidth);
            Controls.Add(label4);
            Controls.Add(cutCenterLocY);
            Controls.Add(saveReusltImage);
            Controls.Add(label3);
            Controls.Add(adjustStep);
            Controls.Add(label2);
            Controls.Add(startPosition);
            Controls.Add(label1);
            Controls.Add(maxValue);
            Controls.Add(buttonPixelMeasure);
            Controls.Add(buttonCutTraceValidate);
            Controls.Add(buttonCutLineDetection);
            Controls.Add(buttonBrightQuality);
            Controls.Add(buttonFocusQuality);
            Controls.Add(buttonMatcher);
            Controls.Add(buttonRotateDegree);
            Controls.Add(resultImage);
            Controls.Add(templateImage);
            Controls.Add(inputImage);
            Controls.Add(selectTarget);
            Controls.Add(selectImage);
            Controls.Add(console);
            Controls.Add(load_status);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)adjustStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutCenterLocY).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)retryTimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutCenterLocX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label load_status;
        private RichTextBox console;
        private string dllPath = "";
        private string imagePath = "";
        string imageBase64String;
        string targetBase64String;
        private string targetPath = "";
        private Bitmap originalImage;
        private OpenFileDialog selectDllPath;
        private Button selectImage;
        private Button selectTarget;
        private OpenFileDialog openImage;
        private OpenFileDialog openTarget;
        private PictureBox inputImage;
        private PictureBox templateImage;
        private PictureBox resultImage;
        private Button buttonRotateDegree;
        private Button buttonMatcher;
        private Button buttonFocusQuality;
        private Button buttonBrightQuality;
        private Button buttonCutLineDetection;
        private Button buttonCutTraceValidate;
        private Button buttonPixelMeasure;
        private NumericUpDown maxValue;
        private Label label1;
        private NumericUpDown startPosition;
        private Label label2;
        private NumericUpDown adjustStep;
        private Label label3;
        private Button saveReusltImage;
        private NumericUpDown cutCenterLocY;
        private Label label4;
        private NumericUpDown cutLineWidth;
        private Label label5;
        private Button cutCenterValidate;
        private NumericUpDown retryTimes;
        private Button detectLowCrossroad;
        private Button detectHighCrossroad;
        private Button checkGrainExist;
        private Label label6;
        private NumericUpDown cutCenterLocX;
        private Button CheckifCutTrace;
        private Button edgeDetection;
    }
}