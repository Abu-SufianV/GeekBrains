# 48. Показать двумерный массив размером m×n заполненный целыми числами

import lib.array as ar

lst = [[0 for _ in range(10)] for i in range(10)]

ar.fill_matrix(lst, 100)
ar.show_matrix(lst)
