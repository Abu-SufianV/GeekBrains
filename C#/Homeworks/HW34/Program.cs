// 34. Написать программу замену элементов массива на противоположные

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
    array[i] = new Random().Next(-10, 10);
}

get_array(array);

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

get_array(array);