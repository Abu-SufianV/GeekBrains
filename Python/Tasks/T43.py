# 43. Написать программу преобразования десятичного числа в двоичное

def decimal_to_binary(number: int) -> str:
    result = []
    while number >= 1:
        result.append(number % 2)
        number = number // 2
    return ''.join(list(map(str, result)))[::-1]


print(decimal_to_binary(100))
