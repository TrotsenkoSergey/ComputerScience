namespace Models;

public class GraphNode<T>
{
    public GraphNode(T value)
    {
        Value = value;
    }

    public T Value { get; private set; }
    public List<GraphNode<T>> Neighbors { get; set; } = [];
}
