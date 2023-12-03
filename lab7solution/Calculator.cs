// Delegate for arithmetic operations
public delegate T ArithmeticOperation<T>(T a, T b);

// Generic Calculator class
public class Calculator<T>
{
    // Arithmetic operation delegates
    public ArithmeticOperation<T> Add { get; }
    public ArithmeticOperation<T> Subtract { get; }
    public ArithmeticOperation<T> Multiply { get; }
    public ArithmeticOperation<T> Divide { get; }

    // Constructor to initialize delegates
    public Calculator()
    {
        Add = (a, b) => Operator<T>.Add(a, b);
        Subtract = (a, b) => Operator<T>.Subtract(a, b);
        Multiply = (a, b) => Operator<T>.Multiply(a, b);
        Divide = (a, b) => Operator<T>.Divide(a, b);
    }

    // Method to perform arithmetic operation using delegates
    public T PerformOperation(T operand1, T operand2, ArithmeticOperation<T> operation)
    {
        return operation(operand1, operand2);
    }
}
