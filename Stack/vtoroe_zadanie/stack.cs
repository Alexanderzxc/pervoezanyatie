using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace vtoroe_zadanie
{
    public class stack
    {
        private int currentindex;
        private int[] mystack;
        

        public stack(int razmer)
        {
            mystack = new int[razmer];
            currentindex = 0;
        }

        public void push()
        {
            if (currentindex < mystack.Length)
            {
                Random rnd = new Random();
                mystack[currentindex] = rnd.Next(1, 150);
                currentindex += 1;
            }
        }

        public void pop()
        {
            mystack[currentindex - 1] = 0;
            currentindex--;
        }

        public string peek()
        {
            return Convert.ToString(mystack[currentindex - 1]);
        }

        public void Values(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var VARIABLE in mystack)
            {
                listBox.Items.Add(VARIABLE);
            }
        }

        public int[] Reverse()
        {
            var temp = new int[mystack.Length];
            for (int i = 0; i < currentindex; i++)
            {
                temp[i] = mystack[currentindex - i - 1];
            }

            mystack = temp;
            return mystack;
        }
    }
}
