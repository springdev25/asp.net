using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void PrintNumber(string message)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{message}:{i}");
            Thread.Sleep(1000); // Simulate work
        }
    }//end PrintNumber

    static void Main()
    {
        Thread.CurrentThread.Name = "Main";
        //Create a task by using lambda expression
        Task task01 = new Task(() => PrintNumber("Task 01"));
        task01.Start();
        //Create a task by using delegate and run the task
        Task task02 = Task.Run(delegate { PrintNumber("Task 02"); });
        //Create a task by using Action delegate
        Task task03 = Task.Run(new Action(() => PrintNumber("Task 03")));
        task03.Start();
        Console.WriteLine($"Thread '{Thread.CurrentThread.Name}'");
        Console.ReadKey();
    }//end Main
}//end Program