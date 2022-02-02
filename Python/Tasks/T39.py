# 39. Найти произведение пар чисел в одномерном массиве.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.

import lib.array as ar
import random

lst = [random.randint(1, 20) for _ in range(10)]
ar.show_array(lst)
print(list(map(lambda x, y: x + y, lst[:len(lst) // 2], lst[-1:len(lst) // 2-1:-1])))
