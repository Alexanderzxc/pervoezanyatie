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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            stack1.push();
            stack1.Values(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stack1.pop();
            stack1.Values(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top_num.Text=stack1.peek();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stack1.Reverse();
            stack1.Values(listBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stack1 = new stack(Convert.ToInt32(textBox1.Text));
            stack1.Values(listBox1);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}