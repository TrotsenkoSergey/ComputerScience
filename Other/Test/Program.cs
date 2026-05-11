using Sorting;

internal class Program
{
    private static void Main(string[] args)
    {
        var overlapIntervals = new NoOverlapingIntervals();
        int oliOutput1 = overlapIntervals.EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]);
        int oliOutput2 = overlapIntervals.EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]]);
        int oliOutput3 = overlapIntervals.EraseOverlapIntervals([[1, 2], [2, 3]]);

    }
}