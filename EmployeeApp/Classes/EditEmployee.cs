using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class EditEmployee : AbstractModification
    {
        internal static int Id { get; set; }
        internal static Employee Employee { get; set; }

        internal static void UserInput()
        {
            Console.Write("Введите идентификатор сотрудника, информацию о котором Вы хотите изменить: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var employee = Context.context.Employees.FirstOrDefault(c => c.EmployeeId == id);
            if (employee == null)
            {
                throw new Exception("Работника с таким идентификатором не существует");
            }

            employee.FirstName = GetUpdatedValue($"Имя сотрудника - {employee.FirstName}, новое - ", employee.FirstName);
            employee.LastName = GetUpdatedValue($"Фамилия сотрудника - {employee.LastName}, новая - ", employee.LastName);
            employee.Email = GetUpdatedValue($"Email сотрудника - {employee.Email}, новый - ", employee.Email);
            employee.DateOfBirth = GetUpdatedValue($"Дата рождения сотрудника - {employee.DateOfBirth}, новая - ", employee.DateOfBirth);
            employee.Salary = GetUpdatedValue($"Зарплата сотрудника - {employee.Salary}, новая - ", employee.Salary);

            Context.context.SaveChanges();
            Console.WriteLine("Если Вы хотите изменить поле - введите новое значение, если нет, нажмите Enter для пропуска");
        }

        private static string GetUpdatedValue(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return string.IsNullOrEmpty(input) ? currentValue : input;
        }

        private static DateOnly? GetUpdatedValue(string prompt, DateOnly? currentValue)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return string.IsNullOrEmpty(input) ? currentValue : DateOnly.Parse(input);
        }

        private static decimal? GetUpdatedValue(string prompt, decimal? currentValue)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return string.IsNullOrEmpty(input) ? currentValue : Convert.ToDecimal(input);
        }

        internal static void Edit(int id, string? firstName, string? lastName, string? email, DateOnly? dateOfBirth, decimal? salary)
        {
            EmployeeHelper.SetEmployeeProperties(Employee, FirstName, LastName, Email, DateOfBirth, Salary);
            Context.context.SaveChanges();
        }
    }
}
