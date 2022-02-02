# 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

import lib.array as ar
import random

lst = [random.randint(1, 200) for _ in range(123)]
ar.show_array(lst)

print("Кол-во элементов из отрезка [10,99]:", len(list(filter(lambda x: 10 <= x <= 99, lst))))
