namespace ImageCenter
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
            button1 = new Button();
            load_status = new Label();
            console = new RichTextBox();
            selectDllPath = new OpenFileDialog();
            selectImage = new Button();
            selectTarget = new Button();
            openImage = new OpenFileDialog();
            openTarget = new OpenFileDialog();
            imagePathLabel = new Label();
            targetPathLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(398, 308);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 0;
            button1.Text = "Start Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(52, 40);
            load_status.Name = "load_status";
            load_status.Size = new Size(42, 15);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            load_status.Click += load_status_Click;
            // 
            // console
            // 
            console.Location = new Point(52, 76);
            console.Margin = new Padding(2);
            console.Name = "console";
            console.Size = new Size(619, 207);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(52, 308);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(130, 44);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(223, 308);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(130, 44);
            selectTarget.TabIndex = 5;
            selectTarget.Text = "Select Target...";
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
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Location = new Point(56, 368);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new Size(70, 15);
            imagePathLabel.TabIndex = 6;
            imagePathLabel.Text = "Image path:";
            // 
            // targetPathLabel
            // 
            targetPathLabel.AutoSize = true;
            targetPathLabel.Location = new Point(56, 394);
            targetPathLabel.Name = "targetPathLabel";
            targetPathLabel.Size = new Size(69, 15);
            targetPathLabel.TabIndex = 7;
            targetPathLabel.Text = "Target path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(targetPathLabel);
            Controls.Add(imagePathLabel);
            Controls.Add(selectTarget);
            Controls.Add(selectImage);
            Controls.Add(console);
            Controls.Add(load_status);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label load_status;
        private RichTextBox console;
        private string dllPath = "";
        private string imagePath = "";
        private string targetPath = "";
        private OpenFileDialog selectDllPath;
        private Button selectImage;
        private Button selectTarget;
        private OpenFileDialog openImage;
        private OpenFileDialog openTarget;
        private Label imagePathLabel;
        private Label targetPathLabel;
    }
}