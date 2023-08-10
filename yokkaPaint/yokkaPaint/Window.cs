using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Windows.Input;

namespace yokkaPaint
{
    public partial class yWindow : Form
    {
        int paintBoxX = 125;
        int paintBoxY = 37;
        TextBox control = new TextBox();
        Graphics canvas;
        Pen pen;
        bool drawMode = false;
        System.Windows.Forms.Timer drawTicker;
        int MouseX = 10;
        int MouseY = 10;
        int BrushSize = 4;

        string Mode = "Pen";

        public yWindow()
        {
            //KeyboardTask();
            /*            control.Location = new Point(-100, -100);
                        this.Controls.Add(control);
                        control.KeyPress += new KeyPressEventHandler(keypress);*/
            InitializeComponent();
        }

        private void ChangePaintBoxPos(string dir)
        {
            switch (dir)
            {
                case "w":
                    paintBoxY -= 50;
                    break;
                case "s":
                    paintBoxY += 50;
                    break;
                case "d":
                    paintBoxX += 50;
                    break;
                case "a":
                    paintBoxX -= 50;
                    break;
            }

            Text = Convert.ToString($"{paintBoxX}, {paintBoxY}, {paintBox.Location.Y}");
            paintBox.Location = new Point(paintBoxX, paintBoxY);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brushSizeController.ValueChanged += new EventHandler(changeBrushSize);

        }

        private void changeBrushSize(object sender, EventArgs e)
        {
            BrushSize = Convert.ToInt16(brushSizeController.Value);
        }

        private void DrawingModeOn(object sender, MouseEventArgs e) { drawMode = true; }
        private void DrawingModeOff(object sender, MouseEventArgs e) { drawMode = false; }

        private void UpdateCursorCoords(object sender, MouseEventArgs e)
        {
            MouseX = e.Location.X;
            MouseY = e.Location.Y;
        }

        private void openFileButton_click(object sender, EventArgs e)
        {
            Bitmap openedImage = new Bitmap(@"C:\Users\bline\paint.jpg");
            canvas = Graphics.FromImage(openedImage);
            paintBox.Image = openedImage;

            paintBox.Size = new Size(openedImage.Width, openedImage.Height);

            paintBox.MouseDown += new MouseEventHandler(DrawingModeOn);
            paintBox.MouseUp += new MouseEventHandler(DrawingModeOff);
            paintBox.MouseMove += new MouseEventHandler(UpdateCursorCoords);

            drawTicker = new System.Windows.Forms.Timer();
            drawTicker.Interval = 20;
            drawTicker.Tick += new EventHandler(PaintTick);
            drawTicker.Start();
        }


        private void PaintTick(object sender, EventArgs e)
        {
            if (drawMode)
            {
                pen = new Pen(Brushes.Aqua);
                pen.Width = BrushSize
                    ;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                canvas.DrawRectangle(pen, MouseX, MouseY, BrushSize, BrushSize);

                pen.Dispose();
                paintBox.Invalidate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void arrowUp(object sender, EventArgs e)
        {
            ChangePaintBoxPos("s");
        }

        private void arrowDown(object sender, EventArgs e)
        {
            ChangePaintBoxPos("w");
        }

        private void arrowRight(object sender, EventArgs e)
        {
            ChangePaintBoxPos("d");
        }

        private void arrowLeft(object sender, EventArgs e)
        {
            ChangePaintBoxPos("a");
        }
    }
}