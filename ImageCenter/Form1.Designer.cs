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
            targetLocXBox = new NumericUpDown();
            targetLocYBox = new NumericUpDown();
            label8 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)targetLocXBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetLocYBox).BeginInit();
            SuspendLayout();
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(-4, 394);
            load_status.Name = "load_status";
            load_status.Size = new Size(42, 15);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            // 
            // console
            // 
            console.Location = new Point(46, 392);
            console.Margin = new Padding(2);
            console.Name = "console";
            console.Size = new Size(396, 190);
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
            selectImage.Margin = new Padding(3, 2, 3, 2);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(162, 34);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(532, 338);
            selectTarget.Margin = new Padding(3, 2, 3, 2);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(162, 32);
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
            inputImage.Location = new Point(28, 22);
            inputImage.Margin = new Padding(3, 2, 3, 2);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(412, 299);
            inputImage.SizeMode = PictureBoxSizeMode.Zoom;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(557, 230);
            templateImage.Margin = new Padding(3, 2, 3, 2);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(130, 91);
            templateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(786, 22);
            resultImage.Margin = new Padding(3, 2, 3, 2);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(456, 299);
            resultImage.SizeMode = PictureBoxSizeMode.Zoom;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(453, 392);
            buttonRotateDegree.Margin = new Padding(3, 2, 3, 2);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(181, 34);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(646, 507);
            buttonFocusQuality.Margin = new Padding(3, 2, 3, 2);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(126, 31);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(646, 547);
            buttonBrightQuality.Margin = new Padding(3, 2, 3, 2);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(126, 34);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(942, 504);
            buttonCutLineDetection.Margin = new Padding(3, 2, 3, 2);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(126, 34);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "CutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(942, 394);
            buttonCutTraceValidate.Margin = new Padding(3, 2, 3, 2);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(126, 34);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "CutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(646, 468);
            buttonPixelMeasure.Margin = new Padding(3, 2, 3, 2);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(126, 29);
            buttonPixelMeasure.TabIndex = 17;
            buttonPixelMeasure.Text = "ImagePixelMeasure";
            buttonPixelMeasure.UseVisualStyleBackColor = true;
            buttonPixelMeasure.Click += buttonPixelMeasure_Click;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(598, 592);
            maxValue.Margin = new Padding(2);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(48, 23);
            maxValue.TabIndex = 18;
            maxValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 594);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 19;
            label1.Text = "焦距/光亮最大值";
            // 
            // startPosition
            // 
            startPosition.Location = new Point(751, 592);
            startPosition.Margin = new Padding(2);
            startPosition.Name = "startPosition";
            startPosition.Size = new Size(40, 23);
            startPosition.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 594);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 21;
            label2.Text = "搜索起始位置";
            // 
            // adjustStep
            // 
            adjustStep.Location = new Point(872, 592);
            adjustStep.Margin = new Padding(3, 2, 3, 2);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(36, 23);
            adjustStep.TabIndex = 22;
            adjustStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(814, 594);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 23;
            label3.Text = "搜索Step";
            // 
            // saveReusltImage
            // 
            saveReusltImage.Location = new Point(952, 339);
            saveReusltImage.Margin = new Padding(3, 2, 3, 2);
            saveReusltImage.Name = "saveReusltImage";
            saveReusltImage.Size = new Size(162, 32);
            saveReusltImage.TabIndex = 24;
            saveReusltImage.Text = "save";
            saveReusltImage.UseVisualStyleBackColor = true;
            saveReusltImage.Click += saveReusltImage_Click;
            // 
            // cutCenterLocY
            // 
            cutCenterLocY.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocY.Location = new Point(1020, 434);
            cutCenterLocY.Margin = new Padding(3, 2, 3, 2);
            cutCenterLocY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocY.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocY.Name = "cutCenterLocY";
            cutCenterLocY.Size = new Size(48, 23);
            cutCenterLocY.TabIndex = 25;
            cutCenterLocY.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocY.ValueChanged += cutCenterLocY_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(942, 436);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 26;
            label4.Text = "切割道中心Y";
            // 
            // cutLineWidth
            // 
            cutLineWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            cutLineWidth.Location = new Point(1020, 481);
            cutLineWidth.Margin = new Padding(3, 2, 3, 2);
            cutLineWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cutLineWidth.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            cutLineWidth.Name = "cutLineWidth";
            cutLineWidth.Size = new Size(48, 23);
            cutLineWidth.TabIndex = 27;
            cutLineWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.ValueChanged += cutLineWidth_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(942, 482);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 28;
            label5.Text = "切割道宽度";
            // 
            // cutCenterValidate
            // 
            cutCenterValidate.Location = new Point(786, 511);
            cutCenterValidate.Margin = new Padding(3, 2, 3, 2);
            cutCenterValidate.Name = "cutCenterValidate";
            cutCenterValidate.Size = new Size(74, 29);
            cutCenterValidate.TabIndex = 29;
            cutCenterValidate.Text = "CutCenterValidate";
            cutCenterValidate.UseVisualStyleBackColor = true;
            cutCenterValidate.Click += cutCenterValidate_Click;
            // 
            // retryTimes
            // 
            retryTimes.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            retryTimes.Location = new Point(864, 515);
            retryTimes.Margin = new Padding(3, 2, 3, 2);
            retryTimes.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            retryTimes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryTimes.Name = "retryTimes";
            retryTimes.Size = new Size(48, 23);
            retryTimes.TabIndex = 30;
            retryTimes.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // detectLowCrossroad
            // 
            detectLowCrossroad.Location = new Point(646, 394);
            detectLowCrossroad.Margin = new Padding(3, 2, 3, 2);
            detectLowCrossroad.Name = "detectLowCrossroad";
            detectLowCrossroad.Size = new Size(126, 33);
            detectLowCrossroad.TabIndex = 31;
            detectLowCrossroad.Text = "LowCrossroad";
            detectLowCrossroad.UseVisualStyleBackColor = true;
            detectLowCrossroad.Click += detectLowCrossroad_Click;
            // 
            // detectHighCrossroad
            // 
            detectHighCrossroad.Location = new Point(786, 394);
            detectHighCrossroad.Margin = new Padding(3, 2, 3, 2);
            detectHighCrossroad.Name = "detectHighCrossroad";
            detectHighCrossroad.Size = new Size(126, 34);
            detectHighCrossroad.TabIndex = 32;
            detectHighCrossroad.Text = "HighCrossroad";
            detectHighCrossroad.UseVisualStyleBackColor = true;
            detectHighCrossroad.Click += detectHighCrossroad_Click;
            // 
            // checkGrainExist
            // 
            checkGrainExist.Location = new Point(786, 470);
            checkGrainExist.Margin = new Padding(3, 2, 3, 2);
            checkGrainExist.Name = "checkGrainExist";
            checkGrainExist.Size = new Size(126, 27);
            checkGrainExist.TabIndex = 33;
            checkGrainExist.Text = "IfHasGrain";
            checkGrainExist.UseVisualStyleBackColor = true;
            checkGrainExist.Click += checkGrainExist_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(942, 460);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 35;
            label6.Text = "切割道中心X";
            // 
            // cutCenterLocX
            // 
            cutCenterLocX.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocX.Location = new Point(1020, 458);
            cutCenterLocX.Margin = new Padding(3, 2, 3, 2);
            cutCenterLocX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocX.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocX.Name = "cutCenterLocX";
            cutCenterLocX.Size = new Size(48, 23);
            cutCenterLocX.TabIndex = 34;
            cutCenterLocX.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocX.ValueChanged += cutCenterLocX_ValueChanged;
            // 
            // CheckifCutTrace
            // 
            CheckifCutTrace.Location = new Point(942, 541);
            CheckifCutTrace.Margin = new Padding(3, 2, 3, 2);
            CheckifCutTrace.Name = "CheckifCutTrace";
            CheckifCutTrace.Size = new Size(126, 34);
            CheckifCutTrace.TabIndex = 36;
            CheckifCutTrace.Text = "CheckifCutTrace";
            CheckifCutTrace.UseVisualStyleBackColor = true;
            CheckifCutTrace.Click += CheckifCutTrace_Click;
            // 
            // edgeDetection
            // 
            edgeDetection.Location = new Point(1090, 392);
            edgeDetection.Margin = new Padding(3, 2, 3, 2);
            edgeDetection.Name = "edgeDetection";
            edgeDetection.Size = new Size(160, 34);
            edgeDetection.TabIndex = 37;
            edgeDetection.Text = "ChipEdgeDetect";
            edgeDetection.UseVisualStyleBackColor = true;
            edgeDetection.Click += edgeDetection_Click;
            // 
            // checkIfUniqueTargetInGrain
            // 
            checkIfUniqueTargetInGrain.Location = new Point(1090, 504);
            checkIfUniqueTargetInGrain.Margin = new Padding(3, 2, 3, 2);
            checkIfUniqueTargetInGrain.Name = "checkIfUniqueTargetInGrain";
            checkIfUniqueTargetInGrain.Size = new Size(160, 34);
            checkIfUniqueTargetInGrain.TabIndex = 38;
            checkIfUniqueTargetInGrain.Text = "CheckUnqiueTargetLow";
            checkIfUniqueTargetInGrain.UseVisualStyleBackColor = true;
            checkIfUniqueTargetInGrain.Click += checkIfUniqueTargetInGrain_Click;
            // 
            // targetSizeBox
            // 
            targetSizeBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Location = new Point(508, 539);
            targetSizeBox.Margin = new Padding(3, 2, 3, 2);
            targetSizeBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetSizeBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Name = "targetSizeBox";
            targetSizeBox.Size = new Size(125, 23);
            targetSizeBox.TabIndex = 39;
            targetSizeBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
            targetSizeBox.ValueChanged += targetSizeBox_ValueChanged;
            // 
            // AutoGetTarget
            // 
            AutoGetTarget.Location = new Point(1090, 431);
            AutoGetTarget.Margin = new Padding(3, 2, 3, 2);
            AutoGetTarget.Name = "AutoGetTarget";
            AutoGetTarget.Size = new Size(160, 28);
            AutoGetTarget.TabIndex = 41;
            AutoGetTarget.Text = "AutoGetUniqueTarget";
            AutoGetTarget.UseVisualStyleBackColor = true;
            AutoGetTarget.Click += AutoGetTarget_Click;
            // 
            // negtiveMatch
            // 
            negtiveMatch.Location = new Point(493, 562);
            negtiveMatch.Margin = new Padding(3, 2, 3, 2);
            negtiveMatch.Name = "negtiveMatch";
            negtiveMatch.Size = new Size(36, 25);
            negtiveMatch.TabIndex = 42;
            negtiveMatch.Text = "-5°";
            negtiveMatch.UseVisualStyleBackColor = true;
            negtiveMatch.Click += negtiveMatch_Click;
            // 
            // postiveMatch
            // 
            postiveMatch.Location = new Point(447, 562);
            postiveMatch.Margin = new Padding(3, 2, 3, 2);
            postiveMatch.Name = "postiveMatch";
            postiveMatch.Size = new Size(40, 25);
            postiveMatch.TabIndex = 43;
            postiveMatch.Text = "+5°";
            postiveMatch.UseVisualStyleBackColor = true;
            postiveMatch.Click += postiveMatch_Click;
            // 
            // GenterateTargetList
            // 
            GenterateTargetList.Location = new Point(646, 431);
            GenterateTargetList.Margin = new Padding(3, 2, 3, 2);
            GenterateTargetList.Name = "GenterateTargetList";
            GenterateTargetList.Size = new Size(126, 33);
            GenterateTargetList.TabIndex = 44;
            GenterateTargetList.Text = "LowTargetsList";
            GenterateTargetList.UseVisualStyleBackColor = true;
            GenterateTargetList.Click += GenterateTargetList_Click;
            // 
            // moveToLeft
            // 
            moveToLeft.Location = new Point(447, 426);
            moveToLeft.Margin = new Padding(3, 2, 3, 2);
            moveToLeft.Name = "moveToLeft";
            moveToLeft.Size = new Size(57, 25);
            moveToLeft.TabIndex = 45;
            moveToLeft.Text = "左移100";
            moveToLeft.UseVisualStyleBackColor = true;
            moveToLeft.Click += moveToLeft_Click;
            // 
            // moveToRight
            // 
            moveToRight.Location = new Point(578, 425);
            moveToRight.Margin = new Padding(3, 2, 3, 2);
            moveToRight.Name = "moveToRight";
            moveToRight.Size = new Size(57, 26);
            moveToRight.TabIndex = 46;
            moveToRight.Text = "右移100";
            moveToRight.UseVisualStyleBackColor = true;
            moveToRight.Click += moveToRight_Click;
            // 
            // moveDown
            // 
            moveDown.Location = new Point(577, 487);
            moveDown.Margin = new Padding(3, 2, 3, 2);
            moveDown.Name = "moveDown";
            moveDown.Size = new Size(57, 26);
            moveDown.TabIndex = 47;
            moveDown.Text = "下移100";
            moveDown.UseVisualStyleBackColor = true;
            moveDown.Click += moveDown_Click;
            // 
            // moveUp
            // 
            moveUp.Location = new Point(447, 487);
            moveUp.Margin = new Padding(3, 2, 3, 2);
            moveUp.Name = "moveUp";
            moveUp.Size = new Size(57, 26);
            moveUp.TabIndex = 48;
            moveUp.Text = "上移100";
            moveUp.UseVisualStyleBackColor = true;
            moveUp.Click += moveUp_Click;
            // 
            // rotatebutton
            // 
            rotatebutton.Location = new Point(535, 562);
            rotatebutton.Margin = new Padding(3, 2, 3, 2);
            rotatebutton.Name = "rotatebutton";
            rotatebutton.Size = new Size(45, 25);
            rotatebutton.TabIndex = 49;
            rotatebutton.Text = "+0.1°";
            rotatebutton.UseVisualStyleBackColor = true;
            rotatebutton.Click += rotatebutton_Click;
            // 
            // moveTargetLeft
            // 
            moveTargetLeft.Location = new Point(447, 456);
            moveTargetLeft.Margin = new Padding(3, 2, 3, 2);
            moveTargetLeft.Name = "moveTargetLeft";
            moveTargetLeft.Size = new Size(63, 26);
            moveTargetLeft.TabIndex = 50;
            moveTargetLeft.Text = "目标左移";
            moveTargetLeft.UseVisualStyleBackColor = true;
            moveTargetLeft.Click += moveTargetLeft_Click;
            // 
            // targetMoveRight
            // 
            targetMoveRight.Location = new Point(570, 456);
            targetMoveRight.Margin = new Padding(3, 2, 3, 2);
            targetMoveRight.Name = "targetMoveRight";
            targetMoveRight.Size = new Size(64, 26);
            targetMoveRight.TabIndex = 51;
            targetMoveRight.Text = "目标右移";
            targetMoveRight.UseVisualStyleBackColor = true;
            targetMoveRight.Click += targetMoveRight_Click;
            // 
            // moveUpTarget
            // 
            moveUpTarget.Location = new Point(508, 426);
            moveUpTarget.Margin = new Padding(3, 2, 3, 2);
            moveUpTarget.Name = "moveUpTarget";
            moveUpTarget.Size = new Size(64, 26);
            moveUpTarget.TabIndex = 52;
            moveUpTarget.Text = "目标上移";
            moveUpTarget.UseVisualStyleBackColor = true;
            moveUpTarget.Click += moveUpTarget_Click;
            // 
            // moveTargetDown
            // 
            moveTargetDown.Location = new Point(508, 487);
            moveTargetDown.Margin = new Padding(3, 2, 3, 2);
            moveTargetDown.Name = "moveTargetDown";
            moveTargetDown.Size = new Size(64, 26);
            moveTargetDown.TabIndex = 53;
            moveTargetDown.Text = "目标下移";
            moveTargetDown.UseVisualStyleBackColor = true;
            moveTargetDown.Click += moveTargetDown_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 541);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 54;
            label7.Text = "目标大小";
            // 
            // matchSelectedTarget
            // 
            matchSelectedTarget.Location = new Point(508, 456);
            matchSelectedTarget.Margin = new Padding(3, 2, 3, 2);
            matchSelectedTarget.Name = "matchSelectedTarget";
            matchSelectedTarget.Size = new Size(64, 26);
            matchSelectedTarget.TabIndex = 55;
            matchSelectedTarget.Text = "目标匹配";
            matchSelectedTarget.UseVisualStyleBackColor = true;
            matchSelectedTarget.Click += matchSelectedTarget_Click;
            // 
            // matchScaleDown
            // 
            matchScaleDown.Location = new Point(586, 562);
            matchScaleDown.Margin = new Padding(3, 2, 3, 2);
            matchScaleDown.Name = "matchScaleDown";
            matchScaleDown.Size = new Size(48, 25);
            matchScaleDown.TabIndex = 56;
            matchScaleDown.Text = "缩略";
            matchScaleDown.UseVisualStyleBackColor = true;
            matchScaleDown.Click += matchScaleDown_Click;
            // 
            // CheckUniqueTargetHigh
            // 
            CheckUniqueTargetHigh.Location = new Point(1090, 542);
            CheckUniqueTargetHigh.Margin = new Padding(3, 2, 3, 2);
            CheckUniqueTargetHigh.Name = "CheckUniqueTargetHigh";
            CheckUniqueTargetHigh.Size = new Size(160, 34);
            CheckUniqueTargetHigh.TabIndex = 57;
            CheckUniqueTargetHigh.Text = "CheckUnqiueTargetHigh";
            CheckUniqueTargetHigh.UseVisualStyleBackColor = true;
            CheckUniqueTargetHigh.Click += CheckUniqueTargetHigh_Click;
            // 
            // targetListForHigh
            // 
            targetListForHigh.Location = new Point(786, 431);
            targetListForHigh.Margin = new Padding(3, 2, 3, 2);
            targetListForHigh.Name = "targetListForHigh";
            targetListForHigh.Size = new Size(126, 33);
            targetListForHigh.TabIndex = 59;
            targetListForHigh.Text = "HighTargetsList";
            targetListForHigh.UseVisualStyleBackColor = true;
            targetListForHigh.Click += targetListForHigh_Click;
            // 
            // targetLocXBox
            // 
            targetLocXBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetLocXBox.Location = new Point(509, 513);
            targetLocXBox.Margin = new Padding(2);
            targetLocXBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetLocXBox.Name = "targetLocXBox";
            targetLocXBox.Size = new Size(63, 23);
            targetLocXBox.TabIndex = 61;
            targetLocXBox.Value = new decimal(new int[] { 50, 0, 0, 0 });
            targetLocXBox.ValueChanged += targetLocXBox_ValueChanged;
            // 
            // targetLocYBox
            // 
            targetLocYBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetLocYBox.Location = new Point(578, 513);
            targetLocYBox.Margin = new Padding(2);
            targetLocYBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetLocYBox.Name = "targetLocYBox";
            targetLocYBox.Size = new Size(55, 23);
            targetLocYBox.TabIndex = 62;
            targetLocYBox.Value = new decimal(new int[] { 50, 0, 0, 0 });
            targetLocYBox.ValueChanged += targetLocYBox_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(449, 515);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 63;
            label8.Text = "目标位置";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1270, 629);
            Controls.Add(label8);
            Controls.Add(targetLocYBox);
            Controls.Add(targetLocXBox);
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
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)targetLocXBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetLocYBox).EndInit();
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
        bool isAutoGetUniqueTarget = false;
        int autoUniqueTargetSize = -1;
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
        private NumericUpDown targetLocXBox;
        private NumericUpDown targetLocYBox;
        private Label label8;
    }
}