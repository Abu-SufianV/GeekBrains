// 56. Написать программу, которая обменивает элементы первой строки и последней строки

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

void change_rows(int[,] array)
{
    int[] first_row = new int[array.GetLength(0)];
    int[] last_row = new int[array.GetLength(0)];

    for (int i = 0; i < first_row.Length; i++)
    {
        first_row[i] = array[0, i];
        last_row[i] = array[array.GetUpperBound(0), i];

        array[0, i] = last_row[i];
        array[array.GetUpperBound(0), i] = first_row[i];
    }

}

fill_matrix(matrix);
show_matrix(matrix);
change_rows(matrix);
show_matrix(matrix);
