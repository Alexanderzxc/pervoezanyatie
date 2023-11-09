namespace WindowsFormsApp4;

public class GraphVertexInfo
{
    public GraphVertex Vertex;
    public bool IsUnvisited;
    public int EdgesWeightSum;
    public GraphVertex PreviousVertex;

    public GraphVertexInfo(GraphVertex vertex)
    {
        Vertex = vertex;
        IsUnvisited = true;
        EdgesWeightSum = 999999;
        PreviousVertex = null;
    }
}