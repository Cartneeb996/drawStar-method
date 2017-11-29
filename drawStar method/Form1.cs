using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawStar_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawStar(Pen drawPen, float x, float y, int size)
        {
           
            Graphics gGraphics = this.CreateGraphics();
            Point TL = new Point(Convert.ToInt16(x), Convert.ToInt16(y));
            Point TM = new Point((TL.X + size) / 2, TL.Y);
            Point TR = new Point(TL.X + size, TL.Y);
            Point BL = new Point(TL.X, TL.Y + size);
            Point BM = new Point(TM.X, TL.Y + size);
            Point BR = new Point(TL.X + size, TL.Y + size);
            Point CL = new Point(TL.X, TL.Y + size / 2);
            Point CR = new Point(TL.X + size, TL.Y + size / 2);
            //Point BLR = new Point(B)

            
            //gGraphics.DrawRectangle(drawPen, x, y, size, size);
            Single offset = size / 10;
            gGraphics.DrawLine(drawPen, x + size / 2,  y, x + size/3, y + size / 2 - offset); // top peak, left side
            gGraphics.DrawLine(drawPen, x + size / 2, y, x + (size - size / 3) , y + size / 2 - offset); // top peak, right side
            gGraphics.DrawLine(drawPen, x + size / 3, y + size / 2 - offset, x, y + size / 2); // left peak, top
            gGraphics.DrawLine(drawPen, x + size, y + size / 2, x + (size - size / 3), y + size / 2 - offset); // right peak, top
            gGraphics.DrawLine(drawPen, x, y + size / 2, x + size / 3 - offset, y + size / 2 + offset); // left peak, bottom
            gGraphics.DrawLine(drawPen, x + size, y + size / 2, x + (size - size / 3) + offset, y + size / 2 + offset); // right peak, bottom
            gGraphics.DrawLine(drawPen, x + size / 3 - offset, y + size / 2 + offset, x + size / 3, y + size); // left bottom peak, left side
            gGraphics.DrawLine(drawPen, x + size / 2, y + size / 2 + offset * 2, x + size / 3, y + size); // left bottom peak, right side
            gGraphics.DrawLine(drawPen, x + (size - size / 3), y + size, x + (size - size / 3) + offset, y + size / 2 + offset); // right bottom peak, right side 
            gGraphics.DrawLine(drawPen, x + size / 2, y + size / 2 + offset * 2, x + (size - size / 3), y + size); // right bottom peak, left side
            

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen newPen = new Pen(Color.Black);

            DrawStar(newPen, 100, 100, 100);
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = Convert.ToString(e.X);
        }
    }
}
