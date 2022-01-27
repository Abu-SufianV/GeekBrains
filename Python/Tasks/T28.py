# 28. Подсчитать сумму цифр в числе

def sum_digits_in_num(number: int) -> int:
    return sum(list(map(int, list(str(number)))))


num = int(input("Введите число: "))
print(f"Сумма цифр числа {num} - {sum_digits_in_num(num)}")
