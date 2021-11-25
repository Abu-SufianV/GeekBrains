// 24. Найти кубы чисел от 1 до N

int[] cubic_array(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
    }

    return array;
}


void get_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(String.Format("{0,10}", array[i]));
        if ((i + 1) % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}


Console.Write("Введите число: ");
get_array(cubic_array(Convert.ToInt32(Console.ReadLine())));
