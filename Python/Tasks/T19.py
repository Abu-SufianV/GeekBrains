# 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

def which_quater(x: int, y: int) -> int:
    if x > 0 and y > 0:
        return 1
    elif x < 0 and y > 0:
        return 2
    elif x < 0 and y < 0:
        return 3
    elif x > 0 and y < 0:
        return 4


print(which_quater(1, 1))
print(which_quater(-1, 1))
print(which_quater(-1, -1))
print(which_quater(1, -1))

