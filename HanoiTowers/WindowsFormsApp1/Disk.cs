using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Disk
    {
        private int width;
        private int height;
        private Color color;
        private int number;
        public Point point { get; set; }
        public int TowerNum { get; set; }

        public Disk(int num)
        {
            width = 40+num*4;
            height = 15;
            if (TowerNum == 1)
            {
                point = new Point(250-num, 270 + height * num);
            }
            if (TowerNum == 2)
            {

                point = new Point(400, 270 + height * num);
            }
            if (TowerNum == 3)
            {
                point = new Point(550,270+height*num );
            }
            color = Color.IndianRed;
            point = new Point();
            number = num;
        }

        public int numb
        {
            get { return number; }
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 3);
            g.DrawEllipse(pen, point.X, point.Y, width, height);
        }
    }
}
