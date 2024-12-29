using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class SelectEmployies
    {
        internal static void OutputListEmployies()
        {
            List<Employee> employies = Context.context.Employees.ToList();
            foreach (Employee employee in employies)
            {
                Console.WriteLine($"{employee.EmployeeId}) {employee.LastName} {employee.FirstName}, почта: {employee.Email}, дата рождения {employee.DateOfBirth}, зарплата: {employee.Salary}");
            }
        }
    }
}
