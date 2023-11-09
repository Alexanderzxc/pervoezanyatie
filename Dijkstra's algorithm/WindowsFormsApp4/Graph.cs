using System.Collections.Generic;

namespace WindowsFormsApp4;

public class Graph
{
    public List<GraphVertex> Vertices;

    public Graph()
    {
        Vertices = new List<GraphVertex>();
    }

    public void AddVertex(string vertexName, int x, int y)
    {
        Vertices.Add(new GraphVertex(vertexName, x, y));
    }

    public GraphVertex FindVertex(string vertexName)
    {
        foreach (var VARIABLE in Vertices)
        {
            if (VARIABLE.name == vertexName)
            {
                return VARIABLE;
            }
        }

        return null;
    }

    public void AddEdge(string FirstVertexName, string SecondVertexName, int weight)
    {
        var v1 = FindVertex(FirstVertexName);
        var v2 = FindVertex(SecondVertexName);
        if (v2 != null && v1 != null)
        {
            v1.Add(v2, weight);
            v2.Add(v1,weight);
        }
    }
    
}