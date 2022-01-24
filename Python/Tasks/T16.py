# 15. Дано число. Проверить кратно ли оно 7 и 23


def multiplicity_7_23(number: int) -> bool:
    return True if number % 7 == 0 and number % 23 == 0 else False


print(multiplicity_7_23(23 * 7))
