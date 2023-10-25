using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number == 5 || number == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка при вводе числа.");
        }
    }
}