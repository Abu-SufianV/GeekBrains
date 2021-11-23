// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите 1-е число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if ((num_1 * num_1 == num_2) || (num_2 * num_2 == num_1))
{
    Console.Write("Одно из чисел является квадратом другого");
}
else
{
    Console.Write("Ни одно из чисел не является квадратом другого");
}

Console.WriteLine("\n");