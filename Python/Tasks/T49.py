# 49. Показать двумерный массив размером m×n заполненный вещественными числами

import lib.array as ar
import random

lst = [[0 for _ in range(10)] for i in range(10)]

for i in range(len(lst)):
    for j in range(len(lst[i])):
        lst[i][j] = round(random.random(), 2)
ar.show_matrix(lst)
