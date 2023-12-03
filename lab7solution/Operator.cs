// Operator class to provide generic arithmetic operations
public static class Operator<T>
{
    public static T Add(T a, T b)
    {
        return (dynamic)a + b;
    }

    public static T Subtract(T a, T b)
    {
        return (dynamic)a - b;
    }

    public static T Multiply(T a, T b)
    {
        return (dynamic)a * b;
    }

    public static T Divide(T a, T b)
    {
        if (b.Equals(default(T)) || b.Equals(0))
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (dynamic)a / b;
    }
}
