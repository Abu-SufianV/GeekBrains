// 26. Возведите число А в натуральную степень B используя цикл

double exponential(int number, int degree)
{
    double result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степени: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {num} в степени {degree} = {exponential(num, degree)} ");
