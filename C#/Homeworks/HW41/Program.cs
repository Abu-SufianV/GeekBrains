// 41. Выяснить являются ли три числа сторонами треугольника 

void is_triangle(int A, int B, int C)
{
    if ((A < B + C) && (B < A + C) && (C < A + B))
    {
        Console.WriteLine("\nДанные числа являются сторонами треугольника\n");
    }
    else
    {
        Console.WriteLine("\nДанные числа НЕ являются сторонами треугольника\n");
    }
}

Console.Write("\nВведите сторону А: ");
int side_A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону B: ");
int side_B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону C: ");
int side_C = Convert.ToInt32(Console.ReadLine());

is_triangle(side_A, side_B, side_C);