// 49. Показать двумерный массив размером m×n заполненный вещественными числами

int m = 10;
int n = 10;

double[,] matrix = new double[m, n];

void show_matrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            Console.Write("\t {0:0.##}", (array[i, j]));
        }
        Console.WriteLine();
    }
}

show_matrix(matrix);