# 22. Найти расстояние между точками в пространстве 2D/3D
import math


def points_distance_2d(dot_1: tuple[int, int], dot_2: tuple[int, int]) -> float:
    return round(math.sqrt((dot_2[0] - dot_1[0]) ** 2 + (dot_2[1] - dot_1[1]) ** 2), 5)


def points_distance_3d(dot_1: tuple[int, int, int], dot_2: tuple[int, int, int]) -> float:
    return round(math.sqrt((dot_2[0] - dot_1[0]) ** 2 + (dot_2[1] - dot_1[1]) ** 2 + (dot_2[0] - dot_1[0]) ** 2), 5)


space = input("Выберите пространство (2D или 3D): ").lower()

if space == '2d':
    print("\nТочка А")
    A = (int(input("Введите координат X: ")), int(input("Введите координат Y: ")))
    print("\nТочка В")
    B = (int(input("Введите координат X: ")), int(input("Введите координат Y: ")))
    print(points_distance_2d(A, B))
elif space == '3d':
    print("\nТочка А")
    A = (int(input("Введите координат X: ")), int(input("Введите координат Y: ")), int(input("Введите координат Z: ")))
    print("\nТочка В")
    B = (int(input("Введите координат X: ")), int(input("Введите координат Y: ")), int(input("Введите координат Z: ")))
    print(points_distance_3d(A, B))
else:
    print("Вы неверно ввели информацию!")
