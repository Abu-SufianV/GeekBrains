# 7. Задать список из N элементов, заполненных числами из [-N, N].
# Найти произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число

import Tasks.lib.array as ar
from random import randint

number = int(input("Введите число:"))
lst = [randint(-number, number) for i in range(number)]
ar.show_array(lst)

with open('NT7.txt', 'r') as FILE:
    FILE = FILE.readline()
    result = tuple(map(int, FILE.split()))

print("\n\n\n")
print("Индексы чисел:", result[0], result[1])
print("Произведение чисел: ", lst[result[0]] * lst[result[1]])
