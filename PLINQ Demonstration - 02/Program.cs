using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    //IsPrime returns true if the number is prime, otherwise false.
    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    //GetPrimeList returns Prime numbers by using sequential ForEach
    private static IList<int> GetPrimeList(IList<int> numbers) => numbers.Where(IsPrime).ToList();

    //GetPrimeListWithParallel returns Prime numbers by using Parallel.ForEach
    private static IList<int> GetPrimeListWithParallel(IList<int> numbers)
    {
        var primeNumbers = new ConcurrentBag<int>();
        Parallel.ForEach(numbers, number =>
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
        });
        return primeNumbers.ToList();
    }

    static void Main(string[] args)
    {
        var limit = 2_000_000;
        var numbers = Enumerable.Range(0, limit).ToList();

        var watch = Stopwatch.StartNew();
        var primeNumbersFromForEach = GetPrimeList(numbers);
        watch.Stop();

        var watchForParallel = Stopwatch.StartNew();
        var primeNumbersFromParallelForEach = GetPrimeListWithParallel(numbers);
        watchForParallel.Stop();

        Console.WriteLine($"Classical ForEach loop | Total prime numbers :" + 
                          $"{primeNumbersFromForEach.Count} | Time taken :" +
                          $"{watch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Parallel ForEach loop | Total prime numbers :" +
                            $"{primeNumbersFromParallelForEach.Count} | Time taken :" +
                            $"{watchForParallel.ElapsedMilliseconds} ms");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}