int[] array = new int[10];

void fill_array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10);
    }
}

void show_array(int[] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\n");
}

int[] even_array(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        count = arr[i] % 2 == 0 ? count + 1 : count;
    }

    int[] even_arr = new int[count];

    even_arr = arr.Where(val => val % 2 == 0).ToArray();

    return even_arr;
}

fill_array(array);
show_array(array);
show_array(even_array(array));