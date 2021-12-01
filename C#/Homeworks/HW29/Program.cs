// 29. Написать программу вычисления произведения чисел от 1 до N

int sum_array(int size)
{
    int[] array = new int[size];
    int prod = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        prod *= array[i];
    }

    return prod;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Произведение числел от 1 до {num} = {sum_array(num)}");
