using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> emplist = new List<Employee>
            {
                new Employee { EmployeeId = 1, Name = "Tisha Agarwall", Position = "Manager", Salary = 700000, JoinDate = new DateTime(2022, 1, 1) },
                new Employee { EmployeeId = 2, Name = "Aditya Sen", Position = "Tester", Salary = 450000, JoinDate = new DateTime(2023, 3, 15) },
                new Employee { EmployeeId = 3, Name = "Faruk Rehman", Position = "Designer", Salary = 320000, JoinDate = new DateTime(2024, 2, 1) },
                new Employee { EmployeeId = 4, Name = "Asish Gupta", Position = "Developer ", Salary = 580000, JoinDate = new DateTime(2023, 6, 15) },
                new Employee { EmployeeId = 5, Name = "Ronita Jena", Position = "Tester", Salary = 350000, JoinDate = new DateTime(2024, 1, 10) }
            };


            /*
            
               //List<Employee> emplist = new List<Employee>;
               emplist.Add(201, "Kirit Saha", "Manager", 700000, new DateTime(2020, 5, 12));
               emplist.Add(395, "Swoyam Raj", "Developer", 500000, new DateTime(2022, 10, 5));
               emplist.Add(229, "Tisha Bedi", "Manager", 600000, new DateTime(2021, 8, 3));
               emplist.Add(432, "Adi Sankar", "Developer", 500000, new DateTime(2023, 10, 25));
               emplist.Add(495, "Lovina", "Developer", 400000, new DateTime(2022, 11, 7));
               //shows error 

            */


            EData EData = new EData();

            // 1. Get all list of employee data
            Console.WriteLine("\nList of all employees:");
            EData.PrintEmp(emplist);
            Console.WriteLine();

            // 2. Get data of the employee who has the 2nd highest salary
            Console.WriteLine("\nEmployee with the 2nd highest salary:");
            EData.PrintEmp(EData.HighestSalary(emplist, 2));
            Console.WriteLine();

            // 3. Get the list of employees who joined in a range of dates
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 3, 31);
            Console.WriteLine($"\nEmployees joined between {startDate:d} and {endDate:d}");
            EData.PrintEmp(EData.EmployeesJoinedBetween(emplist, startDate, endDate));
            Console.WriteLine();


            // 4. Add an employee and print the whole list
            Console.Write("\nEnter new Employee Name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter Position: ");
            string newPosition = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double newSalary;
            while (!double.TryParse(Console.ReadLine(), out newSalary))
            {
                Console.WriteLine("Invalid input. Please enter a valid salary:");
            }

            Console.Write("Enter JoinDate (yyyy-MM-dd): ");
            DateTime newJoinDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out newJoinDate))
            {
                Console.WriteLine("Invalid date format. Please enter the date in the format yyyy-MM-dd:");
            }

            Employee newEmployee = new Employee
            {
                EmployeeId = emplist.Max(e => e.EmployeeId) + 1,
                Name = newName,
                Position = newPosition,
                Salary = newSalary,
                JoinDate = newJoinDate
            };
            emplist.Add(newEmployee);

            Console.WriteLine("\nUpdated list of employees:");
            EData.PrintEmp(emplist);
            Console.WriteLine();


            // 5. Update the position and salary of the employee with the lowest salary
            //should updated salary be grater than previous salary???
            Employee lowestSalaryEmployee = EData.LowestSalary(emplist);
            Console.WriteLine("\nGet Employee with lowest salary:");
            EData.PrintEmp(lowestSalaryEmployee);

            Console.Write("Enter new position: ");
            string newLowestPosition = Console.ReadLine();

            double newLowestSalary;
            while (true)
            {
                Console.Write("Enter new salary: ");
                if (double.TryParse(Console.ReadLine(), out newLowestSalary))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid salary.");
                }
            }

            lowestSalaryEmployee.Position = newLowestPosition;
            lowestSalaryEmployee.Salary = newLowestSalary;

            Console.WriteLine("\nEmployee with updated position and salary:");
            EData.PrintEmp(lowestSalaryEmployee);
        }
    }
}