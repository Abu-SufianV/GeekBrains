// 45. Показать числа Фибоначчи

void Fibonachi_nums(int amount)
{
    int[] numbers = new int[amount];
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < amount; i++)
    {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }
    Console.Write($"\nПоследовательность чисел Фибоначи до {amount} числа: ");
    Console.WriteLine(String.Join(" ", numbers));
}

Console.Write($"\nВведите кол-во чисел: ");
Fibonachi_nums(Convert.ToInt32(Console.ReadLine()));
