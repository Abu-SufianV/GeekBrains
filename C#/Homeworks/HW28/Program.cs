// 28. Подсчитать сумму цифр в числе


int digit_sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}


Console.Write("\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nСумма цифр в числе {num} = {digit_sum(num)} ");