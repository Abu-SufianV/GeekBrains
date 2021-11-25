// 8. Показать четные числа от 1 до N

void show_even_numbers(int number)
{
    Console.WriteLine($"Список чётных чисел от 1 до {number}: ");
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i}  ");
        }

    }
}

Console.Write("\nВведите число: ");

show_even_numbers(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\n");