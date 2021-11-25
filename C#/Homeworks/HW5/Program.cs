//  5. Написать программу вычисления значения функции y = f(a)

using System;

double function(double num)
{
    return Math.Sin(Math.Pow(num, 10));
}

Console.WriteLine("\nФункция: f(x) = sin(x ^ 10)");
Console.Write("\nВведите число: ");

Console.Write($"\nОтвет: {function(Convert.ToDouble(Console.ReadLine()))}");