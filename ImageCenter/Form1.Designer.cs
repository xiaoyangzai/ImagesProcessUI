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
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).BeginInit();
            SuspendLayout();
            // 
            // StartAllTest
            // 
            StartAllTest.Location = new Point(1246, 936);
            StartAllTest.Margin = new Padding(6);
            StartAllTest.Name = "StartAllTest";
            StartAllTest.Size = new Size(1022, 72);
            StartAllTest.TabIndex = 0;
            StartAllTest.Text = "Select DLL...";
            StartAllTest.UseVisualStyleBackColor = true;
            StartAllTest.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(24, 942);
            load_status.Margin = new Padding(6, 0, 6, 0);
            load_status.Name = "load_status";
            load_status.Size = new Size(91, 31);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(125, 939);
            console.Margin = new Padding(4);
            console.Name = "console";
            console.Size = new Size(1041, 388);
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
            selectImage.Margin = new Padding(6);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(323, 72);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(967, 701);
            selectTarget.Margin = new Padding(6);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(323, 68);
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
            inputImage.Location = new Point(55, 46);
            inputImage.Margin = new Padding(6);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(825, 618);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(1007, 475);
            templateImage.Margin = new Padding(6);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(260, 188);
            templateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(1401, 46);
            resultImage.Margin = new Padding(6);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(911, 618);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(1246, 1038);
            buttonRotateDegree.Margin = new Padding(6);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(323, 72);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonMatcher
            // 
            buttonMatcher.Location = new Point(1246, 1147);
            buttonMatcher.Margin = new Padding(6);
            buttonMatcher.Name = "buttonMatcher";
            buttonMatcher.Size = new Size(323, 72);
            buttonMatcher.TabIndex = 12;
            buttonMatcher.Text = "ImageMatcher";
            buttonMatcher.UseVisualStyleBackColor = true;
            buttonMatcher.Click += buttonMatcher_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(1246, 1256);
            buttonFocusQuality.Margin = new Padding(6);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(323, 72);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(1582, 1256);
            buttonBrightQuality.Margin = new Padding(6);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(323, 72);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(1945, 1038);
            buttonCutLineDetection.Margin = new Padding(6);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(323, 72);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "ImageCutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(1582, 1038);
            buttonCutTraceValidate.Margin = new Padding(6);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(323, 72);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "ImageCutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(1582, 1147);
            buttonPixelMeasure.Margin = new Padding(6);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(323, 72);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(1474, 1349);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(95, 38);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1262, 1353);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(1767, 1349);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(115, 38);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1593, 1353);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2694, 1614);
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
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)startPosition).EndInit();
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
    }
}