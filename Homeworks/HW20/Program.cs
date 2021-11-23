// 20. Задать номер четверти, показать диапазоны для возможных координат

string dots(int quarter)
{
    switch (quarter)
    {
        case 1:
            return $"Диапозон {quarter} четверти:\nX: (0 , +]\nY: (0 , +]";

        case 2:
            return $"Диапозон {quarter} четверти:\nX: [- , 0)\nY: (0 , +]";

        case 3:
            return $"Диапозон {quarter} четверти:\nX: [- , 0)\nY: [- , 0)";

        case 4:
            return $"Диапозон {quarter} четверти:\nX - (0 , +]\nY: [- , 0)";

        default: return "Вы введи неверное значение";
    }
}

Console.Write("Введите четверть: ");
Console.Write(dots(Convert.ToInt32(Console.ReadLine())));