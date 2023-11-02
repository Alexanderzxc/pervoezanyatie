using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private Myqueue _myqueue;
        public Form1()
        {
            InitializeComponent();
            QueueBox.Visible = false;
            EnqueueButton.Visible = false;
            DequeueButton.Visible = false;
            PeekButton.Visible = false;
            ToArrayButton.Visible = false;
            IsEmptyButton.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void SpawnQueueButton_Click(object sender, EventArgs e)
        {
            try
            {
                int len = Convert.ToInt32(SpawnQueueTextBox.Text);
                _myqueue = new Myqueue(len);
                SpawnQueueTextBox.Visible = false;
                SpawnQueueButton.Visible = false;
                QueueBox.Visible = true;
                EnqueueButton.Visible = true;
                DequeueButton.Visible = true;
                PeekButton.Visible = true;
                ToArrayButton.Visible = true;
                IsEmptyButton.Visible = true;
                textBox1.Visible = true;
                label1.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception:" + exception.Message);
            }
        }


        private void EnqueueButton_Click(object sender, EventArgs e)
        {
            try
            {
                _myqueue.Enqueue(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception: " + exception);
            }
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            try
            {
                _myqueue.Dequeue(label2);
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception: " + exception);
            }
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            try
            {
                _myqueue.Peek(label2);
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception: " + exception);
            }
            
        }

        private void ToArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                QueueBox.Items.Clear();
                _myqueue.ToArray(QueueBox);
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception: " + exception);
            }
        }

        private void IsEmptyButton_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(_myqueue.IsEmpty());
        }
    }
}