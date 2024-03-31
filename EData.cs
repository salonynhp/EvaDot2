using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProject
{
    public class EData
    {   //To get employee list
        public void PrintEmp(List<Employee> emplist)
        {
            foreach (var emp in emplist)
            {
                PrintEmp(emp);
            }
        }
        //To print emp with 2nd hightest salary
       
        public void PrintEmp(Employee emplist)
        {
            //Console.WriteLine($"EmployeeId: {emplist.EmployeeId}, Name: {emplist.Name}, Position: {emplist.Position}, Salary: {emplist.Salary}, JoinDate: {emplist.JoinDate:d}");
            Console.WriteLine("{0}     |{1}     |{2}     |{3}     |{4}", emplist.EmployeeId, emplist.Name, emplist.Position, emplist.Salary, emplist.JoinDate);
        }
        //To print highest salary
        public Employee HighestSalary(List<Employee> emplist, int n)
        {
            return emplist.OrderByDescending(e => e.Salary).Skip(n - 1).FirstOrDefault();
            /*
{
            if (emplist == null || emplist.Count < n)
                return null;

            // Create a copy of the list 
            List<Employee> sortedEmp = new List<Employee>(emplist);

            // Sort the list in descending order based on the Salary property
            sortedEmplist.Sort((e1, e2) => e2.Salary.CompareTo(e1.Salary));

            // Return the employee at index n - 1 (since the list is 0-based)
            return sortedEmplist[n - 1];
           } */
        }

        public List<Employee> EmployeesJoinedBetween(List<Employee> emplist, DateTime startDate, DateTime endDate)
        {
            return emplist.Where(e => e.JoinDate >= startDate && e.JoinDate <= endDate).ToList();
        }
        //To print lowest salary
        public Employee LowestSalary(List<Employee> emplist)
        {
            return emplist.OrderBy(e => e.Salary).FirstOrDefault();
        }
    }
}