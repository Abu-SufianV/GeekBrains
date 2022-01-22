# 13. Выяснить, кратно ли число заданному, если нет, вывести остаток


def multiplicity(num_1: int, num_2: int) -> int | bool:
    if num_1 % num_2 == 0:
        return True
    return num_1 % num_2


print(multiplicity(15, 5))
print(multiplicity(15, 2))
