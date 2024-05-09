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

            Console.WriteLine("\nTask 4: Employees with Maximum Salary");
            foreach (var emp in LinqTasks.Task4())
            {
                Console.WriteLine($"{emp.Ename} - ${emp.Salary}");
            }

            Console.WriteLine("\nTask 5: Employee Names and Jobs");
            foreach (dynamic item in LinqTasks.Task5())
            {
                Console.WriteLine($"{item.Nazwisko} - {item.Praca}");
            }

            Console.WriteLine("\nTask 6: Employee Names, Jobs, and Department Names");
            foreach (dynamic item in LinqTasks.Task6())
            {
                Console.WriteLine($"{item.Ename} - {item.Job} - {item.Dname}");
            }
        }
    }
}