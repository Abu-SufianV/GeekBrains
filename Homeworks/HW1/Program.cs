// 1. По двум заданным числам проверять является ли первое квадратом второго

using System;

Console.Write("Введите 1-е число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 == num_2 * num_2)
{
    Console.WriteLine("\nПервое число является квадратом второго");
}
else
{
    Console.WriteLine("\nПервое число НЕ является квадратом второго");
}