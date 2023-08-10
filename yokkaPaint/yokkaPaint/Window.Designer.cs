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
            penButton = new Button();
            eraserButton = new Button();
            brushSizeController = new NumericUpDown();
            arrowRightButton = new Button();
            arrowLeftButton = new Button();
            colorPicker = new ColorDialog();
            colorPanel = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)paintBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brushSizeController).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(3, 2);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(116, 29);
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
            // penButton
            // 
            penButton.Location = new Point(125, 2);
            penButton.Name = "penButton";
            penButton.Size = new Size(94, 29);
            penButton.TabIndex = 4;
            penButton.Text = "Pen";
            penButton.UseVisualStyleBackColor = true;
            // 
            // eraserButton
            // 
            eraserButton.Location = new Point(225, 2);
            eraserButton.Name = "eraserButton";
            eraserButton.Size = new Size(94, 29);
            eraserButton.TabIndex = 5;
            eraserButton.Text = "Eraser";
            eraserButton.UseVisualStyleBackColor = true;
            // 
            // brushSizeController
            // 
            brushSizeController.Location = new Point(325, 4);
            brushSizeController.Name = "brushSizeController";
            brushSizeController.Size = new Size(43, 27);
            brushSizeController.TabIndex = 6;
            brushSizeController.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // arrowRightButton
            // 
            arrowRightButton.Location = new Point(84, 387);
            arrowRightButton.Name = "arrowRightButton";
            arrowRightButton.Size = new Size(35, 29);
            arrowRightButton.TabIndex = 7;
            arrowRightButton.Text = "→";
            arrowRightButton.UseVisualStyleBackColor = true;
            arrowRightButton.Click += arrowRight;
            // 
            // arrowLeftButton
            // 
            arrowLeftButton.Location = new Point(3, 387);
            arrowLeftButton.Name = "arrowLeftButton";
            arrowLeftButton.Size = new Size(35, 29);
            arrowLeftButton.TabIndex = 8;
            arrowLeftButton.Text = "←";
            arrowLeftButton.UseVisualStyleBackColor = true;
            arrowLeftButton.Click += arrowLeft;
            // 
            // colorPicker
            // 
            colorPicker.ShowHelp = true;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = SystemColors.ControlLight;
            colorPanel.Cursor = Cursors.Hand;
            colorPanel.ForeColor = Color.CornflowerBlue;
            colorPanel.Location = new Point(374, 4);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(29, 27);
            colorPanel.TabIndex = 9;
            colorPanel.Click += openColorPicker;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 461);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Location = new Point(120, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 39);
            panel2.TabIndex = 11;
            // 
            // yWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(colorPanel);
            Controls.Add(arrowLeftButton);
            Controls.Add(arrowRightButton);
            Controls.Add(brushSizeController);
            Controls.Add(eraserButton);
            Controls.Add(penButton);
            Controls.Add(arrowDownButton);
            Controls.Add(arrowUpButton);
            Controls.Add(openFileButton);
            Controls.Add(panel1);
            Controls.Add(paintBox);
            Name = "yWindow";
            Text = "yokkaPaint C#";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)paintBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)brushSizeController).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button openFileButton;
        public PictureBox paintBox;
        private Button arrowUpButton;
        private Button arrowDownButton;
        private Button penButton;
        private Button eraserButton;
        private NumericUpDown brushSizeController;
        private Button arrowRightButton;
        private Button arrowLeftButton;
        private ColorDialog colorPicker;
        private Panel colorPanel;
        private Panel panel1;
        private Panel panel2;
    }
}