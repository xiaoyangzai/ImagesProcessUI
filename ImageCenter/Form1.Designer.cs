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
            StartAllTest = new Button();
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
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adjustStep).BeginInit();
            SuspendLayout();
            // 
            // StartAllTest
            // 
            StartAllTest.Location = new Point(1214, 806);
            StartAllTest.Margin = new Padding(6, 5, 6, 5);
            StartAllTest.Name = "StartAllTest";
            StartAllTest.Size = new Size(1022, 71);
            StartAllTest.TabIndex = 0;
            StartAllTest.Text = "Select DLL...";
            StartAllTest.UseVisualStyleBackColor = true;
            StartAllTest.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(-8, 813);
            load_status.Margin = new Padding(6, 0, 6, 0);
            load_status.Name = "load_status";
            load_status.Size = new Size(91, 31);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(92, 810);
            console.Margin = new Padding(4, 4, 4, 4);
            console.Name = "console";
            console.Size = new Size(1040, 389);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(272, 697);
            selectImage.Margin = new Padding(6, 5, 6, 5);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(324, 71);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(968, 700);
            selectTarget.Margin = new Padding(6, 5, 6, 5);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(324, 67);
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
            inputImage.Location = new Point(56, 46);
            inputImage.Margin = new Padding(6, 5, 6, 5);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(824, 618);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(1008, 474);
            templateImage.Margin = new Padding(6, 5, 6, 5);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(260, 188);
            templateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(1400, 46);
            resultImage.Margin = new Padding(6, 5, 6, 5);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(912, 618);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(1214, 908);
            buttonRotateDegree.Margin = new Padding(6, 5, 6, 5);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(324, 71);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonMatcher
            // 
            buttonMatcher.Location = new Point(1214, 1018);
            buttonMatcher.Margin = new Padding(6, 5, 6, 5);
            buttonMatcher.Name = "buttonMatcher";
            buttonMatcher.Size = new Size(324, 71);
            buttonMatcher.TabIndex = 12;
            buttonMatcher.Text = "ImageMatcher";
            buttonMatcher.UseVisualStyleBackColor = true;
            buttonMatcher.Click += buttonMatcher_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(1214, 1127);
            buttonFocusQuality.Margin = new Padding(6, 5, 6, 5);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(324, 71);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(1550, 1127);
            buttonBrightQuality.Margin = new Padding(6, 5, 6, 5);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(324, 71);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(1912, 908);
            buttonCutLineDetection.Margin = new Padding(6, 5, 6, 5);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(324, 71);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "ImageCutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(1550, 908);
            buttonCutTraceValidate.Margin = new Padding(6, 5, 6, 5);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(324, 71);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "ImageCutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(1550, 1018);
            buttonPixelMeasure.Margin = new Padding(6, 5, 6, 5);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(324, 71);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(1442, 1220);
            maxValue.Margin = new Padding(4, 4, 4, 4);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(96, 38);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1230, 1224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(1752, 1220);
            startPosition.Margin = new Padding(4, 4, 4, 4);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(116, 38);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1584, 1224);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // adjustStep
            // 
            adjustStep.Location = new Point(2028, 1220);
            adjustStep.Margin = new Padding(6, 5, 6, 5);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(208, 38);
            adjustStep.TabIndex = 22;
            adjustStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1912, 1224);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 23;
            label3.Text = "搜索Step";
            // 
            // saveReusltImage
            // 
            saveReusltImage.Location = new Point(1400, 697);
            saveReusltImage.Margin = new Padding(6, 5, 6, 5);
            saveReusltImage.Name = "saveReusltImage";
            saveReusltImage.Size = new Size(324, 67);
            saveReusltImage.TabIndex = 24;
            saveReusltImage.Text = "save";
            saveReusltImage.UseVisualStyleBackColor = true;
            saveReusltImage.Click += saveReusltImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2402, 1287);
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
            Controls.Add(StartAllTest);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)adjustStep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartAllTest;
        private Label load_status;
        private RichTextBox console;
        private string dllPath = "C:\\Users\\wangy\\source\\repos\\ChipImage\\bin\\";
        private string imagePath = "";
        string imageBase64String;
        string targetBase64String;
        private string targetPath = "";
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
    }
}