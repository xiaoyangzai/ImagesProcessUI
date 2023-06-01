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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(380, 494);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(232, 86);
            button1.TabIndex = 0;
            button1.Text = "Start Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // load_status
            // 
            load_status.AutoSize = true;
            load_status.Location = new Point(75, 67);
            load_status.Margin = new Padding(4, 0, 4, 0);
            load_status.Name = "load_status";
            load_status.Size = new Size(64, 25);
            load_status.TabIndex = 1;
            load_status.Text = "Status:";
            load_status.Click += load_status_Click;
            // 
            // console
            // 
            console.Location = new Point(75, 126);
            console.Name = "console";
            console.Size = new Size(882, 343);
            console.TabIndex = 3;
            console.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 750);
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
        private byte[] imageBytes;
    }
}