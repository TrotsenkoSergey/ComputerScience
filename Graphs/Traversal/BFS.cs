namespace Traversal;

public class BFS
{
    public void Traverse(Dictionary<char, List<char>> graph, char startNode)
    {
        var traverse = WithQueue(graph, startNode);

        traverse.ForEach(Console.Write);
        Console.WriteLine();
    }

    private List<char> WithQueue(Dictionary<char, List<char>> graph, char value) 
    {
        var result = new List<char>();
        var queue = new Queue<char>();
        queue.Enqueue(value);

        while (queue.Count > 0) 
        { 
            char node = queue.Dequeue();
            result.Add(node);

            foreach (var val in graph[node]) 
            { 
                queue.Enqueue(val);
            }
        }

        return result;
    }
}
