// 9. Показать последнюю цифру трёхзначного числа

Console.Write("\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Последняя цифра числа {num} - {num % 10}");

Console.WriteLine("\n");