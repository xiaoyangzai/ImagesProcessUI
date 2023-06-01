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
            console.Text = message;
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
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            IntPtr ptr = Marshal.AllocHGlobal(30);
            try
            {
                BaseFunctionTest(ptr, 20);
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