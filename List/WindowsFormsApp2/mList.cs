using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public class mList : IEnumerable
    {
        private int Length;
        private extraINT[] list;
        private extraINT Next;
        private extraINT Prev;
        private int sort_method;
        


        
        public int change_sort_method
        {
            get { return sort_method; }
            set { sort_method = value; }
        }
        
        public extraINT next
        {
            get {
                try
                {
                    return list[Length + 1];
                }
                catch
                {
                    return null;
                }
            }
        }

        public extraINT prev
        {
            get
            {
                if (Length >= 1)
                {
                    return list[Length - 1];
                }
                else
                {
                    return null;
                }
            }
        }
        
        public mList(int length)
        {
            Length = length;
            list = new extraINT[Length+100];
            for (int i = 0; i < Length; i++)    
            {
                var newEl = new extraINT();
                list[i] = newEl;
            }

            var temp = Length+100;
            
            for (int i = Length; i < temp; i++)
            {
                extraINT nulle = new extraINT();
                nulle.null_extraint();
                list[i] = nulle;
            }
        }

        public void Prepend(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            
            extraINT new_ele = new extraINT();
            for (int i = Length; i >0; i--)
            {
                list[i] = list[i - 1];
            }

            Length++;
            list[0] = new_ele;
            Visualize(listBox1,listBox2,listBox3,list,Length);
            
        }

        public void Append(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            extraINT new_ele = new extraINT();
            list[Length] = new_ele;
            Length++;
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }
        public void ToArray(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }

        static void Visualize(ListBox listBox1, ListBox listBox2, ListBox listBox3, extraINT[] list, int Length)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            
            var worklist = list;
            for (int i = 0; i < Length; i++)
            {
                listBox1.Items.Add(worklist[i].id);
                listBox2.Items.Add(worklist[i].str);
                listBox3.Items.Add(worklist[i].boolean);
            }
        }
        
        public void Find(TextBox textBox1, Label label)
        {
            var s = "";
            
            for (int i = 0; i < Length; i++)
            {
                if (list[i].EqualsByStr(textBox1.Text))
                {
                    s += Convert.ToString(list[i].id) + " | " + list[i].str + " | " + Convert.ToString(list[i].boolean) + "\n";
                }
            }
            label.Text = s;
        }
        
        public void At(TextBox textBox1, Label label)
        {
            var s = "";
            
            for (int i = 0; i < Length; i++)
            {
                if (list[i].EqualsById(Convert.ToInt32(textBox1.Text)))
                {
                    s += Convert.ToString(list[i].id) + " | " + list[i].str + " | " + Convert.ToString(list[i].boolean) + "\n";
                }
            }
            label.Text = s;
        }

        public void Remove(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            extraINT Null = new extraINT();
            Null.null_extraint();
            list[Length] = Null;
            Length--;
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }

        public void RemoveAt(TextBox textBox1, ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            var s = "";
            for (int i = 0; i < Length; i++)
            {
                if (list[i].EqualsById(Convert.ToInt32(textBox1.Text)))
                {
                    s += Convert.ToString(list[i].id) + " | " + list[i].str + " | " + Convert.ToString(list[i].str) + "\n";
                    list[i].null_extraint();
                    for (int c = i; c <Length-1; c++)
                    {
                        list[c] = list[c + 1];
                    }
                    Length--;
                }
            }
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }
        
        
        protected static bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false; 
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        public void IDSort(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            for (int i=0; i < Length; i++)
            {
                for (int j = 0; j < Length - 1; j++)
                {
                    if (list[j].id < list[j + 1].id)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }

        public void strSort(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            for (int i=0; i < Length; i++)
            {
                for (int j = 0; j < Length - 1; j++)
                {
                    if (needToReOrder(list[j].str, list[j+1].str))
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            Visualize(listBox1,listBox2,listBox3,list,Length);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public mListEnum GetEnumerator()
        {
            return new mListEnum(list);
        }
        
    }
    public class mListEnum : IEnumerator
    {

        public extraINT[] _data;
        private int position = -1; 
        public mListEnum(extraINT[] list)
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
        public extraINT Current
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