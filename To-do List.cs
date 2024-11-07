using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do List:");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    MarkTaskComplete();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewTasks()
    {
        Console.WriteLine("\nYour To-Do List:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to show.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = taskStatus[i] ? "Completed" : "Incomplete";
                Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter the task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        taskStatus.Add(false);
        Console.WriteLine("Task added.");
    }

    static void MarkTaskComplete()
    {
        Console.Write("Enter the task number to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            taskStatus[taskNumber - 1] = true;
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
