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

        public yWindow()
        {
            //KeyboardTask();
            /*            control.Location = new Point(-100, -100);
                        this.Controls.Add(control);
                        control.KeyPress += new KeyPressEventHandler(keypress);*/
            paintBox.CreateGraphics();
            InitializeComponent();
        }

        private void ChangePaintBoxPos(string dir)
        {
            switch (dir)
            {
                case "w":
                    paintBoxY -= 5;
                    break;
                case "s":
                    paintBoxY += 5;
                    break;
            }

            Text = Convert.ToString($"{paintBoxX}, {paintBoxY}, {paintBox.Location.Y}");
            paintBox.Location = new Point(paintBoxX, paintBoxY);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
        }

        private void openFileButton_click(object sender, EventArgs e)
        {
            Bitmap openedImage = new Bitmap(@"C:\Users\bline\paint.jpg");
            Graphics graphics = Graphics.FromImage(openedImage);
            paintBox.Image = openedImage;
            paintBox.Size = new Size(openedImage.Width, openedImage.Height);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void arrowUp(object sender, EventArgs e)
        {
            ChangePaintBoxPos("w");
        }

        private void arrowDown(object sender, EventArgs e)
        {
            ChangePaintBoxPos("s");
        }
    }
}