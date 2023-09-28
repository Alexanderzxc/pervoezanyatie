using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private System.Threading.Thread thr;
        private System.Threading.ManualResetEvent ev;
        public Form1()
        {
            InitializeComponent();
            thr = new System.Threading.Thread(ff);
            ev = new System.Threading.ManualResetEvent(false);
            ButtonPro.BringToFront();
        }

        private void ButtonPro_Click(object sender, EventArgs e)
        {
            string file_name = FileNameTextBox.Text ;
            try
            {
                StreamReader sr = new StreamReader(file_name+".txt");
                StreamWriter sw = new StreamWriter(file_name + "_sorted" + ".txt");
                
                string res = "";
                int counter = 1;
                int pr = 70;
                while (true)
                {
                    if (counter <= 100)
                    {
                        progressBar1.Value = counter;
                    }
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (counter % 2 != 0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            char ch = line[i];
                            res += ch;
                        }

                        counter++;
                    }
                    else
                    {
                        res += "   ";
                        for (int i = 10; i < 56; i++)
                        {
                            char ch = line[i];
                            res += ch;
                        }

                        for (int i = 70; i < line.Length; i++)
                        {
                            char c = line[i];
                            res += c;
                            pr++;
                        }
                        sw.WriteLine(res);
                        counter++;
                        res = "";
                    }
                }
                
                timer1.Interval = 700;
                thr.Start();
                ev.WaitOne();
                sw.Close();
                sr.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception:" + exception.Message);
            }
        }

        private void ff()
        {
            timer1.Enabled = true;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label2.Text = "Файл заражён на " + Convert.ToString(progressBar1.Value)+"%.";
            
            if (Convert.ToInt32(progressBar1.Value) > 50)
            {
                label1.Visible = true;
                label1.Text = "Файл успешно заражён.";
                ButtonPro.Visible = false;
                
            }
            timer1.Enabled = false;
            
            ev.Set();
        }
    }
}