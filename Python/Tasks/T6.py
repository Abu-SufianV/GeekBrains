#  5. Написать программу вычисления значения функции y = f(a)

import math

print("Функция: f(x) = sin(x ^ 10)\n")
x = int(input("Введите x: "))

print(f"\nОтвет: {math.sin(x**10)}")
