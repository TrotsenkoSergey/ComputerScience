
internal class Program
{
    private static void Main(string[] args)
    {
        var sw = new SlidingWindow.SlidingWindowMaximum();
        int[] swOutput1 = sw.MaxSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3);
        int[] swOutput2 = sw.MaxSlidingWindow([1], 1);

        var ps = new PrefixSum.NumArray([-2, 0, 3, -5, 2, -1]);
        int psOutput1 = ps.SumRange(0, 2);
        int psOutput2 = ps.SumRange(2, 5);
        int psOutput3 = ps.SumRange(0, 5);

        var pwd = new TwoPointers.PairWithDiffGtk();
        int pwdOutput1 = pwd.CalculatePairWithDiffGtk([1, 3, 3, 4, 5, 6], 2);

        var ms = new TwoPointers.MaxSubstringWithK();
        int msOutput1 = ms.FindMax(['a', 'b', 'a', 'c', 'c', 'c', 'd', 'a'], 2);

        /* Random + Shuffle
        List<int> counts = [];

        int iteration = 100;
        for (int i = 0; i < iteration; i++)
        {
            int count = 0;
            int result = 0;
            while (result != 100)
            {
                result = Random.Shared.Next(1, 101);
                count++;
            }

            counts.Add(count);
        }

        Console.WriteLine(string.Join(", ", counts));
        int[] arr = counts.ToArray();
        Random.Shared.Shuffle(arr);
        Console.WriteLine(string.Join(", ", arr));

        Console.WriteLine($"Mid: {counts.Sum() / iteration}");
        */

        var maxAverageSubarrayISolution = new SlidingWindow.MaximumAverageSubarrayI();
        double maxAverageSubarrayI = maxAverageSubarrayISolution.FindMaxAverage([1, 12, -5, -6, 50, 3],4);;
    }
}
