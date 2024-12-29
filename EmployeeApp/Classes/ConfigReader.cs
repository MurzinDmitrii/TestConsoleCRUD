using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class ConfigReader
    {
        internal static string Read()
        {
            return File.ReadAllText("Config.txt");
        }
    }
}
