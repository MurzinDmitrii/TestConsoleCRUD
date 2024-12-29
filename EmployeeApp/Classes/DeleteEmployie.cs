using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class DeleteEmployie
    {
        public static int Id { get; set; }

        internal static void UserInput()
        {
            Console.Write("Введите идентификатор сотрудника: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Delete();
        }

        internal static void Delete()
        {
            Employee employee = Context.context.Employees.FirstOrDefault(c => c.EmployeeId == Id);
            if (employee == null) throw new Exception("Работника с таким идентификатором не существует");
            Context.context.Remove(employee);
            Context.context.SaveChanges();
        }
    }
}
