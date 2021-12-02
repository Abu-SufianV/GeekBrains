// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива


int[] Arr = new int[12];

void get_array(int[] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(String.Format("{0,5}", array[i]));
        if ((i + 1) % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = new Random().Next(0, 10);
}

get_array(Arr);
