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
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)templateImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            SuspendLayout();
            // 
            // StartAllTest
            // 
            StartAllTest.Location = new Point(623, 453);
            StartAllTest.Name = "StartAllTest";
            StartAllTest.Size = new Size(330, 35);
            StartAllTest.TabIndex = 0;
            StartAllTest.Text = "Select DLL...";
            StartAllTest.UseVisualStyleBackColor = true;
            StartAllTest.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(12, 456);
            load_status.Name = "load_status";
            load_status.Size = new Size(42, 15);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(56, 453);
            console.Margin = new Padding(2);
            console.Name = "console";
            console.Size = new Size(503, 299);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(136, 337);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(162, 35);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(623, 339);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(162, 33);
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
            inputImage.Location = new Point(27, 22);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(412, 299);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(478, 22);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(456, 299);
            templateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(971, 22);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(456, 299);
            resultImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(623, 502);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(162, 35);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonMatcher
            // 
            buttonMatcher.Location = new Point(623, 555);
            buttonMatcher.Name = "buttonMatcher";
            buttonMatcher.Size = new Size(162, 35);
            buttonMatcher.TabIndex = 12;
            buttonMatcher.Text = "ImageMatcher";
            buttonMatcher.UseVisualStyleBackColor = true;
            buttonMatcher.Click += buttonMatcher_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(623, 608);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(162, 35);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "ImageFocusQuality";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(623, 661);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(162, 35);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "ImageBrightQuality";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(623, 714);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(162, 35);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "ImageCutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(791, 502);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(162, 35);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "ImageCutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(791, 555);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(162, 35);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 783);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartAllTest;
        private Label load_status;
        private RichTextBox console;
        private string dllPath = "";
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
    }
}