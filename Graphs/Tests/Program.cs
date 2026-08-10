
using Graphs;

internal class Program
{
    /*
   
   1 - 2
        
       4
       |
   5 - 6 - 8
       |
       7

       3

     */


    private static void Main(string[] args)
    {
        Dictionary<char, List<char>> graph = new()
        {
            ['1'] = ['2'],
            ['2'] = ['1'],
            ['3'] = [],
            ['4'] = ['6'],
            ['5'] = ['6'],
            ['6'] = ['4', '5', '7', '8'],
            ['7'] = ['6'],
            ['8'] = ['6']
        };

        var connectedComponentsCount = new ConnectedComponentsCount();
        int count = connectedComponentsCount.CountOfConnections(graph);


        var hasPathService = new HasPathSolution();
        bool hasPath = hasPathService.HasDFSPath(graph, '7', '4');

        int n1 = 3;
        int[][] edges1 = [[0, 1], [1, 2], [2, 0]];
        int src1 = 0;
        int dst1 = 2;
        var validPathSolution1= new ValidPathSolution();
        bool validPath1 = validPathSolution1.ValidPath(n1, edges1, src1, dst1); // expected true

        int n2 = 6;
        int[][] edges2 = [[0, 1], [0, 2], [3, 5], [5, 4], [4, 3]];
        int src2 = 0;
        int dst2 = 5;
        var validPathSolution2 = new ValidPathSolution();
        bool validPath2 = validPathSolution2.ValidPath(n2, edges2, src2, dst2); // expected false

        int n3 = 10;
        int[][] edges3 = [[4, 3], [1, 4], [4, 8], [1, 7], [6, 4], [4, 2], [7, 4], [4, 0], [0, 9], [5, 4]];
        int src3 = 5;
        int dst3 = 9;
        var validPathSolution3 = new ValidPathSolution();
        bool validPath3 = validPathSolution3.ValidPath(n3, edges3, src3, dst3); // expected true
    }
}