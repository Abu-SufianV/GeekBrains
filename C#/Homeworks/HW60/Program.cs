// 60. Составить частотный словарь элементов двумерного массива

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

void min_sum_column(int[,] array)
{
    Dictionary<int, int> numbers = new Dictionary<int, int>(array.GetLength(0) * array.GetLength(1));

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (numbers.ContainsKey(array[i, j]))
            {
                numbers[array[i, j]]++;
            }
            else
            {
                numbers[array[i, j]] = 1;
            }
        }
    }

    Console.WriteLine("Частотный словарь данного массива: ");
    foreach (var num in numbers)
    {
        Console.WriteLine($"{num.Key} - {num.Value}");
    }
}

fill_matrix(matrix);
show_matrix(matrix);
min_sum_column(matrix);
