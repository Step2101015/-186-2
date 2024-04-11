/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        // Ввод дня, месяца и года
        Console.Write("Введите день: ");
        int day = int.Parse(Console.ReadLine());
        
        Console.Write("Введите месяц: ");
        int month = int.Parse(Console.ReadLine());
        
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        // Увеличение года на 1
        year++;

        // Уменьшение даты на 2 дня
        day -= 2;
        if (day <= 0)
        {
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            day += DateTime.DaysInMonth(year, month);
        }

        // Вывод новой даты
        Console.WriteLine($"Новая дата: {day}.{month}.{year}");
    }
}