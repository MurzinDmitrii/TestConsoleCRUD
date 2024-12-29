using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Classes
{
    internal class OutputInfo
    {
        internal static void Startup()
        {
            Console.Write(@"Выберите команду:

                1 - Добавить сотрудника
                2 - Просмотреть информацию о сотрудниках
                3 - Изменить информацию о сотруднике по его идентификатору
                4 - Удалить информацию о сотруднике по его идентификатору
                5 - Выйти из приложения

                Выберите номер команды: ");
        }
    }
}
