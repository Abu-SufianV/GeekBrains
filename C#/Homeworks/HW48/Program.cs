// 48. Показать двумерный массив размером m×n заполненный целыми числами

int m = 10;
int n = 10;

int[,] matrix = new int[m, n];

void show_matrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
            Console.Write($"\t{array[i, j]}", 10);
        }
        Console.WriteLine();
    }
}

show_matrix(matrix);