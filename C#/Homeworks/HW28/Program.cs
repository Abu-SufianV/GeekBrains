// 28. Подсчитать сумму цифр в числе


int digit_sum(int number)
{
    string line = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < line.Length; i++)
    {
        Console.WriteLine($"Str - {line[i]}");
        Console.WriteLine($"Int - {Convert.ToInt32(line[i])}\n");
        sum += Convert.ToInt32(line[i]);
    }

    return sum;
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр в числе {num} = {digit_sum(num)} ");