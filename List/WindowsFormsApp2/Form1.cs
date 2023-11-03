using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private mList mylist;
        public static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent(); 
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                mylist = new mList(Convert.ToInt32(textBox1.Text));
                mylist.ToArray(listBox1,listBox2,listBox3);
                button2.Visible = false;
                textBox1.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                button3.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            extraINT value = new extraINT();
            value.id = Convert.ToInt32(textBox4.Text);
            value.str = textBox5.Text;
            if (checkBox1.Checked)
            {
                value.boolean = true;
            }
            else
            {
                value.boolean = false;
            }
            mylist.Append(listBox1,listBox2,listBox3, value);
        }

        private void PrependButton_Click(object sender, EventArgs e)
        {
            try
            {
                extraINT value = new extraINT();
                value.id = Convert.ToInt32(textBox4.Text);
                value.str = textBox5.Text;
                if (checkBox1.Checked)
                {
                    value.boolean = true;
                }
                else
                {
                    value.boolean = false;
                }
                mylist.Prepend(listBox1,listBox2,listBox3, value);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception.Message);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.Find(textBox3, FindLabel);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.Remove(listBox1,listBox2,listBox3);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.At(textBox2, FindLabel);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.RemoveAt(textBox2, listBox1, listBox2,listBox3);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.IDSort(listBox1, listBox2,listBox3);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                mylist.strSort(listBox1, listBox2,listBox3);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception);
                throw;
            }
        }
    }
}