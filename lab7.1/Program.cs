using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Example usage with a Repository of strings
        Repository<string> stringRepository = new Repository<string>();
        stringRepository.Add("Apple");
        stringRepository.Add("Banana");
        stringRepository.Add("Orange");
        stringRepository.Add("Grapes");

        // Define a criteria to find elements starting with the letter 'A'
        Criteria<string> startsWithA = s => s.StartsWith("A");

        // Find elements based on the criteria
        List<string> result = stringRepository.Find(startsWithA);

        // Display the result
        Console.WriteLine("Elements starting with 'A':");
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
}
