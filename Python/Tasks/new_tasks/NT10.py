# 10. Определить, присутствует ли в заданном списке строк, некоторое число

line = input("Введите строку: ")
number = int(input("Введите число: "))


def num_in_line(row: str, num: int) -> bool:
    return True if str(num) in row else False


print(num_in_line(line, number))
