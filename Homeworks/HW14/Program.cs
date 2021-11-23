// 14. Найти третью цифру числа или сообщить, что её нет

string search_num(string number)
{
    if (number.Length >= 3)
    {
        return $"Третья цифра числа {number[2]}";
    }

    return "Данное число меньше 100";
}

Console.Write("Введите число: ");

Console.WriteLine(search_num(Console.ReadLine()));

Console.WriteLine("\n");