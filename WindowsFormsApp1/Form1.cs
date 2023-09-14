using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        floatt float1;
        floatt float2;
        private floatt float3;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float1 = new floatt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            first_num.Text = Convert.ToString(float1.fl);
            float2 = new floatt(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            second_numb.Text = Convert.ToString(float2.fl);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            float1 = new floatt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            first_num.Text = Convert.ToString(float1.fl);
            float2 = new floatt(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            second_numb.Text = Convert.ToString(float2.fl);
            float3 = float1 + float2;
            ans_bot.Text = Convert.ToString(float3.znamenatel);
            ans_top.Text = Convert.ToString(float3.chislitel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float1 = new floatt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            first_num.Text = Convert.ToString(float1.fl);
            float2 = new floatt(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            second_numb.Text = Convert.ToString(float2.fl);
            float3 = float1 - float2;
            ans_bot.Text = Convert.ToString(float3.znamenatel);
            ans_top.Text = Convert.ToString(float3.chislitel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float1 = new floatt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            first_num.Text = Convert.ToString(float1.fl);
            float2 = new floatt(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            second_numb.Text = Convert.ToString(float2.fl);
            float3 = float1 * float2;
            ans_bot.Text = Convert.ToString(float3.znamenatel);
            ans_top.Text = Convert.ToString(float3.chislitel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float1 = new floatt(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            first_num.Text = Convert.ToString(float1.fl);
            float2 = new floatt(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            second_numb.Text = Convert.ToString(float2.fl);
            float3 = float1 / float2;
            ans_bot.Text = Convert.ToString(float3.znamenatel);
            ans_top.Text = Convert.ToString(float3.chislitel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float3 = new floatt(Convert.ToInt32(ans_top.Text), Convert.ToInt32(ans_bot.Text));
            nodlabel.Text = Convert.ToString(float3.getNOD());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float3 = new floatt(Convert.ToInt32(ans_top.Text), Convert.ToInt32(ans_bot.Text));
            sokr_bot.Text = Convert.ToString(float3.znamenatel / float3.getNOD());
            sokr_top.Text = Convert.ToString(float3.chislitel / float3.getNOD());
        }
    }
}