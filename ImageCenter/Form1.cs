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

namespace ImageCenter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StartAllTest.Text = "Please select DLL...";
            if (imagePath != "")
            {
                Image inputFile = Image.FromFile(imagePath);
                inputImage.Image = inputFile;
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                imageBase64String = Convert.ToBase64String(imageBytes);
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            selectDllPath.FileName = "*.dll";
            string filePath = dllPath + "image_process.dll";
            if (dllPath == null && selectDllPath.ShowDialog() == DialogResult.OK)
            {
                filePath = selectDllPath.FileName;
                dllPath = Path.GetDirectoryName(filePath);
                if (dllPath == null || filePath == null)
                {
                    console.Text = "[Error]: Failed to select file DLL. Please re-select.";
                    return;
                }
            }
            if (dllPath == null)
            {
                return;
            }
            Directory.SetCurrentDirectory(dllPath);
            console.Text = "Select DLL: " + filePath;

            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern void BaseFunctionTest(IntPtr data, int length);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text = "[Info] Calling BaseFunctionTest...\n";
            try
            {
                BaseFunctionTest(IntPtr.Zero, "hello world".Length);
                console.Text += "\n[Info] Calling BaseFunctionTest...Done\n";
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
            console.Text = "[Info] Calling MatcherTarget function...\n";
            [DllImport("image_process.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("image_process.dll")]
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, UInt16 fontSize = 5);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref offsetX, ref offsetY, out resultPtr, 7);
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
            static extern int CutLineDetection(IntPtr source, int source_size, ref int width, ref int offsetY, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int width = -1;
                int offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                int ret = CutLineDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref width, ref offsetY, out resultPtr);
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
            static extern int CutTraceDetection(IntPtr source, int source_size, ref int traceCenterOffset, ref int tranceWidth, ref int maxTraceWith, ref int maxArea, int cutLineCenterY, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text = "[Info] Calling CutTraceDetection function...\n";
            try
            {
                int traceCenterOffset = 0;
                int tranceWidth = -1;
                int maxTraceWith = -1;
                int maxArea = -1;
                IntPtr resultPtr = IntPtr.Zero;
                int cutLineCencertLocY = (int)cutCenterLocY.Value;
                int ret = CutTraceDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref traceCenterOffset, ref tranceWidth, ref maxTraceWith, ref maxArea, cutLineCencertLocY, out resultPtr);
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
    }
}