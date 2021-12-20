// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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

void sort_rows(int[,] array)
{
    int[] row = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }

    }

}

fill_matrix(matrix);
show_matrix(matrix);
sort_rows(matrix);
show_matrix(matrix);

