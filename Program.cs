using System;

namespace MonthInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = int.Parse(Console.ReadLine());

            string season;
            string semester;

            if (month >= 1 && month <= 2 || month == 12)
            {
                season = "Зима";
                if (month == 1 || month == 12)
                {
                    semester = "Сессия";
                }
                else
                {
                    semester = "2 семестр";
                }
            }
            else if (month >= 3 && month <= 5)
            {
                season = "Весна";
                semester = "2 семестр";
            }
            else if (month >= 6 && month <= 8)
            {
                season = "Лето";
                if (month == 6)
                {
                    semester = "Сессия";
                }
                else
                {
                    semester = "Каникулы";
                }
            }
            else if (month >= 9 && month <= 11)
            {
                season = "Осень";
                semester = "1 семестр";
            }
            else
            {
                season = "Некорректный номер месяца";
                semester = "";
            }

            Console.WriteLine($"Это {season}, {semester}");
            Console.ReadKey();
        }
    }
}
