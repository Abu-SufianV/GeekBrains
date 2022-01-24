# 14. Найти третью цифру числа или сообщить, что её нет


def search_third_digit(number: int) -> int | bool:
    number = str(number)
    if number[0] != '-' and len(number) >= 3:
        return number[2]
    elif number[0] == '-' and len(number) >= 4:
        return number[3]
    else:
        return False


print(search_third_digit(-112))
