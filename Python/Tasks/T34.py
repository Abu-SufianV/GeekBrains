# 34. Написать программу замену элементов массива на противоположные

import lib.array as ar
import random

lst = [random.randint(-10, 10) for _ in range(10)]
ar.show_array(lst)
ar.show_array(list(map(lambda x: x*-1, lst)))
