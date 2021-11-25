// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int x = num / 10;
int y = num % 10;

Console.WriteLine();

if (x > y)
{
    Console.Write($"В числе {num} наибольшая цифра - {x}");
}
else
{
    Console.Write($"В числе {num} наибольшая цифра - {y}");
}

Console.WriteLine("\n");