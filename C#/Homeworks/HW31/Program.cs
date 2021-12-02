// 31. Задать массив из 8 элементов и вывести их на экран 
int[] Arr = new int[8];

void get_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(String.Format("{0,5}", array[i]));
        if ((i + 1) % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}

get_array(Arr);
