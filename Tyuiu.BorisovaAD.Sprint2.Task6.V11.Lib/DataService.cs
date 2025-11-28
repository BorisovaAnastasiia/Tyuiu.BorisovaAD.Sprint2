using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BorisovaAD.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            // Год не високосный, февраль всегда 28 дней
            const int FebDays = 28;

            // Определяем количество дней в текущем месяце с помощью switch expression
            int daysInCurrentMonth = m switch
            {
                2 => FebDays,
                4 => 30,
                6 => 30,
                9 => 30,
                11 => 30,
                // Все остальные месяцы имеют 31 день
                _ => 31
            };

            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            // Если следующий день превышает количество дней в текущем месяце, 
            // значит мы переходим на следующий месяц
            if (nextDay > daysInCurrentMonth)
            {
                nextDay = 1;
                nextMonth++;

                // Если следующий месяц превышает 12, значит мы переходим на следующий год
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }
            // Также нужно убедиться, что исходный день n был корректным
            else if (n < 1 || n > daysInCurrentMonth)
            {
                throw new ArgumentException("Некорректное число дня для данного месяца.");
            }

            return $"{nextDay}.{nextMonth}.{nextYear}";
        }
    }
}
