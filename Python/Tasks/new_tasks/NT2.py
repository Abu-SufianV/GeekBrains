# 2. Для натурального N создать словарь индекс-значение, состоящий из элементов последовательности 3k + 1.

def create_dict(number: int) -> list[int, int]:
    result = dict()
    for i in range(number):
        result[i] = 3 * i + 1
    return result


print(create_dict(10))
