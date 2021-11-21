//  7. Показать числа от -N до N

void show_numbers(int first, int second)
{
    Console.WriteLine("Список чисел: ");
    for (int i = first; i <= second; i++)
    {
        Console.Write($"{i}  ");
    }
}

Console.Write("\nВведите 1-e число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nВведите 2-e число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

show_numbers(num_1, num_2);

Console.WriteLine("\n");