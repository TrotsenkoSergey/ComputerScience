
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
    }
}