# 5. Написать программу получающую набор произведений чисел от 1 до N. Пример: пусть N = 4, тогда [ 1, 2, 6, 24 ]

def expon_four(number: int) -> list[int]:
    result = [1]
    for i in range(2, number + 1):
        result.append(result[i - 2] * i)
    return result


print(expon_four(4))
