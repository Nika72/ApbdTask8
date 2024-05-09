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

            Console.WriteLine("\nTask 2: Frontend Programmers with Salary > 1000, ordered by name descending");
            foreach (var emp in LinqTasks.Task2())
            {
                Console.WriteLine($"{emp.Ename} - {emp.Job} - ${emp.Salary}");
            }

            Console.WriteLine("\nTask 3: Maximum Salary");
            int maxSalary = LinqTasks.Task3();
            Console.WriteLine($"The highest salary is ${maxSalary}");
        }
    }
}