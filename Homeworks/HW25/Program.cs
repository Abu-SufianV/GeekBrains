// 25. Найти сумму чисел от 1 до А

int sum_array(int size)
{
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        sum = sum + array[i];
    }

    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма числел от 1 до {num} = {sum_array(num)}");
