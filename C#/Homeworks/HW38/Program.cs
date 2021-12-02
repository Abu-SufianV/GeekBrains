// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
int sum_odd = 0;

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
    array[i] = new Random().Next(0, 100);
    if (i % 2 == 1)
    {
        sum_odd += array[i];
    }
}

get_array(array);

Console.WriteLine($"\nСумма нечётных элементов в данном массиве: {sum_odd} \n");
