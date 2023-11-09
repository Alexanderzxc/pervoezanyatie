namespace WindowsFormsApp4;

public class GraphEdge
{
    public GraphVertex ConectedVertex;
    public int EdgeWeight;

    public GraphEdge(GraphVertex conectedVertex, int weight)
    {
        ConectedVertex = conectedVertex;
        EdgeWeight = weight;
    }
 }