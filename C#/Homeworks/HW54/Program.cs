// 54. В матрице чисел найти сумму элементов главной диагонали

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

int sum_main_diagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, i];
        }
    }
    return sum;
}
fill_matrix(matrix);
show_matrix(matrix);
Console.WriteLine("Сумма главной диагонали: " + sum_main_diagonal(matrix));