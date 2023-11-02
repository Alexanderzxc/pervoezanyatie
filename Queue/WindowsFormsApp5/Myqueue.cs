using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class Myqueue
    {
        private int[] Queue;
        private int currentIn;
        private int currentOut;
        private int capacity;
        private int count;

        public Myqueue(int len)
        {
            count = len;
            Queue = new int[len];
            currentOut = len / 2 + 1;
            currentIn = currentOut;  
            for (int i = 0; i < count; i++)
            {
                Queue[i] = 0;
            }
        }

        public void Enqueue(int num)
        {
            if (currentIn == count)
            {
                currentIn = 0;
            }
            
            if (Queue[currentIn] != 0)
            {
                currentOut++;
                if (currentOut >= count)
                {
                    currentOut = 0;
                }
            }    
            Queue[currentIn]=num;
            currentIn += 1; 
            
        }

        public void Dequeue(Label label)
        {
            if (Queue[currentOut] == 0)
            {
                MessageBox.Show("Массив пустой");
            }

            label.Text = "Удалён элемент: " + Convert.ToString(Queue[currentOut]);
            Queue[currentOut] = 0;
            currentOut++;
            if (currentOut == count)
            {
                currentOut = 0;
            }
            
        }

        public void Peek(Label label)
        {
            label.Text="Первый элемент очереди на выход: " + Convert.ToString(Queue[currentOut]);
        }

        public void ToArray(ListBox listBox)
        {
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add(Queue[i]);
            }
        }

        public bool IsEmpty()
        {
            if (Queue[currentOut] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        
}
}