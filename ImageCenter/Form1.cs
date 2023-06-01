using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace ImageCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            [DllImport("C:\\Users\\ywang2\\source\\repos\\ImageProcessModule\\build\\imageProcessAlgor\\Debug\\Myimageops.dll")]
            static extern void BaseFunctionTest(IntPtr data, int length);

            [DllImport("C:\\Users\\ywang2\\source\\repos\\ImageProcessModule\\build\\imageProcessAlgor\\Debug\\Myimageops.dll")]
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