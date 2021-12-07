// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


Console.WriteLine("\nУравнения прямых:");
Console.WriteLine("1) y = k1 * x + b1");
Console.WriteLine("2) y = k2 * x + b2");

Console.Write("\n\nВведите k1: ");
int var_k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int var_b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int var_k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int var_b2 = Convert.ToInt32(Console.ReadLine());

int[] intersection_point(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    return new int[] { x, y };
}
int[] point = intersection_point(var_k1, var_b1, var_k2, var_b2);
Console.WriteLine($"\n\nТочка пересечения данных прямых: [{point[0]},{point[1]}]\n");
