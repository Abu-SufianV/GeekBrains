// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
int need_numbers = 0;

void get_array(int[] array)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(String.Format("{0,5}", array[i]));
        if ((i + 1) % 10 == 0)
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
    if ((10 <= array[i]) && (array[i] <= 99))
    {
        need_numbers++;
    }
}

get_array(array);

Console.WriteLine($"\nВ данном массиве {need_numbers} чисел входят в отрезок [10,99]\n");