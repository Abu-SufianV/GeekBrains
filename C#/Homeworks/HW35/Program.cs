// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = new int[10];

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
    array[i] = new Random().Next(0, 10);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

get_array(array);

for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        Console.Write($"Число {num} есть в данном массиве\nНаходится на {i + 1} месте\n\n");
        break;
    }
}