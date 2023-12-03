// Delegate for user-defined function
public delegate TResult Func<TKey, TResult>(TKey key);

// Generic FunctionCache class
public class FunctionCache<TKey, TResult>
{
    private Dictionary<TKey, CacheItem> cache;

    // Class to store cached items
    private class CacheItem
    {
        public TResult Result { get; set; }
        public DateTime ExpirationTime { get; set; }
    }

    // Constructor
    public FunctionCache()
    {
        cache = new Dictionary<TKey, CacheItem>();
    }

    // Method to get the result from the cache or execute the function
    public TResult GetOrAdd(TKey key, Func<TKey, TResult> function, TimeSpan expirationTime)
    {
        if (cache.TryGetValue(key, out CacheItem cachedItem) && DateTime.Now < cachedItem.ExpirationTime)
        {
            // Return cached result if available and not expired
            return cachedItem.Result;
        }
        else
        {
            // Execute the function and store the result in the cache
            TResult result = function(key);
            cache[key] = new CacheItem { Result = result, ExpirationTime = DateTime.Now.Add(expirationTime) };
            return result;
        }
    }
}
