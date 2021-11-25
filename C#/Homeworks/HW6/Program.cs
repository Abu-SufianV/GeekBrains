// 6. Выяснить является ли число чётным

using System;

Console.Write("\nВведите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} - чётное");
}
else
{
    Console.WriteLine($"Число {num} - не чётное");
}

Console.WriteLine("\n");