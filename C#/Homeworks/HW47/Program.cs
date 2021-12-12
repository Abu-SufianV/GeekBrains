// 47. Написать программу копирования массива

int[] array_copy(int[] source_arr)
{
    int[] copy_arr = new int[source_arr.Length];

    for (int i = 0; i < source_arr.Length; i++)
    {
        copy_arr[i] = source_arr[i];
    }

    return copy_arr;
}

int[] Arr_1 = new int[] { 1, 2, 3, 1, 2, 3 };
int[] Arr_2 = array_copy(Arr_1);

Console.WriteLine(String.Join(' ', Arr_2));