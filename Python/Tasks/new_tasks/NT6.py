# 6. Задать список из n чисел последовательности (1+1n)n и вывести на экран их сумму

import Tasks.lib.array as ar

lst = [(1 + i) * i for i in range(0, int(input("Введите число:")))]
ar.show_array(lst)
