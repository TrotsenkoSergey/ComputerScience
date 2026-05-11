namespace Traversal;

public class DFS
{
    public void Traverse(Dictionary<char, List<char>> graph, char startNode)
    {
        var stackResult = WithStack(graph, startNode);

        stackResult.ForEach(Console.Write);
        Console.WriteLine();

        var recursiveResult = WithRecursions(graph, startNode);

        recursiveResult.ForEach(Console.Write);
        Console.WriteLine();
    }

    private List<char> WithStack(Dictionary<char, List<char>> graph, char value)
    {
        var stack = new Stack<char>();
        stack.Push(value);
        var result = new List<char>();

        while (stack.Count > 0) 
        { 
            var current = stack.Pop();
            result.Add(current);

            foreach (char neighbor in graph[current]) 
            {
                stack.Push(neighbor);
            }
        }

        return result;
    }

    private List<char> WithRecursions(Dictionary<char, List<char>> graph, char value)
    {
        var result = new List<char>();
        result.Add(value);

        foreach (char neighbor in graph[value])
        { 
           result.AddRange(WithRecursions(graph, neighbor));
        }

        return result;
    }
}
