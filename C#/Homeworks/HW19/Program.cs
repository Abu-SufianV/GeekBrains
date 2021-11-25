// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int quarter(int x, int y)
{

    if ((x > 0) && (y > 0))
    {
        return 1;
    }
    else if ((x < 0) && (y > 0))
    {
        return 2;
    }
    else if ((x < 0) && (y < 0))
    {
        return 3;
    }
    return 4;
}

Console.Write("\nВведите X: ");
int dot_x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите Y: ");
int dot_y = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nТочка находится в {quarter(dot_x, dot_y)} четверти\n\n");