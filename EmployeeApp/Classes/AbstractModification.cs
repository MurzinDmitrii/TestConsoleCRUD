using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class AbstractModification
    {
        internal static string? FirstName {  get; set; }
        internal static string? LastName {  get; set; }
        internal static string? Email {  get; set; }
        internal static DateOnly? DateOfBirth {  get; set; }
        internal static decimal? Salary {  get; set; }
    }
}
