# 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

import lib.array as ar
import random

lst = [random.randint(1, 20) for _ in range(10)]
ar.show_array(lst)

print("Сумма чисел нечётной позиции:", sum([lst[i] for i in range(len(lst)) if i % 2 == 1]))
