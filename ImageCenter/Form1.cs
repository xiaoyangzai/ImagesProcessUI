using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Data.SqlTypes;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Net.NetworkInformation;
using System.Drawing;

namespace ImageCenter
{
    public partial class Form1 : Form
    {
        delegate void DebugCallbackDelegate(string message);
        delegate int CaptureImageDelegate(IntPtr message, ref int length, int focusIndex);
        private void DebugCallback(string message)
        {
            Debug.WriteLine("************************\n");
            Debug.WriteLine("DEBUG: " + message);
            console.Text += message;
            Debug.WriteLine("************************\n");
        }

        private int CaptureImage(IntPtr image, ref int length, int focusIndex)
        {
            Debug.WriteLine("************************\n");
            Debug.WriteLine("Calling CaptureImage()...\n");
            if (image == IntPtr.Zero)
            {
                Debug.WriteLine("Invalid buffer from algorithm\n");
                return -1;
            }
            // TODO: Capture the image based on the specified focus index
            string focusImagePath = Path.GetDirectoryName(imagePath);
            string focusImage = Path.Combine(focusImagePath, focusIndex + ".png");
            byte[] imageBytes = File.ReadAllBytes(focusImage);
            string focusImageBase64String = Convert.ToBase64String(imageBytes);
            byte[] strBytes = Encoding.ASCII.GetBytes(focusImageBase64String);

            Image inputFile = Image.FromFile(focusImage);
            inputImage.Image = inputFile;
            inputImage.Refresh();
            // Copy the image base64 data to chipImage algorithm 
            Marshal.Copy(strBytes, 0, image, strBytes.Length);
            length = strBytes.Length;

            Debug.WriteLine("Capture image at focus or brightness position: " + focusImage + " with length: " + length + "\n");
            Debug.WriteLine("Calling CaptureImage()...Done\n");
            Debug.WriteLine("************************\n");
            return 0;
        }
        public Form1()
        {
            InitializeComponent();
            if (imagePath != "")
            {
                Image inputFile = Image.FromFile(imagePath);
                inputImage.Image = inputFile;
                originalImage = new Bitmap(inputImage.Image);
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                imageBase64String = Convert.ToBase64String(imageBytes, Base64FormattingOptions.None);
            }
            console.Text += "Loading image processor center...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll", CallingConvention = CallingConvention.Cdecl)]
            static extern int GetVersionInfo(StringBuilder result);

            [DllImport("image_process.dll")]
            static extern int ChipModuleInit();
            ChipModuleInit();
            StringBuilder result = new StringBuilder(100);
            int retCode = GetVersionInfo(result);
            if (retCode == 0)
            {
                console.Text += "Image processor runtime version: " + result.ToString() + "\n";
            }

