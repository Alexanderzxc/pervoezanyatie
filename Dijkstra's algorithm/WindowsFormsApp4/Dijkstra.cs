using System.Collections.Generic;

namespace WindowsFormsApp4;

public class Dijkstra
{ 
    private Graph graph;
    private List<GraphVertexInfo> _data;

    public Dijkstra(Graph graph)
    {
        this.graph = graph;
    }

    public void InitInfo()
    {
        _data = new List<GraphVertexInfo>();
        foreach (var VARIABLE in graph.Vertices)
        {
            _data.Add(new GraphVertexInfo(VARIABLE));
        }
    }

    public GraphVertexInfo GetVertexInfo(GraphVertex vertex)
    {
        foreach (var VARIABLE in _data)
        {
            if (VARIABLE.Vertex==vertex)
            {
                return VARIABLE;
            }
        }

        return null;
    }

    public GraphVertexInfo FindUnvisitedVertexWithMinSum()
    {
        int minvalue = 999999;
        GraphVertexInfo minvertexInfo = null;
        foreach (var VARIABLE in _data)
        {
            if (VARIABLE.IsUnvisited && VARIABLE.EdgesWeightSum < minvalue)
            {
                minvertexInfo = VARIABLE;
                minvalue = VARIABLE.EdgesWeightSum;
            }
        }

        return minvertexInfo;
    }

    public string FindShortestPath(GraphVertex StartVertex, GraphVertex FinishVertex)
    {
        InitInfo();
        var first = GetVertexInfo(StartVertex);
        first.EdgesWeightSum = 0;
        while (true)
        {
            var current = FindUnvisitedVertexWithMinSum();
            if (current == null)
            {
                break;
            }
            SetSumToNextVertex(current);
        }
        return GetPath(StartVertex, FinishVertex);
    }
    public void SetSumToNextVertex(GraphVertexInfo info)
    {
        info.IsUnvisited = false;
        foreach (var VARIABLE in info.Vertex.Edges)
        {
            var nextInfo = GetVertexInfo(VARIABLE.ConectedVertex);
            var sum = info.EdgesWeightSum + VARIABLE.EdgeWeight;
            if (sum < nextInfo.EdgesWeightSum)
            {
                nextInfo.EdgesWeightSum = sum;
                nextInfo.PreviousVertex = info.Vertex;
            }
        }
    }
    string GetPath(GraphVertex startVertex, GraphVertex endVertex)
    {
        var path = endVertex.name;
        while (startVertex != endVertex)
        {
            endVertex = GetVertexInfo(endVertex).PreviousVertex;
            path = endVertex.name + path;
        }

        return path;
    }

}