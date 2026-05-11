using Traversal;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         
         a -> c
         ↓    ↓
         b    e
         ↓    
         d -> f
         
         
         */
        Dictionary<char, List<char>> graph = new()
        {
            ['a'] = ['b','c'],
            ['b'] = ['d'],
            ['c'] = ['e'],
            ['d'] = ['f'],
            ['e'] = [],
            ['f'] = []
        };

        var bfs = new BFS();
        bfs.Traverse(graph, 'a');

        var dfs = new DFS();
        dfs.Traverse(graph, 'a');
    }
}