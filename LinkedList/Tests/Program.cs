using TypicalProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        var linkedList = GenerateRandom();
        Show(linkedList);
        Console.WriteLine();

        var traversal = new Traversal();
        int[] result = traversal.Traverse(linkedList);
        Show(result);
        Console.WriteLine();

        List<int> resultRecursive = traversal.TraverseRecursive(linkedList);
        Show(resultRecursive);
        Console.WriteLine();

        var sum = new SumListProblem();
        int resultSum = sum.Sum(linkedList);
        Console.WriteLine($"Sum = {resultSum}");

        var find = new FindValue();
        int target1 = 9;
        var resultFind1 = find.Find(linkedList, target1);
        Console.WriteLine($"Target = {target1}, find = {resultFind1?.Value}");
        int target2 = -20;
        var resultFind2 = find.Find(linkedList, target2);
        Console.WriteLine($"Target = {target2}, find = {resultFind2?.Value}");

        var reverse = new ReverseLinkedList();
        var reversedResult1 = reverse.Reverse(linkedList);
        Show(reversedResult1);
        Console.WriteLine();

        linkedList = reverse.ReverseRecursive(reversedResult1);
        Show(linkedList);
        Console.WriteLine();

    }

    private readonly static int[] _array = Enumerable.Range(1, 10).ToArray();
    private static TypicalProblems.LinkedList<int> GenerateRandom() 
    {
        TypicalProblems.LinkedList<int> head = new(_array[0]);

        var current = head;
        for(int i = 1; i < _array.Length; i++)
        {
            current.Next = new(_array[i]);
            current = current.Next;
        }

        return head;
    }

    private static void Show(TypicalProblems.LinkedList<int>? list)
    {
        Console.Write("( ");

        var current = list;
        while (current is not null)
        {
            Console.Write(current.Value);
            if(current.Next is not null)
                Console.Write(" -> ");
            current = current.Next;
        }
        
        Console.Write(" )");
    }

    private static void Show(IEnumerable<int> arr)
    {
        Console.Write("[ ");
        Console.Write(string.Join(", ", arr));
        Console.Write(" ]");
    }
}