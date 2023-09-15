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

        public int[] mass
        {
            get { return mystack; }
        }
        public stack(int razmer)
        {
            mystack = new int[razmer];
            currentindex = 0;
        }
        
        public void push()
        {
            if (mystack.Length > currentindex)
            {
                
               Random rnd = new Random();
               mystack[currentindex] = rnd.Next(1,150);
               currentindex += 1;

            }
            else
            {
                MessageBox.Show("массив переполнен");
            }
        }
        
        public int pop()
        {
            var last = mystack[currentindex - 1];
            mystack[currentindex - 1] = 0;
            currentindex -= 1;
            return last;
        }

        public int peek()
        {
            var last = mystack[currentindex-1];
            return last;
        }

        public void Values(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var VARIABLE in mystack)
            {
                listBox.Items.Add(VARIABLE);
            }
        }
        
    }
}