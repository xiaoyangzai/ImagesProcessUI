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
            button1.Text = "Select DLL...";
            button1.Enabled = false;
        }
        // 委托类型
        delegate void DebugCallbackDelegate(string message);

        // 回调函数
        private void DebugCallback(string message)
        {
            Console.WriteLine("DEBUG: " + message);
            console.Text += "************************\n";
            console.Text += message;
            console.Text += "************************\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dllPath == "")
            {
                if (selectDllPath.ShowDialog() == DialogResult.OK)
                {
                    string filePath = selectDllPath.FileName;
                    dllPath = Path.GetDirectoryName(filePath);
                    Directory.SetCurrentDirectory(dllPath);
                    button1.Text = "Start Test";
                }
                else
                {
                    return;
                }
            }
            [DllImport("Myimageops.dll")]
            static extern void BaseFunctionTest(IntPtr data, int length);

            [DllImport("Myimageops.dll")]
            static extern void SetDebugCallback(DebugCallbackDelegate callback);

            [DllImport("Myimageops.dll")]
            static extern int MatchTarget(IntPtr source, int source_size, IntPtr target, int target_size, ref int loc_x, ref int loc_y);

            [DllImport("Myimageops.dll")]
            static extern int RotateTransform(IntPtr source, int source_size, ref double angle);

            [DllImport("Myimageops.dll")]
            static extern int PixelSizeMeasure(IntPtr source, int source_size, int focalDistance, ref int pixelSize);

            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));

            byte[] imageBytes = File.ReadAllBytes(imagePath);
            byte[] targetBytes = File.ReadAllBytes(targetPath);

            // encode image with Base64 
            string imageBase64String = Convert.ToBase64String(imageBytes);
            string targetBase64String = Convert.ToBase64String(targetBytes);
            try
            {
                BaseFunctionTest(IntPtr.Zero, "hello world".Length);
                int quality = -1;
                int loc_x = 0, loc_y = 0;
                quality = MatchTarget(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, Marshal.StringToHGlobalAnsi(targetBase64String), targetBase64String.Length, ref loc_x, ref loc_y);
                double angle = 0.0;
                int ret = RotateTransform(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, ref angle);

                int pixelSize = 0;
                ret = PixelSizeMeasure(Marshal.StringToHGlobalAnsi(imageBase64String), imageBase64String.Length, 8, ref pixelSize);
                load_status.Text = "Status: Done! Quality: " + quality.ToString() + " loc_x: " + loc_x.ToString() + " loc_y: " + loc_y.ToString();
            }
            catch (DllNotFoundException)
            {
                load_status.Text = "Status: DLL not found!!";
            }
            catch (EntryPointNotFoundException)
            {
                load_status.Text = "Status: Function not found!!";
            }
        }

        private void msg_Click(object sender, EventArgs e)
        {

        }

        private void load_status_Click(object sender, EventArgs e)
        {

        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            if (imagePath == "")
            {
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openImage.FileName;
                    imagePathLabel.Text = imagePath;
                    if (targetPath != "")
                        button1.Enabled = true;
                }
                else
                {
                    return;
                }
            }
        }

        private void selectTarget_Click(object sender, EventArgs e)
        {
            if (targetPath == "")
            {
                if (openTarget.ShowDialog() == DialogResult.OK)
                {
                    targetPath = openTarget.FileName;
                    targetPathLabel.Text = targetPath;
                    if (imagePath != "")
                        button1.Enabled = true;
                }
                else
                {
                    return;
                }
            }
        }
    }
}