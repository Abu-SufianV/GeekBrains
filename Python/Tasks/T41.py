# 41. Выяснить являются ли три числа сторонами треугольника

def is_triangle(a: int, b: int, c: int) -> bool:
    if (a < b + c) and (b < a + c) and (c < a + b):
        return True
    return False


print(is_triangle(12, 11, 10))
