# 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

from random import randint as rand


def big_digit(number: int) -> int:
    if number % 10 > number // 10:
        return number % 10
    return number // 10


num = rand(10, 99)
print(f"В числе {num} - цифра {big_digit(num)} является большей")
