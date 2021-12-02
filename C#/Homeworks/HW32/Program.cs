// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

Random rand = new Random();

int[] Arr = new int[8];

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
<<<<<<< HEAD
    Arr[i] = new Random().Next(0, 2);
=======
    if (i % 2 == 0)
    {
        Arr[i] = 1;
    }
    else
    {
        Arr[i] = 0;
    }
>>>>>>> main
}
get_array(Arr);