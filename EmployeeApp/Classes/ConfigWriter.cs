using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class ConfigWriter
    {
        internal static void Write()
        {
            Console.WriteLine("Введите строку подключения к Вашей MS SQL Server");
            string path = Console.ReadLine();
            File.WriteAllText("Config.txt", path);
        }
    }
}
