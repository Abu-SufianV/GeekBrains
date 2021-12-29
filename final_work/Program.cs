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
