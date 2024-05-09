using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the list of Backend Programmers as part of Task 1
            Console.WriteLine("Task 1: List of Backend Programmers");
            foreach (var emp in LinqTasks.Task1())
            {
                // Format and print each employee's name and job title to the console
                Console.WriteLine($"{emp.Ename} - {emp.Job}");
            }
        }
    }
}
