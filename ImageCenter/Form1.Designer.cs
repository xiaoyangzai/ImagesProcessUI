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
            button1.Location = new Point(726, 513);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(231, 73);
            button1.TabIndex = 0;
            button1.Text = "Start Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(74, 67);
            load_status.Margin = new Padding(4, 0, 4, 0);
            load_status.Name = "load_status";
            load_status.Size = new Size(64, 25);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            load_status.Click += load_status_Click;
            // 
            // console
            // 
            console.Location = new Point(74, 127);
            console.Name = "console";
            console.Size = new Size(883, 342);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // selectDllPath
            // 
            selectDllPath.FileName = "openFileDialog1";
            // 
            // selectImage
            // 
            selectImage.Location = new Point(74, 513);
            selectImage.Margin = new Padding(4, 5, 4, 5);
            selectImage.Name = "selectImage";
            selectImage.Size = new Size(186, 73);
            selectImage.TabIndex = 4;
            selectImage.Text = "Select (or Rotated) Image...";
            selectImage.UseVisualStyleBackColor = true;
            selectImage.Click += selectImage_Click;
            // 
            // selectTarget
            // 
            selectTarget.Location = new Point(402, 513);
            selectTarget.Margin = new Padding(4, 5, 4, 5);
            selectTarget.Name = "selectTarget";
            selectTarget.Size = new Size(186, 73);
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
            imagePathLabel.Location = new Point(80, 613);
            imagePathLabel.Margin = new Padding(4, 0, 4, 0);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new Size(107, 25);
            imagePathLabel.TabIndex = 6;
            imagePathLabel.Text = "Image path:";
            // 
            // targetPathLabel
            // 
            targetPathLabel.AutoSize = true;
            targetPathLabel.Location = new Point(80, 657);
            targetPathLabel.Margin = new Padding(4, 0, 4, 0);
            targetPathLabel.Name = "targetPathLabel";
            targetPathLabel.Size = new Size(105, 25);
            targetPathLabel.TabIndex = 7;
            targetPathLabel.Text = "Target path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 750);
            Controls.Add(targetPathLabel);
            Controls.Add(imagePathLabel);
            Controls.Add(selectTarget);
            Controls.Add(selectImage);
            Controls.Add(console);
            Controls.Add(load_status);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
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