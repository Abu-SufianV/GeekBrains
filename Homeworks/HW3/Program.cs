// 3. По заданному номеру дня недели вывести его название

using System;

Console.Write("Введите номер дня недели: ");
int week_day = Convert.ToInt32(Console.ReadLine());

switch (week_day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;

    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;

    default:
        Console.WriteLine("Вы ввели неверное значение!\nВведитезначение от 1 до 7");
        break;
}