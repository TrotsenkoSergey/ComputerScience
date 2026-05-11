namespace Graphs;

/*

↖ ↑ ↗
← · →
↙ ↓ ↘
        
       'f' → 'g' → 'h'
        ↓  ↗
       'i' ← 'j'
        ↓
       'k'
 
        from f to k --> true
        from j to f --> false
 */

public class HasPathSolution
{
    // n - nodes
    // e - edges

    // Time: O(e)
    // Space: O(n)
    public bool HasDFSPath(Dictionary<char, List<char>> graph, char src, char dst)
    {
        if (src == dst) return true;

        foreach (char neighbor in graph[src])
        {
            if (HasDFSPath(graph, neighbor, dst))
                return true;
        }

        return false;
    }

    public bool HasBFSPath(Dictionary<char, List<char>> graph, char src, char dst)
    {
        if (src == dst) return true;
        
        // realize

        return false;
    }
}
