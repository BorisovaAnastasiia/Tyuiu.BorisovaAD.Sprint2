using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int daysInMonth;

            switch (value)
            {
                // Месяцы с 31 днем
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;

                // Месяцы с 30 днями
                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;

                // Февраль (обычно 28 или 29 дней, но в рамках простого switch без учета високосного года принимаем 28)
                case 2: // Февраль
                    daysInMonth = 28;
                    break;

                // Если номер месяца некорректен
                default:
                    // Можно выбросить исключение или вернуть специальное значение
                    throw new ArgumentException($"Некорректный номер месяца: {value}. Номер должен быть от 1 до 12.");
            }

            return daysInMonth;
        }
    }
}

