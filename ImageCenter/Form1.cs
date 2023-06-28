using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace ImageCenter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StartAllTest.Text = "Please select DLL...";
        }
        delegate void DebugCallbackDelegate(string message);

        private void DebugCallback(string message)
        {
            Console.WriteLine("DEBUG: " + message);
            console.Text += "************************\n";
            console.Text += message;
            console.Text += "\n************************\n";
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

            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
            static extern void BaseFunctionTest(IntPtr data, int length);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            console.Text = "[Info] Calling BaseFunctionTest...\n";
            try
            {
                BaseFunctionTest(IntPtr.Zero, "hello world".Length);
                console.Text += "\n[Info] Calling BaseFunctionTest...Done";
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
            openImage.FileName = "*.jpg";
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
            openTarget.FileName = "*.jpg";
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
            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
            static extern int RotateTransform(IntPtr source, int source_size, ref double angle, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                double angle = 0.0;
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
            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
            static extern int MatchTarget(IntPtr source, int source_size, IntPtr target, int target_size, int originalPosX, int originalPosY, ref int loc_x, ref int loc_y, out IntPtr resultPtr);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            try
            {
                int quality = -1;
                int origianlPosX = 345;
                int origianlPosY = 185;
                int loc_x = 0, loc_y = 0;
                IntPtr resultPtr = IntPtr.Zero;
                quality = MatchTarget(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, origianlPosX, origianlPosY, ref loc_x, ref loc_y, out resultPtr);
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
            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
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
            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
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
            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);
            [DllImport("Myimageops.dll")]
            static extern int PixelSizeMeasure(IntPtr source, int source_size, int focalDistance, ref int pixelSize);
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            try
            {
                int pixelSize = 0;
                int ret = PixelSizeMeasure(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, 8, ref pixelSize);
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
    }
}