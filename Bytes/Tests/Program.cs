using TypicalProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0b_0011;
        int b = 0b_0101;

        var sum = new SumOfTwoIntegers();
        int result = sum.GetSum(a, b);

        Console.WriteLine($"A = {a}, B = {b}, Sum = {result}");
    }
}
