// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что размеры не совпадают

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

void matrix_transposition(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("\n - - ОШИБКА - -\nНевозможно транспонировать матрицу!\nКоличество столбцов и строк не сопадают\n");
    }
    else
    {
        int[,] trans = new int[array.GetLength(1), array.GetLength(1)];
        Console.WriteLine($"\nТранспонированный массив {array.GetLength(0)} x {array.GetLength(1)}: \n");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                trans[i, j] = array[j, i];
                Console.Write("\t {0:0}", (trans[i, j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

fill_matrix(matrix);
show_matrix(matrix);
matrix_transposition(matrix);

