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

        Shape Tool;
        Pen colorPen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tool = new Line();
            colorPen = new Pen(Color.Red);
            
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
    }
    public   class Shape 
    {
        public  Pen shape;
        public  Color shapeColor;

        public void drawShape()
        {

        }
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

        public void drawShape(Graphics g, Pen p,int oldx, int oldy, int newx, int newy)
        {
            g.DrawLine(p, oldx, oldy, newx, newy);
        }
        
    }
   
}
