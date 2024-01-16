using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _421_Lab_1
{
    public partial class Form1 : Form
    {
        bool mouseDown = false;
        int oldX;
        int oldY;
        int redCol = 0;
        int blueCol = 0;
        int greenCol = 0;

        Shape Tool;
        Pen colorPen;
        Color shapeColor;
        public Form1()
        {
            InitializeComponent();
            Tool = new Line();
            shapeColor = Color.Black;
            colorPen = new Pen(shapeColor);
            trackBar1.Maximum = 255;
            trackBar2.Maximum = 255;
            trackBar3.Maximum = 255;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tool = new Line();
           // colorPen = new Pen(Color.Red);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
            mouseDown = true;
        }

      

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Graphics gr = panel1.CreateGraphics();
         
            Tool.drawShape(gr, colorPen, oldX, oldY, e.X, e.Y);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redCol = trackBar1.Value;
            shapeColor = Color.FromArgb(redCol, greenCol, blueCol);
            colorPen = new Pen(shapeColor);

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blueCol = trackBar2.Value;
            shapeColor = Color.FromArgb(redCol, greenCol, blueCol);
            colorPen = new Pen(shapeColor);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            greenCol = trackBar3.Value;
            shapeColor = Color.FromArgb(redCol, greenCol, blueCol);
            colorPen = new Pen(shapeColor);
        }
    }
    public   class Shape 
    {
        public  Pen shape;
        public  Color shapeColor;

        public void drawShape(Graphics g, Pen p, int oldx, int oldy, int newx, int newy)
        {
            g.DrawLine(p, oldx, oldy, newx, newy);
        }
        


    }

    public class Line: Shape
    {
        public Line()
        {
            
        }

        public new void  drawShape(Graphics g, Pen p,int oldx, int oldy, int newx, int newy)
        {
            g.DrawLine(p, oldx, oldy, newx, newy);
        }
        
    }
   
}
