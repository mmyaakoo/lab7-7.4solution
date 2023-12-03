using System;



class Program
{
    static void Main()
    {
        // Demonstration with int
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine("Integer Calculator:");
        Console.WriteLine($"Addition: {intCalculator.PerformOperation(5, 3, intCalculator.Add)}");
        Console.WriteLine($"Subtraction: {intCalculator.PerformOperation(5, 3, intCalculator.Subtract)}");
        Console.WriteLine($"Multiplication: {intCalculator.PerformOperation(5, 3, intCalculator.Multiply)}");
        Console.WriteLine($"Division: {intCalculator.PerformOperation(5, 3, intCalculator.Divide)}");
        Console.WriteLine();

        // Demonstration with double
        Calculator<double> doubleCalculator = new Calculator<double>();
        Console.WriteLine("Double Calculator:");
        Console.WriteLine($"Addition: {doubleCalculator.PerformOperation(5.5, 3.3, doubleCalculator.Add)}");
        Console.WriteLine($"Subtraction: {doubleCalculator.PerformOperation(5.5, 3.3, doubleCalculator.Subtract)}");
        Console.WriteLine($"Multiplication: {doubleCalculator.PerformOperation(5.5, 3.3, doubleCalculator.Multiply)}");
        Console.WriteLine($"Division: {doubleCalculator.PerformOperation(5.5, 3.3, doubleCalculator.Divide)}");
    }
}
