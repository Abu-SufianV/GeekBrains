// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

float[] array = new float[30];
float min, max;

void get_array(float[] array)
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
}

max = array[0];
min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

get_array(array);
Console.WriteLine($"min - {min}\nmax - {max}\n");
Console.WriteLine($"Разница между min и max числами: {max - min}\n");