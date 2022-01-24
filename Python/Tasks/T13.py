# 12. Удалить вторую цифру трёхзначного числа

def del_mid_digit(number: int) -> int:
    number = str(number)
    return int(number[0]+number[2])


print(del_mid_digit(123))
