# 23. Показать таблицу квадратов чисел от 1 до N

import lib.array as ar

ar.show_array([i ** 2 for i in range(1, int(input("Введите размер массива: ")) + 1)])
