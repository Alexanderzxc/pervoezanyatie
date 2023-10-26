using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Game[] Towers = new Game[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = CreateGraphics();
            Towers[0] = new Game(g, 1);
            Towers[1] = new Game(g, 2);
            Towers[2] = new Game(g, 3);
            for (int i = 8; i > 0; i--)
            {
                Disk disk = new Disk(50, 30 * i, i, 50 + i * 2);
                Towers[0].Add(disk);
            }
        }
        public void Hanoi(int from, int to, int cou)
        {
            int to2 = 6 - from - to;
            if (cou > 1)
            {
                Hanoi(from, to2, cou - 1);
                Hanoi(from, to, 1);
                Hanoi(to2, to, cou - 1);
            }
            else
            {
                Towers[to].Add();
            }
            if (c != null)
            {
                c[0].Draw();
                c[1].Draw();
                c[2].Draw();
            }
        }
    }
}
