using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Disk
    {
        private Point point;
        private int width;
        private int height;
        private Color color;
        private int number;

        public Disk(int x, int y, int num, int width)
        {
            this.width = width;
            this.height = height;
            color = Color.Black;
            point = new Point(x, y);
            number = num;
        }

        public int numb
        {
            get { return number; }
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawEllipse(pen, point.X, point.Y, width, height);
        }
    }
}
