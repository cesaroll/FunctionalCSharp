public class Program
{
    static long NaiveFibonacci(int n) =>
        n < 2
            ? n
            : NaiveFibonacci(n - 1) + NaiveFibonacci(n - 2);
    static void Demonstrate(Func<int, long> fibonacci)
    {
        int offset = 0;
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{offset + i}\t{fibonacci(offset + i)}");
        Console.WriteLine();
    }

    static Dictionary<int, long> Cache = new();
    static long MemoizedFibonacci(int n)
    {
        if (Cache.TryGetValue(n, out long value))
            return value;

        value = n < 2
                    ? n
                    : MemoizedFibonacci(n - 1) + MemoizedFibonacci(n - 2);

        Cache[n] = value;
        return value;
    }

    static IList<long> ForwardCache = new List<long>() { 0, 1 };

    static long ForwardFibonacci(int n)
    {
        while (ForwardCache.Count <= n)
        {
            ForwardCache.Add(ForwardCache[ForwardCache.Count - 1] + ForwardCache[ForwardCache.Count - 2]);
        }

        return ForwardCache[n];
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("\nMemoizedFibonacci:\n");
        Demonstrate(MemoizedFibonacci);
        Console.WriteLine($"Cache count: {Cache.Count}");

        Console.WriteLine("\nForwardFibonacci:\n");
        Demonstrate(ForwardFibonacci);

        Console.WriteLine("\nNaiveFibonacci:\n");
        Demonstrate(NaiveFibonacci);
    }
}
