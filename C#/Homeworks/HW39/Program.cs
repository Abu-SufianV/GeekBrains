// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний...

int arr_len = 30;

int[] array = new int[arr_len];
int[] result = new int[((int)arr_len / 2)];

void get_array(string name, int[] array)
{
    Console.WriteLine($"\n{name}:");
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

for (int i = 0; i < arr_len; i++)
{
    array[i] = new Random().Next(10);
}

for (int i = 0; i < ((int)arr_len / 2); i++)
{
    int index = i + 1;
    result[i] = array[i] * array[^index];
}

get_array("Массив", array);
get_array("Результат", result);
