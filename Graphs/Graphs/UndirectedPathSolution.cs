namespace Graphs;

/*
 
edges: [
  [i, j],
  [k, i],
  [m, k],
  [k, l],
  [o, n]
]
 
graph: {
  i: [j, k],
  j: [i],
  k: [i, l, m],
  m: [k],
  l: [k],
  o: [n],
  n: [o],

}

    i - j
    | /
    k - l
    |
    m

    o - n

 */

public class UndirectedPathSolution
{
    // n - nodes
    // e - edges
    // Time: O(e), Space: O(n)

    private readonly HashSet<char> _visited = [];
    public bool HasPath(Dictionary<char, List<char>> graph, char src, char dst)
    {
        if (_visited.Contains(src)) return false;
        _visited.Add(src);

        if (src == dst) return true;

        foreach (char neighbor in graph[src])
        {
            if (HasPath(graph, neighbor, dst))
                return true;
        }

        return false;
    }
}
