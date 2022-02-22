# 42. Определить сколько чисел больше 0 введено с клавиатуры

def digits_greater_zero(number: int) -> int:
    number = list(map(int, list(str(number))))
    amount = 0
    for i in number:
        amount += 1 if i > 0 else 0
    return amount


print(digits_greater_zero(int(input("Введите число: "))))
