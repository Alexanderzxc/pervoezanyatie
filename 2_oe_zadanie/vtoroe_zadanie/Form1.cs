using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtoroe_zadanie
{
    
    public partial class Form1 : Form
    {
        stack stack1;
        public Form1()
        {
            InitializeComponent();
            stack1 = new stack(Convert.ToInt32(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stack1.Values(listBox1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            stack1.push();
            stack1.Values(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            top_num.Text=Convert.ToString(stack1.pop());
            stack1.Values(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top_num.Text = Convert.ToString(stack1.peek());
            stack1.Values(listBox1);
        }
    }
}