# 26. Возведите число А в натуральную степень B используя цикл


def exponentiation(num_1: int | float, num_2: int):
    result = 1
    for i in range(0, num_2):
        result *= num_1
    return result


print(exponentiation(2, 3))
