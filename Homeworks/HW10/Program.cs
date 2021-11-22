// 10. Показать вторую цифру трёхзначного числа

Console.Write("\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nВторая цифра числа {num} - {num / 10 % 10}");

Console.WriteLine("\n");
