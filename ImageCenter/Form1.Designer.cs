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
            StartAllTest.Location = new Point(607, 442);
            StartAllTest.Name = "StartAllTest";
            StartAllTest.Size = new Size(511, 39);
            StartAllTest.TabIndex = 0;
            StartAllTest.Text = "Select DLL...";
            StartAllTest.UseVisualStyleBackColor = true;
            StartAllTest.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(-4, 446);
            load_status.Name = "load_status";
            load_status.Size = new Size(46, 17);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(46, 444);
            console.Margin = new Padding(2);
            console.Name = "console";
            console.Size = new Size(522, 215);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(136, 382);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(162, 39);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(484, 384);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(162, 37);
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
            inputImage.Location = new Point(28, 25);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(412, 339);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(504, 260);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(130, 103);
            templateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(700, 25);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(456, 339);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(607, 498);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(162, 39);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonMatcher
            // 
            buttonMatcher.Location = new Point(607, 558);
            buttonMatcher.Name = "buttonMatcher";
            buttonMatcher.Size = new Size(162, 39);
            buttonMatcher.TabIndex = 12;
            buttonMatcher.Text = "ImageMatcher";
            buttonMatcher.UseVisualStyleBackColor = true;
            buttonMatcher.Click += buttonMatcher_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(607, 618);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(162, 39);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(775, 618);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(162, 39);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(956, 498);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(162, 39);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "ImageCutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(775, 498);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(162, 39);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "ImageCutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(775, 558);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(162, 39);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(721, 669);
            maxValue.Margin = new Padding(2);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(48, 23);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 671);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(876, 669);
            startPosition.Margin = new Padding(2);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(58, 23);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(792, 671);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // adjustStep
            // 
            adjustStep.Location = new Point(1014, 669);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(104, 23);
            adjustStep.TabIndex = 22;
            adjustStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 671);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 23;
            label3.Text = "搜索Step";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1201, 706);
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
    }
}