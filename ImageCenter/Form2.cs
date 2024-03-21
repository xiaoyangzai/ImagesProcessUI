using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCenter
{
    public partial class Form2 : Form
    {
        delegate void DebugCallbackDelegate(string message);
        private void DebugCallback(string message)
        {
            console.Text += message;
        }
        [DllImport("image_process.dll")]
        static extern int GetUniqueTargetHigh(IntPtr image, int imageSize, int targetCenterX, int targetCenterY, int targetWidth, int targetHigh, ref int offsetX, ref int offsetY, out IntPtr outputTargetImage, out IntPtr outputMatchedImage, UInt16 fontSize = 5);

        [DllImport("image_process.dll")]
        static extern void SetDebugCallback(DebugCallbackDelegate callback);
        [DllImport("image_process.dll")]
        static extern int MatchTargetCenter(IntPtr source, int source_size, IntPtr target, int target_size, ref int offsetX, ref int offsetY, out IntPtr resultPtr, UInt16 fontSize = 5, bool isShowOffset = true);

        List<string> _sortedFilePathList;
        List<string> base64ImageStringList;
        List<PictureBox> pictureBoxesLeft;
        string _sourceImage;
        string _targetsString;
        string _imageBase64String;
        string base64TargetImageData;
        int nextIndex = 0;
        string[] targesStringList;

        private bool Stage_1st(int targetCenteX, int targetCenterY, int targetWidth, int targetHigh)
        {

            console.Text = "[Info] check stage 1...\n";
            try
            {
                console.Text += "[Info] GetUniqueTargetHigh() function...\n";
                IntPtr targetPtr = IntPtr.Zero;
                IntPtr resultPtr = IntPtr.Zero;
                int offsetX = -1;
                int offsetY = -1;
                int ret = GetUniqueTargetHigh(Marshal.StringToHGlobalAnsi(_imageBase64String), _imageBase64String.Length, targetCenteX, targetCenterY, targetWidth, targetHigh, ref offsetX, ref offsetY, out targetPtr, out resultPtr);
                if (resultPtr != IntPtr.Zero)
                {
                    string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pictureBoxSouce.Image = Image.FromStream(ms);
                }
                if (ret < 0 || (ret < 90 && offsetX > 2 || offsetY > 2))
                {
                    console.Text += "\n[Error] Target is not valid :\n\tMatched quality: " + ret + "\n\toffset X: " + offsetX + "\n\toffsetY: " + offsetY + "\n";
                    return false;
                }
                if (targetPtr != IntPtr.Zero)
                {
                    pictureBoxTarget.Image = null;
                    base64TargetImageData = Marshal.PtrToStringAnsi(targetPtr);
                    byte[] imageBytes = Convert.FromBase64String(base64TargetImageData);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pictureBoxTarget.Image = Image.FromStream(ms);
                }
                console.Text += "\n[Info] Calling GetUniqueTargetHigh() function...Done!\n";
                console.Text += "[Info] Calling GetUniqueTargetHigh() function...Done\n";
            }
            catch (DllNotFoundException)
            {
                console.Text += "[Error] DLL not found!!\n";
            }
            catch (EntryPointNotFoundException)
            {
                console.Text += "[Error] Functior not found!!\n";
            }
            return true;
        }
        private bool Stage_2nd()
        {
            if (base64TargetImageData == "")
            {
                console.Text += "[Error] Target image is not valid.\n";
                return false;
            }
            console.Text = "[Info] check stage 2...\n";
            bool ret = false;

            for (int i = 0; i < 9; i++)
            {
                string sourceBase64String = base64ImageStringList[i];
                try
                {
                    int quality = -1;
                    int offsetX = -1, offsetY = -1;
                    IntPtr resultPtr = IntPtr.Zero;
                    quality = MatchTargetCenter(Marshal.StringToHGlobalAnsi(sourceBase64String), sourceBase64String.Length, Marshal.StringToHGlobalAnsi(base64TargetImageData), base64TargetImageData.Length, ref offsetX, ref offsetY, out resultPtr, 7);
                    if (quality < 0)
                    {
                        console.Text += "\n[Error] Failed to call MatchTargetCenter function. Exit Code: " + quality;
                        return false;
                    }
                    if (resultPtr != IntPtr.Zero)
                    {
                        string base64ImageData = Marshal.PtrToStringAnsi(resultPtr);
                        byte[] imageBytes = Convert.FromBase64String(base64ImageData);
                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBoxesLeft[i].Image = Image.FromStream(ms);
                    }
                    //if (quality >= 60)
                    //    return false;
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
            console.Text = "[Info] check stage 2...Done\n";
            return true;
        }
        private bool Stage_3rd()
        {
            return true;
        }
        private bool CheckTarget(int targetCenteX, int targetCenterY, int targetWidth, int targetHigh)
        {
            // 1. get target image if it is unique
            if (Stage_1st(targetCenteX, targetCenterY, targetWidth, targetHigh) == false)
                return false;
            // 2. 九宫格校验
            if (Stage_2nd() == false)
                return false;
            // 3. 步进校验
            return true;
        }

        public Form2(string sourceImage, string targetsString, List<string> sortedFilePathList)
        {
            InitializeComponent();
            _sortedFilePathList = sortedFilePathList;
            _sourceImage = sourceImage;
            _targetsString = targetsString;

            // source image
            byte[] imageBytes = File.ReadAllBytes(_sourceImage);
            _imageBase64String = Convert.ToBase64String(imageBytes);

            // 九宫图

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetDebugCallback(new DebugCallbackDelegate(DebugCallback));
            // 1. 九宫格
            // 左上角-中上-右上角
            // 左边- 中间-右边
            // 左下角-中下-右小角
            pictureBoxesLeft = new List<PictureBox> {
                pictureBox0, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16 };
            base64ImageStringList = new List<string>();
            for (int i = 0; i < 17; i++)
            {
                // pictureBoxesLeft[i].Image = Image.FromFile(_sortedFilePathList[i]);
                byte[] imageBytes = File.ReadAllBytes(_sortedFilePathList[i]);
                base64ImageStringList.Add(Convert.ToBase64String(imageBytes));
            }
            nextIndex = 0;
            targesStringList = _targetsString.Split(',');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var box in pictureBoxesLeft)
            {
                box.Image = null;
            }
            pictureBoxSouce.Image = null;
            pictureBoxTarget.Image = null;
            base64TargetImageData = "";
            console.Text = "Parse the target string...index: " + nextIndex + "\n";
            string targe = targesStringList[nextIndex++];
            {
                string[] subItems = targe.Split('-');
                int targetCenterX = Convert.ToInt32(subItems[0]);
                int targetCenterY = Convert.ToInt32(subItems[1]);
                int targetWidth = Convert.ToInt32(subItems[2]);
                int targetHigh = Convert.ToInt32(subItems[3]);
                console.Text += "check target located at " + targetCenterX + "*" + targetCenterY + " with size " + targetWidth + "*" + targetHigh + "...\n";
                button1.Enabled = false;
                bool ret = CheckTarget(targetCenterX, targetCenterY, targetWidth, targetHigh);
                if (ret == false)
                {
                    console.Text += "\nInvalid target\n";
                }
                console.Text += "check target located at " + targetCenterX + "*" + targetCenterY + " with size " + targetWidth + "*" + targetHigh + "...Done\n";
                button1.Enabled = true;
            }

        }
    }
}
