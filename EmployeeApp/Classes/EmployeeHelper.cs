using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal static class EmployeeHelper
    {
        public static void SetEmployeeProperties(Employee employee, string? firstName, string? lastName, string? email, DateOnly? dateOfBirth, decimal? salary)
        {
            MailAddress mail = new(email);
            employee.FirstName = firstName ?? employee.FirstName;
            employee.LastName = lastName ?? employee.LastName;
            employee.Email = mail.ToString() ?? employee.Email;
            employee.DateOfBirth = dateOfBirth ?? employee.DateOfBirth;
            employee.Salary = salary ?? employee.Salary;
        }
    }

}
