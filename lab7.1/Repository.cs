// Delegate for criteria
public delegate bool Criteria<T>(T item);

// Generic Repository class
public class Repository<T>
{
    private List<T> elements;

    // Constructor
    public Repository()
    {
        elements = new List<T>();
    }

    // Method to add an element to the repository
    public void Add(T item)
    {
        elements.Add(item);
    }

    // Method to find elements based on criteria
    public List<T> Find(Criteria<T> criteria)
    {
        List<T> result = new List<T>();

        foreach (T item in elements)
        {
            if (criteria(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}
