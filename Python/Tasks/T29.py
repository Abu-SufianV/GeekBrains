# 29. Написать программу вычисления произведения чисел от 1 до N

import functools as fct
print(fct.reduce(lambda x, y: x*y, [i ]))