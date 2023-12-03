using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Example usage of TaskScheduler with string tasks and int priorities
        TaskScheduler<string, int> taskScheduler = new TaskScheduler<string, int>();

        // Add tasks with different priorities
        taskScheduler.AddTask("Task 1", 3);
        taskScheduler.AddTask("Task 2", 1);
        taskScheduler.AddTask("Task 3", 2);

        // Execute tasks in order of priority
        taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing task: {task}"));
        taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing task: {task}"));
        taskScheduler.ExecuteNext(task => Console.WriteLine($"Executing task: {task}"));
    }
}
