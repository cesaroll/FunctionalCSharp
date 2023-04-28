static long NaiveFibonacci(int n) =>
    n < 2
        ? n
        : NaiveFibonacci(n - 1) + NaiveFibonacci(n - 2);

static void Demonstrate(Func<int, long> fibonacci)
{
    int offset = 33;
    for (int i = 0; i < 10; i++)
        Console.WriteLine($"{offset + i}\t{fibonacci(offset + i)}");
    Console.WriteLine();
}


Demonstrate(NaiveFibonacci);
