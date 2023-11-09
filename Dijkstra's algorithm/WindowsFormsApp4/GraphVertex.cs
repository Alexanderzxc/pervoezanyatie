using System.Collections.Generic;
using System.Drawing;
using System.Xml;

namespace WindowsFormsApp4;

public class GraphVertex
{
    public string name;
    public List<GraphEdge> Edges;
    public Point point;

    public GraphVertex(string VertexName, int x, int y)
    {
        name = VertexName;
        Edges = new List<GraphEdge>();
        point = new Point(x, y);
    }

    public void Add(GraphVertex vertex, int edgeweight)
    {
        var newEdge = new GraphEdge(vertex, edgeweight);
        Edges.Add(newEdge);
    }
    public void Draw(Graphics g)
    {
        Pen pen = new Pen(Color.Black, 2);
        g.DrawEllipse(pen, point.X, point.Y, 30, 30);
    }
}