using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPro
{
    public partial class Form1 : Form
    {
        
        public static Random rnd = new Random();
        private MyVector Vector; 
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Vector = new MyVector(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Vector.Visualize(listBox1,listBox2);
            
            listBox1.Visible = true;
            listBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            Vector.PrintSize(label6,label5);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector.Add();
            Vector.Visualize(listBox1,listBox2);
            Vector.PrintSize(label6,label5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector.SetValue(Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text),textBox5.Text);
            Vector.Visualize(listBox1,listBox2);
            Vector.PrintSize(label6,label5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector.Resize(Convert.ToInt32(textBox6.Text));
            Vector.Visualize(listBox1,listBox2);
            Vector.PrintSize(label6,label5);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Vector.Reverse(Convert.ToInt32(textBox7.Text));
            Vector.PrintSize(label6,label5);
        }

        public void Proverka()
        {
            int i = 0;
            foreach (var VARIABLE in Vector)
            {
                MyElement temp = VARIABLE;
                temp = Vector[i];
                i++;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vector.ShrinkToFit();
            Vector.PrintSize(label6,label5);
        }
        


    }
}