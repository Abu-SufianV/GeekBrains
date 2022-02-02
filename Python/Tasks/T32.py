# 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

import lib.array as ar
import random

ar.show_array([random.randint(0, 1) for i in range(0, 8)])
