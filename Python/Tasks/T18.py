# 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

def is_true(x: bool, y: bool, ) -> bool:
    return True if (~(x or y) == ~x and ~y) else False


print(is_true(True, False))
print(is_true(False, True))
print(is_true(True, True))
print(is_true(False, False))
