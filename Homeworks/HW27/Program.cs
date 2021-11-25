// 27. Определить количество цифр в числе

int digit_count(int number)
{
    return number.ToString().Length;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Количество цифр в числе {num} = {digit_count(num)}");