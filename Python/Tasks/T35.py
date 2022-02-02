# 35. Определить, присутствует ли в заданном массиве, некоторое число

import lib.array as ar
import random

lst = [random.randint(1, 100) for _ in range(30)]

ar.show_array(lst)

if int(input("Введите число: ")) in lst:
    print("Число есть в списке чисел")
else:
    print("Числа нет в списке чисел")
