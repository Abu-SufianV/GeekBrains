# 1. Для натурального N создать множество: 1, -3, 9, -27, 81 и т.д.

def create_set(number: int) -> set[int]:
    result = set()
    for i in range(number):
        result.add(3 ** i if i % 2 == 0 else 3 ** i * -1)
    return result


print(create_set(10))
