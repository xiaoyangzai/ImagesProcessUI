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
            static extern void Base64Decoder(IntPtr data, int length);

            [DllImport("Myimageops.dll")]
            static extern void Base64Encoder(IntPtr data, int length);

            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            IntPtr encodedPtr = Marshal.StringToCoTaskMemUTF8("aGVsbG8gd29ybGQ=");
            IntPtr decodedPtr = Marshal.StringToCoTaskMemUTF8("hello world");
            try
            {
                //BaseFunctionTest(decodedPtr,"hello world".Length);
                Base64Decoder(encodedPtr,"aGVsbG8gd29ybGQ=".Length);
                Base64Encoder(decodedPtr,"hello world".Length);
                load_status.Text = "Status: Done!!";
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
    }
}