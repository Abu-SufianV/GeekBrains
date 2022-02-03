# 9. Реализовать алгоритм задания случайных чисел.
# Без использования встроенного генератора псевдослучайных чисел

def random_int(num: int):
    import time
    rnd_num = str(time.time()).split('.')[1]

    if num <= 10:
        rnd_num = rnd_num[-1]
    elif num <= 100:
        rnd_num = rnd_num[-2:]
    elif num <= 1000:
        rnd_num = rnd_num[-3:]
    elif num <= 10000:
        rnd_num = rnd_num[-4:]
    elif num <= 100000:
        rnd_num = rnd_num[-5:]

    return int(rnd_num)


print(random_int(100))
