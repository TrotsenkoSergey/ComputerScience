namespace Graphs;

public class ConnectedComponentsCount
{
    // n - nodes
    // e - edges
    // Time: O(e)
    // Space: O(n)

    private readonly HashSet<char> _visited = [];
    public int CountOfConnections(Dictionary<char, List<char>> graph)
    {
        int counts = 0;
        foreach (char node in graph.Keys)
        {
            if (IsTraversed(graph, node))
                counts++;
        }

        return counts;
    }

    private bool IsTraversed(Dictionary<char, List<char>> graph, char current)
    {
        if (_visited.Contains(current)) return false;
        _visited.Add(current);

        foreach (char neighbor in graph[current])
        {
            IsTraversed(graph, neighbor);
        }

        return true;
    }
}
