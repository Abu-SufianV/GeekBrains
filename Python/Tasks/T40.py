# 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

import lib.array as ar
import random

lst = [random.randint(1, 20) for _ in range(10)]
ar.show_array(lst)

print(f"Разность между max({max(lst)}) b min({min(lst)}) числами списка = {max(lst) - min(lst)}")
