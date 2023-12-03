using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Example usage with a FunctionCache of string keys and int results
        FunctionCache<string, int> cache = new FunctionCache<string, int>();

        // Define a user-defined function
        Func<string, int> calculateLength = key => key.Length;

        // Get or add result to the cache with a 5-second expiration time
        int result1 = cache.GetOrAdd("apple", calculateLength, TimeSpan.FromSeconds(5));
        Console.WriteLine($"Result for 'apple': {result1}");

        // Wait for a while to allow the result to expire
        System.Threading.Thread.Sleep(6000);

        // Get or add result to the cache again
        int result2 = cache.GetOrAdd("apple", calculateLength, TimeSpan.FromSeconds(5));
        Console.WriteLine($"Result for 'apple' after expiration: {result2}");
    }
}
