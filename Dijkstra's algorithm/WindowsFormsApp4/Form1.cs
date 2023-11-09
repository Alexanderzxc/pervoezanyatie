using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Graph graph = new Graph();
        private Dictionary<string, int> CoordinatesInfo = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            graph = new Graph();
            var b = VertexListBox.CheckedItems;
            int counterX = 105;
            int count = 0;
            int counterY = 30;
            Font font = new Font("Impact", 14);
            foreach (var VARIABLE in b)
            {
                if (count < 2)
                {
                    graph.AddVertex(VARIABLE.ToString(), 100 + counterX * count, 100 - counterY * count);
                    graph.Vertices[count].Draw(g);
                }

                if (count == 2)
                {
                    graph.AddVertex(VARIABLE.ToString(), 310, 120);
                    graph.Vertices[count].Draw(g);

                }

                if (count > 2 && count < 6)
                {
                    graph.AddVertex(VARIABLE.ToString(), 100 + counterX * (count - 3), 130 + counterY * count);
                    graph.Vertices[count].Draw(g);
                }

                if (count == 6)
                {
                    graph.AddVertex(VARIABLE.ToString(), 210, 170);
                    graph.Vertices[count].Draw(g);
                }

                count++;
            }

            foreach (var VARIABLE in graph.Vertices)
            {
                g.DrawString(VARIABLE.name, font, new SolidBrush(Color.Red), VARIABLE.point.X + 7, VARIABLE.point.Y + 7,
                    new StringFormat());
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // для примера "A", "B", 22
            // для примера "A", "C", 33
            // для примера "A", "D", 61
            // для примера "B", "C", 47
            // для примера "B", "E", 93
            // для примера "C", "D", 11
            // для примера "C", "E", 79
            // для примера "C", "F", 63
            // для примера "D", "F", 41
            // для примера "E", "F", 17
            // для примера "E", "G", 58
            // для примера "F", "G", 84
            // высчитать путь от А до G
            graph.AddEdge(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            foreach (var VARIABLE in graph.Vertices)
            {
                if (VARIABLE.name.Equals(textBox1.Text))
                {
                    foreach (var v in graph.Vertices)
                    {
                        if (v.name.Equals(textBox2.Text))
                        {
                            g.DrawLine(pen, VARIABLE.point.X + 30, VARIABLE.point.Y + 15, v.point.X + 30,
                                v.point.Y + 15);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dijkstra dijkstra = new Dijkstra(graph);
            string path = dijkstra.FindShortestPath(graph.FindVertex(textBox4.Text), graph.FindVertex(textBox5.Text));
            label3.Text = path;
        }
    }
}