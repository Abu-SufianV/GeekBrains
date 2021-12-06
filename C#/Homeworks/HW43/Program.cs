// 43. Написать программу преобразования десятичного числа в двоичное число 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string decimal_to_binary(int num)
{
    return Convert.ToString(num, 2);
}

Console.WriteLine($"\nЧисло {number} в двоичной системе счисления равен: {decimal_to_binary(number)}\n");