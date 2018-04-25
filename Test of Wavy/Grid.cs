using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Test_of_Wavy
{
    class Grid
    {
        PictureBox myPictureBox;
        Bitmap DrawArea;

        public Grid(PictureBox p) {
            myPictureBox = p;

            DrawArea = new Bitmap(myPictureBox.Size.Width, myPictureBox.Size.Height);
            myPictureBox.Image = DrawArea;
        }
        public void drawGrid()
        {
            int x1, y1, x2, y2;

            // x axis
            x1 = 0; y1 = myPictureBox.Height / 2;
            x2 = myPictureBox.Width; y2 = myPictureBox.Height / 2;
            drawXaxis(x1, y1, x2, y2, "dark");
            
            // x axes

            // draw horizontal axes as long as we didint reach the top of the picturebox
            while (y1 > 0) {
                y1 -= 30;
                y2 -= 30;
                drawXaxis(x1, y1, x2, y2, "light");
            }
            x1 = 0; y1 = myPictureBox.Height / 2;
            x2 = myPictureBox.Width; y2 = myPictureBox.Height / 2;
            // draw horizontal axes as long as we didint reach the bottom of the picturebox
            while (y1 < myPictureBox.Height)
            {
                y1 += 30;
                y2 += 30;
                drawXaxis(x1, y1, x2, y2, "light");
            }

            // y axis

            x1 = myPictureBox.Width / 2; y1 = 0;
            x2 = myPictureBox.Width / 2; y2 = myPictureBox.Height;
            drawYaxis(x1, y1, x2, y2, "dark");

            // y axes
            // draw horizontal axes as long as we didint reach the top of the picturebox
            while (x1 > 0)
            {
                x1 -= 30;
                x2 -= 30;
                drawXaxis(x1, y1, x2, y2, "light");
            }
            x1 = myPictureBox.Width / 2; y1 = 0;
            x2 = myPictureBox.Width / 2; y2 = myPictureBox.Height;
            // draw horizontal axes as long as we didint reach the bottom of the picturebox
            while (x1 < myPictureBox.Width)
            {
                x1 += 30;
                x2 += 30;
                drawXaxis(x1, y1, x2, y2, "light");
            }
        }

        void drawXaxis(int x1, int y1, int x2, int y2, string GrayColorType)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen pen;

            if (GrayColorType == "dark")
                pen = new Pen(Brushes.Gray, 1F);
            else
                pen = new Pen(Brushes.LightGray, 1F);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLine(pen, x1, y1, x2, y2);

            myPictureBox.Image = DrawArea;
            g.Dispose();
        }

        void drawYaxis(int x1, int y1, int x2, int y2, string GrayColorType)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen pen;

            if (GrayColorType == "dark")
                pen = new Pen(Brushes.Gray, 1F);
            else
                pen = new Pen(Brushes.LightGray, 1F);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLine(pen, x1, y1, x2, y2);

            myPictureBox.Image = DrawArea;
            g.Dispose();
        }

        public void clearCanvas()
        {
            myPictureBox.Refresh();
        }

        /*
        void drawXaxes(int x1, int y1, int x2, int y2, string GrayColorType) {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen pen;

            if (GrayColorType == "dark")
                pen = new Pen(Brushes.Gray, 1F);
            else
                pen = new Pen(Brushes.LightGray, 1F);

            // loop until we done drawing the x axes 
            while (y1 > 0) {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, x1, y1, x2, y2);

                myPictureBox.Image = DrawArea;
            }
            
            g.Dispose();
        }
        */
    }
}
