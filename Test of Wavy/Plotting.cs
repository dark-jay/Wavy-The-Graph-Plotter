using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Test_of_Wavy
{
    class Plotting
    {
        private string infix;
        private double y;
        private double noOfPeriod = 5;
        private double period = 2 * Math.PI;
        private double plotSpeed = 0.1F;
        PictureBox myPictureBox;

        private double x2 = 0, y1 = 0, y2 = 0, x1 = 0;
        private double topSpacing; // distance from top
        private double sizeMul = 30; // size multiplier
        private double leftSpacing; // left spacing

        private float tempX1;
        private float tempY1;
        private float tempX2;
        private float tempY2;

        public Plotting(string s, PictureBox p) {
            infix = s;
            myPictureBox = p;
        }
        private double getYvalue(double x) {
            unsafe
            {
                mspWrapper.mspWrapperClass myMsp = new mspWrapper.mspWrapperClass(infix);
                y = myMsp.ReturnYvalue(x);
            }
            return y;
        }

        public void plotGraph() {
            Graphics g = myPictureBox.CreateGraphics();

            Pen pen = new Pen(Brushes.Red, 1F);

            x2 = 0; //if we dont make it 0 every time when the plotGraph() funtion is call, there will be stright line drawn on the picturebox 

            // putting everything at the (0,0) co-ordinate
            topSpacing = myPictureBox.Height / 2;
            leftSpacing = myPictureBox.Width / 2;
            //myLabel.Text = leftSpacing.ToString() + " " + topSpacing.ToString();

            // left
            for (x2 = 0; x2 > -noOfPeriod * period; x2 -= plotSpeed)
            {
                y2 = -getYvalue(x2);

                if (x2 == 0)
                {
                    x1 = x2;
                    y1 = y2;
                }

                tempX1 = (float)(x1 * sizeMul + leftSpacing);
                tempY1 = (float)(y1 * sizeMul + topSpacing);

                tempX2 = (float)(x2 * sizeMul + leftSpacing);
                tempY2 = (float)(y2 * sizeMul + topSpacing);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, tempX1, tempY1, tempX2, tempY2);

                x1 = x2;
                y1 = y2;
            }
            //right
            for (x2 = 0; x2 < noOfPeriod * period; x2 += plotSpeed)
            {
                y2 = -getYvalue(x2);
                
                if (x2 == 0)
                {
                    x1 = x2;
                    y1 = y2;
                }

                tempX1 = (float)(x1 * sizeMul + leftSpacing);
                tempY1 = (float)(y1 * sizeMul + topSpacing);

                tempX2 = (float)(x2 * sizeMul + leftSpacing);
                tempY2 = (float)(y2 * sizeMul + topSpacing);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, tempX1, tempY1, tempX2, tempY2);

                /*
                // 0.999574
                if (y2 >= 0.999990 && y2 <= 1)
                {
                    myLabel.Text = tempX2.ToString() + " " + tempY2.ToString();
                }
                */
                x1 = x2;
                y1 = y2;
            }
        }

        public void clearCanvas() {
            myPictureBox.Refresh();
            resetAllValue();
        }

        private void resetAllValue()
        {
            x2 = 0; y1 = 0; y2 = 0; x1 = 0; topSpacing = 0; leftSpacing = 0;
        }

        public void setPeriod(double d) {
            period = d;
        }
    }
}
