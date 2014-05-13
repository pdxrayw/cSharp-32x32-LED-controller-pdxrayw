using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_LED_cSharp
{
    public partial class Form1 : Form
    {
        private Point currentMousePos;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = 32;
            int cellSize = 5;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y <= numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x <= numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            currentMousePos = e.Location;
            x = (currentMousePos.X)/5;
            txtPosX.Text = x.ToString();
            y = (currentMousePos.Y)/5;
            txtPosY.Text = y.ToString();
            txtAdjPosY.Text = (y).ToString();
            txtAdjPosX.Text = (x).ToString();

            DrawingSquares(x*5, y*5);
        }


        public void DrawingSquares(int x, int y)//the function gets x and y to know where to print the square.
        {
            Graphics graphicsObj;
            

            //Draw a solid Rectangle of desired color
            graphicsObj = pictureBox1.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Crimson);
            Rectangle myRectangle1 = new Rectangle(x, y, 5, 5);
            graphicsObj.FillRectangle(myBrush, myRectangle1);


            //suround the solid rectangle with a black rectangle for visual aestetics
            //graphicsObj = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 1);
            Rectangle myRectangle2 = new Rectangle(x, y, 5, 5);
            graphicsObj.DrawRectangle(myPen, myRectangle2);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }

}
