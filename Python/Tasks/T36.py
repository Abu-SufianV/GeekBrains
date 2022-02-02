# 36. Задать массив, заполнить случайными положительными трёхзначными числами.
# Показать количество нечетных\четных чисел

import lib.array as ar
import random

lst = [random.randint(100, 999) for _ in range(30)]

ar.show_array(lst)

even_num = len(list(filter(lambda x: not x % 2, lst)))
odd_num = len(list(filter(lambda x: x % 2, lst)))

print("Сумма чётных чисел:  ", even_num, "\nСумма нечётных чисел:", odd_num)
