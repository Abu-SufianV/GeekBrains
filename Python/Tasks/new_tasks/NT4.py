# 4. Подсчитать сумму цифр в вещественном числе.

def sum_digits_in_num(number: float) -> int:
    return sum(list(map(int, list(str(number).replace(".", "")))))


print(sum_digits_in_num(123.0))
