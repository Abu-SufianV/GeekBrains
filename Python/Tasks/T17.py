# 17. По двум заданным числам проверять является ли одно квадратом другого


def is_sqrt(num_1: int, num_2: int) -> bool:
    return True if num_1 ** 2 == num_2 or num_1 == num_2 ** 2 else False


print(is_sqrt(5, 25))
print(is_sqrt(25, 5))
print(is_sqrt(10, 5))
