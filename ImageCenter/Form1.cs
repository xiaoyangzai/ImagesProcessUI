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
            if (selectDllPath.ShowDialog() == DialogResult.OK)
            {
                string filePath = selectDllPath.FileName;
                dllPath = Path.GetDirectoryName(filePath);
                if (dllPath == null || filePath == null)
                {
                    console.Text = "[Error]: Failed to select file DLL. Please re-select.";
                    return;
                }
                Directory.SetCurrentDirectory(dllPath);
                console.Text = "Select DLL: " + filePath;
            }
            if (dllPath == null)
            {
                return;
            }

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
            static extern int RotateTransform(IntPtr source, int source_size, ref float angle);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                float angle = 0;
                int ret = RotateTransform(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref angle);
                if (ret < 0)
                {
                    console.Text += "\n[Error] Failed to call RotateDegree function. Exit Code: " + ret;
                    return;
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
            static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size,  ref int offsetX, ref int offsetY, out IntPtr resultPtr, UInt16 fontSize = 5);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int offsetX = -1, offsetY = -1;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length,  ref offsetX, ref offsetY, out resultPtr, 7);
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
            static extern int CutLineDetection(IntPtr source, int source_size, ref int delta_x, ref int delta_y);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int delta_x = -1;
                int delta_y = -1;
                int ret = CutLineDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref delta_x, ref delta_y);
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
            static extern int CutTraceDetection(IntPtr source, int source_size, ref double tarceAngle, ref int traceCenterOffset, ref int tranceWidth, ref int maxTraceWith, ref int maxArea);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text = "[Info] Calling CutTraceDetection function...\n";
            try
            {
                double tarceAngle = 0.0;
                int traceCenterOffset = 0;
                int tranceWidth = -1;
                int maxTraceWith = -1;
                int maxArea = -1;
                int ret = CutTraceDetection(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref tarceAngle, ref traceCenterOffset, ref tranceWidth, ref maxTraceWith, ref maxArea);
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
            static extern int AutoAdjustFocus(int minPosition, int maxPosition, int step, CaptureImageDelegate callback,ref float optimumQuality,int currentPosition = -1, int timeout = -1, float refQuality = -1);
            try
            {
                console.Text = "[Info] Calling AutoFocus function...\n";
                float optQuality = 0.0f;
                int focus = AutoAdjustFocus(1, 16, 1, new CaptureImageDelegate(CaptureImage), ref optQuality, 5, 900, 0.2f);
                if (focus > 0)
                {
                    console.Text += "[Info] Best focus value: " + focus + "\n";
                    console.Text += "[Info] Best quality value: " + optQuality + "\n";
                    console.Text += "[Info] Calling AutoFocus function...Done\n";
                    return;
                }
                if (focus == -1)
                {
                    console.Text += "[Info] Calling AutoFocus function...Timeout\n";
                } else {
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
                int bright = AutoAdjustLight(1, 21, 1, new CaptureImageDelegate(CaptureImage), ref quality, -1, -1, 0.8f);
                console.Text += "[Info] Best bright value: " + bright + "\n";
                console.Text += "[Info] Best bright quality: " + quality+ "\n";
                console.Text += "[Info] Calling AutoBright function...Done\n";
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
    }
}