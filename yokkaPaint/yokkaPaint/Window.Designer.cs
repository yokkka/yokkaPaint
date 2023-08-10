namespace yokkaPaint
{
    partial class yWindow
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
            openFileButton = new Button();
            paintBox = new PictureBox();
            arrowUpButton = new Button();
            arrowDownButton = new Button();
            ((System.ComponentModel.ISupportInitialize)paintBox).BeginInit();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(12, 12);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(94, 29);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open file";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_click;
            // 
            // paintBox
            // 
            paintBox.Location = new Point(125, 37);
            paintBox.Name = "paintBox";
            paintBox.Size = new Size(673, 412);
            paintBox.TabIndex = 1;
            paintBox.TabStop = false;
            paintBox.Click += pictureBox1_Click;
            // 
            // arrowUpButton
            // 
            arrowUpButton.Location = new Point(44, 368);
            arrowUpButton.Name = "arrowUpButton";
            arrowUpButton.Size = new Size(34, 29);
            arrowUpButton.TabIndex = 2;
            arrowUpButton.Text = " ↑";
            arrowUpButton.UseVisualStyleBackColor = true;
            arrowUpButton.Click += arrowUp;
            // 
            // arrowDownButton
            // 
            arrowDownButton.Location = new Point(44, 403);
            arrowDownButton.Name = "arrowDownButton";
            arrowDownButton.Size = new Size(34, 29);
            arrowDownButton.TabIndex = 3;
            arrowDownButton.Text = "↓";
            arrowDownButton.UseVisualStyleBackColor = true;
            arrowDownButton.Click += arrowDown;
            // 
            // yWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(arrowDownButton);
            Controls.Add(arrowUpButton);
            Controls.Add(paintBox);
            Controls.Add(openFileButton);
            Name = "yWindow";
            Text = "yokkaPaint C#";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)paintBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button openFileButton;
        public PictureBox paintBox;
        Graphics canvas;
        private Button arrowUpButton;
        private Button arrowDownButton;
    }
}