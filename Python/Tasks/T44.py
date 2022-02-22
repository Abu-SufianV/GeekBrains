# 44. Найти точку пересечения двух прямых заданных уравнением
# y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

def intersection_point(k1: int, b1: int, k2: int, b2: int):
    x = (b2 - b1) / (k1 - k2)
    y = k1 * x + b1
    return [x, y]


print(intersection_point(1, 2, 2, 2))
