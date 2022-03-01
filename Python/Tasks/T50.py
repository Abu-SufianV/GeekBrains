# 50. В двумерном массиве n×k заменить четные элементы на противоположные

import lib.array as ar

lst = [[0 for _ in range(5)] for i in range(5)]

ar.fill_matrix(lst, 10)

for i in range(len(lst)):
    for j in range(len(lst[i])):
        if j % 2 == 0:
            lst[i][j] = lst[i][j] * -1

ar.show_matrix(lst)
