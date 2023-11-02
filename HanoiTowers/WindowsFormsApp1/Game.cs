using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Game 
    {
        private Stack<Disk> Stack;
        public int number;

        public Stack<Disk> disks
        {
            get { return Stack; }
            set { Stack=value; }
        }


        public Game(int number)
        {
            Stack = new Stack<Disk>();
            this.number = number;
        }

        public void Add(Disk disk)
        {
            Stack.Push(disk);
        }
        



    }
}
