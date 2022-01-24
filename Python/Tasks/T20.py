# 20. Задать номер четверти, показать диапазоны для возможных координат

def coordinates(quarter: int) -> str:
    if quarter == 1:
        return f"\nДиапазон {quarter} четверти:\nX: (0 , +]\nY: (0 , +]"
    elif quarter == 2:
        return f"\nДиапазон {quarter} четверти:\nX: [- , 0)\nY: (0 , +]"
    elif quarter == 3:
        return f"\nДиапазон {quarter} четверти:\nX: [- , 0)\nY: [- , 0)"
    elif quarter == 4:
        return f"\nДиапазон {quarter} четверти:\nX - (0 , +]\nY: [- , 0)"

    return "Вы ввели неверное значение"


print(coordinates(1))
print(coordinates(2))
print(coordinates(3))
print(coordinates(4))
