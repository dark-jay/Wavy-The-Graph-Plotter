using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_of_Wavy
{

    public partial class Form1 : Form
    {
        PictureBox myPictureBox = new PictureBox();
        Plotting p;
        Grid gridFirst;
        string inputEqation;

        public Form1()
        {
            InitializeComponent();

            myPictureBox = pbCanvas;
            gridFirst = new Grid(myPictureBox);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridFirst.drawGrid();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            plot();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myPictureBox.Refresh();
            txtInput.Text = "";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            gridFirst = new Grid(myPictureBox);
            gridFirst.drawGrid();

            plot();
        }

        private void plot() {
            inputEqation = txtInput.Text;
            if(inputEqation != "")
            {
                try {
                    p = new Plotting(inputEqation, myPictureBox);
                    p.clearCanvas();
                    p.plotGraph();
                }
                catch {  } // this doesnt work with unmannged code, i will write the exception later 
            }  
        }
    }
}
