// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int m = 10;
int n = 10;

int[,] matrix = new int[m, n];

void show_matrix(int[,] array)
{
    Console.WriteLine($"\nДвумерный массив {array.GetLength(0)} x {array.GetLength(1)}: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t {0:0}", (array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void fill_matrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void choose_num(int[,] array, int num)
{
    int amount = 0;

    Console.Write($"Индексы числа {num}: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.Write($"[{i} , {j}]");
                amount++;
            }
        }
    }
    if (amount == 0)
    {
        Console.Write("*Данного числа нет в массиве*");
    }
}

fill_matrix(matrix);
show_matrix(matrix);
choose_num(matrix, 15);