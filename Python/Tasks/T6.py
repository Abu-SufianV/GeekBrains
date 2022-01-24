#  6. Выяснить является ли число чётным

def is_even(num: int | float) -> bool:
    if num % 2 == 0:
        return True
    return False


print(is_even(int(input("Введите число для проверки на чётность:"))))
