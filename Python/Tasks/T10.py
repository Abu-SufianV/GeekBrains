# 10. Показать вторую цифру трёхзначного числа


def mid_digit(number: int) -> int:
    return number % 100 // 10


print(mid_digit(123))
