// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void sum_average_column(int[,] array)
{
    double[] columns = new double[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0.0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        columns[i] = sum / array.GetLength(0);
    }

    Console.WriteLine($"Среднее арифметическое: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("\t{0:0.##}", (columns[i]));
    }
    Console.WriteLine();
}
fill_matrix(matrix);
show_matrix(matrix);
sum_average_column(matrix);