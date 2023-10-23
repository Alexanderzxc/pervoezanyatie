using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;

namespace VectorPro
{
    public class MyVector : IEnumerable
    {
        private MyElement[] _data;
        private int Size;
        private int Capacity;

        public int GetCapacity
        {
            get { return Capacity; }
        }

        public int GetSize
        {
            get { return Size; }
        }
        public MyVector(int size, int capacity)
        {
            _data = new MyElement[capacity];
            Size = size;
            Capacity = capacity;
            for (int i = 0; i < size; i++)
            {
                MyElement temp = new MyElement();
                _data[i] = temp;
            }

            for (int i = size; i < capacity; i++)
            {
                _data[i] = null;
            }
        }
        
        
        public MyElement this[int index]
        {
            get
            {
                if (index < 0 || index >= _data.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
 
                return _data[index];
            }
            set
            {
                if (index < 0 || index >= _data.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
 
                _data[index] = value;
            }
        }
        
        public void Visualize(ListBox listBox1, ListBox listBox2)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i< Size; i++)
            {
                listBox1.Items.Add(_data[i].id);
                listBox2.Items.Add(_data[i].String);
            }
        }

        public void PrintSize(Label label1, Label label2)
        {
            label1.Text = "Size: " + Convert.ToString(Size);
            label2.Text = "Capacity: " + Convert.ToString(Capacity);
        }
        
        public void Add()
        {
            Capacity *= 2;
            _data = CapacityChanged(Size, Capacity, _data);
            MyElement temp = new MyElement();
            _data[Size] = temp;
            Size++;
        }

        public void SetValue(int index, int NewId, string NewString)
        {
            MyElement temp = new MyElement();
            temp.id = NewId;
            temp.String = NewString;
            _data[index] = temp;
        }

        static MyElement[] CapacityChanged(int size, int Capacity, MyElement[] data)
        {
            MyElement[] list = new MyElement[Capacity];
            if (Capacity > size)
            {
                for (int i = 0; i < size; i++)
                {
                    list[i] = data[i];
                }

                for (int i = size; i < Capacity; i++)
                {
                    list[i] = null;
                } 
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    list[i] = data[i];
                }
            }

            return list;
        }
        public void Resize(int NewSize)
        {
            if (NewSize > Capacity)
            {
                MessageBox.Show("Вы указали рамер, который больше Capacity");
            }
            else
            {
                if (NewSize > Size)
                {
                    for (int i = Size; i < NewSize; i++)
                    {
                        MyElement temp = new MyElement();
                        _data[i] = temp;
                    }
                    Capacity += NewSize-Size;
                    Size = NewSize;
                    _data = CapacityChanged(Size, Capacity, _data);
                }
                else if (NewSize==Size)
                {
                    MessageBox.Show("Указан такой же размер");
                }
                else
                {
                    Size = NewSize;
                    Capacity -= Size - NewSize;
                    _data = CapacityChanged(Size, Capacity, _data);
                }
            }
        }

        public void Reverse(int num)
        {
            if (num < Size)
            {
                MessageBox.Show("Capacity меньше Size");
            }
            else
            {
                Capacity = num;
                _data = CapacityChanged(Size, Capacity, _data);
            }
        }

        public void ShrinkToFit()
        {
            Capacity = Size;
            _data = CapacityChanged(Size, Capacity, _data);
        }
        
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public MyVectorEnum GetEnumerator()
        {
            return new MyVectorEnum(_data);
        }
        

    }


    public class MyVectorEnum : IEnumerator
    {

        public MyElement[] _data;
        private int position = -1; 
        public MyVectorEnum(MyElement[] list)
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
        public MyElement Current
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