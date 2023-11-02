using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Game[] Towers = new Game[3];
        bool IsGameStart = false;
        public Form1()
        {


            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = CreateGraphics();
            
            
            Towers[0] = new Game(1);    
            Towers[1] = new Game(2);
            Towers[2] = new Game(3);
            for (int i = Convert.ToInt32(textBox5.Text); i > 0; i--)
            {
                Disk disk = new Disk(i);
                disk.point = new Point(130-i*2, (310-16*Convert.ToInt32(textBox5.Text))+16*i);
                Towers[0].Add(disk);
            }

            IsGameStart = true;
            Refresh();
            button1.Visible = false;
            textBox5.Visible = false;
            label5.Visible = false;
        }
        
        public void Hanoi(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                Hanoi(n-1, from, other, to);
                var temp = Towers[from].disks.Pop();
                temp.point = new Point(130 + to * 150, (310-16*Convert.ToInt32(textBox5.Text)) + 16 * temp.numb);
                Towers[to].disks.Push(temp);
                Thread.Sleep(250);
                Hanoi(n - 1, other, to, from);
            }
            Refresh();
        }
        

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (IsGameStart)
            {
                Pen pen = new Pen(Color.BlueViolet, 13);
                Point[] points = new Point[6]
                {
                    new Point(150,150),
                    new Point(150, 350),
                    new Point(300,150),
                    new Point(300, 350),
                    new Point(450,150),
                    new Point(450, 350),
                };
                for (int i = 0; i < 6; i+=2)
                {
                    e.Graphics.DrawLine(pen, points[i], points[i+1]);
                }
                
                var stack1 = Towers[0].disks;
                var stack2 = Towers[1].disks;
                var stack3 = Towers[2].disks;
                
                
                if (stack1 != null)
                {
                    foreach (var VARIABLE in stack1)
                    {
                        VARIABLE.Draw(e.Graphics);
                    }
                }
                if (stack2 != null)
                {
                    foreach (var VARIABLE in stack2)
                    {
                        VARIABLE.Draw(e.Graphics);
                    }
                }
                if (stack3 != null)
                {
                    foreach (var VARIABLE in stack3)
                    {
                        VARIABLE.Draw(e.Graphics);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Hanoi(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox4.Text));
        }
    }
}
