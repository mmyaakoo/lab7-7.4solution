// Delegate for task execution
public delegate void TaskExecution<TTask>(TTask task);

// Generic TaskScheduler class
public class TaskScheduler<TTask, TPriority> where TPriority : IComparable<TPriority>
{
    private SortedDictionary<TPriority, Queue<TTask>> taskQueue;

    // Constructor
    public TaskScheduler()
    {
        taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
    }

    // Method to add a task with a specific priority
    public void AddTask(TTask task, TPriority priority)
    {
        if (!taskQueue.ContainsKey(priority))
        {
            taskQueue[priority] = new Queue<TTask>();
        }

        taskQueue[priority].Enqueue(task);
    }

    // Method to execute the next task with the highest priority
    public void ExecuteNext(TaskExecution<TTask> executeTask)
    {
        if (taskQueue.Count > 0)
        {
            TPriority highestPriority = taskQueue.Keys.Max();
            TTask nextTask = taskQueue[highestPriority].Dequeue();

            executeTask(nextTask);

            // Remove the priority queue if it is empty
            if (taskQueue[highestPriority].Count == 0)
            {
                taskQueue.Remove(highestPriority);
            }
        }
        else
        {
            Console.WriteLine("No tasks in the queue.");
        }
    }

    // Method to return an object to the pool (unused in this example)
    public void ReturnToPool(TTask task, TPriority priority)
    {
        AddTask(task, priority);
    }

    // Method to get an object from the pool (unused in this example)
    public TTask GetFromPool(TPriority priority)
    {
        if (taskQueue.ContainsKey(priority) && taskQueue[priority].Count > 0)
        {
            return taskQueue[priority].Dequeue();
        }
        else
        {
            Console.WriteLine("No tasks available in the pool.");
            return default(TTask);
        }
    }
}

