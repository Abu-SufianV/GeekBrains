// 23. Показать таблицу квадратов чисел от 1 до N 

void get_table(int size)
{
    if (size <= 10)
    {
        for (int num = 1; num <= size; num++)
        {
            Console.Write($"{num * num} ");
        }
    }
    else
    {
        for (int num = 1; num <= size; num++)
        {
            Console.Write($"{num * num} ");
            if (num % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }

}

Console.Write("Введите размер таблицы: ");
int number = Convert.ToInt32(Console.ReadLine());

get_table(number);