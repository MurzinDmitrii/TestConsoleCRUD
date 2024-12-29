using EmployeeApp.Classes;
using Microsoft.Data.SqlClient;

internal class Program
{
    internal static void Main(string[] args)
    {
        bool end = false;
        while (!end)
        {
            try
            {
                if (string.IsNullOrEmpty(ConfigReader.Read()))
                {
                    ConfigWriter.Write();
                }
                OutputInfo.Startup();
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        AddEmployee.UserInput();
                        Console.WriteLine("Успешно");
                        break;
                    case "2":
                        SelectEmployies.OutputListEmployies();
                        break;
                    case "3":
                        EditEmployee.UserInput();
                        Console.WriteLine("Успешно");
                        break;
                    case "4":
                        DeleteEmployie.UserInput();
                        Console.WriteLine("Успешно");
                        break;
                    case "5":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Такой команды нет в списке!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Проверьте правильность введенных данных! Обратите особое внимание на корректность электронной почты, даты рождения и зарплаты");
            }
            catch (SqlException)
            {
                Console.WriteLine("Ошибка! Проверьте подключение к базе данных!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ошибка! Проверьте наличие файла конфигурации в корне приложения!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}