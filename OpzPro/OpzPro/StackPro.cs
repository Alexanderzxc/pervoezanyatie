using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace OpzPro
{
    public class stack<T> : IEnumerable
    {
        private int currentindex;
        private double[] stackpro;  
        private bool reverse=false;
        public T[] mystack { get;}


        public int Count
        {
            get { return currentindex - 1; }
        }
        public T[] mass
        {
            get { return mystack; }
        }
        
        public stack(int razmer)
        {
            mystack = new T[razmer];
            currentindex = 0;
        }
        
        public void Push(T x)
        {
            mystack[currentindex] = x; 
            currentindex++;
        }
        
        public T Pop()
        {
             var value = mystack[currentindex - 1];
             mystack[currentindex - 1] = default;
             currentindex -= 1;
             return value;
        }

        public T Peek()
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
        
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= mystack.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
 
                return mystack[index];
            }
            set
            {
                if (index < 0 || index >= mystack.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
 
                mystack[index] = value;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public RPNGodEnum<T> GetEnumerator()
        {
            return new RPNGodEnum<T>(mystack);
        }
        
    }
    public class RPNGodEnum<T> : IEnumerator
    {

        public T[] _data;
        private int position = -1; 
        public RPNGodEnum(T[] list)
        {
            _data = list;
        }
        

        public bool MoveNext()
        {
            position++;
            return (position < _data.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public T Current
        {
            get
            {
                try
                {
                    return _data[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        
    }
}