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
        private bool reverse=false;

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
        
        public void pop()
        {
            if (currentindex >=1)
            {
                var last = mystack[currentindex - 1];
                mystack[currentindex - 1] = 0;
                currentindex -= 1;
            }
            else
            {
                MessageBox.Show("массив пустой");
            }
            
        }

        public void peek(Label label)
        {
            if (currentindex >= 1)
            {
                var last = mystack[currentindex-1];
                label.Text = Convert.ToString(last);
            }
            else
            {
                label.Text = "Массив пустой";
            }
        }

        public void Values(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var VARIABLE in mystack)
            {
                listBox.Items.Add(VARIABLE);
            }
        }

        public void Reverse(ListBox listBox)
        {
            listBox.Items.Clear();
            if (reverse == false)
            {
                for (int i = mystack.Length - 1; i >= 0; i--)
                {
                    listBox.Items.Add(mystack[i]);
                }

                reverse = true;
            }
            else
            {
                foreach (var VARIABLE in mystack)
                {
                    listBox.Items.Add(VARIABLE);
                }

                reverse = false;
            }
        }
        
    }
}