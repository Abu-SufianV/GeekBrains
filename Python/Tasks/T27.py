# 27. Определить количество цифр в числе


def amount_digits(number: int) -> int:
    return len(str(number))


num = int(input("Введите число: "))
print(f"Число {num} состоит из {amount_digits(num)} цифр")