            currentTargetX = -1;
            currentTargetY = -1;
            isAutoGetUniqueTarget = false;
            console.Text += "Loading image processor center...Done\n";
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            openImage.FileName = "";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImage.FileName;
            }
            if (imagePath != null)
            {
                Image inputFile = Image.FromFile(imagePath);
                inputImage.Image = inputFile;
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                imageBase64String = Convert.ToBase64String(imageBytes);
                originalImage = new Bitmap(inputImage.Image);
                resultImage.Image = null;
                scaleX = (double)inputImage.ClientSize.Width / inputImage.Image.Width;
                scaleY = (double)inputImage.ClientSize.Height / inputImage.Image.Height;
                currentTargetX = -1;
                currentTargetY = -1;
            }
        }

        private void selectTarget_Click(object sender, EventArgs e)
        {
            openTarget.FileName = "";
            if (openTarget.ShowDialog() == DialogResult.OK)
            {
                targetPath = openTarget.FileName;
            }
            if (targetPath != null)
            {
                Image targetFile = Image.FromFile(targetPath);
                templateImage.Image = targetFile;
                byte[] targetBytes = File.ReadAllBytes(targetPath);
                targetBase64String = Convert.ToBase64String(targetBytes);
            }
        }

        private void buttonRotateDegree_Click(object sender, EventArgs e)
        {
            if (imagePath == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            console.Text = "[Info] Calling RotateDegree function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int RotateTransform(IntPtr source, int source_size, ref float angle, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                float angle = 0;
                IntPtr resultPtr = IntPtr.Zero;
                int ret = RotateTransform(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref angle, out resultPtr);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call RotateDegree function. Exit Code: " + ret;
                    return;
                }

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling RotateDegree function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function RtateDegreeDegree not found!!";
            }
        }

        private void buttonMatcher_Click(object sender, EventArgs e)
        {
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }
            using (MemoryStream ms = new MemoryStream())
            {

                Image img = originalImage;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }
            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resultPtr, 7);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }

        }

        private void buttonCutLineDetection_Click(object sender, EventArgs e)
        {
            if (imagePath == null)
            {
                console.Text = "[Info] Input image is not selected. Please selec the input image again!";
                return;
            }
            console.Text = "[Info] Calling CutLineDetection function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int CutLineDetection(IntPtr source, int source_size, ref int widthY, ref int widthX, ref int offsetY, ref int offsetX, int refOffsetY, int refOffsetX, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int widthY = -1;
                int offsetY = -1;
                int widthX = -1;
                int offsetX = -1;
                IntPtr resultPtr = IntPtr.Zero;
                int refOffsetY = (int)cutCenterLocY.Value;
                int refOffsetX = (int)cutCenterLocX.Value;
                int ret = CutLineDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref widthY, ref widthX, ref offsetY, ref offsetX, refOffsetY, refOffsetX, out resultPtr);
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling CutLineDetection function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function CutLineDetection not found!!";
            }
        }

        private void buttonCutTraceValidate_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int CutTraceDetection(IntPtr source, int source_size, ref int traceCenterOffset, ref double tranceWidth, ref double maxTraceWith, ref int maxArea, ref int traceQuality, ref double half_w, ref double max_collapse_w, int pixelSize, double cutLineWidth, double mask_a, double mask_b, int cutLineCenterY, double bladeWidth, int scopeXWidth, int detectSensitive, int detectMode, out IntPtr resultPtr, bool enableTegMask = false, int maxTegWidth = 0, bool enbleDetectionScope = false, int tegMaskSensitive = 5);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text = "[Info] Calling CutTraceDetection function...\n";
            try
            {
                int traceCenterOffset = 0;
                double tranceWidth = -1;
                double maxTraceWith = -1;
                int maxArea = -1;
                int traceQuality = -1;
                double half_w = -1;
                double max_collapse_w = -1;
                double mask_a = (double)Mask_ABox.Value;
                double mask_b = (double)Mask_bBox.Value;
                int scopeXWidth = (int)ScopeXWidthBox.Value;
                int pixelSize = (int)PixelSizeBox.Value;
                double bladeWidth = (double)BladeWidthBox.Value;
                IntPtr resultPtr = IntPtr.Zero;
                int cutLineCencertLocY = (int)cutCenterLocY.Value;
                double cutLineTraceWidth = (double)cutLineWidth.Value;
                int ret = CutTraceDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref traceCenterOffset, ref tranceWidth, ref maxTraceWith, ref maxArea, ref traceQuality, ref half_w, ref max_collapse_w, pixelSize, cutLineTraceWidth, mask_a, mask_b, cutLineCencertLocY, bladeWidth, scopeXWidth, 0, 0, out resultPtr);
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling CutTraceDetection function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function cutTraceDetection not found...";
            }
        }

        private void buttonPixelMeasure_Click(object sender, EventArgs e)
        {
            if (imagePath == null)
            {
                console.Text = "[Info] Input image is not selected. Please selec the input image again!";
                return;
            }
            console.Text = "[Info] Calling PixelMeasure function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int PixelSizeMeasure(IntPtr source, int source_size, IntPtr target, int target_size, ref int offset_x, ref int offset_y, out IntPtr resultPtr, UInt16 fontSize = 5);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            try
            {
                int offset_x = -1;
                int offset_y = -1;
                IntPtr resultPtr = IntPtr.Zero;
                int ret = PixelSizeMeasure(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offset_x, ref offset_y, out resultPtr, 7);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + ret;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling PixelMeasure function...Done.\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function PixelMeasure not found...";
            }
        }

        private void buttonFocusQuality_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int AutoAdjustFocus(int minPosition, int maxPosition, int step, CaptureImageDelegate callback, ref float optimumQuality, int currentPosition = -1, int timeout = -1, float refQuality = -1);
            try
            {
                console.Text = "[Info] Calling AutoFocus function...\n";
                float optQuality = 0.0f;
                int end = (int)maxValue.Value;
                int step = (int)adjustStep.Value <= 0 ? -1 : (int)adjustStep.Value;
                int refPosition = (int)startPosition.Value <= 0 ? -1 : (int)startPosition.Value;
                int focus = AutoAdjustFocus(1, end, step, new CaptureImageDelegate(CaptureImage), ref optQuality, refPosition);
                if (focus > 0)
                {
                    string focusImagePath = Path.GetDirectoryName(imagePath);
                    string focusImage = Path.Combine(focusImagePath, focus + ".png");
                    imagePath = focusImage;
                    Image inputFile = Image.FromFile(focusImage);
                    inputImage.Image = inputFile;
                    inputImage.Refresh();
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    imageBase64String = Convert.ToBase64String(imageBytes);


                    console.Text += "[Info] Best focus value: " + focus + "\n";
                    console.Text += "[Info] Best quality value: " + optQuality + "\n";
                    console.Text += "[Info] Calling AutoFocus function...Done\n";
                    return;
                }
                if (focus == -1)
                {
                    console.Text += "[Info] Calling AutoFocus function...Timeout\n";
                }
                else if (focus == -3)
                {
                    console.Text += "[Error] Failed to call AutoFocus function. Low quality: " + optQuality + ". Please re-select focus range.\n";
                }
                else
                {
                    console.Text += "[Error] Failed to call AutoFocus function. Exit code: " + focus + "\n";
                }
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }
            catch (Exception ex)
            {
                console.Text = "[Error] Catched unexpected exception: " + ex.Message + "\n";
            }

        }

        private void buttonBrightQuality_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int AutoAdjustLight(int minPosition, int maxPosition, int step, CaptureImageDelegate callback, ref float optimumQuality, int currentPosition = -1, int timeout = -1, float refQuality = -1.0f);

            try
            {
                console.Text = "[Info] Calling AutoBright function...\n";
                float quality = 0.0f;
                int end = (int)maxValue.Value;
                int step = (int)adjustStep.Value <= 0 ? -1 : (int)adjustStep.Value;
                int refPosition = (int)startPosition.Value <= 0 ? -1 : (int)startPosition.Value;
                int bright = AutoAdjustLight(1, end, step, new CaptureImageDelegate(CaptureImage), ref quality, refPosition);
                if (bright > 0)
                {
                    string focusImagePath = Path.GetDirectoryName(imagePath);
                    string brightImage = Path.Combine(focusImagePath, bright + ".png");
                    imagePath = brightImage;
                    Image inputFile = Image.FromFile(brightImage);
                    inputImage.Image = inputFile;
                    inputImage.Refresh();
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    imageBase64String = Convert.ToBase64String(imageBytes);
                    console.Text += "[Info] Best bright value: " + bright + "\n";
                    console.Text += "[Info] Best quality value: " + quality + "\n";
                    console.Text += "[Info] Calling AutoLight function...Done\n";
                    return;
                }
                if (bright == -1)
                {
                    console.Text += "[Info] Calling AutoLight function...Timeout\n";
                }
                else if (bright == -3)
                {
                    console.Text += "[Error] Failed to call AutoLight function. Low quality: " + quality + ". Please re-select bright range.\n";
                }
                else
                {
                    console.Text += "[Error] Failed to call AutoLight function. Exit code: " + bright + "\n";
                }
                console.Text += "[Info] Calling AutoLight function...Done\n";
                return;
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }
        }

        private void saveReusltImage_Click(object sender, EventArgs e)
        {
            if (resultImage.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                saveFileDialog.Title = "Save an Image File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultImage.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void cutLineWidth_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap bitmap = new Bitmap(originalImage);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // 设置线条颜色和宽度
                    Pen pen = new Pen(Color.YellowGreen, 2);

                    // 设置虚线的样式
                    Pen dashedPen = new Pen(Color.YellowGreen, 2);
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    // 计算线条的起点和终点
                    int startY = (int)cutCenterLocY.Value;
                    int endY = startY;
                    int topY = startY - (int)cutLineWidth.Value / 2;
                    int bottomY = startY + (int)cutLineWidth.Value / 2;

                    // 绘制水平线条
                    graphics.DrawLine(pen, 0, startY, inputImage.Image.Width, endY);
                    graphics.DrawLine(dashedPen, 0, topY, inputImage.Image.Width, topY);
                    graphics.DrawLine(dashedPen, 0, bottomY, inputImage.Image.Width, bottomY);
                }

                // 将绘制好线条的 Bitmap 对象设置为 PictureBox 的图像
                inputImage.Image = bitmap;
            }
        }

        private void cutCenterLocY_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap bitmap = new Bitmap(originalImage);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // 设置线条颜色和宽度
                    Pen pen = new Pen(Color.YellowGreen, 2);

                    // 设置虚线的样式
                    Pen dashedPen = new Pen(Color.YellowGreen, 2);
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    // 计算线条的起点和终点
                    int startY = (int)cutCenterLocY.Value;
                    int endY = startY;
                    int topY = startY - (int)cutLineWidth.Value / 2;
                    int bottomY = startY + (int)cutLineWidth.Value / 2;

                    // 绘制水平线条
                    graphics.DrawLine(pen, 0, startY, inputImage.Image.Width, endY);
                    graphics.DrawLine(dashedPen, 0, topY, inputImage.Image.Width, topY);
                    graphics.DrawLine(dashedPen, 0, bottomY, inputImage.Image.Width, bottomY);
                }

                // 将绘制好线条的 Bitmap 对象设置为 PictureBox 的图像
                inputImage.Image = bitmap;
            }
        }

        private void cutCenterValidate_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int CutLineCenterValidator(IntPtr source, int source_size, ref int actualOffsetY, int width, int expectedOffsetY, int retryTimes, out IntPtr resultPtr);

            try
            {
                console.Text = "[Info] Calling CutLineCenterValidator() function...\n";
                float quality = 0.0f;
                int times = (int)retryTimes.Value;
                IntPtr resultPtr = IntPtr.Zero;
                int cutLineCencertLocY = (int)cutCenterLocY.Value;
                int width = (int)cutLineWidth.Value;
                int acctualOffsetY = 0;
                int ret = CutLineCenterValidator(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref acctualOffsetY, width, cutLineCencertLocY, times, out resultPtr);

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                    console.Text += "[Info] actual center of cut line is " + acctualOffsetY + "\n";
                    console.Text += "[Info] Calling CutLineCenterValidator() function...Done\n";
                }
                console.Text += "[Info] Calling CutLineCenterValidator() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }

        }

        private void detectLowCrossroad_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int DetectCutLineCrossroad(IntPtr source, int source_size, ref int centerX, ref int centerY, ref int width, ref int high, bool isLow, out IntPtr resultPtr);

            try
            {
                console.Text = "[Info] Calling DetectCutLineCrossroad() function...\n";
                int times = (int)retryTimes.Value;
                IntPtr resultPtr = IntPtr.Zero;
                int centerX = -1;
                int centerY = -1;
                int width = -1;
                int high = -1;
                int ret = DetectCutLineCrossroad(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref centerX, ref centerY, ref width, ref high, true, out resultPtr);

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                    console.Text += "[Info] center of cut line crossrad is at (" + centerX + "," + centerY + ")\n";
                    console.Text += "[Info] size of crossrad bounding box is at (" + width + "*" + high + ")\n";
                    console.Text += "[Info] Calling DetectCutLineCrossroad() function...Done\n";
                }
                console.Text += "[Info] Calling DetectCutLineCrossroad() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }
        }

        private void detectHighCrossroad_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int DetectCutLineCrossroad(IntPtr source, int source_size, ref int centerX, ref int centerY, ref int width, ref int high, bool isLow, out IntPtr resultPtr);

            try
            {
                console.Text = "[Info] Calling DetectCutLineCrossroad() function...\n";
                int times = (int)retryTimes.Value;
                IntPtr resultPtr = IntPtr.Zero;
                int centerX = -1;
                int centerY = -1;
                int width = -1;
                int high = -1;
                int ret = DetectCutLineCrossroad(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref centerX, ref centerY, ref width, ref high, false, out resultPtr);

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                    console.Text += "[Info] center of cut line crossrad is at (" + centerX + "," + centerY + ")\n";
                    console.Text += "[Info] size of crossrad bounding box is at (" + width + "*" + high + ")\n";
                    console.Text += "[Info] Calling DetectCutLineCrossroad() function...Done\n";
                }
                console.Text += "[Info] Calling DetectCutLineCrossroad() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }
        }

        private void checkGrainExist_Click(object sender, EventArgs e)
        {
            if (imagePath == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (targetPath == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }
            console.Text = "[Info] Calling HasGrain() function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int HasGrain(IntPtr source, int source_size, IntPtr target, int target_size, ref bool flag, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                bool isExisted = false;
                IntPtr resultPtr = IntPtr.Zero;
                quality = HasGrain(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref isExisted, out resultPtr);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call HasGrain function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling HasGrain() function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }
        }

        private void cutCenterLocX_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap bitmap = new Bitmap(originalImage);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // 设置线条颜色和宽度
                    Pen pen = new Pen(Color.YellowGreen, 10);

                    // 设置虚线的样式
                    Pen dashedPen = new Pen(Color.YellowGreen, 10);
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    // 计算线条的起点和终点
                    int startX = (int)cutCenterLocX.Value;

                    // 绘制垂直线
                    graphics.DrawLine(pen, startX, 0, startX, inputImage.Image.Height);
                }

                // 将绘制好线条的 Bitmap 对象设置为 PictureBox 的图像
                inputImage.Image = bitmap;
            }

        }

        private void CheckifCutTrace_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int IsCutTrace(IntPtr source, int source_size, ref bool hasCutTrace);

            try
            {
                console.Text = "[Info] Calling IsCutTrace() function...\n";
                bool hasCutTrace = false;
                int ret = IsCutTrace(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref hasCutTrace);
                console.Text += "[Info] Calling DetectCutLineCrossroad() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }

        }

        private void edgeDetection_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int EdgePointDetection(IntPtr source, int source_size, ref int locX, ref int locY, out IntPtr resultPtr);

            try
            {
                console.Text = "[Info] Calling EdgePointDetection() function...\n";
                bool hasCutTrace = false;
                int locX = -1;
                int locY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                int ret = EdgePointDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref locX, ref locY, out resultPtr);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call EdgePointDetection function. Exit Code: " + ret;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling EdgePointDetection() function...Done!";
                console.Text += "[Info] Calling EdgePointDetection() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Functior not found!!";
            }
        }

        private void checkIfUniqueTargetInGrain_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));


            [DllImport("image_process.dll")]
            static extern int GetUniqueTargetLow(IntPtr source, int source_size, int targetCenterX, int targetCenterY, int targetWidth, int targetHigh, ref int offsetX, ref int offsetY, int horizontalStep, int verticalStep, out IntPtr targetPtr, out IntPtr resultPtr, UInt16 fontSize = 5);
            templateImage.Image = null;
            resultImage.Image = null;
            try
            {
                console.Text = "[Info] IsUnqueTargetInGrain() function...\n";
                int targetSize = (int)targetSizeBox.Value;
                int step = (int)cutLineWidth.Value;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr targetPtr = IntPtr.Zero;
                int offsetX = -1;
                int offsetY = -1;
                int ret = GetUniqueTargetLow(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, currentTargetX, currentTargetY, targetSize, targetSize, ref offsetX, ref offsetY, step, step, out targetPtr, out resultPtr);
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call IsUnqueTargetInGrain function. Exit Code: " + ret;
                    return;
                }
                if (targetPtr != IntPtr.Zero)
                {
                    templateImage.Image = null;
                    string base64ImageData = Marshal.PtrToStringAnsi(targetPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    templateImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling IsUnqueTargetInGrain() function...Done!";
                console.Text += "[Info] Calling IsUnqueTargetInGrain() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!";
            }

        }

        private void targetSizeBox_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap bitmap = new Bitmap(originalImage);
                int x = bitmap.Width / 2 - (int)targetSizeBox.Value / 2;
                int y = bitmap.Height / 2 - (int)targetSizeBox.Value / 2;
                if (currentTargetX < 0 && currentTargetY < 0)
                {
                    currentTargetX = originalImage.Width / 2;
                    currentTargetY = originalImage.Height / 2;
                }
                x = currentTargetX - (int)targetSizeBox.Value / 2;
                y = currentTargetY - (int)targetSizeBox.Value / 2;

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // 设置线条颜色和宽度
                    Pen pen = new Pen(Color.Green, 5);

                    // 绘制垂直线
                    graphics.DrawRectangle(pen, x, y, (int)targetSizeBox.Value, (int)targetSizeBox.Value);
                }

                // 将绘制好线条的 Bitmap 对象设置为 PictureBox 的图像
                inputImage.Image = bitmap;
                int targetSize = (int)targetSizeBox.Value;
                console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
                Rectangle cropRect = new Rectangle(x, y, (int)targetSizeBox.Value, (int)targetSizeBox.Value);
                Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
                templateImage.Image = croppedImage;
                using (MemoryStream targetms = new MemoryStream())
                {
                    Image img = templateImage.Image;
                    img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] targetImageBytes = targetms.ToArray();
                    targetBase64String = Convert.ToBase64String(targetImageBytes);
                }
            }
        }

        private void AutoGetTarget_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int AutoGetUniqueTarget(IntPtr source, int source_size, ref int targetCenterX, ref int targetCenterY, ref int targetSize, ref int distanceToMove, out IntPtr targetImagePtr, out IntPtr resultPtr, UInt16 fontSize = 5);
            templateImage.Image = null;
            resultImage.Image = null;
            try
            {
                console.Text = "[Info] AutoGetUniqueTarget() function...\n";
                int targetSize = -1;
                int targetCenterX = -1;
                int targetCenterY = -1;
                int distanceToMove = 0;
                IntPtr targetPtr = IntPtr.Zero;
                IntPtr resultPtr = IntPtr.Zero;
                int ret = AutoGetUniqueTarget(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref targetCenterX, ref targetCenterY, ref targetSize, ref distanceToMove, out targetPtr, out resultPtr);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call IsUnqueTargetInGrain function. Exit Code: " + ret;
                    return;
                }

                if (targetPtr != IntPtr.Zero && resultPtr != IntPtr.Zero)
                {
                    string base64TargetData = Marshal.PtrToStringAnsi(targetPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64TargetData);
                    MemoryStream msTarget = new MemoryStream(imageBytes);
                    templateImage.Image = Image.FromStream(msTarget);

                    string base64ResultData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageResultBytes = Convert.FromBase64String(base64ResultData);
                    MemoryStream msResult = new MemoryStream(imageResultBytes);
                    resultImage.Image = Image.FromStream(msResult);
                }
                currentTargetX = targetCenterX;
                currentTargetY = targetCenterY;
                autoUniqueTargetSize = targetSize;
                isAutoGetUniqueTarget = true;
                console.Text += "\n[Info] Calling AutoGetUniqueTarget() function...Done!";
                console.Text += "[Info] Calling AutoGetUniqueTarget() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!";
            }

        }

        private void negtiveMatch_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(originalImage.Width / 2, originalImage.Height / 2);
                    g.RotateTransform(-5);
                    g.TranslateTransform(-originalImage.Width / 2, -originalImage.Height / 2);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }
            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetOriginal(IntPtr source, int source_size, IntPtr target, int target_size, int originalX, int originalY, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedPtr, UInt16 fontSize = 5, bool isShowOffset = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            if (currentTargetX < 0 && currentTargetY < 0)
            {
                currentTargetX = originalImage.Width / 2;
                currentTargetY = originalImage.Height / 2;
            }
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetOriginal(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, currentTargetX - (int)targetSizeBox.Value / 2, currentTargetY - (int)targetSizeBox.Value / 2, ref offsetX, ref offsetY, out resultPtr, -1, out resultPtr, 1);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }

        }

        private void postiveMatch_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(originalImage.Width / 2, originalImage.Height / 2);
                    g.RotateTransform(5);
                    g.TranslateTransform(-originalImage.Width / 2, -originalImage.Height / 2);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetOriginal(IntPtr source, int source_size, IntPtr target, int target_size, int originalX, int originalY, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedPtr, UInt16 fontSize = 1, bool isShowOffset = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            if (currentTargetX < 0 && currentTargetY < 0)
            {
                currentTargetX = originalImage.Width / 2;
                currentTargetY = originalImage.Height / 2;
            }
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetOriginal(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, currentTargetX - (int)targetSizeBox.Value / 2, currentTargetY - (int)targetSizeBox.Value / 2, ref offsetX, ref offsetY, out resultPtr, -1, out resultPtr, 1);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }



        }

        private void GenterateTargetList_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int GetTargetCandidateListLow(IntPtr source, int source_size, int horizontalStep, int verticalStep, out IntPtr targetsList, out IntPtr resultPtr);
            templateImage.Image = null;
            resultImage.Image = null;
            try
            {
                console.Text = "[Info] GetTargetCandidateList() function...\n";
                IntPtr targetsListPtr = IntPtr.Zero;
                IntPtr resultPtr = IntPtr.Zero;
                int step = (int)cutLineWidth.Value;
                int ret = GetTargetCandidateListLow(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, step, step, out targetsListPtr, out resultPtr);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call IsUnqueTargetInGrain function. Exit Code: " + ret;
                    return;
                }

                if (targetsListPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(targetsListPtr);
                    byte[] targetsListBytes = Convert.FromBase64String(base64ImageData);
                    string targetsListStr = Encoding.ASCII.GetString(targetsListBytes);
                    Console.WriteLine(targetsListStr);
                }

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling AutoGetUniqueTarget() function...Done!";
                console.Text += "[Info] Calling AutoGetUniqueTarget() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!";
            }

        }

        private void moveToLeft_Click(object sender, EventArgs e)
        {

            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(-100, 0);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resultPtr, 7);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }

        }

        private void moveToRight_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(100, 0);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr resiedPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resiedPtr, 7);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(0, 100);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr resizedPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resizedPtr, 7);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }

        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(originalImage);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(0, -100);
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr resizedPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resizedPtr, 7);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }

        }

        private void rotatebutton_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap rotatedBitmap = new Bitmap(inputImage.Image);
                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    // 设置旋转角度为0.2°（顺时针方向）
                    float angle = 0.2f;

                    // 计算旋转中心点坐标
                    float centerX = rotatedBitmap.Width / 2f;
                    float centerY = rotatedBitmap.Height / 2f;

                    // 执行旋转操作
                    g.TranslateTransform(centerX, centerY); // 将旋转中心点移动到图像中心
                    g.RotateTransform(angle); // 进行旋转
                    g.TranslateTransform(-centerX, -centerY); // 将旋转中心点移回原位
                    g.DrawImage(originalImage, Point.Empty);
                }

                rotatedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
                inputImage.Image = rotatedBitmap;
                originalImage = rotatedBitmap;
            }
        }

        private void moveUpTarget_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            int targetSize = (int)targetSizeBox.Value;
            if (currentTargetX == 0)
                currentTargetX = bitmap.Width / 2;
            if (currentTargetY == 0)
                currentTargetY = bitmap.Height / 2;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 5);
                if (currentTargetY - targetSize / 2 > 0)
                    currentTargetY -= (int)(20 * scaleY);

                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;

        }

        private void moveTargetDown_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            if (currentTargetX == 0)
                currentTargetX = bitmap.Width / 2;
            if (currentTargetY == 0)
                currentTargetY = bitmap.Height / 2;
            int targetSize = (int)targetSizeBox.Value;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 5);
                if (currentTargetY + targetSize / 2 < bitmap.Height)
                    currentTargetY += (int)(20 * scaleY);

                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;
        }

        private void moveTargetLeft_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            if (currentTargetX == 0)
                currentTargetX = bitmap.Width / 2;
            if (currentTargetY == 0)
                currentTargetY = bitmap.Height / 2;
            int targetSize = (int)targetSizeBox.Value;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 5);
                if (currentTargetX - targetSize / 2 > 0)
                    currentTargetX -= (int)(20 * scaleX);

                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;

        }

        private void targetMoveRight_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            if (currentTargetX == 0)
                currentTargetX = bitmap.Width / 2;
            if (currentTargetY == 0)
                currentTargetY = bitmap.Height / 2;
            int targetSize = (int)targetSizeBox.Value;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 5);
                if (currentTargetX + targetSize / 2 < bitmap.Width)
                    currentTargetX += (int)(20 * scaleX);

                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;

        }

        private void matchSelectedTarget_Click(object sender, EventArgs e)
        {
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }
            using (MemoryStream ms = new MemoryStream())
            {

                Image img = originalImage;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }
            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetOriginal(IntPtr source, int source_size, IntPtr target, int target_size, int originalX, int originalY, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedPtr, UInt16 fontSize = 1, bool isShowOffset = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text += "\n[***] current pos: " + currentTargetX + " x " + currentTargetY + "\n";
            if (currentTargetX < 0 && currentTargetY < 0)
            {
                currentTargetX = originalImage.Width / 2;
                currentTargetY = originalImage.Height / 2;
            }
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr resizePtr = IntPtr.Zero;
                int originalX = currentTargetX - (int)targetSizeBox.Value / 2;
                int originalY = currentTargetY - (int)targetSizeBox.Value / 2;
                if (isAutoGetUniqueTarget)
                {
                    originalX = currentTargetX - autoUniqueTargetSize / 2;
                    originalY = currentTargetY - autoUniqueTargetSize / 2;
                    console.Text += "\n[INFO] current auto generated target size: " + autoUniqueTargetSize + "\n";
                }
                else
                {
                    console.Text += "\n[INFO] current target size: " + autoUniqueTargetSize + "\n";
                }
                console.Text += "\n[***] current pos: " + currentTargetX + " x " + currentTargetY + "\n";
                int resize = (int)resizeBox.Value;
                UInt16 fontSize = (UInt16)fontSizeBox.Value;
                quality = MatchTargetOriginal(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, originalX, originalY, ref offsetX, ref offsetY, out resultPtr, resize, out resizePtr, fontSize);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                if (resizePtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resizePtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resizedImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }
        }

        private void matchScaleDown_Click(object sender, EventArgs e)
        {
            isAutoGetUniqueTarget = false;
            if (inputImage.Image == null)
            {
                console.Text = "[Error] Input image is not selected. Please selec the input image again!";
                return;
            }
            if (templateImage.Image == null)
            {
                console.Text = "[Error] Target image is not selected. Please selec the target image again!";
                return;
            }

            int newWidth = originalImage.Width / 3;
            int newHigh = originalImage.Height / 3;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap resizedBitmap = new Bitmap(newWidth, newHigh);
                using (Graphics g = Graphics.FromImage(resizedBitmap))
                {
                    g.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHigh));
                }

                resizedBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }

            int newTargetW = templateImage.Image.Width / 3;
            int newTargetH = templateImage.Image.Height / 3;
            using (MemoryStream targetms = new MemoryStream())
            {

                Bitmap resizedTargetBitmap = new Bitmap(newTargetW, newTargetH);
                using (Graphics g = Graphics.FromImage(resizedTargetBitmap))
                {
                    g.DrawImage(templateImage.Image, new Rectangle(0, 0, newTargetW, newTargetH));
                }
                resizedTargetBitmap.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }

            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, int resize, out IntPtr resizedRetPtr, UInt16 fontSize = 5, bool isShow = true);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                IntPtr resizedPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, -1, out resizedPtr, 1, false);
                if (quality < 0)
                {
                    console.Text += "\n[Error] Failed to call MatchTarget function. Exit Code: " + quality;
                    return;
                }
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling MatcherTarget function...Done!";
            }
            catch (DllNotFoundException)
            {
                console.Text = "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text = "[Error] Function MatcherTarget not found!!";
            }
        }

        private void CheckUniqueTargetHigh_Click(object sender, EventArgs e)
        {
            resultImage.Image = null;
            using (MemoryStream ms = new MemoryStream())
            {

                Image img = originalImage;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] inputImageBytes = ms.ToArray();
                imageBase64String = Convert.ToBase64String(inputImageBytes);
            }
            using (MemoryStream targetms = new MemoryStream())
            {

                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));


            [DllImport("image_process.dll")]
            static extern int GetUniqueTargetHigh(IntPtr image, int imageSize, int targetCenterX, int targetCenterY, int targetWidth, int targetHigh, ref int offsetX, ref int offsetY, out IntPtr outputTargetImage, out IntPtr outputMatchedImage, UInt16 fontSize = 5);

            resultImage.Image = null;
            try
            {
                console.Text = "[Info] IsUnqueTargetHigh() function...\n";
                int targetSize = (int)targetSizeBox.Value;
                IntPtr targetPtr = IntPtr.Zero;
                IntPtr resultPtr = IntPtr.Zero;
                int offsetX = -1;
                int offsetY = -1;
                int ret = GetUniqueTargetHigh(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, currentTargetX, currentTargetY, targetSize, targetSize, ref offsetX, ref offsetY, out targetPtr, out resultPtr);
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call IsUnqueTargetHigh function. Exit Code: " + ret;
                    return;
                }
                if (targetPtr != IntPtr.Zero)
                {
                    templateImage.Image = null;
                    string base64ImageData = Marshal.PtrToStringAnsi(targetPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    templateImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling IsUnqueTargetHigh() function...Done!";
                console.Text += "[Info] Calling IsUnqueTargetHigh() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!";
            }
        }

        private void targetListForHigh_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            [DllImport("image_process.dll")]
            static extern int GetTargetCandidateListHigh(IntPtr source, int source_size, int horizontalWidth, int verticalWidth, out IntPtr targetsList, out IntPtr resultPtr);
            templateImage.Image = null;
            resultImage.Image = null;
            try
            {
                console.Text = "[Info] GetTargetCandidateList() function...\n";
                IntPtr targetsListPtr = IntPtr.Zero;
                IntPtr resultPtr = IntPtr.Zero;
                int step = (int)cutLineWidth.Value;
                int ret = GetTargetCandidateListHigh(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, step, step, out targetsListPtr, out resultPtr);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call IsUnqueTargetInGrain function. Exit Code: " + ret;
                    return;
                }

                if (targetsListPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(targetsListPtr);
                    byte[] targetsListBytes = Convert.FromBase64String(base64ImageData);
                    string targetsListStr = Encoding.ASCII.GetString(targetsListBytes);
                    Console.WriteLine(targetsListStr);
                }

                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    resultImage.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling AutoGetUniqueTarget() function...Done!";
                console.Text += "[Info] Calling AutoGetUniqueTarget() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!";
            }
        }

        private void targetLocXBox_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage == null)
                return;
            int targetLocX = (int)targetLocXBox.Value;
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            if (targetLocX >= bitmap.Width)
            {
                return;
            }
            if (currentTargetY < 0)
                currentTargetY = bitmap.Height / 2;
            currentTargetX = targetLocX;
            int targetSize = (int)targetSizeBox.Value;
            currentTargetX = currentTargetX < targetSize / 2 ? targetSize / 2 : targetLocX;

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 10);
                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;
        }

        private void targetLocYBox_ValueChanged(object sender, EventArgs e)
        {
            if (originalImage == null)
                return;
            int targetLocY = (int)targetLocYBox.Value;
            isAutoGetUniqueTarget = false;
            templateImage.Image = null;
            Bitmap bitmap = new Bitmap(originalImage);
            if (targetLocY >= bitmap.Height)
            {
                return;
            }
            if (currentTargetX < 0)
                currentTargetX = bitmap.Width / 2;
            currentTargetY = targetLocY;
            int targetSize = (int)targetSizeBox.Value;
            currentTargetY = currentTargetY < targetSize / 2 ? targetSize / 2 : targetLocY;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Green, 10);
                graphics.DrawRectangle(pen, currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            }
            console.Text = "[INFO] Selected target center location: " + currentTargetX + "x" + currentTargetY + "\n" + "[INFO] Selected target size: " + targetSize + "x" + targetSize;
            Rectangle cropRect = new Rectangle(currentTargetX - targetSize / 2, currentTargetY - targetSize / 2, targetSize, targetSize);
            Bitmap croppedImage = originalImage.Clone(cropRect, originalImage.PixelFormat);
            templateImage.Image = croppedImage;
            using (MemoryStream targetms = new MemoryStream())
            {
                Image img = templateImage.Image;
                img.Save(targetms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] targetImageBytes = targetms.ToArray();
                targetBase64String = Convert.ToBase64String(targetImageBytes);
            }
            inputImage.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern int ChipModuleClean();
            ChipModuleClean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            console.Text = "";
            [DllImport("image_process.dll")]
            static extern float ImageFocusQuality(IntPtr source, int source_size);
            float ret = ImageFocusQuality(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            console.Text = "";
            [DllImport("image_process.dll")]
            static extern float ImageLightQuality(IntPtr source, int source_size);
            float ret = ImageLightQuality(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length);
        }
    }
}
