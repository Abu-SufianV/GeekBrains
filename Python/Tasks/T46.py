# 46. Написать программу масштабирования фигуры

def scaling_shape(shape: list[tuple], scale: float) -> list[tuple]:
    return [(i[0] * scale, i[1] * scale) for i in shape]


print(scaling_shape([(0, 0), (4, 0), (4, 4), (0, 4)], 2))
