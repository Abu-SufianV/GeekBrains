// 2. Даны два числа. Показать большее и меньшее число

using System;

Console.Write("Введите 1-е число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine("\nПервое число больше второго");
}
else
{
    Console.WriteLine("\nПервое число меньше второго");
}
