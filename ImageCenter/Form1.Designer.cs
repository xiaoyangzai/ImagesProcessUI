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
            checkIfUniqueTargetInGrain = new Button();
            targetSizeBox = new NumericUpDown();
            AutoGetTarget = new Button();
            negtiveMatch = new Button();
            postiveMatch = new Button();
            GenterateTargetList = new Button();
            moveToLeft = new Button();
            moveToRight = new Button();
            moveDown = new Button();
            moveUp = new Button();
            rotatebutton = new Button();
            moveTargetLeft = new Button();
            targetMoveRight = new Button();
            moveUpTarget = new Button();
            moveTargetDown = new Button();
            label7 = new Label();
            matchSelectedTarget = new Button();
            matchScaleDown = new Button();
            CheckUniqueTargetHigh = new Button();
            targetListForHigh = new Button();
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
            ((System.ComponentModel.ISupportInitialize)targetSizeBox).BeginInit();
            SuspendLayout();
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
            console.Margin = new Padding(4);
            console.Name = "console";
            console.Size = new Size(788, 389);
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
            selectTarget.Location = new Point(1064, 698);
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
            inputImage.SizeMode = PictureBoxSizeMode.Zoom;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(1114, 476);
            templateImage.Margin = new Padding(6, 5, 6, 5);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(260, 188);
            templateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(1572, 46);
            resultImage.Margin = new Padding(6, 5, 6, 5);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(912, 618);
            resultImage.SizeMode = PictureBoxSizeMode.Zoom;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(906, 810);
            buttonRotateDegree.Margin = new Padding(6, 5, 6, 5);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(361, 71);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(968, 1131);
            buttonFocusQuality.Margin = new Padding(6, 5, 6, 5);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(258, 71);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(1268, 1131);
            buttonBrightQuality.Margin = new Padding(6, 5, 6, 5);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(252, 71);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(1884, 1042);
            buttonCutLineDetection.Margin = new Padding(6, 5, 6, 5);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(252, 71);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "CutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(1884, 813);
            buttonCutTraceValidate.Margin = new Padding(6, 5, 6, 5);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(252, 71);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "CutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(1292, 1021);
            buttonPixelMeasure.Margin = new Padding(6, 5, 6, 5);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(252, 71);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(1196, 1224);
            maxValue.Margin = new Padding(4);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(96, 38);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(984, 1227);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(1502, 1224);
            startPosition.Margin = new Padding(4);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(80, 38);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1334, 1227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // adjustStep
            // 
            adjustStep.Location = new Point(1744, 1224);
            adjustStep.Margin = new Padding(6, 5, 6, 5);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(72, 38);
            adjustStep.TabIndex = 22;
            adjustStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1628, 1227);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 23;
            label3.Text = "搜索Step";
            // 
            // saveReusltImage
            // 
            saveReusltImage.Location = new Point(1904, 700);
            saveReusltImage.Margin = new Padding(6, 5, 6, 5);
            saveReusltImage.Name = "saveReusltImage";
            saveReusltImage.Size = new Size(324, 67);
            saveReusltImage.TabIndex = 24;
            saveReusltImage.Text = "save";
            saveReusltImage.UseVisualStyleBackColor = true;
            saveReusltImage.Click += saveReusltImage_Click;
            // 
            // cutCenterLocY
            // 
            cutCenterLocY.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocY.Location = new Point(2040, 916);
            cutCenterLocY.Margin = new Padding(6, 5, 6, 5);
            cutCenterLocY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocY.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocY.Name = "cutCenterLocY";
            cutCenterLocY.Size = new Size(96, 38);
            cutCenterLocY.TabIndex = 25;
            cutCenterLocY.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocY.ValueChanged += cutCenterLocY_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1884, 920);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 31);
            label4.TabIndex = 26;
            label4.Text = "切割道中心Y";
            // 
            // cutLineWidth
            // 
            cutLineWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            cutLineWidth.Location = new Point(2040, 995);
            cutLineWidth.Margin = new Padding(6, 5, 6, 5);
            cutLineWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cutLineWidth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.Name = "cutLineWidth";
            cutLineWidth.Size = new Size(96, 38);
            cutLineWidth.TabIndex = 27;
            cutLineWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.ValueChanged += cutLineWidth_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1884, 996);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 31);
            label5.TabIndex = 28;
            label5.Text = "切割道宽度";
            // 
            // cutCenterValidate
            // 
            cutCenterValidate.Location = new Point(1572, 1129);
            cutCenterValidate.Margin = new Padding(6, 5, 6, 5);
            cutCenterValidate.Name = "cutCenterValidate";
            cutCenterValidate.Size = new Size(148, 71);
            cutCenterValidate.TabIndex = 29;
            cutCenterValidate.Text = "CutCenterValidate";
            cutCenterValidate.UseVisualStyleBackColor = true;
            cutCenterValidate.Click += cutCenterValidate_Click;
            // 
            // retryTimes
            // 
            retryTimes.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            retryTimes.Location = new Point(1728, 1149);
            retryTimes.Margin = new Padding(6, 5, 6, 5);
            retryTimes.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            retryTimes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryTimes.Name = "retryTimes";
            retryTimes.Size = new Size(96, 38);
            retryTimes.TabIndex = 30;
            retryTimes.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // detectLowCrossroad
            // 
            detectLowCrossroad.Location = new Point(1292, 813);
            detectLowCrossroad.Margin = new Padding(6, 5, 6, 5);
            detectLowCrossroad.Name = "detectLowCrossroad";
            detectLowCrossroad.Size = new Size(252, 68);
            detectLowCrossroad.TabIndex = 31;
            detectLowCrossroad.Text = "LowCrossroad";
            detectLowCrossroad.UseVisualStyleBackColor = true;
            detectLowCrossroad.Click += detectLowCrossroad_Click;
            // 
            // detectHighCrossroad
            // 
            detectHighCrossroad.Location = new Point(1572, 813);
            detectHighCrossroad.Margin = new Padding(6, 5, 6, 5);
            detectHighCrossroad.Name = "detectHighCrossroad";
            detectHighCrossroad.Size = new Size(252, 71);
            detectHighCrossroad.TabIndex = 32;
            detectHighCrossroad.Text = "HighCrossroad";
            detectHighCrossroad.UseVisualStyleBackColor = true;
            detectHighCrossroad.Click += detectHighCrossroad_Click;
            // 
            // checkGrainExist
            // 
            checkGrainExist.Location = new Point(1572, 1021);
            checkGrainExist.Margin = new Padding(6, 5, 6, 5);
            checkGrainExist.Name = "checkGrainExist";
            checkGrainExist.Size = new Size(252, 71);
            checkGrainExist.TabIndex = 33;
            checkGrainExist.Text = "IfHasGrain";
            checkGrainExist.UseVisualStyleBackColor = true;
            checkGrainExist.Click += checkGrainExist_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1884, 962);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 31);
            label6.TabIndex = 35;
            label6.Text = "切割道中心X";
            // 
            // cutCenterLocX
            // 
            cutCenterLocX.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocX.Location = new Point(2040, 958);
            cutCenterLocX.Margin = new Padding(6, 5, 6, 5);
            cutCenterLocX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocX.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocX.Name = "cutCenterLocX";
            cutCenterLocX.Size = new Size(96, 38);
            cutCenterLocX.TabIndex = 34;
            cutCenterLocX.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocX.ValueChanged += cutCenterLocX_ValueChanged;
            // 
            // CheckifCutTrace
            // 
            CheckifCutTrace.Location = new Point(1884, 1117);
            CheckifCutTrace.Margin = new Padding(6, 5, 6, 5);
            CheckifCutTrace.Name = "CheckifCutTrace";
            CheckifCutTrace.Size = new Size(252, 71);
            CheckifCutTrace.TabIndex = 36;
            CheckifCutTrace.Text = "CheckifCutTrace";
            CheckifCutTrace.UseVisualStyleBackColor = true;
            CheckifCutTrace.Click += CheckifCutTrace_Click;
            // 
            // edgeDetection
            // 
            edgeDetection.Location = new Point(2180, 810);
            edgeDetection.Margin = new Padding(6, 5, 6, 5);
            edgeDetection.Name = "edgeDetection";
            edgeDetection.Size = new Size(319, 71);
            edgeDetection.TabIndex = 37;
            edgeDetection.Text = "ChipEdgeDetect";
            edgeDetection.UseVisualStyleBackColor = true;
            edgeDetection.Click += edgeDetection_Click;
            // 
            // checkIfUniqueTargetInGrain
            // 
            checkIfUniqueTargetInGrain.Location = new Point(2180, 1042);
            checkIfUniqueTargetInGrain.Margin = new Padding(6, 5, 6, 5);
            checkIfUniqueTargetInGrain.Name = "checkIfUniqueTargetInGrain";
            checkIfUniqueTargetInGrain.Size = new Size(319, 71);
            checkIfUniqueTargetInGrain.TabIndex = 38;
            checkIfUniqueTargetInGrain.Text = "CheckUnqiueTargetGrain";
            checkIfUniqueTargetInGrain.UseVisualStyleBackColor = true;
            checkIfUniqueTargetInGrain.Click += checkIfUniqueTargetInGrain_Click;
            // 
            // targetSizeBox
            // 
            targetSizeBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Location = new Point(2299, 996);
            targetSizeBox.Margin = new Padding(6, 5, 6, 5);
            targetSizeBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetSizeBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Name = "targetSizeBox";
            targetSizeBox.Size = new Size(185, 38);
            targetSizeBox.TabIndex = 39;
            targetSizeBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
            targetSizeBox.ValueChanged += targetSizeBox_ValueChanged;
            // 
            // AutoGetTarget
            // 
            AutoGetTarget.Location = new Point(2180, 909);
            AutoGetTarget.Margin = new Padding(6, 5, 6, 5);
            AutoGetTarget.Name = "AutoGetTarget";
            AutoGetTarget.Size = new Size(319, 48);
            AutoGetTarget.TabIndex = 41;
            AutoGetTarget.Text = "AutoGetUniqueTarget";
            AutoGetTarget.UseVisualStyleBackColor = true;
            AutoGetTarget.Click += AutoGetTarget_Click;
            // 
            // negtiveMatch
            // 
            negtiveMatch.Location = new Point(985, 1070);
            negtiveMatch.Margin = new Padding(6, 5, 6, 5);
            negtiveMatch.Name = "negtiveMatch";
            negtiveMatch.Size = new Size(73, 51);
            negtiveMatch.TabIndex = 42;
            negtiveMatch.Text = "-5°";
            negtiveMatch.UseVisualStyleBackColor = true;
            negtiveMatch.Click += negtiveMatch_Click;
            // 
            // postiveMatch
            // 
            postiveMatch.Location = new Point(893, 1070);
            postiveMatch.Margin = new Padding(6, 5, 6, 5);
            postiveMatch.Name = "postiveMatch";
            postiveMatch.Size = new Size(80, 51);
            postiveMatch.TabIndex = 43;
            postiveMatch.Text = "+5°";
            postiveMatch.UseVisualStyleBackColor = true;
            postiveMatch.Click += postiveMatch_Click;
            // 
            // GenterateTargetList
            // 
            GenterateTargetList.Location = new Point(1292, 891);
            GenterateTargetList.Margin = new Padding(6, 5, 6, 5);
            GenterateTargetList.Name = "GenterateTargetList";
            GenterateTargetList.Size = new Size(252, 68);
            GenterateTargetList.TabIndex = 44;
            GenterateTargetList.Text = "LowTargetsList";
            GenterateTargetList.UseVisualStyleBackColor = true;
            GenterateTargetList.Click += GenterateTargetList_Click;
            // 
            // moveToLeft
            // 
            moveToLeft.Location = new Point(893, 880);
            moveToLeft.Margin = new Padding(6, 5, 6, 5);
            moveToLeft.Name = "moveToLeft";
            moveToLeft.Size = new Size(113, 52);
            moveToLeft.TabIndex = 45;
            moveToLeft.Text = "左移100";
            moveToLeft.UseVisualStyleBackColor = true;
            moveToLeft.Click += moveToLeft_Click;
            // 
            // moveToRight
            // 
            moveToRight.Location = new Point(1156, 879);
            moveToRight.Margin = new Padding(6, 5, 6, 5);
            moveToRight.Name = "moveToRight";
            moveToRight.Size = new Size(113, 53);
            moveToRight.TabIndex = 46;
            moveToRight.Text = "右移100";
            moveToRight.UseVisualStyleBackColor = true;
            moveToRight.Click += moveToRight_Click;
            // 
            // moveDown
            // 
            moveDown.Location = new Point(1154, 1006);
            moveDown.Margin = new Padding(6, 5, 6, 5);
            moveDown.Name = "moveDown";
            moveDown.Size = new Size(113, 53);
            moveDown.TabIndex = 47;
            moveDown.Text = "下移100";
            moveDown.UseVisualStyleBackColor = true;
            moveDown.Click += moveDown_Click;
            // 
            // moveUp
            // 
            moveUp.Location = new Point(893, 1006);
            moveUp.Margin = new Padding(6, 5, 6, 5);
            moveUp.Name = "moveUp";
            moveUp.Size = new Size(113, 53);
            moveUp.TabIndex = 48;
            moveUp.Text = "上移100";
            moveUp.UseVisualStyleBackColor = true;
            moveUp.Click += moveUp_Click;
            // 
            // rotatebutton
            // 
            rotatebutton.Location = new Point(1070, 1070);
            rotatebutton.Margin = new Padding(6, 5, 6, 5);
            rotatebutton.Name = "rotatebutton";
            rotatebutton.Size = new Size(90, 51);
            rotatebutton.TabIndex = 49;
            rotatebutton.Text = "+0.1°";
            rotatebutton.UseVisualStyleBackColor = true;
            rotatebutton.Click += rotatebutton_Click;
            // 
            // moveTargetLeft
            // 
            moveTargetLeft.Location = new Point(893, 943);
            moveTargetLeft.Margin = new Padding(6, 5, 6, 5);
            moveTargetLeft.Name = "moveTargetLeft";
            moveTargetLeft.Size = new Size(126, 53);
            moveTargetLeft.TabIndex = 50;
            moveTargetLeft.Text = "目标左移";
            moveTargetLeft.UseVisualStyleBackColor = true;
            moveTargetLeft.Click += moveTargetLeft_Click;
            // 
            // targetMoveRight
            // 
            targetMoveRight.Location = new Point(1140, 943);
            targetMoveRight.Margin = new Padding(6, 5, 6, 5);
            targetMoveRight.Name = "targetMoveRight";
            targetMoveRight.Size = new Size(129, 53);
            targetMoveRight.TabIndex = 51;
            targetMoveRight.Text = "目标右移";
            targetMoveRight.UseVisualStyleBackColor = true;
            targetMoveRight.Click += targetMoveRight_Click;
            // 
            // moveUpTarget
            // 
            moveUpTarget.Location = new Point(1015, 880);
            moveUpTarget.Margin = new Padding(6, 5, 6, 5);
            moveUpTarget.Name = "moveUpTarget";
            moveUpTarget.Size = new Size(129, 53);
            moveUpTarget.TabIndex = 52;
            moveUpTarget.Text = "目标上移";
            moveUpTarget.UseVisualStyleBackColor = true;
            moveUpTarget.Click += moveUpTarget_Click;
            // 
            // moveTargetDown
            // 
            moveTargetDown.Location = new Point(1015, 1006);
            moveTargetDown.Margin = new Padding(6, 5, 6, 5);
            moveTargetDown.Name = "moveTargetDown";
            moveTargetDown.Size = new Size(129, 53);
            moveTargetDown.TabIndex = 53;
            moveTargetDown.Text = "目标下移";
            moveTargetDown.UseVisualStyleBackColor = true;
            moveTargetDown.Click += moveTargetDown_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2180, 998);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 54;
            label7.Text = "目标大小";
            // 
            // matchSelectedTarget
            // 
            matchSelectedTarget.Location = new Point(1015, 943);
            matchSelectedTarget.Margin = new Padding(6, 5, 6, 5);
            matchSelectedTarget.Name = "matchSelectedTarget";
            matchSelectedTarget.Size = new Size(129, 53);
            matchSelectedTarget.TabIndex = 55;
            matchSelectedTarget.Text = "目标匹配";
            matchSelectedTarget.UseVisualStyleBackColor = true;
            matchSelectedTarget.Click += matchSelectedTarget_Click;
            // 
            // matchScaleDown
            // 
            matchScaleDown.Location = new Point(1172, 1070);
            matchScaleDown.Margin = new Padding(6, 5, 6, 5);
            matchScaleDown.Name = "matchScaleDown";
            matchScaleDown.Size = new Size(95, 51);
            matchScaleDown.TabIndex = 56;
            matchScaleDown.Text = "缩略";
            matchScaleDown.UseVisualStyleBackColor = true;
            matchScaleDown.Click += matchScaleDown_Click;
            // 
            // CheckUniqueTargetHigh
            // 
            CheckUniqueTargetHigh.Location = new Point(2180, 1121);
            CheckUniqueTargetHigh.Margin = new Padding(6, 5, 6, 5);
            CheckUniqueTargetHigh.Name = "CheckUniqueTargetHigh";
            CheckUniqueTargetHigh.Size = new Size(319, 71);
            CheckUniqueTargetHigh.TabIndex = 57;
            CheckUniqueTargetHigh.Text = "CheckUnqiueTargetHigh";
            CheckUniqueTargetHigh.UseVisualStyleBackColor = true;
            CheckUniqueTargetHigh.Click += CheckUniqueTargetHigh_Click;
            // 
            // targetListForHigh
            // 
            targetListForHigh.Location = new Point(1572, 891);
            targetListForHigh.Margin = new Padding(6, 5, 6, 5);
            targetListForHigh.Name = "targetListForHigh";
            targetListForHigh.Size = new Size(252, 68);
            targetListForHigh.TabIndex = 59;
            targetListForHigh.Text = "HighTargetsList";
            targetListForHigh.UseVisualStyleBackColor = true;
            targetListForHigh.Click += targetListForHigh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2514, 1399);
            Controls.Add(targetListForHigh);
            Controls.Add(CheckUniqueTargetHigh);
            Controls.Add(matchScaleDown);
            Controls.Add(matchSelectedTarget);
            Controls.Add(label7);
            Controls.Add(moveTargetDown);
            Controls.Add(moveUpTarget);
            Controls.Add(targetMoveRight);
            Controls.Add(moveTargetLeft);
            Controls.Add(rotatebutton);
            Controls.Add(moveUp);
            Controls.Add(moveDown);
            Controls.Add(moveToRight);
            Controls.Add(moveToLeft);
            Controls.Add(GenterateTargetList);
            Controls.Add(postiveMatch);
            Controls.Add(negtiveMatch);
            Controls.Add(AutoGetTarget);
            Controls.Add(targetSizeBox);
            Controls.Add(checkIfUniqueTargetInGrain);
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
            Controls.Add(buttonRotateDegree);
            Controls.Add(resultImage);
            Controls.Add(templateImage);
            Controls.Add(inputImage);
            Controls.Add(selectTarget);
            Controls.Add(selectImage);
            Controls.Add(console);
            Controls.Add(load_status);
            Margin = new Padding(6, 5, 6, 5);
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
            ((System.ComponentModel.ISupportInitialize)targetSizeBox).EndInit();
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
        double scaleX = 1.0;
        double scaleY = 1.0;
        Point targetPos;
        int currentTargetX = 0;
        int currentTargetY = 0;
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
        private Button checkIfUniqueTargetInGrain;
        private NumericUpDown targetSizeBox;
        private Button AutoGetTarget;
        private Button negtiveMatch;
        private Button postiveMatch;
        private Button GenterateTargetList;
        private Button moveToLeft;
        private Button moveToRight;
        private Button moveDown;
        private Button moveUp;
        private Button rotatebutton;
        private Button moveTargetLeft;
        private Button targetMoveRight;
        private Button moveUpTarget;
        private Button moveTargetDown;
        private Label label7;
        private Button matchSelectedTarget;
        private Button matchScaleDown;
        private Button CheckUniqueTargetHigh;
        private Button targetListForHigh;
    }
}