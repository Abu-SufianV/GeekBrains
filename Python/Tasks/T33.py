# 33. Задать массив из 12 элементов, заполненных числами из [0,9].
# Найти сумму положительных/отрицательных элементов массива


import random

lst = [random.randint(-10, 10) for _ in range(12)]

positive_num = sum(list(filter(lambda x: x > 0, lst)))
negative_num = sum(list(filter(lambda x: x < 0, lst)))

print("Сумма чисел > 0: ", positive_num, "\nСумма чисел < 0:", negative_num)
