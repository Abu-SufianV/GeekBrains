# 8. Реализовать алгоритм перемешивания списка.

import Tasks.lib.array as ar
from random import randint


def shuffle_array(arr: list[int]) -> list[int]:
    new_arr = []

    while len(new_arr) < len(arr):
        num = randint(0, len(arr))
        if num not in new_arr:
            new_arr.append(num)
    return new_arr


ar.show_array(shuffle_array([i for i in range(100)]))
