﻿namespace ImageCenter
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
            label9 = new Label();
            Mask_ABox = new NumericUpDown();
            label10 = new Label();
            Mask_bBox = new NumericUpDown();
            label11 = new Label();
            PixelSizeBox = new NumericUpDown();
            label12 = new Label();
            ScopeXWidthBox = new NumericUpDown();
            label13 = new Label();
            BladeWidthBox = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)Mask_ABox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mask_bBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PixelSizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScopeXWidthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BladeWidthBox).BeginInit();
            SuspendLayout();
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(-6, 657);
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
            selectImage.Margin = new Padding(4, 3, 4, 3);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(231, 57);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select input Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(760, 563);
            selectTarget.Margin = new Padding(4, 3, 4, 3);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(231, 53);
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
            inputImage.Margin = new Padding(4, 3, 4, 3);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(589, 498);
            inputImage.SizeMode = PictureBoxSizeMode.Zoom;
            inputImage.TabIndex = 8;
            inputImage.TabStop = false;
            // 
            // templateImage
            // 
            templateImage.Location = new Point(796, 383);
            templateImage.Margin = new Padding(4, 3, 4, 3);
            templateImage.Name = "templateImage";
            templateImage.Size = new Size(186, 152);
            templateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            templateImage.TabIndex = 9;
            templateImage.TabStop = false;
            // 
            // resultImage
            // 
            resultImage.Location = new Point(1123, 37);
            resultImage.Margin = new Padding(4, 3, 4, 3);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(651, 498);
            resultImage.SizeMode = PictureBoxSizeMode.Zoom;
            resultImage.TabIndex = 10;
            resultImage.TabStop = false;
            // 
            // buttonRotateDegree
            // 
            buttonRotateDegree.Location = new Point(647, 653);
            buttonRotateDegree.Margin = new Padding(4, 3, 4, 3);
            buttonRotateDegree.Name = "buttonRotateDegree";
            buttonRotateDegree.Size = new Size(259, 57);
            buttonRotateDegree.TabIndex = 11;
            buttonRotateDegree.Text = "ImageRotateDegree";
            buttonRotateDegree.UseVisualStyleBackColor = true;
            buttonRotateDegree.Click += buttonRotateDegree_Click;
            // 
            // buttonFocusQuality
            // 
            buttonFocusQuality.Location = new Point(923, 845);
            buttonFocusQuality.Margin = new Padding(4, 3, 4, 3);
            buttonFocusQuality.Name = "buttonFocusQuality";
            buttonFocusQuality.Size = new Size(180, 52);
            buttonFocusQuality.TabIndex = 13;
            buttonFocusQuality.Text = "AutoFocus";
            buttonFocusQuality.UseVisualStyleBackColor = true;
            buttonFocusQuality.Click += buttonFocusQuality_Click;
            // 
            // buttonBrightQuality
            // 
            buttonBrightQuality.Location = new Point(923, 912);
            buttonBrightQuality.Margin = new Padding(4, 3, 4, 3);
            buttonBrightQuality.Name = "buttonBrightQuality";
            buttonBrightQuality.Size = new Size(180, 57);
            buttonBrightQuality.TabIndex = 14;
            buttonBrightQuality.Text = "AutoBright";
            buttonBrightQuality.UseVisualStyleBackColor = true;
            buttonBrightQuality.Click += buttonBrightQuality_Click;
            // 
            // buttonCutLineDetection
            // 
            buttonCutLineDetection.Location = new Point(1557, 893);
            buttonCutLineDetection.Margin = new Padding(4, 3, 4, 3);
            buttonCutLineDetection.Name = "buttonCutLineDetection";
            buttonCutLineDetection.Size = new Size(229, 43);
            buttonCutLineDetection.TabIndex = 15;
            buttonCutLineDetection.Text = "CutLineDetection";
            buttonCutLineDetection.UseVisualStyleBackColor = true;
            buttonCutLineDetection.Click += buttonCutLineDetection_Click;
            // 
            // buttonCutTraceValidate
            // 
            buttonCutTraceValidate.Location = new Point(1346, 657);
            buttonCutTraceValidate.Margin = new Padding(4, 3, 4, 3);
            buttonCutTraceValidate.Name = "buttonCutTraceValidate";
            buttonCutTraceValidate.Size = new Size(180, 57);
            buttonCutTraceValidate.TabIndex = 16;
            buttonCutTraceValidate.Text = "CutTraceValidate";
            buttonCutTraceValidate.UseVisualStyleBackColor = true;
            buttonCutTraceValidate.Click += buttonCutTraceValidate_Click;
            // 
            // buttonPixelMeasure
            // 
            buttonPixelMeasure.Location = new Point(923, 780);
            buttonPixelMeasure.Margin = new Padding(4, 3, 4, 3);
            buttonPixelMeasure.Name = "buttonPixelMeasure";
            buttonPixelMeasure.Size = new Size(180, 48);
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
            adjustStep.Margin = new Padding(4, 3, 4, 3);
            adjustStep.Name = "adjustStep";
            adjustStep.Size = new Size(51, 31);
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
            saveReusltImage.Location = new Point(1360, 565);
            saveReusltImage.Margin = new Padding(4, 3, 4, 3);
            saveReusltImage.Name = "saveReusltImage";
            saveReusltImage.Size = new Size(231, 53);
            saveReusltImage.TabIndex = 24;
            saveReusltImage.Text = "save";
            saveReusltImage.UseVisualStyleBackColor = true;
            saveReusltImage.Click += saveReusltImage_Click;
            // 
            // cutCenterLocY
            // 
            cutCenterLocY.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocY.Location = new Point(1457, 723);
            cutCenterLocY.Margin = new Padding(4, 3, 4, 3);
            cutCenterLocY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocY.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocY.Name = "cutCenterLocY";
            cutCenterLocY.Size = new Size(69, 31);
            cutCenterLocY.TabIndex = 25;
            cutCenterLocY.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocY.ValueChanged += cutCenterLocY_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1346, 727);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 26;
            label4.Text = "切割道中心Y";
            // 
            // cutLineWidth
            // 
            cutLineWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            cutLineWidth.Location = new Point(1457, 802);
            cutLineWidth.Margin = new Padding(4, 3, 4, 3);
            cutLineWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cutLineWidth.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            cutLineWidth.Name = "cutLineWidth";
            cutLineWidth.Size = new Size(69, 31);
            cutLineWidth.TabIndex = 27;
            cutLineWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
            cutLineWidth.ValueChanged += cutLineWidth_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1346, 803);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 28;
            label5.Text = "切割道宽度";
            // 
            // cutCenterValidate
            // 
            cutCenterValidate.Location = new Point(1123, 852);
            cutCenterValidate.Margin = new Padding(4, 3, 4, 3);
            cutCenterValidate.Name = "cutCenterValidate";
            cutCenterValidate.Size = new Size(106, 48);
            cutCenterValidate.TabIndex = 29;
            cutCenterValidate.Text = "CutCenterValidate";
            cutCenterValidate.UseVisualStyleBackColor = true;
            cutCenterValidate.Click += cutCenterValidate_Click;
            // 
            // retryTimes
            // 
            retryTimes.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            retryTimes.Location = new Point(1234, 858);
            retryTimes.Margin = new Padding(4, 3, 4, 3);
            retryTimes.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            retryTimes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            retryTimes.Name = "retryTimes";
            retryTimes.Size = new Size(69, 31);
            retryTimes.TabIndex = 30;
            retryTimes.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // detectLowCrossroad
            // 
            detectLowCrossroad.Location = new Point(923, 657);
            detectLowCrossroad.Margin = new Padding(4, 3, 4, 3);
            detectLowCrossroad.Name = "detectLowCrossroad";
            detectLowCrossroad.Size = new Size(180, 55);
            detectLowCrossroad.TabIndex = 31;
            detectLowCrossroad.Text = "LowCrossroad";
            detectLowCrossroad.UseVisualStyleBackColor = true;
            detectLowCrossroad.Click += detectLowCrossroad_Click;
            // 
            // detectHighCrossroad
            // 
            detectHighCrossroad.Location = new Point(1123, 657);
            detectHighCrossroad.Margin = new Padding(4, 3, 4, 3);
            detectHighCrossroad.Name = "detectHighCrossroad";
            detectHighCrossroad.Size = new Size(180, 57);
            detectHighCrossroad.TabIndex = 32;
            detectHighCrossroad.Text = "HighCrossroad";
            detectHighCrossroad.UseVisualStyleBackColor = true;
            detectHighCrossroad.Click += detectHighCrossroad_Click;
            // 
            // checkGrainExist
            // 
            checkGrainExist.Location = new Point(1123, 783);
            checkGrainExist.Margin = new Padding(4, 3, 4, 3);
            checkGrainExist.Name = "checkGrainExist";
            checkGrainExist.Size = new Size(180, 45);
            checkGrainExist.TabIndex = 33;
            checkGrainExist.Text = "IfHasGrain";
            checkGrainExist.UseVisualStyleBackColor = true;
            checkGrainExist.Click += checkGrainExist_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1346, 767);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 35;
            label6.Text = "切割道中心X";
            // 
            // cutCenterLocX
            // 
            cutCenterLocX.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            cutCenterLocX.Location = new Point(1457, 763);
            cutCenterLocX.Margin = new Padding(4, 3, 4, 3);
            cutCenterLocX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cutCenterLocX.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            cutCenterLocX.Name = "cutCenterLocX";
            cutCenterLocX.Size = new Size(69, 31);
            cutCenterLocX.TabIndex = 34;
            cutCenterLocX.Value = new decimal(new int[] { 878, 0, 0, 0 });
            cutCenterLocX.ValueChanged += cutCenterLocX_ValueChanged;
            // 
            // CheckifCutTrace
            // 
            CheckifCutTrace.Location = new Point(1123, 912);
            CheckifCutTrace.Margin = new Padding(4, 3, 4, 3);
            CheckifCutTrace.Name = "CheckifCutTrace";
            CheckifCutTrace.Size = new Size(180, 51);
            CheckifCutTrace.TabIndex = 36;
            CheckifCutTrace.Text = "CheckifCutTrace";
            CheckifCutTrace.UseVisualStyleBackColor = true;
            CheckifCutTrace.Click += CheckifCutTrace_Click;
            // 
            // edgeDetection
            // 
            edgeDetection.Location = new Point(1557, 653);
            edgeDetection.Margin = new Padding(4, 3, 4, 3);
            edgeDetection.Name = "edgeDetection";
            edgeDetection.Size = new Size(229, 57);
            edgeDetection.TabIndex = 37;
            edgeDetection.Text = "ChipEdgeDetect";
            edgeDetection.UseVisualStyleBackColor = true;
            edgeDetection.Click += edgeDetection_Click;
            // 
            // checkIfUniqueTargetInGrain
            // 
            checkIfUniqueTargetInGrain.Location = new Point(1557, 780);
            checkIfUniqueTargetInGrain.Margin = new Padding(4, 3, 4, 3);
            checkIfUniqueTargetInGrain.Name = "checkIfUniqueTargetInGrain";
            checkIfUniqueTargetInGrain.Size = new Size(229, 48);
            checkIfUniqueTargetInGrain.TabIndex = 38;
            checkIfUniqueTargetInGrain.Text = "CheckUnqiueTargetLow";
            checkIfUniqueTargetInGrain.UseVisualStyleBackColor = true;
            checkIfUniqueTargetInGrain.Click += checkIfUniqueTargetInGrain_Click;
            // 
            // targetSizeBox
            // 
            targetSizeBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Location = new Point(726, 898);
            targetSizeBox.Margin = new Padding(4, 3, 4, 3);
            targetSizeBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetSizeBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            targetSizeBox.Name = "targetSizeBox";
            targetSizeBox.Size = new Size(179, 31);
            targetSizeBox.TabIndex = 39;
            targetSizeBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
            targetSizeBox.ValueChanged += targetSizeBox_ValueChanged;
            // 
            // AutoGetTarget
            // 
            AutoGetTarget.Location = new Point(1557, 718);
            AutoGetTarget.Margin = new Padding(4, 3, 4, 3);
            AutoGetTarget.Name = "AutoGetTarget";
            AutoGetTarget.Size = new Size(229, 47);
            AutoGetTarget.TabIndex = 41;
            AutoGetTarget.Text = "AutoGetUniqueTarget";
            AutoGetTarget.UseVisualStyleBackColor = true;
            AutoGetTarget.Click += AutoGetTarget_Click;
            // 
            // negtiveMatch
            // 
            negtiveMatch.Location = new Point(704, 937);
            negtiveMatch.Margin = new Padding(4, 3, 4, 3);
            negtiveMatch.Name = "negtiveMatch";
            negtiveMatch.Size = new Size(51, 42);
            negtiveMatch.TabIndex = 42;
            negtiveMatch.Text = "-5°";
            negtiveMatch.UseVisualStyleBackColor = true;
            negtiveMatch.Click += negtiveMatch_Click;
            // 
            // postiveMatch
            // 
            postiveMatch.Location = new Point(639, 937);
            postiveMatch.Margin = new Padding(4, 3, 4, 3);
            postiveMatch.Name = "postiveMatch";
            postiveMatch.Size = new Size(57, 42);
            postiveMatch.TabIndex = 43;
            postiveMatch.Text = "+5°";
            postiveMatch.UseVisualStyleBackColor = true;
            postiveMatch.Click += postiveMatch_Click;
            // 
            // GenterateTargetList
            // 
            GenterateTargetList.Location = new Point(923, 718);
            GenterateTargetList.Margin = new Padding(4, 3, 4, 3);
            GenterateTargetList.Name = "GenterateTargetList";
            GenterateTargetList.Size = new Size(180, 55);
            GenterateTargetList.TabIndex = 44;
            GenterateTargetList.Text = "LowTargetsList";
            GenterateTargetList.UseVisualStyleBackColor = true;
            GenterateTargetList.Click += GenterateTargetList_Click;
            // 
            // moveToLeft
            // 
            moveToLeft.Location = new Point(639, 710);
            moveToLeft.Margin = new Padding(4, 3, 4, 3);
            moveToLeft.Name = "moveToLeft";
            moveToLeft.Size = new Size(81, 42);
            moveToLeft.TabIndex = 45;
            moveToLeft.Text = "左移100";
            moveToLeft.UseVisualStyleBackColor = true;
            moveToLeft.Click += moveToLeft_Click;
            // 
            // moveToRight
            // 
            moveToRight.Location = new Point(826, 708);
            moveToRight.Margin = new Padding(4, 3, 4, 3);
            moveToRight.Name = "moveToRight";
            moveToRight.Size = new Size(81, 43);
            moveToRight.TabIndex = 46;
            moveToRight.Text = "右移100";
            moveToRight.UseVisualStyleBackColor = true;
            moveToRight.Click += moveToRight_Click;
            // 
            // moveDown
            // 
            moveDown.Location = new Point(824, 812);
            moveDown.Margin = new Padding(4, 3, 4, 3);
            moveDown.Name = "moveDown";
            moveDown.Size = new Size(81, 43);
            moveDown.TabIndex = 47;
            moveDown.Text = "下移100";
            moveDown.UseVisualStyleBackColor = true;
            moveDown.Click += moveDown_Click;
            // 
            // moveUp
            // 
            moveUp.Location = new Point(639, 812);
            moveUp.Margin = new Padding(4, 3, 4, 3);
            moveUp.Name = "moveUp";
            moveUp.Size = new Size(81, 43);
            moveUp.TabIndex = 48;
            moveUp.Text = "上移100";
            moveUp.UseVisualStyleBackColor = true;
            moveUp.Click += moveUp_Click;
            // 
            // rotatebutton
            // 
            rotatebutton.Location = new Point(764, 937);
            rotatebutton.Margin = new Padding(4, 3, 4, 3);
            rotatebutton.Name = "rotatebutton";
            rotatebutton.Size = new Size(64, 42);
            rotatebutton.TabIndex = 49;
            rotatebutton.Text = "+0.1°";
            rotatebutton.UseVisualStyleBackColor = true;
            rotatebutton.Click += rotatebutton_Click;
            // 
            // moveTargetLeft
            // 
            moveTargetLeft.Location = new Point(639, 760);
            moveTargetLeft.Margin = new Padding(4, 3, 4, 3);
            moveTargetLeft.Name = "moveTargetLeft";
            moveTargetLeft.Size = new Size(90, 43);
            moveTargetLeft.TabIndex = 50;
            moveTargetLeft.Text = "目标左移";
            moveTargetLeft.UseVisualStyleBackColor = true;
            moveTargetLeft.Click += moveTargetLeft_Click;
            // 
            // targetMoveRight
            // 
            targetMoveRight.Location = new Point(814, 760);
            targetMoveRight.Margin = new Padding(4, 3, 4, 3);
            targetMoveRight.Name = "targetMoveRight";
            targetMoveRight.Size = new Size(91, 43);
            targetMoveRight.TabIndex = 51;
            targetMoveRight.Text = "目标右移";
            targetMoveRight.UseVisualStyleBackColor = true;
            targetMoveRight.Click += targetMoveRight_Click;
            // 
            // moveUpTarget
            // 
            moveUpTarget.Location = new Point(726, 710);
            moveUpTarget.Margin = new Padding(4, 3, 4, 3);
            moveUpTarget.Name = "moveUpTarget";
            moveUpTarget.Size = new Size(91, 43);
            moveUpTarget.TabIndex = 52;
            moveUpTarget.Text = "目标上移";
            moveUpTarget.UseVisualStyleBackColor = true;
            moveUpTarget.Click += moveUpTarget_Click;
            // 
            // moveTargetDown
            // 
            moveTargetDown.Location = new Point(726, 812);
            moveTargetDown.Margin = new Padding(4, 3, 4, 3);
            moveTargetDown.Name = "moveTargetDown";
            moveTargetDown.Size = new Size(91, 43);
            moveTargetDown.TabIndex = 53;
            moveTargetDown.Text = "目标下移";
            moveTargetDown.UseVisualStyleBackColor = true;
            moveTargetDown.Click += moveTargetDown_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(643, 902);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 54;
            label7.Text = "目标大小";
            // 
            // matchSelectedTarget
            // 
            matchSelectedTarget.Location = new Point(726, 760);
            matchSelectedTarget.Margin = new Padding(4, 3, 4, 3);
            matchSelectedTarget.Name = "matchSelectedTarget";
            matchSelectedTarget.Size = new Size(91, 43);
            matchSelectedTarget.TabIndex = 55;
            matchSelectedTarget.Text = "目标匹配";
            matchSelectedTarget.UseVisualStyleBackColor = true;
            matchSelectedTarget.Click += matchSelectedTarget_Click;
            // 
            // matchScaleDown
            // 
            matchScaleDown.Location = new Point(837, 937);
            matchScaleDown.Margin = new Padding(4, 3, 4, 3);
            matchScaleDown.Name = "matchScaleDown";
            matchScaleDown.Size = new Size(69, 42);
            matchScaleDown.TabIndex = 56;
            matchScaleDown.Text = "缩略";
            matchScaleDown.UseVisualStyleBackColor = true;
            matchScaleDown.Click += matchScaleDown_Click;
            // 
            // CheckUniqueTargetHigh
            // 
            CheckUniqueTargetHigh.Location = new Point(1557, 834);
            CheckUniqueTargetHigh.Margin = new Padding(4, 3, 4, 3);
            CheckUniqueTargetHigh.Name = "CheckUniqueTargetHigh";
            CheckUniqueTargetHigh.Size = new Size(229, 46);
            CheckUniqueTargetHigh.TabIndex = 57;
            CheckUniqueTargetHigh.Text = "CheckUnqiueTargetHigh";
            CheckUniqueTargetHigh.UseVisualStyleBackColor = true;
            CheckUniqueTargetHigh.Click += CheckUniqueTargetHigh_Click;
            // 
            // targetListForHigh
            // 
            targetListForHigh.Location = new Point(1123, 718);
            targetListForHigh.Margin = new Padding(4, 3, 4, 3);
            targetListForHigh.Name = "targetListForHigh";
            targetListForHigh.Size = new Size(180, 55);
            targetListForHigh.TabIndex = 59;
            targetListForHigh.Text = "HighTargetsList";
            targetListForHigh.UseVisualStyleBackColor = true;
            targetListForHigh.Click += targetListForHigh_Click;
            // 
            // targetLocXBox
            // 
            targetLocXBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetLocXBox.Location = new Point(727, 855);
            targetLocXBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetLocXBox.Name = "targetLocXBox";
            targetLocXBox.Size = new Size(90, 31);
            targetLocXBox.TabIndex = 61;
            targetLocXBox.Value = new decimal(new int[] { 50, 0, 0, 0 });
            targetLocXBox.ValueChanged += targetLocXBox_ValueChanged;
            // 
            // targetLocYBox
            // 
            targetLocYBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            targetLocYBox.Location = new Point(826, 855);
            targetLocYBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            targetLocYBox.Name = "targetLocYBox";
            targetLocYBox.Size = new Size(79, 31);
            targetLocYBox.TabIndex = 62;
            targetLocYBox.Value = new decimal(new int[] { 50, 0, 0, 0 });
            targetLocYBox.ValueChanged += targetLocYBox_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(641, 858);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 63;
            label8.Text = "目标位置";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1379, 839);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 65;
            label9.Text = "Mask_a";
            // 
            // Mask_ABox
            // 
            Mask_ABox.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            Mask_ABox.Location = new Point(1457, 839);
            Mask_ABox.Margin = new Padding(4, 3, 4, 3);
            Mask_ABox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            Mask_ABox.Name = "Mask_ABox";
            Mask_ABox.Size = new Size(69, 31);
            Mask_ABox.TabIndex = 64;
            Mask_ABox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1377, 878);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 25);
            label10.TabIndex = 66;
            label10.Text = "Mask_b";
            // 
            // Mask_bBox
            // 
            Mask_bBox.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            Mask_bBox.Location = new Point(1457, 876);
            Mask_bBox.Margin = new Padding(4, 3, 4, 3);
            Mask_bBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            Mask_bBox.Name = "Mask_bBox";
            Mask_bBox.Size = new Size(69, 31);
            Mask_bBox.TabIndex = 67;
            Mask_bBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1377, 916);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(78, 25);
            label11.TabIndex = 68;
            label11.Text = "PixelSize";
            // 
            // PixelSizeBox
            // 
            PixelSizeBox.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            PixelSizeBox.Location = new Point(1457, 914);
            PixelSizeBox.Margin = new Padding(4, 3, 4, 3);
            PixelSizeBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PixelSizeBox.Name = "PixelSizeBox";
            PixelSizeBox.Size = new Size(69, 31);
            PixelSizeBox.TabIndex = 69;
            PixelSizeBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1330, 954);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(125, 25);
            label12.TabIndex = 70;
            label12.Text = "ScopeX Width";
            // 
            // ScopeXWidthBox
            // 
            ScopeXWidthBox.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            ScopeXWidthBox.Location = new Point(1457, 952);
            ScopeXWidthBox.Margin = new Padding(4, 3, 4, 3);
            ScopeXWidthBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            ScopeXWidthBox.Name = "ScopeXWidthBox";
            ScopeXWidthBox.Size = new Size(69, 31);
            ScopeXWidthBox.TabIndex = 71;
            ScopeXWidthBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1346, 996);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(103, 25);
            label13.TabIndex = 72;
            label13.Text = "BladeWidth";
            // 
            // BladeWidthBox
            // 
            BladeWidthBox.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            BladeWidthBox.Location = new Point(1457, 990);
            BladeWidthBox.Margin = new Padding(4, 3, 4, 3);
            BladeWidthBox.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            BladeWidthBox.Name = "BladeWidthBox";
            BladeWidthBox.Size = new Size(69, 31);
            BladeWidthBox.TabIndex = 73;
            BladeWidthBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1814, 1048);
            Controls.Add(BladeWidthBox);
            Controls.Add(label13);
            Controls.Add(ScopeXWidthBox);
            Controls.Add(label12);
            Controls.Add(PixelSizeBox);
            Controls.Add(label11);
            Controls.Add(Mask_bBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Mask_ABox);
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
            Margin = new Padding(4, 3, 4, 3);
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
            ((System.ComponentModel.ISupportInitialize)Mask_ABox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mask_bBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PixelSizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScopeXWidthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BladeWidthBox).EndInit();
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
        private Label label9;
        private NumericUpDown Mask_ABox;
        private Label label10;
        private NumericUpDown Mask_bBox;
        private Label label11;
        private NumericUpDown PixelSizeBox;
        private Label label12;
        private NumericUpDown ScopeXWidthBox;
        private Label label13;
        private NumericUpDown BladeWidthBox;
    }
}