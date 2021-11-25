// 22. Найти расстояние между точками в пространстве 2D/3D

double distance_points(int[] dot_1, int[] dot_2)
{
    return Math.Round(Math.Sqrt(Math.Pow((dot_1[0] - dot_2[0]), 2) + (Math.Pow((dot_1[1] - dot_2[1]), 2)) + (Math.Pow((dot_1[2] - dot_2[2]), 2))), 4);
}

int[] point_create(int index)
{
    Console.WriteLine($"Введите координаты {index}-й точки:");
    int[] arr = new int[3];

    Console.Write("x: ");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("y: ");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("z: ");
    arr[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return arr;
}


int[] First = point_create(1);

int[] Second = point_create(2);
Console.WriteLine($"Расстояние между точками - {distance_points(First, Second)}\n\n");