// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

string num_multiple(int number, int multiple)
{
    if (number % multiple == 0)
    {
        return $"Число {multiple} кратно {number}";
    }

    return $"Число {multiple} не кратно {number}\nОстаток от деления: {number % multiple}";
}

Console.Write("Введите число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для проверки кратности: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");

Console.WriteLine(num_multiple(num_1, num_2));

Console.WriteLine("\n");