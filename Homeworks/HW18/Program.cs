// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("\nНеобходимо проверить истинность утверждения: ¬(X ⋁ Y) = ¬X ⋀ ¬Y\n\nВведите значения X и Y (значения не равные нуля, равняются ЛОЖЬ)\n");

Console.Write("Введите X: ");
bool X = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите Y: ");
bool Y = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

if (!(X & Y) == !X | !Y)
{
    Console.Write("Утверждение инстинно");
}
