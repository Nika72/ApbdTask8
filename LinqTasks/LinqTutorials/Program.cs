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

            Console.WriteLine("\nTask 7: Job Counts");
            foreach (dynamic item in LinqTasks.Task7())
            {
                Console.WriteLine($"{item.Praca} - {item.LiczbaPracownikow}");
            }

            Console.WriteLine("\nTask 8: Is there at least one Backend programmer?");
            bool hasBackendProgrammer = LinqTasks.Task8();
            Console.WriteLine(hasBackendProgrammer ? "Yes" : "No");

            Console.WriteLine("Task 9: Most Recently Hired Frontend Programmer");
            var resultTask9 = LinqTasks.Task9();
            if (resultTask9 != null)
            {
                Console.WriteLine($"{resultTask9.Ename} - {resultTask9.HireDate}");
            }
            else
            {
                Console.WriteLine("No Frontend Programmer found.");
            }

            Console.WriteLine();
            Console.WriteLine("Task 10: Select and Union Operation");
            foreach (dynamic item in LinqTasks.Task10())
            {
                Console.WriteLine($"{item.Ename} - {item.Job} - {item.HireDate}");
            }

            Console.WriteLine();

            Console.WriteLine("Task 11: Group Employees by Department");
            foreach (dynamic group in LinqTasks.Task11())
            {
                Console.WriteLine($"{group.Name} - {group.NumOfEmployees}");
            }

            Console.WriteLine();

            Console.WriteLine("Task 12: Employees with Subordinates");
            foreach (var emp in LinqTasks.Task12())
            {
                Console.WriteLine($"{emp.Ename} - {emp.Salary}");
            }

            Console.WriteLine();
            
            Console.WriteLine("Task 13: Number appearing odd times in an array");
            int[] array = new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            Console.WriteLine(LinqTasks.Task13(array));
            Console.WriteLine();

            Console.WriteLine("Task 14: Departments with exactly 5 employees or none");
            foreach (var dept in LinqTasks.Task14())
            {
                Console.WriteLine($"{dept.Dname} - {dept.Deptno}");
            }
            Console.WriteLine();

            Console.WriteLine("Task 15: Jobs containing 'A' with count > 2");
            foreach (dynamic item in LinqTasks.Task15())
            {
                Console.WriteLine($"{item.Job} - {item.Count}");
            }
            Console.WriteLine();

            Console.WriteLine("Task 16: Select all from Emps and Depts");
            foreach (dynamic item in LinqTasks.Task16())
            {
                Console.WriteLine($"{item.Ename} - {item.Job} - {item.Dname}");
            }
            Console.WriteLine();
        }
    }
}