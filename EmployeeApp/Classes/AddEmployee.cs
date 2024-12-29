using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class AddEmployee : AbstractModification
    {
        internal static void UserInput()
        {
            Console.Write("Введите имя сотрудника: ");
            FirstName = Console.ReadLine();
            Console.Write("Введите фамилию сотрудника: ");
            LastName = Console.ReadLine();
            Console.Write("Введите email сотрудника: ");
            Email = Console.ReadLine();
            Console.Write("Введите дату рождения сотрудника: ");
            DateOfBirth = DateOnly.Parse(Console.ReadLine());
            Console.Write("Введите зарплату сотрудника: ");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Add();
        }

        internal static void Add()
        {
            Employee employee = new();
            EmployeeHelper.SetEmployeeProperties(employee, FirstName, LastName, Email, DateOfBirth, Salary);
            Context.context.Employees.Add(employee);
            Context.context.SaveChanges();
        }
    }
}
